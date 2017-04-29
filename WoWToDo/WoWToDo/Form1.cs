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
            Personages.DropDownStyle = ComboBoxStyle.DropDownList;

            var repo = new PersonageRepository();
            var persList = repo.GetAll();
            foreach (var personage in persList)
            {
                Personages.Items.Add(personage.Name);
            }

            Personages.SelectedIndex = 0;
        }

        private void Personages_Click(object sender, EventArgs e)
        {

        }

        private void NewPersonage_Click(object sender, EventArgs e)
        {
            var newPers = new Newpersonage();
            newPers.ShowDialog();
        }
    }
}
