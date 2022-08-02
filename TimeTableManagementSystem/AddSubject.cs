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
    public partial class AddSubject : Form
    {
        public AddSubject()
        {
            InitializeComponent();
        }

        public object SubjectCRUD { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {
            String s = txtSubjectName.Text;
            if(s!=null && s!= ""){
                Subjects sub = new Subjects();
                sub.SubjectName1 = s;
                SubjectsCRUD.AddSubject(sub);
                MessageBox.Show("Subject Saved!");
            }
            else{

                MessageBox.Show("Please make sure to fill all boxes");
            }
        }
    }
}
