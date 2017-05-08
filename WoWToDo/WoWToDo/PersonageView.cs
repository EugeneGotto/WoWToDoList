using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WoWToDo.Common;
using WoWToDo.DAL;

namespace WoWToDo
{
    public partial class PersonageView : Form
    {
        private Personage _currentPers;
        private DbContext _dbContext;
        public PersonageView(DbContext context, Personage pers)
        {
            InitializeComponent();

            _currentPers = pers;
            _dbContext = context;

            this.UpdateTable();
        }

        private void UpdateTable()
        {
            dataGridDaily.Rows.Clear();
            dataGridWeekly.Rows.Clear();
            using (var repo = new DailyTaskRepository(_dbContext))
            {
                var dailyTasks = repo.GetAll().Where(d => d.PersonageId == _currentPers.Id);
                foreach (var dailyTask in dailyTasks)
                {
                    var row = new DataGridViewRow();
                    DataGridViewCell nameCell = new DataGridViewTextBoxCell();
                    DataGridViewCell checkCell = new DataGridViewCheckBoxCell();
                    using (var taskRepo = new TaskToDoRepository(_dbContext))
                    {
                        nameCell.Value = taskRepo.GetById(dailyTask.TaskToDoId).TaskName;
                    }

                    checkCell.Value = dailyTask.IsChecked;
                    row.Cells.AddRange(nameCell, checkCell);
                    dataGridDaily.Rows.Add(row);
                }
                
                dataGridDaily.Refresh();
            }

            using (var repo = new WeeklyTaskRepository(_dbContext))
            {
                var weeklyTasks = repo.GetAll().Where(w => w.PersonageId == _currentPers.Id);
                foreach (var weeklyTask in weeklyTasks)
                {
                    var row = new DataGridViewRow();
                    DataGridViewCell nameCell = new DataGridViewTextBoxCell();
                    DataGridViewCell checkCell = new DataGridViewCheckBoxCell();
                    nameCell.Value = weeklyTask.TaskToDo.TaskName;
                    checkCell.Value = weeklyTask.IsChecked;
                    row.Cells.AddRange(nameCell, checkCell);
                    dataGridWeekly.Rows.Add(row);
                }

                dataGridWeekly.Refresh();
            }
        }

        private void buttonAddNewDaily_Click(object sender, EventArgs e)
        {
            var addNewTask = new AddNewTask(_dbContext, _currentPers);
            addNewTask.SetPage(1);
            addNewTask.ShowDialog();
            this.UpdateTable();
        }

        private void buttonAddNewWeekly_Click(object sender, EventArgs e)
        {
            var addNewTask = new AddNewTask(_dbContext, _currentPers);
            addNewTask.SetPage(2);
            addNewTask.ShowDialog();
            this.UpdateTable();
        }

        private void buttonSaveDaily_Click(object sender, EventArgs e)
        {
            using (var dailyRepo = new DailyTaskRepository(_dbContext))
            {
                var checkedList = new List<bool>();
                for (int i = 0; i < dataGridDaily.RowCount - 1; i++)
                {
                    checkedList.Add((bool)dataGridDaily.Rows[i].Cells[1].Value);
                }

                var dailyTasks = dailyRepo.GetAll().Where(d => d.PersonageId == _currentPers.Id).ToArray();
                for (int i = 0; i < dailyTasks.Count(); i++)
                {
                    dailyTasks[i].IsChecked = checkedList[i];
                }

                foreach (var dailyTask in dailyTasks)
                {
                    dailyRepo.AddOrUpdate(dailyTask);
                }

                dailyRepo.SaveChanges();
            }
        }

        private void buttonSaveWeekly_Click(object sender, EventArgs e)
        {
            using (var weeklyRepo = new WeeklyTaskRepository(_dbContext))
            {
                var checkedList = new List<bool>();
                for (int i = 0; i < dataGridWeekly.RowCount - 1; i++)
                {
                    checkedList.Add((bool)dataGridWeekly.Rows[i].Cells[1].Value);
                }

                var weeklyTasks = weeklyRepo.GetAll().Where(d => d.PersonageId == _currentPers.Id).ToArray();
                for (int i = 0; i < weeklyTasks.Count(); i++)
                {
                    weeklyTasks[i].IsChecked = checkedList[i];
                }

                foreach (var weeklyTask in weeklyTasks)
                {
                    weeklyRepo.AddOrUpdate(weeklyTask);
                }

                weeklyRepo.SaveChanges();
            }
        }
    }
}
