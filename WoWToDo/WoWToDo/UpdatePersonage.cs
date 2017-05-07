using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using WoWToDo.DAL;

namespace WoWToDo
{
    public partial class UpdatePersonage : Form
    {
        private DbContext _dbContext;

        public UpdatePersonage(DbContext context)
        {
            InitializeComponent();

            _dbContext = context;
            ClassComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            using (var repo = new GameClassRepository(_dbContext))
            {
                var classes = repo.GetAll().Select(c=>c.NameRu);
                ClassComboBox.Items.AddRange(classes.ToArray());
            }

            NameComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            using (var repo = new PersonageRepository(_dbContext))
            {
                var persList = repo.GetAll().Select(t => t.Name);
                NameComboBox.Items.AddRange(persList.ToArray());
            }
            
            NameComboBox.SelectedIndex = 0;
            this.GetInfoByName();
        }

        private void UpdateAll_Click(object sender, EventArgs e)
        {
            using (var repo = new PersonageRepository(_dbContext))
            {
                string name = NameComboBox.SelectedItem.ToString();
                var pers = repo.FirstOrDefault(p => p.Name == name);
                pers.Name = NewNameTextBox.Text;
                pers.Level = int.Parse(LevelTextBox.Text);
                pers.GameClassId = ClassComboBox.SelectedIndex + 1;
                repo.AddOrUpdate(pers);
                repo.SaveChanges();
            }

            this.Close();
        }

        private void NameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.GetInfoByName();
        }

        private void GetInfoByName()
        {
            using (var repo = new PersonageRepository(_dbContext))
            {
                string name = NameComboBox.SelectedItem.ToString();
                var pers = repo.FirstOrDefault(p => p.Name == name);
                NewNameTextBox.Text = pers.Name;
                LevelTextBox.Text = pers.Level.ToString();
                ClassComboBox.SelectedIndex = pers.GameClassId - 1;
            }
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
