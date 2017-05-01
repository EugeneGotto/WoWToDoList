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
using WoWToDo.Infrastructure;

namespace WoWToDo.Controls
{
    public partial class UpdatePers_Class : UserControl
    {
        public UpdatePers_Class()
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

        private void UpdateClass_Click(object sender, EventArgs e)
        {
            var service = new PersonageService();
            service.ChangeClass(NameComboBox.SelectedItem.ToString(), (GameClass)ClassComboBox.SelectedItem);
            this.Parent.FindForm().Close();
        }
    }
}
