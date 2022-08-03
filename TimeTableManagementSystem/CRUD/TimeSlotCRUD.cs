using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTableManagementSystem.Models;

namespace TimeTableManagementSystem.CRUD
{
    class TimeSlotCRUD
    {
        public static void addTimeSlot(TimeSlot ts)
        {
            String q= "insert into TimeSlot";
            SQLiteConnection con = new SQLiteConnection("Data Source=saved.sqlite;Version=3;");
            con.Open();
            SQLiteCommand cmd = new SQLiteCommand(q, con);
            cmd.ExecuteNonQuery();
            con.Close();


        }
    }
}
