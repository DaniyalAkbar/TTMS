using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTableManagementSystem.Models;

namespace TimeTableManagementSystem.CRUD
{
    class SectionCRUD
    {
        public static void AddSection(Sections s)
        {
            String q = "insert into sections(sectionname) values(" + s.SectionName1+ ");";
            SQLiteConnection con = new SQLiteConnection("Data Source=saved.sqlite;Version=3;");
            con.Open();
            SQLiteCommand cmd = new SQLiteCommand(q, con);
            cmd.ExecuteNonQuery();
            con.Close();


        }
        public static void deleteSections(Sections s)
        {
            String q = "delete from sections where sectionid=" + s.SectionID1+ ";";
            SQLiteConnection con = new SQLiteConnection("Data Source=saved.sqlite;Version=3;");
            con.Open();
            SQLiteCommand cmd = new SQLiteCommand(q, con);
            cmd.ExecuteNonQuery();
            con.Close();


        }
        public static void UpdateSection(Sections s)
        {
            String q = "update sections set sectionname=" + s.SectionName1+ " where sectionid=" + s.SectionID1+ ";";
            SQLiteConnection con = new SQLiteConnection("Data Source=saved.sqlite;Version=3;");
            con.Open();
            SQLiteCommand cmd = new SQLiteCommand(q, con);
            cmd.ExecuteNonQuery();



        }
        public static SQLiteDataAdapter viewSections()
        {
            String q = "select sectionid,sectionname from sections";
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
