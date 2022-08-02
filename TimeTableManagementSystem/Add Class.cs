using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTableManagementSystem.CRUD;
using TimeTableManagementSystem.Models;

namespace TimeTableManagementSystem
{
    public partial class Add_Class : Form
    {
        private Boolean forUpdate;
        public Add_Class(Boolean forUpdate)
        {
            InitializeComponent();
            this.forUpdate = forUpdate;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveClass_Click(object sender, EventArgs e)
        {
            Classes c = new Classes();
            if (txtClassName.Text != "" && txtClassName != null && cmbSection.Text != "" && cmbSection.Text != null)
            {
                c.ClassName1 = txtClassName + cmbSection.Text;
                ClassesCRUD.AddClass(c);
                MessageBox.Show("Class Saved!");
            }
            else
            {

                MessageBox.Show("Please make sure to fill all boxes");
            }
        }
    }
}
