using System.Data.Entity;
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
        //2 - WeeklyTask
        public void SetPage(int page)
        {
            switch (page)
            {
                case 1:
                    panel1.Controls.Add(new AddNewDailyTask(_dbContext, _currentPersonage));
                    break;
                case 2:
                    panel1.Controls.Add(new AddNEwWeeklyTask(_dbContext, _currentPersonage));
                    break;
                default:
                    panel1.Controls.Add(new AddNewDailyTask(_dbContext, _currentPersonage));
                    break;
            }
        }
    }
}
