using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TimeTableManagementSystem
{
    public partial class MenuSections : Form
    {
        public MenuSections()
        {
            InitializeComponent();

            
        }
        

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void addAClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new Add_Class(false);
            f.MdiParent = this;
            f.Show();
        }

        private void MenuSections_Load(object sender, EventArgs e)
        {
            DropTables();
            CreateTables();

        }
        public void CreateTables() {
            SQLiteConnection con = new SQLiteConnection("Data Source=saved.sqlite;Version=3;");
            con.Open();

            String q = "CREATE TABLE IF NOT EXISTS classes(classid integer primary key autoincrement,classname varchar);";

            String q2 = "CREATE TABLE IF NOT EXISTS subjects(subjectid integer primary key autoincrement,subjectname varchar);";
            String q3 = "CREATE TABLE IF NOT EXISTS teachers(teacherid integer primary key autoincrement,teachername varchar);";
            String q4 = "CREATE TABLE IF NOT EXISTS timetable(TID integer primary key autoincrement," +
                "subjectid int references subjects(subjectid)," +
                "classid int references classes(classid)," +
                "teacherid int references teachers(teacherid),Day varchar,StartTime varchar, EndTime varchar);";

            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = con;
            cmd.CommandText = q;
            cmd.ExecuteNonQuery();
            cmd.CommandText = q2;
            cmd.ExecuteNonQuery();
            cmd.CommandText = q3;
            cmd.ExecuteNonQuery();
            cmd.CommandText = q4;
            cmd.ExecuteNonQuery();
            con.Close();

        }

        public void DropTables() {
            SQLiteConnection con = new SQLiteConnection("Data Source=saved.sqlite;Version=3;");
            con.Open();

            String q1 = "DROP TABLE IF EXISTS sections";
            String q = "DROP TABLE IF EXISTS classes";

            String q2 = "DROP TABLE IF EXISTS subjects";
            String q3 = "DROP TABLE IF EXISTS teachers";
            String q4 = "DROP TABLE IF EXISTS timetable";

            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = con;
            cmd.CommandText = q1;
            cmd.ExecuteNonQuery();
            cmd.CommandText = q;
            cmd.ExecuteNonQuery();
            cmd.CommandText = q2;
            cmd.ExecuteNonQuery();
            cmd.CommandText = q3;
            cmd.ExecuteNonQuery();
            cmd.CommandText = q4;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void addATeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new AddTeacher();
            f.MdiParent = this;
            
            f.Show();
        }
    }
    
}
