using System.Windows.Forms;

namespace WoWToDo
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewPersonage = new System.Windows.Forms.ToolStripMenuItem();
            this.NewToDo = new System.Windows.Forms.ToolStripMenuItem();
            this.Update = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdatePers = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateTask = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxPersonage = new System.Windows.Forms.ComboBox();
            this.labelPersName = new System.Windows.Forms.Label();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.NewGlobalToDo = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateGlobalTask = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewGlobal = new System.Windows.Forms.DataGridView();
            this.GlobalTaskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GlobalIsDone = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.buttonGlobalSave = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGlobal)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(481, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.Update});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewPersonage,
            this.NewToDo,
            this.NewGlobalToDo});
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            // 
            // NewPersonage
            // 
            this.NewPersonage.Name = "NewPersonage";
            this.NewPersonage.Size = new System.Drawing.Size(207, 22);
            this.NewPersonage.Text = "Новый Персонаж";
            this.NewPersonage.Click += new System.EventHandler(this.NewPersonage_Click);
            // 
            // NewToDo
            // 
            this.NewToDo.Name = "NewToDo";
            this.NewToDo.Size = new System.Drawing.Size(207, 22);
            this.NewToDo.Text = "Новое \"Дело\"";
            this.NewToDo.Click += new System.EventHandler(this.NewToDo_Click);
            // 
            // Update
            // 
            this.Update.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UpdatePers,
            this.UpdateTask,
            this.UpdateGlobalTask});
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(152, 22);
            this.Update.Text = "Обновить";
            // 
            // UpdatePers
            // 
            this.UpdatePers.Name = "UpdatePers";
            this.UpdatePers.Size = new System.Drawing.Size(168, 22);
            this.UpdatePers.Text = "Персонаж";
            this.UpdatePers.Click += new System.EventHandler(this.UpdatePers_Click);
            // 
            // UpdateTask
            // 
            this.UpdateTask.Name = "UpdateTask";
            this.UpdateTask.Size = new System.Drawing.Size(168, 22);
            this.UpdateTask.Text = "\"Дело\"";
            this.UpdateTask.Click += new System.EventHandler(this.UpdateTask_Click);
            // 
            // comboBoxPersonage
            // 
            this.comboBoxPersonage.FormattingEnabled = true;
            this.comboBoxPersonage.Location = new System.Drawing.Point(128, 266);
            this.comboBoxPersonage.Name = "comboBoxPersonage";
            this.comboBoxPersonage.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPersonage.TabIndex = 1;
            // 
            // labelPersName
            // 
            this.labelPersName.AutoSize = true;
            this.labelPersName.Location = new System.Drawing.Point(6, 269);
            this.labelPersName.Name = "labelPersName";
            this.labelPersName.Size = new System.Drawing.Size(116, 13);
            this.labelPersName.TabIndex = 2;
            this.labelPersName.Text = "Выберите персонажа";
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(84, 293);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 3;
            this.buttonLoad.Text = "Загрузить";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // NewGlobalToDo
            // 
            this.NewGlobalToDo.Name = "NewGlobalToDo";
            this.NewGlobalToDo.Size = new System.Drawing.Size(207, 22);
            this.NewGlobalToDo.Text = "Новая Глобальная Цель";
            this.NewGlobalToDo.Click += new System.EventHandler(this.NewGlobalToDo_Click);
            // 
            // UpdateGlobalTask
            // 
            this.UpdateGlobalTask.Name = "UpdateGlobalTask";
            this.UpdateGlobalTask.Size = new System.Drawing.Size(168, 22);
            this.UpdateGlobalTask.Text = "Глобальная цель";
            this.UpdateGlobalTask.Click += new System.EventHandler(this.UpdateGlobalTask_Click);
            // 
            // dataGridViewGlobal
            // 
            this.dataGridViewGlobal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGlobal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GlobalTaskName,
            this.GlobalIsDone});
            this.dataGridViewGlobal.Location = new System.Drawing.Point(9, 28);
            this.dataGridViewGlobal.Name = "dataGridViewGlobal";
            this.dataGridViewGlobal.Size = new System.Drawing.Size(465, 208);
            this.dataGridViewGlobal.TabIndex = 4;
            // 
            // GlobalTaskName
            // 
            this.GlobalTaskName.HeaderText = "Название";
            this.GlobalTaskName.Name = "GlobalTaskName";
            this.GlobalTaskName.ReadOnly = true;
            this.GlobalTaskName.Width = 350;
            // 
            // GlobalIsDone
            // 
            this.GlobalIsDone.HeaderText = "Выполнено";
            this.GlobalIsDone.Name = "GlobalIsDone";
            this.GlobalIsDone.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.GlobalIsDone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.GlobalIsDone.Width = 70;
            // 
            // buttonGlobalSave
            // 
            this.buttonGlobalSave.Location = new System.Drawing.Point(394, 242);
            this.buttonGlobalSave.Name = "buttonGlobalSave";
            this.buttonGlobalSave.Size = new System.Drawing.Size(75, 23);
            this.buttonGlobalSave.TabIndex = 5;
            this.buttonGlobalSave.Text = "Сохранить";
            this.buttonGlobalSave.UseVisualStyleBackColor = true;
            this.buttonGlobalSave.Click += new System.EventHandler(this.buttonGlobalSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 328);
            this.Controls.Add(this.buttonGlobalSave);
            this.Controls.Add(this.dataGridViewGlobal);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.labelPersName);
            this.Controls.Add(this.comboBoxPersonage);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGlobal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewPersonage;
        private ToolStripMenuItem NewToDo;
        private ToolStripMenuItem Update;
        private ToolStripMenuItem UpdatePers;
        private ToolStripMenuItem UpdateTask;
        private ComboBox comboBoxPersonage;
        private Label labelPersName;
        private Button buttonLoad;
        private ToolStripMenuItem NewGlobalToDo;
        private ToolStripMenuItem UpdateGlobalTask;
        private DataGridView dataGridViewGlobal;
        private DataGridViewTextBoxColumn GlobalTaskName;
        private DataGridViewCheckBoxColumn GlobalIsDone;
        private Button buttonGlobalSave;
    }
}

