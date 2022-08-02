using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTableManagementSystem.Models
{
    class TimeTable
    {
        private int TID;
        private int SubjectID;
        private int TeacherID;
        private int Class;
        private int Section;
        private String Day;
        private String StartTime;
        private String EndTime;

        public int TID1 { get => TID; set => TID = value; }
        public int SubjectID1 { get => SubjectID; set => SubjectID = value; }
        public int TeacherID1 { get => TeacherID; set => TeacherID = value; }
        public int Class1 { get => Class; set => Class = value; }
        public int Section1 { get => Section; set => Section = value; }
        public string Day1 { get => Day; set => Day = value; }
        public string StartTime1 { get => StartTime; set => StartTime = value; }
        public string EndTime1 { get => EndTime; set => EndTime = value; }
    }
}
