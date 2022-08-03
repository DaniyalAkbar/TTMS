using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTableManagementSystem.Models
{
    class TimeSlot
    {
        int TimeSlotID;
        String StartTime;
        String EndTime;

        public int TimeSlotID1 { get => TimeSlotID; set => TimeSlotID = value; }
        public string StartTime1 { get => StartTime; set => StartTime = value; }
        public string EndTime1 { get => EndTime; set => EndTime = value; }
    }
}
