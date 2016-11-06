using Models.Generics.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Common.Professor
{
   public class Professor
    {
        public PlainTextValueObject Name { get; internal set; }
         public Professor(PlainTextValueObject name)
        {
            Name = name;
        }
    }
}
