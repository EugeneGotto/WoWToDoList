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
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewPersonage = new System.Windows.Forms.ToolStripMenuItem();
            this.NewToDo = new System.Windows.Forms.ToolStripMenuItem();
            this.Update = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdatePers = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdatePersLevel = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdatePersName = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdatePersClass = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateTask = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.полностьюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.настройкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.открытьToolStripMenuItem.Text = "Открыть";
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
            this.NewToDo});
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            // 
            // NewPersonage
            // 
            this.NewPersonage.Name = "NewPersonage";
            this.NewPersonage.Size = new System.Drawing.Size(172, 22);
            this.NewPersonage.Text = "Новый Персонаж";
            this.NewPersonage.Click += new System.EventHandler(this.NewPersonage_Click);
            // 
            // NewToDo
            // 
            this.NewToDo.Name = "NewToDo";
            this.NewToDo.Size = new System.Drawing.Size(172, 22);
            this.NewToDo.Text = "Новое \"Дело\"";
            this.NewToDo.Click += new System.EventHandler(this.NewToDo_Click);
            // 
            // Update
            // 
            this.Update.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UpdatePers,
            this.UpdateTask});
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(152, 22);
            this.Update.Text = "Обновить";
            // 
            // UpdatePers
            // 
            this.UpdatePers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.полностьюToolStripMenuItem,
            this.UpdatePersLevel,
            this.UpdatePersName,
            this.UpdatePersClass});
            this.UpdatePers.Name = "UpdatePers";
            this.UpdatePers.Size = new System.Drawing.Size(152, 22);
            this.UpdatePers.Text = "Персонаж";
            // 
            // UpdatePersLevel
            // 
            this.UpdatePersLevel.Name = "UpdatePersLevel";
            this.UpdatePersLevel.Size = new System.Drawing.Size(152, 22);
            this.UpdatePersLevel.Text = "Уровень";
            this.UpdatePersLevel.Click += new System.EventHandler(this.UpdatePersLevel_Click);
            // 
            // UpdatePersName
            // 
            this.UpdatePersName.Name = "UpdatePersName";
            this.UpdatePersName.Size = new System.Drawing.Size(152, 22);
            this.UpdatePersName.Text = "Имя";
            this.UpdatePersName.Click += new System.EventHandler(this.UpdatePersName_Click);
            // 
            // UpdatePersClass
            // 
            this.UpdatePersClass.Name = "UpdatePersClass";
            this.UpdatePersClass.Size = new System.Drawing.Size(152, 22);
            this.UpdatePersClass.Text = "Класс";
            this.UpdatePersClass.Click += new System.EventHandler(this.UpdatePersClass_Click);
            // 
            // UpdateTask
            // 
            this.UpdateTask.Name = "UpdateTask";
            this.UpdateTask.Size = new System.Drawing.Size(152, 22);
            this.UpdateTask.Text = "\"Дело\"";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(13, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 221);
            this.panel1.TabIndex = 1;
            // 
            // полностьюToolStripMenuItem
            // 
            this.полностьюToolStripMenuItem.Name = "полностьюToolStripMenuItem";
            this.полностьюToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.полностьюToolStripMenuItem.Text = "Полностью";
            this.полностьюToolStripMenuItem.Click += new System.EventHandler(this.полностьюToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewPersonage;
        private Panel panel1;
        private ToolStripMenuItem NewToDo;
        private ToolStripMenuItem Update;
        private ToolStripMenuItem UpdatePers;
        private ToolStripMenuItem UpdatePersLevel;
        private ToolStripMenuItem UpdatePersName;
        private ToolStripMenuItem UpdatePersClass;
        private ToolStripMenuItem UpdateTask;
        private ToolStripMenuItem полностьюToolStripMenuItem;
    }
}

