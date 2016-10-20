using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Note
    {
        private List<Nota> _noteExamen;
        private List<Nota> _noteDistribuita;
        private List<Nota> _noteActivitate;
        
        public Note()
        {
            _noteExamen = new List<Nota>();
            _noteDistribuita = new List<Nota>();
            _noteActivitate = new List<Nota>();
        }
     
       public float Media(string numeStudent, string numeDisciplina) {
            //implementare
            return 0;
        }
       public  void AdaugaNotaExamen(Nota notaEcxamenPrez1, Nota notaEcxamenPrez2, Nota notaEcxamenPrez3)
        {
            _noteExamen.Add(notaEcxamenPrez1);
            _noteExamen.Add(notaEcxamenPrez2);
            _noteExamen.Add(notaEcxamenPrez3);
        }
      public  void AdaugaNotaDistribuita(Nota notaDistr1, Nota notaDistr2)
        {
            _noteDistribuita.Add(notaDistr1);
            _noteDistribuita.Add(notaDistr2);
        }
       public void AdaugaNoteActivitate(Nota nota)
        {
            _noteActivitate.Add(nota);
        }
    }
}
