namespace WoWToDo.Controls
{
    partial class UpdatePers_Class
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
            this.ClassLabel = new System.Windows.Forms.Label();
            this.NameComboBox = new System.Windows.Forms.ComboBox();
            this.ClassComboBox = new System.Windows.Forms.ComboBox();
            this.UpdateClass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(3, 14);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(93, 13);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Имя Персонажа:";
            // 
            // ClassLabel
            // 
            this.ClassLabel.AutoSize = true;
            this.ClassLabel.Location = new System.Drawing.Point(18, 44);
            this.ClassLabel.Name = "ClassLabel";
            this.ClassLabel.Size = new System.Drawing.Size(78, 13);
            this.ClassLabel.TabIndex = 1;
            this.ClassLabel.Text = "Новый Класс:";
            // 
            // NameComboBox
            // 
            this.NameComboBox.FormattingEnabled = true;
            this.NameComboBox.Location = new System.Drawing.Point(110, 11);
            this.NameComboBox.Name = "NameComboBox";
            this.NameComboBox.Size = new System.Drawing.Size(121, 21);
            this.NameComboBox.TabIndex = 2;
            // 
            // ClassComboBox
            // 
            this.ClassComboBox.FormattingEnabled = true;
            this.ClassComboBox.Location = new System.Drawing.Point(110, 41);
            this.ClassComboBox.Name = "ClassComboBox";
            this.ClassComboBox.Size = new System.Drawing.Size(121, 21);
            this.ClassComboBox.TabIndex = 3;
            // 
            // UpdateClass
            // 
            this.UpdateClass.Location = new System.Drawing.Point(76, 68);
            this.UpdateClass.Name = "UpdateClass";
            this.UpdateClass.Size = new System.Drawing.Size(75, 23);
            this.UpdateClass.TabIndex = 4;
            this.UpdateClass.Text = "Обновить";
            this.UpdateClass.UseVisualStyleBackColor = true;
            this.UpdateClass.Click += new System.EventHandler(this.UpdateClass_Click);
            // 
            // UpdatePers_Class
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.UpdateClass);
            this.Controls.Add(this.ClassComboBox);
            this.Controls.Add(this.NameComboBox);
            this.Controls.Add(this.ClassLabel);
            this.Controls.Add(this.NameLabel);
            this.Name = "UpdatePers_Class";
            this.Size = new System.Drawing.Size(244, 104);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label ClassLabel;
        private System.Windows.Forms.ComboBox NameComboBox;
        private System.Windows.Forms.ComboBox ClassComboBox;
        private System.Windows.Forms.Button UpdateClass;
    }
}
