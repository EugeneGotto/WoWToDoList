using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WoWToDo.BLL;
using WoWToDo.Common;
using WoWToDo.DAL;
using WoWToDo.Infrastructure;

namespace WoWToDo.Controls
{
    public partial class UpdatePers_All : UserControl
    {
        public UpdatePers_All()
        {
            InitializeComponent();

            ClassComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ClassComboBox.Items.Add(GameClass.Death_Knight);
            ClassComboBox.Items.Add(GameClass.Demon_Hunter);
            ClassComboBox.Items.Add(GameClass.Druid);
            ClassComboBox.Items.Add(GameClass.Hunter);
            ClassComboBox.Items.Add(GameClass.Mage);
            ClassComboBox.Items.Add(GameClass.Monk);
            ClassComboBox.Items.Add(GameClass.Paladin);
            ClassComboBox.Items.Add(GameClass.Priest);
            ClassComboBox.Items.Add(GameClass.Rogue);
            ClassComboBox.Items.Add(GameClass.Shaman);
            ClassComboBox.Items.Add(GameClass.Warlock);
            ClassComboBox.Items.Add(GameClass.Warrior);

            NameComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            var repo = new PersonageRepository();
            var persList = repo.GetAll().Select(t => t.Name);
            foreach (var name in persList)
            {
                NameComboBox.Items.Add(name);
            }

            NameComboBox.SelectedIndex = 0;
            
            this.GetInfoByName(NameComboBox.SelectedItem.ToString());
        }

        private void UpdateAll_Click(object sender, EventArgs e)
        {
            var repo = new PersonageRepository();
            var oldPers = repo.GetByName(NameComboBox.SelectedItem.ToString());
            var service = new PersonageService();
            repo.DeletePers(oldPers);
            service.AddNewPersonage(
                NewNameTextBox.Text,
                (GameClass)ClassComboBox.SelectedItem,
                int.Parse(LevelTextBox.Text)
                );
            this.Parent.FindForm().Close();
        }

        private void NameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.GetInfoByName(NameComboBox.SelectedItem.ToString());
        }

        private void GetInfoByName(string name)
        {
            var repo = new PersonageRepository();
            var pers = repo.GetByName(NameComboBox.SelectedItem.ToString());
            NewNameTextBox.Text = pers.Name;
            LevelTextBox.Text = pers.Level.ToString();
            ClassComboBox.SelectedIndex = (int) pers.Class;
        }

        private void LevelTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
                return;
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Tab || e.KeyChar == (char)Keys.Enter)
                    UpdateAll.Focus();
                return;
            }

            e.Handled = true;
        }
    }
}
