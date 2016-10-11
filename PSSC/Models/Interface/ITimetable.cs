using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Interface
{
    enum HourType
    {
        Curs,
        Seminar,
        Laborator
    }
    interface ITimetable
    {
        string dayOfWeek
        {
            get;
            set;
        }
        int startHour
        {
            get;
            set;
        }
        int endHour
        {
            get;
            set;
        }
        HourType typeHour
        {
            get;
            set;
        }
    }
}
