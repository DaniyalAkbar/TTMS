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
using System.Data.SQLite;
namespace TimeTableManagementSystem
{
    public partial class ViewClasses : Form
    {
        public ViewClasses()
        {
            InitializeComponent();

        }

        private void ViewClasses_Load(object sender, EventArgs e)
        {
            ClassesCRUD c = new ClassesCRUD();
            SQLiteDataAdapter sda = ClassesCRUD.viewClasses();
            dataGridView1.DataSource = sda;

        }
    }
}
