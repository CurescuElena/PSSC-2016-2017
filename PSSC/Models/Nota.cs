using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Nota
    {
        private int _valoare;
        public int Valoare { get { return _valoare; } }

        public Nota(int valoare)
        {
            _valoare = valoare;
        }
    }
}
