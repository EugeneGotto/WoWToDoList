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
    public partial class UpdatePers_Name : UserControl
    {
        public UpdatePers_Name()
        {
            InitializeComponent();
            OldNameComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            var repo = new PersonageRepository();
            var persList = repo.GetAll().Select(t => t.Name);
            foreach (var name in persList)
            {
                OldNameComboBox.Items.Add(name);
            }

            OldNameComboBox.SelectedIndex = 0;
        }

        private void NewName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Tab || e.KeyChar == (char)Keys.Enter)
                    UpdateName.Focus();
                return;
            }
        }

        private void UpdateName_Click(object sender, EventArgs e)
        {
            var service = new PersonageService();
            service.ChangeName(OldNameComboBox.SelectedItem.ToString(), NewName.Text);
            this.Parent.FindForm().Close();
        }
    }
}
