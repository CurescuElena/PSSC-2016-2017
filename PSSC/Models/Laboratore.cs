using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Laboratore
    {
        private List<Laborator> _laboratoare;
        private List<int> _prezenta;
        public Laboratore()
        {
            _laboratoare = new List<Laborator>();
        }
        public void AdaugaPrezentaLaborator(Laborator laborator, int nrSaptamana)
        {
            _laboratoare.Add(laborator);
            _prezenta.Add(nrSaptamana);
        }
    }
}
