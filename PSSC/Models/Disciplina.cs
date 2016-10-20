using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Disciplina
    {
        public string Nume { get; internal set; }
        public AnStudiu An { get; internal set; }
        public TipDisciplina Tip { get; internal set; }
        public int NrCredite { get; internal set; }
        public Coeficient PondereExamen { get; }
        private List<Student> _studentiInscrisi;
        public Profesor _profesor;
        string NumeProf { get; }
    
        
        public Disciplina(string nume, AnStudiu an, TipDisciplina tip, int credite, Coeficient pondereExamen)
        {
            Nume = nume;
            An = an;
            Tip = tip;
            NrCredite = credite;
            PondereExamen = pondereExamen;

            _studentiInscrisi = new List<Student>();
            _profesor = new Profesor(NumeProf);
           
        }

    }
}
