using System.Windows.Forms;

namespace WoWToDo.Controls
{
    partial class UpdatePers_Name
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
            this.OldNameLabel = new System.Windows.Forms.Label();
            this.NewNameLabel = new System.Windows.Forms.Label();
            this.OldNameComboBox = new System.Windows.Forms.ComboBox();
            this.NewName = new System.Windows.Forms.TextBox();
            this.UpdateName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OldNameLabel
            // 
            this.OldNameLabel.AutoSize = true;
            this.OldNameLabel.Location = new System.Drawing.Point(3, 11);
            this.OldNameLabel.Name = "OldNameLabel";
            this.OldNameLabel.Size = new System.Drawing.Size(93, 13);
            this.OldNameLabel.TabIndex = 0;
            this.OldNameLabel.Text = "Имя Персонажа:";
            // 
            // NewNameLabel
            // 
            this.NewNameLabel.AutoSize = true;
            this.NewNameLabel.Location = new System.Drawing.Point(31, 38);
            this.NewNameLabel.Name = "NewNameLabel";
            this.NewNameLabel.Size = new System.Drawing.Size(65, 13);
            this.NewNameLabel.TabIndex = 1;
            this.NewNameLabel.Text = "Новое имя:";
            // 
            // OldNameComboBox
            // 
            this.OldNameComboBox.FormattingEnabled = true;
            this.OldNameComboBox.Location = new System.Drawing.Point(102, 8);
            this.OldNameComboBox.Name = "OldNameComboBox";
            this.OldNameComboBox.Size = new System.Drawing.Size(121, 21);
            this.OldNameComboBox.TabIndex = 2;
            // 
            // NewName
            // 
            this.NewName.Location = new System.Drawing.Point(102, 35);
            this.NewName.Name = "NewName";
            this.NewName.Size = new System.Drawing.Size(121, 20);
            this.NewName.TabIndex = 3;
            this.NewName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NewName_KeyPress);
            // 
            // UpdateName
            // 
            this.UpdateName.Location = new System.Drawing.Point(78, 61);
            this.UpdateName.Name = "UpdateName";
            this.UpdateName.Size = new System.Drawing.Size(75, 23);
            this.UpdateName.TabIndex = 4;
            this.UpdateName.Text = "Обновить";
            this.UpdateName.UseVisualStyleBackColor = true;
            this.UpdateName.Click += new System.EventHandler(this.UpdateName_Click);
            // 
            // UpdatePers_Name
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.UpdateName);
            this.Controls.Add(this.NewName);
            this.Controls.Add(this.OldNameComboBox);
            this.Controls.Add(this.NewNameLabel);
            this.Controls.Add(this.OldNameLabel);
            this.Name = "UpdatePers_Name";
            this.Size = new System.Drawing.Size(240, 94);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OldNameLabel;
        private System.Windows.Forms.Label NewNameLabel;
        private System.Windows.Forms.ComboBox OldNameComboBox;
        private System.Windows.Forms.TextBox NewName;
        private System.Windows.Forms.Button UpdateName;
    }
}
