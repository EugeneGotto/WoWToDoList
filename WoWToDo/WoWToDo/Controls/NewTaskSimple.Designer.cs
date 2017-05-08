using System.Windows.Forms;

namespace WoWToDo.Controls
{
    partial class NewTaskSimple
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
            this.AddNewTask = new System.Windows.Forms.Button();
            this.TaskName = new System.Windows.Forms.TextBox();
            this.TaskNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddNewTask
            // 
            this.AddNewTask.Location = new System.Drawing.Point(113, 48);
            this.AddNewTask.Name = "AddNewTask";
            this.AddNewTask.Size = new System.Drawing.Size(75, 23);
            this.AddNewTask.TabIndex = 7;
            this.AddNewTask.Text = "Добавить";
            this.AddNewTask.UseVisualStyleBackColor = true;
            this.AddNewTask.Click += new System.EventHandler(this.AddNewTask_Click);
            // 
            // TaskName
            // 
            this.TaskName.Location = new System.Drawing.Point(91, 3);
            this.TaskName.Name = "TaskName";
            this.TaskName.Size = new System.Drawing.Size(215, 20);
            this.TaskName.TabIndex = 6;
            this.TaskName.KeyPress += new KeyPressEventHandler(this.TaskName_KeyPress);
            // 
            // TaskNameLabel
            // 
            this.TaskNameLabel.AutoSize = true;
            this.TaskNameLabel.Location = new System.Drawing.Point(3, 6);
            this.TaskNameLabel.Name = "TaskNameLabel";
            this.TaskNameLabel.Size = new System.Drawing.Size(85, 13);
            this.TaskNameLabel.TabIndex = 5;
            this.TaskNameLabel.Text = "Текст задания:";
            // 
            // NewTaskSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AddNewTask);
            this.Controls.Add(this.TaskName);
            this.Controls.Add(this.TaskNameLabel);
            this.Name = "NewTaskSimple";
            this.Size = new System.Drawing.Size(311, 79);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddNewTask;
        private System.Windows.Forms.TextBox TaskName;
        private System.Windows.Forms.Label TaskNameLabel;
    }
}
