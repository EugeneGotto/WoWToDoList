using System.Windows.Forms;

namespace WoWToDo
{
    partial class UpdateTask
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
            this.labelComboBox = new System.Windows.Forms.Label();
            this.comboBoxTask = new System.Windows.Forms.ComboBox();
            this.labelNewName = new System.Windows.Forms.Label();
            this.textBoxNewName = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelComboBox
            // 
            this.labelComboBox.AutoSize = true;
            this.labelComboBox.Location = new System.Drawing.Point(13, 13);
            this.labelComboBox.Name = "labelComboBox";
            this.labelComboBox.Size = new System.Drawing.Size(60, 13);
            this.labelComboBox.TabIndex = 0;
            this.labelComboBox.Text = "Выберите:";
            // 
            // comboBoxTask
            // 
            this.comboBoxTask.FormattingEnabled = true;
            this.comboBoxTask.Location = new System.Drawing.Point(79, 10);
            this.comboBoxTask.Name = "comboBoxTask";
            this.comboBoxTask.Size = new System.Drawing.Size(259, 21);
            this.comboBoxTask.TabIndex = 1;
            this.comboBoxTask.SelectedIndexChanged += new System.EventHandler(this.comboBoxTask_SelectedIndexChanged);
            // 
            // labelNewName
            // 
            this.labelNewName.AutoSize = true;
            this.labelNewName.Location = new System.Drawing.Point(13, 43);
            this.labelNewName.Name = "labelNewName";
            this.labelNewName.Size = new System.Drawing.Size(118, 13);
            this.labelNewName.TabIndex = 2;
            this.labelNewName.Text = "Введите новый текст:";
            // 
            // textBoxNewName
            // 
            this.textBoxNewName.Location = new System.Drawing.Point(137, 40);
            this.textBoxNewName.Name = "textBoxNewName";
            this.textBoxNewName.Size = new System.Drawing.Size(198, 20);
            this.textBoxNewName.TabIndex = 3;
            this.textBoxNewName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNewName_KeyPress);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(125, 77);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 4;
            this.buttonUpdate.Text = "Обновить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // UpdateTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 111);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.textBoxNewName);
            this.Controls.Add(this.labelNewName);
            this.Controls.Add(this.comboBoxTask);
            this.Controls.Add(this.labelComboBox);
            this.Name = "UpdateTask";
            this.Text = "UpdateTask";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelComboBox;
        private System.Windows.Forms.ComboBox comboBoxTask;
        private System.Windows.Forms.Label labelNewName;
        private System.Windows.Forms.TextBox textBoxNewName;
        private System.Windows.Forms.Button buttonUpdate;
    }
}