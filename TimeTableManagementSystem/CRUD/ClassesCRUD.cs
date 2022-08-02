using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTableManagementSystem.Models;
using System.Data.SQLite;

namespace TimeTableManagementSystem.CRUD
{
    class ClassesCRUD
    {
        public static void AddClass(Classes c) {
            String q = "insert into classes(classname) values('" + c.ClassName1 + "');";
            SQLiteConnection con = new SQLiteConnection("Data Source=saved.sqlite;Version=3;");
            con.Open();
            SQLiteCommand cmd = new SQLiteCommand(q, con);
            cmd.ExecuteNonQuery();
            con.Close();


        }
        public static void deleteClass(Classes c)
        {
            String q = "delete from classes where classid="+c.ClassID1+";";
            SQLiteConnection con = new SQLiteConnection("Data Source=saved.sqlite;Version=3;");
            con.Open();
            SQLiteCommand cmd = new SQLiteCommand(q, con);
            cmd.ExecuteNonQuery();
            con.Close();


        }
        public static void UpdateClass(Classes c)
        {
            String q = "update classes set classname="+ c.ClassName1 + " where classid="+c.ClassID1+";";
            SQLiteConnection con = new SQLiteConnection("Data Source=saved.sqlite;Version=3;");
            con.Open();
            SQLiteCommand cmd = new SQLiteCommand(q, con);
            cmd.ExecuteNonQuery();

            con.Close();

        }
        public static SQLiteDataAdapter viewClasses()
        {
            String q = "select ClassID,classname from classes";
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
