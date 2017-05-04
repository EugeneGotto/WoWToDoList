using System.Windows.Forms;

namespace WoWToDo.Controls
{
    partial class UpdatePers_All
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UpdateAll = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.LevelLabel = new System.Windows.Forms.Label();
            this.ClassLabel = new System.Windows.Forms.Label();
            this.ClassComboBox = new System.Windows.Forms.ComboBox();
            this.LevelTextBox = new System.Windows.Forms.TextBox();
            this.NameComboBox = new System.Windows.Forms.ComboBox();
            this.NewNameLabel = new System.Windows.Forms.Label();
            this.NewNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UpdateAll
            // 
            this.UpdateAll.Location = new System.Drawing.Point(96, 116);
            this.UpdateAll.Name = "UpdateAll";
            this.UpdateAll.Size = new System.Drawing.Size(75, 23);
            this.UpdateAll.TabIndex = 0;
            this.UpdateAll.Text = "Обновить";
            this.UpdateAll.UseVisualStyleBackColor = true;
            this.UpdateAll.Click += new System.EventHandler(this.UpdateAll_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(4, 10);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(119, 13);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Выберите персонажа:";
            // 
            // LevelLabel
            // 
            this.LevelLabel.AutoSize = true;
            this.LevelLabel.Location = new System.Drawing.Point(4, 64);
            this.LevelLabel.Name = "LevelLabel";
            this.LevelLabel.Size = new System.Drawing.Size(54, 13);
            this.LevelLabel.TabIndex = 2;
            this.LevelLabel.Text = "Уровень:";
            // 
            // ClassLabel
            // 
            this.ClassLabel.AutoSize = true;
            this.ClassLabel.Location = new System.Drawing.Point(4, 92);
            this.ClassLabel.Name = "ClassLabel";
            this.ClassLabel.Size = new System.Drawing.Size(41, 13);
            this.ClassLabel.TabIndex = 3;
            this.ClassLabel.Text = "Класс:";
            // 
            // ClassComboBox
            // 
            this.ClassComboBox.FormattingEnabled = true;
            this.ClassComboBox.Location = new System.Drawing.Point(125, 89);
            this.ClassComboBox.Name = "ClassComboBox";
            this.ClassComboBox.Size = new System.Drawing.Size(121, 21);
            this.ClassComboBox.TabIndex = 4;
            // 
            // LevelTextBox
            // 
            this.LevelTextBox.Location = new System.Drawing.Point(125, 61);
            this.LevelTextBox.Name = "LevelTextBox";
            this.LevelTextBox.Size = new System.Drawing.Size(121, 20);
            this.LevelTextBox.TabIndex = 6;
            this.LevelTextBox.KeyPress += new KeyPressEventHandler(this.LevelTextBox_KeyPress);
            // 
            // NameComboBox
            // 
            this.NameComboBox.FormattingEnabled = true;
            this.NameComboBox.Location = new System.Drawing.Point(125, 7);
            this.NameComboBox.Name = "NameComboBox";
            this.NameComboBox.Size = new System.Drawing.Size(121, 21);
            this.NameComboBox.TabIndex = 7;
            this.NameComboBox.SelectedIndexChanged += new System.EventHandler(this.NameComboBox_SelectedIndexChanged);
            // 
            // NewNameLabel
            // 
            this.NewNameLabel.AutoSize = true;
            this.NewNameLabel.Location = new System.Drawing.Point(4, 37);
            this.NewNameLabel.Name = "NewNameLabel";
            this.NewNameLabel.Size = new System.Drawing.Size(65, 13);
            this.NewNameLabel.TabIndex = 8;
            this.NewNameLabel.Text = "Новое имя:";
            // 
            // NewNameTextBox
            // 
            this.NewNameTextBox.Location = new System.Drawing.Point(125, 34);
            this.NewNameTextBox.Name = "NewNameTextBox";
            this.NewNameTextBox.Size = new System.Drawing.Size(121, 20);
            this.NewNameTextBox.TabIndex = 9;
            // 
            // UpdatePers_All
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NewNameTextBox);
            this.Controls.Add(this.NewNameLabel);
            this.Controls.Add(this.NameComboBox);
            this.Controls.Add(this.LevelTextBox);
            this.Controls.Add(this.ClassComboBox);
            this.Controls.Add(this.ClassLabel);
            this.Controls.Add(this.LevelLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.UpdateAll);
            this.Name = "UpdatePers_All";
            this.Size = new System.Drawing.Size(262, 154);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UpdateAll;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label LevelLabel;
        private System.Windows.Forms.Label ClassLabel;
        private System.Windows.Forms.ComboBox ClassComboBox;
        private System.Windows.Forms.TextBox LevelTextBox;
        private System.Windows.Forms.ComboBox NameComboBox;
        private System.Windows.Forms.Label NewNameLabel;
        private System.Windows.Forms.TextBox NewNameTextBox;
    }
}
