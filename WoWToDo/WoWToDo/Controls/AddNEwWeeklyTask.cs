using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using WoWToDo.Common;
using WoWToDo.DAL;

namespace WoWToDo.Controls
{
    public partial class AddNEwWeeklyTask : UserControl
    {
        private DbContext _dbContext;
        private Personage _currentPersonage;

        public AddNEwWeeklyTask(DbContext context, Personage personage)
        {
            InitializeComponent();

            _dbContext = context;
            _currentPersonage = personage;

            using (var repo = new TaskToDoRepository(_dbContext))
            {
                IEnumerable<TaskToDo> tasks = repo.GetAll();
                using (var weeklyTaskRepo = new WeeklyTaskRepository(_dbContext))
                {
                    var tasksIds = weeklyTaskRepo.GetAll().Where(t => t.PersonageId == _currentPersonage.Id).Select(d => d.TaskToDoId);
                    tasks = tasks.Where(t => !tasksIds.Contains(t.Id));
                }

                foreach (var taskToDo in tasks)
                {
                    checkedListBoxWeeklyTasks.Items.Add(taskToDo.TaskName);
                }
            }
        }

        private void buttonAddSelect_Click(object sender, EventArgs e)
        {
            using (var weeklyTaskRepo = new WeeklyTaskRepository(_dbContext))
            {
                var weeklyTasks = new List<WeeklyTask>();
                using (var taskRepo = new TaskToDoRepository(_dbContext))
                {
                    var selectTasksCheckList = checkedListBoxWeeklyTasks.CheckedItems;
                    IEnumerable<TaskToDo> selectTasksFromRepo = taskRepo.GetAll();
                    var selectTaskIds = new List<int>();
                    foreach (var task in selectTasksCheckList)
                    {
                        selectTaskIds.Add(selectTasksFromRepo.FirstOrDefault(t => t.TaskName == task.ToString()).Id);
                    }

                    weeklyTasks.AddRange(selectTaskIds.Select(selectTaskId => new WeeklyTask() { PersonageId = _currentPersonage.Id, TaskToDoId = selectTaskId }));
                }

                foreach (var weeklyTask in weeklyTasks)
                {
                    weeklyTaskRepo.AddOrUpdate(weeklyTask);
                }

                weeklyTaskRepo.SaveChanges();
            }

            this.Parent.FindForm().Close();
        }
    }
}
