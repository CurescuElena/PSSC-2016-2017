using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Laborator
    {
        public string Nume { get; internal set; }

        public Laborator(string nume)
        {
            Nume = nume;
        }
    }
}
