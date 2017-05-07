using System;
using System.Data.Entity;
using System.Windows.Forms;
using WoWToDo.Common;
using WoWToDo.DAL;

namespace WoWToDo
{
    public partial class NewTask : Form
    {
        private DbContext _dbContext;

        public NewTask(DbContext context)
        {
            InitializeComponent();

            _dbContext = context;
        }

        private void AddNewTask_Click(object sender, EventArgs e)
        {
            var newTask = new TaskToDo
            {
                TaskName = TaskName.Text,
                IsChecked = false
            };

            using (var repo = new TaskToDoRepository(_dbContext))
            {
                repo.AddOrUpdate(newTask);
                repo.SaveChanges();
            }
            
            this.Close();
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
