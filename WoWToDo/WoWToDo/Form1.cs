using System;
using System.Data.Entity;
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

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            using (var repo = new PersonageRepository(_myContext))
            {
                var pers = repo.FirstOrDefault(p => p.Name == comboBoxPersonage.SelectedItem.ToString());
                var persView = new PersonageView(_myContext, pers);
                persView.ShowDialog();
            }
        }
    }
}
