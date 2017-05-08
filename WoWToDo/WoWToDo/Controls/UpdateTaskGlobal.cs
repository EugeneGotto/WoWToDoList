using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WoWToDo.DAL;

namespace WoWToDo.Controls
{
    public partial class UpdateTaskGlobal : UserControl
    {
        private DbContext _dbContext;

        public UpdateTaskGlobal(DbContext context)
        {
            InitializeComponent();

            _dbContext = context;
            comboBoxTask.DropDownStyle = ComboBoxStyle.DropDownList;
            using (var repo = new GlobalTaskRepository(_dbContext))
            {
                var tasks = repo.GetAll().Select(t => t.TaskName).ToArray();
                comboBoxTask.Items.AddRange(tasks);
            }

            comboBoxTask.SelectedIndex = 0;
        }

        private void comboBoxTask_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxNewName.Text = comboBoxTask.SelectedItem.ToString();
        }

        private void textBoxNewName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Tab || e.KeyChar == (char)Keys.Enter)
                    buttonUpdate.Focus();
                return;
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            using (var repo = new GlobalTaskRepository(_dbContext))
            {
                var task = repo.GetById(comboBoxTask.SelectedIndex + 1);
                task.TaskName = textBoxNewName.Text;
                repo.AddOrUpdate(task);
                repo.SaveChanges();
            }

            this.Parent.FindForm().Close();
        }
    }
}
