namespace TimeTableManagementSystem
{
    partial class Add_Class
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
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveClass = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSection = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtClassName
            // 
            this.txtClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtClassName.Location = new System.Drawing.Point(85, 25);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(100, 29);
            this.txtClassName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Class";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSaveClass
            // 
            this.btnSaveClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnSaveClass.Location = new System.Drawing.Point(13, 120);
            this.btnSaveClass.Name = "btnSaveClass";
            this.btnSaveClass.Size = new System.Drawing.Size(106, 37);
            this.btnSaveClass.TabIndex = 3;
            this.btnSaveClass.Text = "Save";
            this.btnSaveClass.UseVisualStyleBackColor = true;
            this.btnSaveClass.Click += new System.EventHandler(this.btnSaveClass_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Section";
            // 
            // cmbSection
            // 
            this.cmbSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cmbSection.FormattingEnabled = true;
            this.cmbSection.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F"});
            this.cmbSection.Location = new System.Drawing.Point(88, 69);
            this.cmbSection.Name = "cmbSection";
            this.cmbSection.Size = new System.Drawing.Size(121, 32);
            this.cmbSection.TabIndex = 7;
            // 
            // Add_Class
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 173);
            this.Controls.Add(this.cmbSection);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSaveClass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtClassName);
            this.Name = "Add_Class";
            this.Text = "Add_Class";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveClass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSection;
    }
}