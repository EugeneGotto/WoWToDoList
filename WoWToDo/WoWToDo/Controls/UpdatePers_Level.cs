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
using WoWToDo.DAL;

namespace WoWToDo.Controls
{
    public partial class UpdatePers_Level : UserControl
    {
        public UpdatePers_Level()
        {
            InitializeComponent();
            NameComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            var repo = new PersonageRepository();
            var persList = repo.GetAll().Select(t => t.Name);
            foreach (var name in persList)
            {
                NameComboBox.Items.Add(name);
            }

            NameComboBox.SelectedIndex = 0;
        }

        private void UpdateLevel_Click(object sender, EventArgs e)
        {
            var service = new PersonageService();
            service.ChangeLevel(NameComboBox.SelectedItem.ToString(), Int32.Parse(Level.Text));
            this.Parent.FindForm().Close();
        }

        private void Level_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
                return;
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Tab || e.KeyChar == (char)Keys.Enter)
                    UpdateLevel.Focus();
                return;
            }

            e.Handled = true;
        }
    }
}
