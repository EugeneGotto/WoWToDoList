using System.Windows.Forms;

namespace WoWToDo
{
    partial class NewTask
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
            this.TaskTypeLabel = new System.Windows.Forms.Label();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.TaskNameLabel = new System.Windows.Forms.Label();
            this.TaskName = new System.Windows.Forms.TextBox();
            this.AddNewTask = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TaskTypeLabel
            // 
            this.TaskTypeLabel.AutoSize = true;
            this.TaskTypeLabel.Location = new System.Drawing.Point(66, 13);
            this.TaskTypeLabel.Name = "TaskTypeLabel";
            this.TaskTypeLabel.Size = new System.Drawing.Size(32, 13);
            this.TaskTypeLabel.TabIndex = 0;
            this.TaskTypeLabel.Text = "Тип: ";
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Location = new System.Drawing.Point(104, 10);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.TypeComboBox.TabIndex = 1;
            // 
            // TaskNameLabel
            // 
            this.TaskNameLabel.AutoSize = true;
            this.TaskNameLabel.Location = new System.Drawing.Point(16, 55);
            this.TaskNameLabel.Name = "TaskNameLabel";
            this.TaskNameLabel.Size = new System.Drawing.Size(85, 13);
            this.TaskNameLabel.TabIndex = 2;
            this.TaskNameLabel.Text = "Текст задания:";
            // 
            // TaskName
            // 
            this.TaskName.Location = new System.Drawing.Point(104, 52);
            this.TaskName.Name = "TaskName";
            this.TaskName.Size = new System.Drawing.Size(215, 20);
            this.TaskName.TabIndex = 3;
            this.TaskName.KeyPress += new KeyPressEventHandler(this.TaskName_KeyPress);
            // 
            // AddNewTask
            // 
            this.AddNewTask.Location = new System.Drawing.Point(126, 97);
            this.AddNewTask.Name = "AddNewTask";
            this.AddNewTask.Size = new System.Drawing.Size(75, 23);
            this.AddNewTask.TabIndex = 4;
            this.AddNewTask.Text = "Добавить";
            this.AddNewTask.UseVisualStyleBackColor = true;
            this.AddNewTask.Click += new System.EventHandler(this.AddNewTask_Click);
            // 
            // NewTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 132);
            this.Controls.Add(this.AddNewTask);
            this.Controls.Add(this.TaskName);
            this.Controls.Add(this.TaskNameLabel);
            this.Controls.Add(this.TypeComboBox);
            this.Controls.Add(this.TaskTypeLabel);
            this.Name = "NewTask";
            this.Text = "NewTask";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TaskTypeLabel;
        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.Label TaskNameLabel;
        private System.Windows.Forms.TextBox TaskName;
        private System.Windows.Forms.Button AddNewTask;
    }
}