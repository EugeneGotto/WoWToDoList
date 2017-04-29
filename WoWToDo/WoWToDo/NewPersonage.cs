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
using WoWToDo.Infrastructure;

namespace WoWToDo
{
    public partial class Newpersonage : Form
    {
        public Newpersonage()
        {
            InitializeComponent();
            Class.DropDownStyle = ComboBoxStyle.DropDownList;
            Class.Items.Add(GameClass.Death_Knight);
            Class.Items.Add(GameClass.Demon_Hunter);
            Class.Items.Add(GameClass.Druid);
            Class.Items.Add(GameClass.Hunter);
            Class.Items.Add(GameClass.Mage);
            Class.Items.Add(GameClass.Monk);
            Class.Items.Add(GameClass.Paladin);
            Class.Items.Add(GameClass.Priest);
            Class.Items.Add(GameClass.Rogue);
            Class.Items.Add(GameClass.Shaman);
            Class.Items.Add(GameClass.Warlock);
            Class.Items.Add(GameClass.Warrior);
            Class.SelectedIndex = 0;
        }

        private void Addnewpers_Click(object sender, EventArgs e)
        {
            var persService = new PersonageService();
            string name = NameTextBox.Text;
            int level = Int32.Parse(Level.Text);
            GameClass gameClass = (GameClass) Class.SelectedItem;
            var pers = new Personage()
            {
                Class = gameClass,
                Level = level,
                Name = name
            };

            persService.AddNewPersonage(pers);
            this.Close();
        }

        private void Level_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
                return;
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char) Keys.Tab || e.KeyChar == (char) Keys.Enter)
                    Addnewpers.Focus();
                return;
            }
            e.Handled = true;
        }

        private void Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char) Keys.Tab || e.KeyChar == (char) Keys.Enter)
                    Level.Focus();
                return;
            }
        }

        private void Newpersonage_Load(object sender, EventArgs e)
        {

        }
    }
}
