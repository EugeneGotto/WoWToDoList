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
using WoWToDo.Common;
using WoWToDo.DAL;

namespace WoWToDo.Controls
{
    public partial class NewTaskGlobal : UserControl
    {
        private DbContext _dbContext;

        public NewTaskGlobal(DbContext context)
        {
            InitializeComponent();

            _dbContext = context;
        }

        private void AddNewTask_Click(object sender, EventArgs e)
        {
            var newTask = new GlobalTask()
            {
                TaskName = TaskName.Text,
                IsDone = false
            };

            using (var repo = new GlobalTaskRepository(_dbContext))
            {
                repo.AddOrUpdate(newTask);
                repo.SaveChanges();
            }

            this.Parent.FindForm().Close();
        }

        private void TaskName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Tab || e.KeyChar == (char)Keys.Enter)
                    AddNewTask.Focus();
                return;
            }
        }
    }
}
