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
using WoWToDo.Common;
using WoWToDo.Controls;

namespace WoWToDo
{
    public partial class AddNewTask : Form
    {
        private DbContext _dbContext;
        private Personage _currentPersonage;
        public AddNewTask(DbContext context, Personage personage)
        {
            InitializeComponent();

            _dbContext = context;
            _currentPersonage = personage;
            
        }

        //1 - DailyTask
        public void SetPage(int page)
        {
            switch (page)
            {
                case 1:
                    panel1.Controls.Add(new AddNewDailyTask(_dbContext, _currentPersonage));
                    break;
                default:
                    panel1.Controls.Add(new AddNewDailyTask(_dbContext, _currentPersonage));
                    break;
            }
        }
    }
}
