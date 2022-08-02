using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTableManagementSystem.Models;

namespace TimeTableManagementSystem.CRUD
{
    class TeachersCRUD
    {
        public static void AddTeachers(Teachers s)
        {
            String q = "insert into teachers(teachername) values('" + s.TeacherName1+ "');";
            SQLiteConnection con = new SQLiteConnection("Data Source=saved.sqlite;Version=3;");
            con.Open();
            SQLiteCommand cmd = new SQLiteCommand(q, con);
            cmd.ExecuteNonQuery();
            con.Close();


        }
        public static void deleteClass(Teachers s)
        {
            String q = "delete from teachers where subjectid=" + s.TeacherID1+ ";";
            SQLiteConnection con = new SQLiteConnection("Data Source=saved.sqlite;Version=3;");
            con.Open();
            SQLiteCommand cmd = new SQLiteCommand(q, con);
            cmd.ExecuteNonQuery();
            con.Close();


        }
        public static void UpdateTeachers(Teachers s)
        {
            String q = "update teachers set teachername=" + s.TeacherName1 + " where teacherid=" + s.TeacherID1 + ";";
            SQLiteConnection con = new SQLiteConnection("Data Source=saved.sqlite;Version=3;");
            con.Open();
            SQLiteCommand cmd = new SQLiteCommand(q, con);
            cmd.ExecuteNonQuery();



        }
        public static SQLiteDataAdapter viewTeachers()
        {
            String q = "select teacherid,teachername from teachers";
            SQLiteConnection con = new SQLiteConnection("Data Source=saved.sqlite;Version=3;");
            con.Open();
            SQLiteCommand cmd = new SQLiteCommand(q, con);
            SQLiteDataAdapter sda = new SQLiteDataAdapter();
            sda.SelectCommand = cmd;
            con.Close();
            return sda;



        }
    }
}
