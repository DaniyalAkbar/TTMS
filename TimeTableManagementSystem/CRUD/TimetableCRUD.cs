using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTableManagementSystem.Models;
using System.Data.SQLite;

namespace TimeTableManagementSystem.CRUD
{
    class TimetableCRUD
    {
        public static void AddTimeTable(TimeTable t) {
            String q = "insert into timetable(teacherid,subjectid,classid,Day,StartTime,EndTime) values(" + t.TeacherID1 + ","+t.SubjectID1+"," + t.Class1 + ","+t.Section1+",'"+t.Day1+"','"+t.StartTime1+"','"+t.EndTime1+"');";
            SQLiteConnection con = new SQLiteConnection("Data Source=saved.sqlite;Version=3;");
            con.Open();
            SQLiteCommand cmd = new SQLiteCommand(q, con);
            cmd.ExecuteNonQuery();
            con.Close();


        }
        public static void deleteClass(TimeTable t)
        {
            String q = "delete from TimeTable where tid="+t.TID1+";";
            SQLiteConnection con = new SQLiteConnection("Data Source=saved.sqlite;Version=3;");
            con.Open();
            SQLiteCommand cmd = new SQLiteCommand(q, con);
            cmd.ExecuteNonQuery();
            con.Close();


        }
        public static void UpdateClass(Classes c)
        {
            String q = "update classes set classname="+ c.ClassName1 + ",sectionid=" + c.ClassSection1 + " where classid="+c.ClassID1+";";
            SQLiteConnection con = new SQLiteConnection("Data Source=saved.sqlite;Version=3;");
            con.Open();
            SQLiteCommand cmd = new SQLiteCommand(q, con);
            cmd.ExecuteNonQuery();

            con.Close();

        }
        public static SQLiteDataAdapter viewClasses()
        {
            String q = "select * from timetable";
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
