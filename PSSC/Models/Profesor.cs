using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    //consulta lista disciplinelor de care este responsabil (_discipline.ConsultaDiscipline())
    //introduce note
    //introduce prezenta laborator
    //stabileste ponderea
    class Profesor
    {
       public string Nume { get; internal set; }

       private Discipline _discipline;
       private Note _note;
       private Laboratore _laboratoare;

       private int _numarator;
       private int _numitor;
       private Coeficient _pondereExamen;

        public Profesor(string nume)
        {
            Nume = nume;
        }
        public Profesor()
        {
            _discipline = new Discipline();
            _note = new Note();
            _laboratoare = new Laboratore();

        //    _pondereExamen = new Coeficient(_numarator, _numitor);
        }    
    
    }
}
