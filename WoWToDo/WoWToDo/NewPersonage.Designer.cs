using System.Windows.Forms;

namespace WoWToDo
{
    partial class Newpersonage
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Addnewpers = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.PersLevel = new System.Windows.Forms.Label();
            this.Level = new System.Windows.Forms.TextBox();
            this.Classlabel = new System.Windows.Forms.Label();
            this.Class = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Addnewpers
            // 
            this.Addnewpers.Location = new System.Drawing.Point(109, 118);
            this.Addnewpers.Name = "Addnewpers";
            this.Addnewpers.Size = new System.Drawing.Size(75, 23);
            this.Addnewpers.TabIndex = 0;
            this.Addnewpers.Text = "Добавить";
            this.Addnewpers.UseVisualStyleBackColor = true;
            this.Addnewpers.Click += new System.EventHandler(this.Addnewpers_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(109, 29);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 1;
            this.NameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Name_KeyPress);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(13, 32);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(90, 13);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Имя Персонажа";
            // 
            // PersLevel
            // 
            this.PersLevel.AutoSize = true;
            this.PersLevel.Location = new System.Drawing.Point(13, 59);
            this.PersLevel.Name = "PersLevel";
            this.PersLevel.Size = new System.Drawing.Size(51, 13);
            this.PersLevel.TabIndex = 3;
            this.PersLevel.Text = "Уровень";
            // 
            // Level
            // 
            this.Level.Location = new System.Drawing.Point(109, 56);
            this.Level.Name = "Level";
            this.Level.Size = new System.Drawing.Size(100, 20);
            this.Level.TabIndex = 4;
            this.Level.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Level_KeyPress);
            // 
            // Classlabel
            // 
            this.Classlabel.AutoSize = true;
            this.Classlabel.Location = new System.Drawing.Point(13, 85);
            this.Classlabel.Name = "Classlabel";
            this.Classlabel.Size = new System.Drawing.Size(38, 13);
            this.Classlabel.TabIndex = 5;
            this.Classlabel.Text = "Класс";
            // 
            // Class
            // 
            this.Class.FormattingEnabled = true;
            this.Class.Location = new System.Drawing.Point(109, 82);
            this.Class.Name = "Class";
            this.Class.Size = new System.Drawing.Size(121, 21);
            this.Class.TabIndex = 12;
            // 
            // Newpersonage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 176);
            this.Controls.Add(this.Class);
            this.Controls.Add(this.Classlabel);
            this.Controls.Add(this.Level);
            this.Controls.Add(this.PersLevel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.Addnewpers);
            this.Name = "Newpersonage";
            this.Text = "Новый Персонаж";
            this.Load += new System.EventHandler(this.Newpersonage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Addnewpers;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label PersLevel;
        private System.Windows.Forms.TextBox Level;
        private System.Windows.Forms.Label Classlabel;
        private System.Windows.Forms.ComboBox Class;
    }
}