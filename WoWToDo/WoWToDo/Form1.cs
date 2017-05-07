using System;
using System.Data.Entity;
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
        }

        private void NewPersonage_Click(object sender, EventArgs e)
        {
            var newPers = new Newpersonage(_myContext);
            newPers.ShowDialog();
        }

        private void NewToDo_Click(object sender, EventArgs e)
        {
            var newTask = new NewTask(_myContext);
            newTask.ShowDialog();
        }

        private void UpdatePers_Click(object sender, EventArgs e)
        {
            var updatePers = new UpdatePersonage(_myContext);
            updatePers.ShowDialog();
        }

        private void UpdateTask_Click(object sender, EventArgs e)
        {
            var updateTask = new UpdateTask(_myContext);
            updateTask.ShowDialog();
        }
    }
}
