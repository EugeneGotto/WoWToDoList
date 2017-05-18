using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WoWToDo.DAL;

namespace WoWToDo
{
    public partial class Form1 : Form
    {
        private readonly DbContext _myContext = new WowContext();
        public Form1()
        {
            InitializeComponent();

            comboBoxPersonage.DropDownStyle = ComboBoxStyle.DropDown;
            using (var repo = new PersonageRepository(_myContext))
            {
                var persList = repo.GetAll().Select(p => p.Name).ToArray();
                comboBoxPersonage.Items.AddRange(persList);
            }

            this.UpdateTable();
        }

        private void NewPersonage_Click(object sender, EventArgs e)
        {
            var newPers = new Newpersonage(_myContext);
            newPers.ShowDialog();
        }

        private void NewToDo_Click(object sender, EventArgs e)
        {
            var newTask = new NewTask(_myContext);
            newTask.SetPage(1);
            newTask.ShowDialog();
        }

        private void NewGlobalToDo_Click(object sender, EventArgs e)
        {
            var newTask = new NewTask(_myContext);
            newTask.SetPage(2);
            newTask.ShowDialog();
            this.UpdateTable();
        }

        private void UpdatePers_Click(object sender, EventArgs e)
        {
            var updatePers = new UpdatePersonage(_myContext);
            updatePers.ShowDialog();
        }

        private void UpdateTask_Click(object sender, EventArgs e)
        {
            var updateTask = new UpdateTask(_myContext);
            updateTask.SetPage(1);
            updateTask.ShowDialog();
        }

        private void UpdateGlobalTask_Click(object sender, EventArgs e)
        {
            var updateTask = new UpdateTask(_myContext);
            updateTask.SetPage(2);
            updateTask.ShowDialog();
            this.UpdateTable();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            using (var repo = new PersonageRepository(_myContext))
            {
                var pers = repo.FirstOrDefault(p => p.Name == comboBoxPersonage.SelectedItem.ToString());
                var persView = new PersonageView(_myContext, pers);
                persView.ShowDialog();
            }
        }

        private void buttonGlobalSave_Click(object sender, EventArgs e)
        {
            using (var repo = new GlobalTaskRepository(_myContext))
            {
                var checkedList = new List<bool>();
                for (int i = 0; i < dataGridViewGlobal.RowCount - 1; i++)
                {
                    checkedList.Add((bool)dataGridViewGlobal.Rows[i].Cells[1].Value);
                }

                if (checkedList.Count == 0)
                {
                    this.UpdateTable();
                    return;
                }

                var globalTasks = repo.GetAll().ToArray();
                for (int i = 0; i < globalTasks.Count(); i++)
                {
                    if (checkedList[i])
                        repo.Delete(globalTasks[i]);
                }

                repo.SaveChanges();
            }

            this.UpdateTable();
        }

        private void UpdateTable()
        {
            dataGridViewGlobal.Rows.Clear();
            using (var repo = new GlobalTaskRepository(_myContext))
            {
                var globalTasks = repo.GetAll();
                foreach (var globalTask in globalTasks)
                {
                    var row = new DataGridViewRow();
                    DataGridViewCell nameCell = new DataGridViewTextBoxCell();
                    DataGridViewCell checkCell = new DataGridViewCheckBoxCell();
                    nameCell.Value = globalTask.TaskName;
                    checkCell.Value = globalTask.IsDone;
                    row.Cells.AddRange(nameCell, checkCell);
                    dataGridViewGlobal.Rows.Add(row);
                }

                dataGridViewGlobal.Refresh();
            }
        }
    }
}
