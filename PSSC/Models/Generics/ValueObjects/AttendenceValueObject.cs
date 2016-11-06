using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Generics.ValueObjects
{
    public class AttendanceValueObject
    {
        private int _count;
        public int Count { get; internal set; }

        public AttendanceValueObject(int count)
        {
            _count = count;
        }
    }
}
