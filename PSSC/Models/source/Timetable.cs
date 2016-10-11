using Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.source
{
    class Timetable : ITimetable
    {
        string day;
        int start;
        int end;
        HourType hour;
        Subject subjectInstance;
        Room roomInstance;
        public string dayOfWeek
        {
            get
            {
                return day;
            }

            set
            {
                day = value;
            }
        }

        public int endHour
        {
            get
            {
                return end;
            }

            set
            {
                end = value;
            }
        }

        public int startHour
        {
            get
            {
                return start;
            }

            set
            {
                start = value;
            }
        }

        public HourType typeHour
        {
            get
            {
                return hour;
            }

            set
            {
                hour = value;
            }
        }

        public Timetable(Subject subject, string dayOfWeek, int startHour, int endHour, HourType typeHour, Room room)
        {
            subjectInstance = subject;
            day = dayOfWeek;
            start = startHour;
            end = endHour;
            hour = typeHour;
            roomInstance = room;
        }
    }
}
