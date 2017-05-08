namespace WoWToDo.Controls
{
    partial class AddNEwWeeklyTask
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
            this.buttonAddSelect = new System.Windows.Forms.Button();
            this.checkedListBoxWeeklyTasks = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // buttonAddSelect
            // 
            this.buttonAddSelect.Location = new System.Drawing.Point(84, 134);
            this.buttonAddSelect.Name = "buttonAddSelect";
            this.buttonAddSelect.Size = new System.Drawing.Size(146, 23);
            this.buttonAddSelect.TabIndex = 3;
            this.buttonAddSelect.Text = "Добавить выделенные";
            this.buttonAddSelect.UseVisualStyleBackColor = true;
            this.buttonAddSelect.Click += new System.EventHandler(this.buttonAddSelect_Click);
            // 
            // checkedListBoxWeeklyTasks
            // 
            this.checkedListBoxWeeklyTasks.FormattingEnabled = true;
            this.checkedListBoxWeeklyTasks.Location = new System.Drawing.Point(3, 3);
            this.checkedListBoxWeeklyTasks.Name = "checkedListBoxWeeklyTasks";
            this.checkedListBoxWeeklyTasks.Size = new System.Drawing.Size(314, 124);
            this.checkedListBoxWeeklyTasks.TabIndex = 2;
            // 
            // AddNEwWeeklyTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonAddSelect);
            this.Controls.Add(this.checkedListBoxWeeklyTasks);
            this.Name = "AddNEwWeeklyTask";
            this.Size = new System.Drawing.Size(329, 167);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddSelect;
        private System.Windows.Forms.CheckedListBox checkedListBoxWeeklyTasks;
    }
}
