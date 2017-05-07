using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WoWToDo.DAL;

namespace WoWToDo
{
    public partial class Form2 : Form
    {
        private DbContext _dbContext;
        
        public Form2(DbContext context)
        {
            InitializeComponent();

            _dbContext = context;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            using (var repo = new GameClassRepository(_dbContext))
            {
                var classes = repo.GetAll().Select(c => c.NameRu).ToArray();
                comboBox1.Items.AddRange(classes);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Выбери иконку";
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var fileName = openFileDialog.FileName;
                pictureBox1.Image = Image.FromFile(fileName);
                pictureBox1.Refresh();
                this.Refresh();
            }

            using (var repo = new GameClassRepository(_dbContext))
            {
                var gameClass = repo.GetById(comboBox1.SelectedIndex + 1);
                using (var fs = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                {
                    var byteStream = new byte[fs.Length];
                    fs.Read(byteStream, 0, Convert.ToInt32(fs.Length));
                    gameClass.Icon = byteStream;
                }
                
                repo.AddOrUpdate(gameClass);
                repo.SaveChanges();
            }
        }
    }
}
