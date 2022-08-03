namespace TimeTableManagementSystem
{
    partial class MenuSections
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuClasses = new System.Windows.Forms.ToolStripMenuItem();
            this.addAClassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewClassesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teachersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addATeacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewTeachersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addASubjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSubjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addATimeTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timeSlotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.daysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuClasses,
            this.teachersToolStripMenuItem,
            this.subjectsToolStripMenuItem,
            this.timeTableToolStripMenuItem,
            this.timeSlotToolStripMenuItem,
            this.daysToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuClasses
            // 
            this.menuClasses.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAClassToolStripMenuItem,
            this.viewClassesToolStripMenuItem});
            this.menuClasses.Name = "menuClasses";
            this.menuClasses.Size = new System.Drawing.Size(57, 20);
            this.menuClasses.Text = "Classes";
            this.menuClasses.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // addAClassToolStripMenuItem
            // 
            this.addAClassToolStripMenuItem.Name = "addAClassToolStripMenuItem";
            this.addAClassToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.addAClassToolStripMenuItem.Text = "Add a Class";
            this.addAClassToolStripMenuItem.Click += new System.EventHandler(this.addAClassToolStripMenuItem_Click);
            // 
            // viewClassesToolStripMenuItem
            // 
            this.viewClassesToolStripMenuItem.Name = "viewClassesToolStripMenuItem";
            this.viewClassesToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.viewClassesToolStripMenuItem.Text = "View Classes";
            // 
            // teachersToolStripMenuItem
            // 
            this.teachersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addATeacherToolStripMenuItem,
            this.viewTeachersToolStripMenuItem});
            this.teachersToolStripMenuItem.Name = "teachersToolStripMenuItem";
            this.teachersToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.teachersToolStripMenuItem.Text = "Teachers";
            // 
            // addATeacherToolStripMenuItem
            // 
            this.addATeacherToolStripMenuItem.Name = "addATeacherToolStripMenuItem";
            this.addATeacherToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.addATeacherToolStripMenuItem.Text = "Add a Teacher";
            this.addATeacherToolStripMenuItem.Click += new System.EventHandler(this.addATeacherToolStripMenuItem_Click);
            // 
            // viewTeachersToolStripMenuItem
            // 
            this.viewTeachersToolStripMenuItem.Name = "viewTeachersToolStripMenuItem";
            this.viewTeachersToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.viewTeachersToolStripMenuItem.Text = "View Teachers";
            // 
            // subjectsToolStripMenuItem
            // 
            this.subjectsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addASubjectToolStripMenuItem,
            this.viewSubjectsToolStripMenuItem});
            this.subjectsToolStripMenuItem.Name = "subjectsToolStripMenuItem";
            this.subjectsToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.subjectsToolStripMenuItem.Text = "Subjects";
            // 
            // addASubjectToolStripMenuItem
            // 
            this.addASubjectToolStripMenuItem.Name = "addASubjectToolStripMenuItem";
            this.addASubjectToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.addASubjectToolStripMenuItem.Text = "Add a Subject";
            // 
            // viewSubjectsToolStripMenuItem
            // 
            this.viewSubjectsToolStripMenuItem.Name = "viewSubjectsToolStripMenuItem";
            this.viewSubjectsToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.viewSubjectsToolStripMenuItem.Text = "View Subjects";
            // 
            // timeTableToolStripMenuItem
            // 
            this.timeTableToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addATimeTableToolStripMenuItem,
            this.viewTimeToolStripMenuItem});
            this.timeTableToolStripMenuItem.Name = "timeTableToolStripMenuItem";
            this.timeTableToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.timeTableToolStripMenuItem.Text = "TimeTable";
            // 
            // addATimeTableToolStripMenuItem
            // 
            this.addATimeTableToolStripMenuItem.Name = "addATimeTableToolStripMenuItem";
            this.addATimeTableToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.addATimeTableToolStripMenuItem.Text = "Add a Time Table";
            // 
            // viewTimeToolStripMenuItem
            // 
            this.viewTimeToolStripMenuItem.Name = "viewTimeToolStripMenuItem";
            this.viewTimeToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.viewTimeToolStripMenuItem.Text = "View Time Table";
            // 
            // timeSlotToolStripMenuItem
            // 
            this.timeSlotToolStripMenuItem.Name = "timeSlotToolStripMenuItem";
            this.timeSlotToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.timeSlotToolStripMenuItem.Text = "Time Slot";
            // 
            // daysToolStripMenuItem
            // 
            this.daysToolStripMenuItem.Name = "daysToolStripMenuItem";
            this.daysToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.daysToolStripMenuItem.Text = "Days";
            // 
            // MenuSections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuSections";
            this.Text = "Time Table Management System";
            this.Load += new System.EventHandler(this.MenuSections_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuClasses;
        private System.Windows.Forms.ToolStripMenuItem addAClassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewClassesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teachersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addATeacherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewTeachersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subjectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addASubjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewSubjectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timeTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addATimeTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewTimeToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem timeSlotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem daysToolStripMenuItem;
    }
}

