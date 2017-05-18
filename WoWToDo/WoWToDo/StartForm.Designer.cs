namespace WoWToDo
{
    partial class StartForm
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
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabDaily = new System.Windows.Forms.TabPage();
            this.tabControlPersonagesDaily = new System.Windows.Forms.TabControl();
            this.tabWeekly = new System.Windows.Forms.TabPage();
            this.tabControlPersonagesWeekly = new System.Windows.Forms.TabControl();
            this.tabToys = new System.Windows.Forms.TabPage();
            this.tabPets = new System.Windows.Forms.TabPage();
            this.tabMaunts = new System.Windows.Forms.TabPage();
            this.tabAchives = new System.Windows.Forms.TabPage();
            this.tabControlMain.SuspendLayout();
            this.tabDaily.SuspendLayout();
            this.tabWeekly.SuspendLayout();
            this.SuspendLayout();
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(150, 175);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControlMain.Controls.Add(this.tabDaily);
            this.tabControlMain.Controls.Add(this.tabWeekly);
            this.tabControlMain.Controls.Add(this.tabToys);
            this.tabControlMain.Controls.Add(this.tabPets);
            this.tabControlMain.Controls.Add(this.tabMaunts);
            this.tabControlMain.Controls.Add(this.tabAchives);
            this.tabControlMain.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControlMain.ItemSize = new System.Drawing.Size(19, 19);
            this.tabControlMain.Location = new System.Drawing.Point(13, 13);
            this.tabControlMain.Multiline = true;
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(844, 492);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabDaily
            // 
            this.tabDaily.Controls.Add(this.tabControlPersonagesDaily);
            this.tabDaily.Location = new System.Drawing.Point(23, 4);
            this.tabDaily.Name = "tabDaily";
            this.tabDaily.Padding = new System.Windows.Forms.Padding(3);
            this.tabDaily.Size = new System.Drawing.Size(817, 484);
            this.tabDaily.TabIndex = 0;
            this.tabDaily.Text = "Ежедневки";
            this.tabDaily.UseVisualStyleBackColor = true;
            // 
            // tabControlPersonagesDaily
            // 
            this.tabControlPersonagesDaily.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControlPersonagesDaily.ItemSize = new System.Drawing.Size(19, 19);
            this.tabControlPersonagesDaily.Location = new System.Drawing.Point(0, 0);
            this.tabControlPersonagesDaily.Multiline = true;
            this.tabControlPersonagesDaily.Name = "tabControlPersonagesDaily";
            this.tabControlPersonagesDaily.SelectedIndex = 0;
            this.tabControlPersonagesDaily.Size = new System.Drawing.Size(821, 487);
            this.tabControlPersonagesDaily.TabIndex = 0;
            // 
            // tabWeekly
            // 
            this.tabWeekly.Controls.Add(this.tabControlPersonagesWeekly);
            this.tabWeekly.Location = new System.Drawing.Point(23, 4);
            this.tabWeekly.Name = "tabWeekly";
            this.tabWeekly.Padding = new System.Windows.Forms.Padding(3);
            this.tabWeekly.Size = new System.Drawing.Size(817, 484);
            this.tabWeekly.TabIndex = 1;
            this.tabWeekly.Text = "Еженедельки";
            this.tabWeekly.UseVisualStyleBackColor = true;
            // 
            // tabControlPersonagesWeekly
            // 
            this.tabControlPersonagesWeekly.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControlPersonagesWeekly.ItemSize = new System.Drawing.Size(19, 19);
            this.tabControlPersonagesWeekly.Location = new System.Drawing.Point(0, 0);
            this.tabControlPersonagesWeekly.Multiline = true;
            this.tabControlPersonagesWeekly.Name = "tabControlPersonagesWeekly";
            this.tabControlPersonagesWeekly.SelectedIndex = 0;
            this.tabControlPersonagesWeekly.Size = new System.Drawing.Size(821, 487);
            this.tabControlPersonagesWeekly.TabIndex = 0;
            // 
            // tabToys
            // 
            this.tabToys.Location = new System.Drawing.Point(23, 4);
            this.tabToys.Name = "tabToys";
            this.tabToys.Padding = new System.Windows.Forms.Padding(3);
            this.tabToys.Size = new System.Drawing.Size(817, 484);
            this.tabToys.TabIndex = 2;
            this.tabToys.Text = "Игрушки";
            this.tabToys.UseVisualStyleBackColor = true;
            // 
            // tabPets
            // 
            this.tabPets.Location = new System.Drawing.Point(23, 4);
            this.tabPets.Name = "tabPets";
            this.tabPets.Padding = new System.Windows.Forms.Padding(3);
            this.tabPets.Size = new System.Drawing.Size(817, 484);
            this.tabPets.TabIndex = 3;
            this.tabPets.Text = "Петы";
            this.tabPets.UseVisualStyleBackColor = true;
            // 
            // tabMaunts
            // 
            this.tabMaunts.Location = new System.Drawing.Point(23, 4);
            this.tabMaunts.Name = "tabMaunts";
            this.tabMaunts.Padding = new System.Windows.Forms.Padding(3);
            this.tabMaunts.Size = new System.Drawing.Size(817, 484);
            this.tabMaunts.TabIndex = 4;
            this.tabMaunts.Text = "Маунты";
            this.tabMaunts.UseVisualStyleBackColor = true;
            // 
            // tabAchives
            // 
            this.tabAchives.Location = new System.Drawing.Point(23, 4);
            this.tabAchives.Name = "tabAchives";
            this.tabAchives.Padding = new System.Windows.Forms.Padding(3);
            this.tabAchives.Size = new System.Drawing.Size(817, 484);
            this.tabAchives.TabIndex = 5;
            this.tabAchives.Text = "Достижения";
            this.tabAchives.UseVisualStyleBackColor = true;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 517);
            this.Controls.Add(this.tabControlMain);
            this.Name = "StartForm";
            this.Text = "StartForm";
            this.tabControlMain.ResumeLayout(false);
            this.tabDaily.ResumeLayout(false);
            this.tabWeekly.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabDaily;
        private System.Windows.Forms.TabPage tabWeekly;
        private System.Windows.Forms.TabPage tabToys;
        private System.Windows.Forms.TabPage tabPets;
        private System.Windows.Forms.TabPage tabMaunts;
        private System.Windows.Forms.TabPage tabAchives;
        private System.Windows.Forms.TabControl tabControlPersonagesDaily;
        private System.Windows.Forms.TabControl tabControlPersonagesWeekly;
    }
}