using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WoWToDo.Controls;
using WoWToDo.DAL;

namespace WoWToDo
{
    public partial class UpdateTask : Form
    {
        private DbContext _dbContext;

        public UpdateTask(DbContext context)
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
                    panel1.Controls.Add(new UpdateTaskSimple(_dbContext));
                    break;
                case 2:
                    panel1.Controls.Add(new UpdateTaskGlobal(_dbContext));
                    break;
                default:
                    panel1.Controls.Add(new UpdateTaskSimple(_dbContext));
                    break;
            }
        }
    }
}
