using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Generics.ValueObjects
{
    public class RegistrationNumberValueObject
    {
        private string _number;
        public string Number { get { return _number; } }

        public RegistrationNumberValueObject(string number)
        {
            _number = number;
        }
    }
}
