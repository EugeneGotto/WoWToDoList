namespace WoWToDo
{
    partial class PersonageView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabPageWeekly = new System.Windows.Forms.TabPage();
            this.dataGridWeekly = new System.Windows.Forms.DataGridView();
            this.WeeklyIsDone = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.WeeklyTaskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAddNewWeekly = new System.Windows.Forms.Button();
            this.buttonSaveWeekly = new System.Windows.Forms.Button();
            this.tabPageDaily = new System.Windows.Forms.TabPage();
            this.dataGridDaily = new System.Windows.Forms.DataGridView();
            this.DailyIsDone = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DailyTaskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAddNewDaily = new System.Windows.Forms.Button();
            this.buttonSaveDaily = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageWeekly.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWeekly)).BeginInit();
            this.tabPageDaily.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDaily)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageWeekly
            // 
            this.tabPageWeekly.Controls.Add(this.buttonSaveWeekly);
            this.tabPageWeekly.Controls.Add(this.buttonAddNewWeekly);
            this.tabPageWeekly.Controls.Add(this.dataGridWeekly);
            this.tabPageWeekly.Location = new System.Drawing.Point(4, 22);
            this.tabPageWeekly.Name = "tabPageWeekly";
            this.tabPageWeekly.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWeekly.Size = new System.Drawing.Size(528, 425);
            this.tabPageWeekly.TabIndex = 1;
            this.tabPageWeekly.Text = "Еженедельки";
            this.tabPageWeekly.UseVisualStyleBackColor = true;
            // 
            // dataGridWeekly
            // 
            this.dataGridWeekly.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridWeekly.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WeeklyTaskName,
            this.WeeklyIsDone});
            this.dataGridWeekly.Location = new System.Drawing.Point(6, 6);
            this.dataGridWeekly.Name = "dataGridWeekly";
            this.dataGridWeekly.Size = new System.Drawing.Size(516, 383);
            this.dataGridWeekly.TabIndex = 1;
            // 
            // WeeklyIsDone
            // 
            this.WeeklyIsDone.HeaderText = "Сделано";
            this.WeeklyIsDone.Name = "WeeklyIsDone";
            this.WeeklyIsDone.Width = 70;
            // 
            // WeeklyTaskName
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.WeeklyTaskName.DefaultCellStyle = dataGridViewCellStyle1;
            this.WeeklyTaskName.HeaderText = "Задачи на неделю:";
            this.WeeklyTaskName.Name = "WeeklyTaskName";
            this.WeeklyTaskName.ReadOnly = true;
            this.WeeklyTaskName.Width = 400;
            // 
            // buttonAddNewWeekly
            // 
            this.buttonAddNewWeekly.Location = new System.Drawing.Point(7, 396);
            this.buttonAddNewWeekly.Name = "buttonAddNewWeekly";
            this.buttonAddNewWeekly.Size = new System.Drawing.Size(100, 23);
            this.buttonAddNewWeekly.TabIndex = 2;
            this.buttonAddNewWeekly.Text = "Добавить новую";
            this.buttonAddNewWeekly.UseVisualStyleBackColor = true;
            this.buttonAddNewWeekly.Click += new System.EventHandler(this.buttonAddNewWeekly_Click);
            // 
            // buttonSaveWeekly
            // 
            this.buttonSaveWeekly.Location = new System.Drawing.Point(446, 396);
            this.buttonSaveWeekly.Name = "buttonSaveWeekly";
            this.buttonSaveWeekly.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveWeekly.TabIndex = 3;
            this.buttonSaveWeekly.Text = "Сохранить";
            this.buttonSaveWeekly.UseVisualStyleBackColor = true;
            this.buttonSaveWeekly.Click += new System.EventHandler(this.buttonSaveWeekly_Click);
            // 
            // tabPageDaily
            // 
            this.tabPageDaily.Controls.Add(this.buttonSaveDaily);
            this.tabPageDaily.Controls.Add(this.buttonAddNewDaily);
            this.tabPageDaily.Controls.Add(this.dataGridDaily);
            this.tabPageDaily.Location = new System.Drawing.Point(4, 22);
            this.tabPageDaily.Name = "tabPageDaily";
            this.tabPageDaily.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDaily.Size = new System.Drawing.Size(528, 425);
            this.tabPageDaily.TabIndex = 0;
            this.tabPageDaily.Text = "Ежедневки";
            this.tabPageDaily.UseVisualStyleBackColor = true;
            // 
            // dataGridDaily
            // 
            this.dataGridDaily.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDaily.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DailyTaskName,
            this.DailyIsDone});
            this.dataGridDaily.Location = new System.Drawing.Point(6, 6);
            this.dataGridDaily.Name = "dataGridDaily";
            this.dataGridDaily.Size = new System.Drawing.Size(516, 383);
            this.dataGridDaily.TabIndex = 0;
            // 
            // DailyIsDone
            // 
            this.DailyIsDone.HeaderText = "Сделано";
            this.DailyIsDone.Name = "DailyIsDone";
            this.DailyIsDone.Width = 70;
            // 
            // DailyTaskName
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DailyTaskName.DefaultCellStyle = dataGridViewCellStyle2;
            this.DailyTaskName.HeaderText = "Задачи на сегодня:";
            this.DailyTaskName.Name = "DailyTaskName";
            this.DailyTaskName.ReadOnly = true;
            this.DailyTaskName.Width = 400;
            // 
            // buttonAddNewDaily
            // 
            this.buttonAddNewDaily.Location = new System.Drawing.Point(7, 396);
            this.buttonAddNewDaily.Name = "buttonAddNewDaily";
            this.buttonAddNewDaily.Size = new System.Drawing.Size(101, 23);
            this.buttonAddNewDaily.TabIndex = 1;
            this.buttonAddNewDaily.Text = "Добавить новую";
            this.buttonAddNewDaily.UseVisualStyleBackColor = true;
            this.buttonAddNewDaily.Click += new System.EventHandler(this.buttonAddNewDaily_Click);
            // 
            // buttonSaveDaily
            // 
            this.buttonSaveDaily.Location = new System.Drawing.Point(447, 396);
            this.buttonSaveDaily.Name = "buttonSaveDaily";
            this.buttonSaveDaily.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveDaily.TabIndex = 2;
            this.buttonSaveDaily.Text = "Сохранить";
            this.buttonSaveDaily.UseVisualStyleBackColor = true;
            this.buttonSaveDaily.Click += new System.EventHandler(this.buttonSaveDaily_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageDaily);
            this.tabControl1.Controls.Add(this.tabPageWeekly);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(536, 451);
            this.tabControl1.TabIndex = 0;
            // 
            // PersonageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 472);
            this.Controls.Add(this.tabControl1);
            this.Name = "PersonageView";
            this.Text = "PersonageView";
            this.tabPageWeekly.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWeekly)).EndInit();
            this.tabPageDaily.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDaily)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPageWeekly;
        private System.Windows.Forms.Button buttonSaveWeekly;
        private System.Windows.Forms.Button buttonAddNewWeekly;
        private System.Windows.Forms.DataGridView dataGridWeekly;
        private System.Windows.Forms.DataGridViewTextBoxColumn WeeklyTaskName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn WeeklyIsDone;
        private System.Windows.Forms.TabPage tabPageDaily;
        private System.Windows.Forms.Button buttonSaveDaily;
        private System.Windows.Forms.Button buttonAddNewDaily;
        private System.Windows.Forms.DataGridView dataGridDaily;
        private System.Windows.Forms.DataGridViewTextBoxColumn DailyTaskName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DailyIsDone;
        private System.Windows.Forms.TabControl tabControl1;
    }
}