using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WoWToDo.Common;
using WoWToDo.DAL;

namespace WoWToDo
{
    public partial class StartForm : Form
    {
        private DbContext _myContext = new WowContext();
        private int _selectedIndex = 0;

        public StartForm()
        {
            InitializeComponent();

            using (var repo = new PersonageRepository(_myContext))
            {
                var persList = repo.GetAll();
                foreach (var personage in persList)
                {
                    tabControlPersonagesDaily.TabPages.Add(new TabPage(personage.Name));
                    tabControlPersonagesDaily.TabPages[tabControlPersonagesDaily.TabCount - 1].Controls.Add(this.NewDataGridDaily(personage));
                    tabControlPersonagesWeekly.TabPages.Add(new TabPage(personage.Name));
                }
            }

            tabControlMain.DrawItem += new DrawItemEventHandler(tabControlMain_DrawItem);
            tabControlPersonagesDaily.DrawItem += new DrawItemEventHandler(tabControlPersonagesDaily_DrawItem);
            tabControlPersonagesWeekly.DrawItem += new DrawItemEventHandler(tabControlPersonagesWeekly_DrawItem);
            #region Запоминание открытого персонажа
            tabControlMain.Click += new EventHandler(tabControlMain_Click);
            tabControlPersonagesDaily.Click += new EventHandler(tabControlPersonagesDaily_Click);
            tabControlPersonagesWeekly.Click += new EventHandler(tabControlPersonagesWeekly_Click);
            #endregion

        }

        private void tabControlMain_DrawItem(Object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = tabControlMain.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tabControlMain.GetTabRect(e.Index);

            _textBrush = new SolidBrush(Color.Black);
            switch (e.Index)
            {
                case 0:
                    g.FillRectangle(Brushes.DeepSkyBlue, e.Bounds);
                    break;
                case 1:
                    g.FillRectangle(Brushes.HotPink, e.Bounds);
                    break;
                case 2:
                    g.FillRectangle(Brushes.LimeGreen, e.Bounds);
                    break;
                case 3:
                    g.FillRectangle(Brushes.DodgerBlue, e.Bounds);
                    break;
                case 4:
                    g.FillRectangle(Brushes.MediumOrchid, e.Bounds);
                    break;
                case 5:
                    g.FillRectangle(Brushes.Gold, e.Bounds);
                    break;
                default:
                    g.FillRectangle(Brushes.Gray, e.Bounds);
                    break;
            }

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;

            g.DrawString(_tabPage.Text, e.Font, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }

        private void tabControlPersonagesDaily_DrawItem(Object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = tabControlPersonagesDaily.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tabControlPersonagesDaily.GetTabRect(e.Index);

            _textBrush = new SolidBrush(Color.Black);
            GameClass[] gcList;
            using (var repo = new GameClassRepository(_myContext))
            {
                gcList = repo.GetAll().ToArray();
            }

            Personage[] persList;
            using (var repo = new PersonageRepository(_myContext))
            {
                persList = repo.GetAll().ToArray();
            }

            var _index = persList.FirstOrDefault(p => string.Equals(p.Name, _tabPage.Text)).GameClassId - 1;
            Brush _fontBrush = new SolidBrush(Color.FromArgb(gcList[_index].Red, gcList[_index].Green, gcList[_index].Blue));
            g.FillRectangle(_fontBrush, e.Bounds);

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, e.Font, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }

        private void tabControlPersonagesWeekly_DrawItem(Object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = tabControlPersonagesWeekly.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tabControlPersonagesWeekly.GetTabRect(e.Index);

            _textBrush = new SolidBrush(Color.Black);
            GameClass[] gcList;
            using (var repo = new GameClassRepository(_myContext))
            {
                gcList = repo.GetAll().ToArray();
            }

            Personage[] persList;
            using (var repo = new PersonageRepository(_myContext))
            {
                persList = repo.GetAll().ToArray();
            }

            var _index = persList.FirstOrDefault(p => string.Equals(p.Name, _tabPage.Text)).GameClassId - 1;
            Brush _fontBrush = new SolidBrush(Color.FromArgb(gcList[_index].Red, gcList[_index].Green, gcList[_index].Blue));
            g.FillRectangle(_fontBrush, e.Bounds);

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, e.Font, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }

        #region Запоминание открытого персонажа
        private void tabControlMain_Click(Object sender, EventArgs e)
        {
            tabControlPersonagesDaily.SelectedIndex = _selectedIndex;
            tabControlPersonagesWeekly.SelectedIndex = _selectedIndex;
        }

        private void tabControlPersonagesDaily_Click(Object sender, EventArgs e)
        {
            _selectedIndex = tabControlPersonagesDaily.SelectedIndex;
        }

        private void tabControlPersonagesWeekly_Click(Object sender, EventArgs e)
        {
            _selectedIndex = tabControlPersonagesWeekly.SelectedIndex;
        }
        #endregion
        
        private void UpdateDailyTabs(Personage pers)
        {
            
        }

        private DataGridView NewDataGridDaily(Personage pers)
        {
            var dataGridDaily = new DataGridView();
            dataGridDaily.Name = $"Ежедневные дела {pers.Name}";
            dataGridDaily.AllowUserToAddRows = false;
            dataGridDaily.AllowUserToDeleteRows = true;
            dataGridDaily.AllowUserToResizeColumns = false;
            dataGridDaily.AllowUserToResizeRows = false;
            dataGridDaily.AutoSize = true;
            dataGridDaily.MultiSelect = true;
            dataGridDaily.ScrollBars = ScrollBars.Vertical;
            dataGridDaily.Location = new Point(0, 0);
            dataGridDaily.Dock = DockStyle.Fill;

            var column0 = new DataGridViewTextBoxColumn();
            column0.Name = "TaskName";
            column0.HeaderText = "Название";
            column0.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            var column1 = new DataGridViewComboBoxColumn();
            column1.Name = "IsDone";
            column1.HeaderText = "Выполнено";
            column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            column1.Width = 70;
            dataGridDaily.Columns.AddRange(column0, column1);
            using (var repo = new DailyTaskRepository(_myContext))
            {
                var dailyTasks = repo.GetAll().Where(d => d.PersonageId == pers.Id);
                foreach (var dailyTask in dailyTasks)
                {
                    var row = new DataGridViewRow();
                    DataGridViewCell nameCell = new DataGridViewTextBoxCell();
                    DataGridViewCell checkCell = new DataGridViewCheckBoxCell();
                    using (var taskRepo = new TaskToDoRepository(_myContext))
                    {
                        nameCell.Value = taskRepo.GetById(dailyTask.TaskToDoId).TaskName;
                    }

                    checkCell.Value = dailyTask.IsChecked;
                    
                    row.Cells.AddRange(nameCell, checkCell);
                    dataGridDaily.Rows.Add(row);
                    
                }
            }

            dataGridDaily.Refresh();
            return dataGridDaily;
        }
    }
}
