using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using WoWToDo.Common;
using WoWToDo.DAL;

namespace WoWToDo
{
    public partial class Newpersonage : Form
    {
        private DbContext _dbContext;

        public Newpersonage(DbContext context)
        {
            InitializeComponent();

            _dbContext = context;
            Class.DropDownStyle = ComboBoxStyle.DropDownList;
            using (var repo = new GameClassRepository(_dbContext))
            {
                var classes = repo.GetAll().Select(c => c.NameRu);
                Class.Items.AddRange(classes.ToArray());
            }
            //Class.SelectedIndex = 0;
        }

        private void Addnewpers_Click(object sender, EventArgs e)
        {
            string name = NameTextBox.Text;
            int level = int.Parse(Level.Text);
            int gameClassId = Class.SelectedIndex + 1;
            var pers = new Personage()
            {
                GameClassId = gameClassId,
                Level = level,
                Name = name
            };

            using (var repo = new PersonageRepository(_dbContext))
            {
                repo.AddOrUpdate(pers);
                repo.SaveChanges();
            }
            
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
    }
}
