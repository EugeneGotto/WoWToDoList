using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WoWToDo.DAL;
using WoWToDo.Infrastructure;

namespace WoWToDo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void NewPersonage_Click(object sender, EventArgs e)
        {
            var newPers = new Newpersonage();
            newPers.ShowDialog();
        }

        private void NewToDo_Click(object sender, EventArgs e)
        {
            var newTask = new NewTask();
            newTask.ShowDialog();
        }

        private void UpdatePersLevel_Click(object sender, EventArgs e)
        {
            var updatePers = new UpdatePersonage();
            updatePers.SetPage(1);
            updatePers.ShowDialog();
        }

        private void UpdatePersName_Click(object sender, EventArgs e)
        {
            var updatePers = new UpdatePersonage();
            updatePers.SetPage(2);
            updatePers.ShowDialog();
        }

        private void UpdatePersClass_Click(object sender, EventArgs e)
        {
            var updatePers = new UpdatePersonage();
            updatePers.SetPage(3);
            updatePers.ShowDialog();
        }
    }
}
