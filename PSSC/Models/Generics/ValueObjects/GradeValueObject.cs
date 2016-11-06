using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Generics.ValueObjects
{
    public class GradeValueObject
    {
        private decimal _value;
        public decimal Value { get { return _value; } }

        public GradeValueObject(decimal value)
        {
            _value = value;
        }
    }
}
