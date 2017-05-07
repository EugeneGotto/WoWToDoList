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
                    nameCell.Value = dailyTask.TaskToDo.TaskName;
                    checkCell.Value = dailyTask.TaskToDo.IsChecked;
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
                    checkCell.Value = weeklyTask.TaskToDo.IsChecked;
                    row.Cells.AddRange(nameCell, checkCell);
                    dataGridWeekly.Rows.Add(row);
                }

                dataGridWeekly.Refresh();
            }
        }

        private void buttonAddNewDaily_Click(object sender, EventArgs e)
        {
            
        }
    }
}
