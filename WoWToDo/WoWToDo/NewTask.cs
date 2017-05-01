using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WoWToDo.BLL;
using WoWToDo.Common;
using WoWToDo.DAL;
using WoWToDo.Infrastructure;

namespace WoWToDo
{
    public partial class NewTask : Form
    {
        public NewTask()
        {
            InitializeComponent();

            TypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            TypeComboBox.Items.Add("Ежедневное");
            TypeComboBox.Items.Add("Еженедельное");
            TypeComboBox.SelectedIndex = 0;
        }

        private void AddNewTask_Click(object sender, EventArgs e)
        {
            var newTask = new TaskToDo();
            newTask.TaskName = TaskName.Text;
            newTask.IsChecked = false;
            if (TypeComboBox.SelectedIndex == 0)
            {
                newTask.TaskType = TaskType.Daily;
                var service = new AvailableTasksService();
                service.AddNewTask(newTask);
            }

            else
            {
                newTask.TaskType = TaskType.Weekly;
                var service = new AvailableTasksService();
                service.AddNewTask(newTask);
            }
            
            this.Close();
        }

        private void TaskName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Tab || e.KeyChar == (char)Keys.Enter)
                    AddNewTask.Focus();
                return;
            }
        }
    }
}
