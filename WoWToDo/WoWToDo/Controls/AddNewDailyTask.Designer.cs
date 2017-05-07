namespace WoWToDo.Controls
{
    partial class AddNewDailyTask
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
            this.checkedListBoxDailyTasks = new System.Windows.Forms.CheckedListBox();
            this.buttonAddSelect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBoxDailyTasks
            // 
            this.checkedListBoxDailyTasks.FormattingEnabled = true;
            this.checkedListBoxDailyTasks.Location = new System.Drawing.Point(4, 4);
            this.checkedListBoxDailyTasks.Name = "checkedListBoxDailyTasks";
            this.checkedListBoxDailyTasks.Size = new System.Drawing.Size(314, 124);
            this.checkedListBoxDailyTasks.TabIndex = 0;
            // 
            // buttonAddSelect
            // 
            this.buttonAddSelect.Location = new System.Drawing.Point(85, 135);
            this.buttonAddSelect.Name = "buttonAddSelect";
            this.buttonAddSelect.Size = new System.Drawing.Size(146, 23);
            this.buttonAddSelect.TabIndex = 1;
            this.buttonAddSelect.Text = "Добавить выделенные";
            this.buttonAddSelect.UseVisualStyleBackColor = true;
            this.buttonAddSelect.Click += new System.EventHandler(this.buttonAddSelect_Click);
            // 
            // AddNewDailyTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonAddSelect);
            this.Controls.Add(this.checkedListBoxDailyTasks);
            this.Name = "AddNewDailyTask";
            this.Size = new System.Drawing.Size(347, 173);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxDailyTasks;
        private System.Windows.Forms.Button buttonAddSelect;
    }
}
