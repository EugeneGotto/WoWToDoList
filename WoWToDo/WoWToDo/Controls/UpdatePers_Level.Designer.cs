using System.Windows.Forms;

namespace WoWToDo.Controls
{
    partial class UpdatePers_Level
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.LevelLabel = new System.Windows.Forms.Label();
            this.NameComboBox = new System.Windows.Forms.ComboBox();
            this.Level = new System.Windows.Forms.TextBox();
            this.UpdateLevel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(3, 9);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(91, 13);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Имя персонажа:";
            // 
            // LevelLabel
            // 
            this.LevelLabel.AutoSize = true;
            this.LevelLabel.Location = new System.Drawing.Point(4, 35);
            this.LevelLabel.Name = "LevelLabel";
            this.LevelLabel.Size = new System.Drawing.Size(91, 13);
            this.LevelLabel.TabIndex = 1;
            this.LevelLabel.Text = "Новый уровень: ";
            // 
            // NameComboBox
            // 
            this.NameComboBox.FormattingEnabled = true;
            this.NameComboBox.Location = new System.Drawing.Point(100, 6);
            this.NameComboBox.Name = "NameComboBox";
            this.NameComboBox.Size = new System.Drawing.Size(121, 21);
            this.NameComboBox.TabIndex = 2;
            // 
            // Level
            // 
            this.Level.Location = new System.Drawing.Point(101, 32);
            this.Level.Name = "Level";
            this.Level.Size = new System.Drawing.Size(120, 20);
            this.Level.TabIndex = 3;
            this.Level.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Level_KeyPress);
            // 
            // UpdateLevel
            // 
            this.UpdateLevel.Location = new System.Drawing.Point(78, 58);
            this.UpdateLevel.Name = "UpdateLevel";
            this.UpdateLevel.Size = new System.Drawing.Size(75, 23);
            this.UpdateLevel.TabIndex = 4;
            this.UpdateLevel.Text = "Обновить";
            this.UpdateLevel.UseVisualStyleBackColor = true;
            this.UpdateLevel.Click += new System.EventHandler(this.UpdateLevel_Click);
            // 
            // UpdatePers_Level
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.UpdateLevel);
            this.Controls.Add(this.Level);
            this.Controls.Add(this.NameComboBox);
            this.Controls.Add(this.LevelLabel);
            this.Controls.Add(this.NameLabel);
            this.Name = "UpdatePers_Level";
            this.Size = new System.Drawing.Size(233, 91);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label LevelLabel;
        private System.Windows.Forms.ComboBox NameComboBox;
        private System.Windows.Forms.TextBox Level;
        private System.Windows.Forms.Button UpdateLevel;
    }
}
