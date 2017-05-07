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
    public partial class AddNewDailyTask : UserControl
    {
        private DbContext _dbContext;
        private Personage _currentPersonage;
        public AddNewDailyTask(DbContext context, Personage personage)
        {
            InitializeComponent();

            _dbContext = context;
            _currentPersonage = personage;
            
            using (var repo = new TaskToDoRepository(_dbContext))
            {
                IEnumerable<TaskToDo> tasks = repo.GetAll();
                using (var dailyTaskRepo = new DailyTaskRepository(_dbContext))
                {
                    var tasksIds = dailyTaskRepo.GetAll().Where(t => t.PersonageId == _currentPersonage.Id).Select(d=>d.TaskToDoId);
                    tasks = tasks.Where(t => !tasksIds.Contains(t.Id));
                }
                
                foreach (var taskToDo in tasks)
                {
                    checkedListBoxDailyTasks.Items.Add(taskToDo.TaskName);
                }
            }
        }

        private void buttonAddSelect_Click(object sender, EventArgs e)
        {
            using (var dailyTaskRepo = new DailyTaskRepository(_dbContext))
            {
                var dailyTasks = new List<DailyTask>();
                using (var taskRepo = new TaskToDoRepository(_dbContext))
                {
                    var selectTasksCheckList = checkedListBoxDailyTasks.CheckedItems;
                    IEnumerable<TaskToDo> selectTasksFromRepo = taskRepo.GetAll();
                    var selectTaskIds = new List<int>();
                    foreach (var task in selectTasksCheckList)
                    {
                        selectTaskIds.Add(selectTasksFromRepo.FirstOrDefault(t=>t.TaskName == task.ToString()).Id);
                    }

                    dailyTasks.AddRange(selectTaskIds.Select(selectTaskId => new DailyTask() {PersonageId = _currentPersonage.Id, TaskToDoId = selectTaskId}));
                }

                foreach (var dailyTask in dailyTasks)
                {
                    dailyTaskRepo.AddOrUpdate(dailyTask);
                }
                
                dailyTaskRepo.SaveChanges();
            }

            this.Parent.FindForm().Close();
        }
    }
}
