using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTableManagementSystem.Models;

namespace TimeTableManagementSystem.CRUD
{
    class SubjectsCRUD
    {
        public static void AddSubject(Subjects s)
        {
            String q = "insert into subjects(subjectname) values(" + s.SubjectName1 + ");";
            SQLiteConnection con = new SQLiteConnection("Data Source=saved.sqlite;Version=3;");
            con.Open();
            SQLiteCommand cmd = new SQLiteCommand(q, con);
            cmd.ExecuteNonQuery();
            con.Close();


        }
        public static void deleteSubject(Subjects s)
        {
            String q = "delete from subjects where subjectid=" + s.SubjectID1 + ";";
            SQLiteConnection con = new SQLiteConnection("Data Source=saved.sqlite;Version=3;");
            con.Open();
            SQLiteCommand cmd = new SQLiteCommand(q, con);
            cmd.ExecuteNonQuery();
            con.Close();


        }
        public static void UpdateSubject(Classes c)
        {
            String q = "update classes set classname=" + c.ClassName1 + ",sectionid=" + c.ClassSection1 + " where classid=" + c.ClassID1 + ";";
            SQLiteConnection con = new SQLiteConnection("Data Source=saved.sqlite;Version=3;");
            con.Open();
            SQLiteCommand cmd = new SQLiteCommand(q, con);
            cmd.ExecuteNonQuery();



        }
        public static SQLiteDataAdapter viewSubjects()
        {
            String q = "select subjectid,subectname from subjects";
            SQLiteConnection con = new SQLiteConnection("Data Source=saved.sqlite;Version=3;");
            con.Open();
            SQLiteCommand cmd = new SQLiteCommand(q, con);
            SQLiteDataAdapter sda = new SQLiteDataAdapter();
            sda.SelectCommand=cmd;
            con.Close();
            return sda;



        }
    }
}
