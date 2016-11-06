using Models.Generics.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Common.Student
{
   public class Student
    {
        public RegistrationNumberValueObject RegNumber { get; internal set; }
        public PlainTextValueObject Name { get; internal set; }
        public CreditsValueObject Credits { get; internal set; }

        public Student(RegistrationNumberValueObject regNumber, PlainTextValueObject name)
        {
            RegNumber = regNumber;
            Name = name;
        }

        public Student(RegistrationNumberValueObject regNumber, PlainTextValueObject name, CreditsValueObject credits)
            : this(regNumber, name)
        {
            Credits = credits;
        }
    }
}
