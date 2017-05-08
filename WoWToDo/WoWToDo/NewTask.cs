using System;
using System.Data.Entity;
using System.Windows.Forms;
using WoWToDo.Common;
using WoWToDo.Controls;
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

        //1 - Simple Task
        //2 - Global Task
        public void SetPage(int page)
        {
            switch (page)
            {
                case 1:
                    panel1.Controls.Add(new NewTaskSimple(_dbContext));
                    break;
                case 2:
                    panel1.Controls.Add(new NewTaskGlobal(_dbContext));
                    break;
                default:
                    panel1.Controls.Add(new NewTaskSimple(_dbContext));
                    break;
            }
        }
    }
}
