using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Discipline
    {
        private List<Disciplina> _discipline;

        public Discipline()
        {
            _discipline = new List<Disciplina>();
        }
        public void AdaugaDiscipline(Disciplina disciplina)
        {
            _discipline.Add(disciplina);
        }

        public List<Disciplina> ConsultaDiscipline(string numeProfesor)
        {
            List<Disciplina> _disciplineSpecificeProfesorului = new List<Disciplina>();
            //implementare
            return _disciplineSpecificeProfesorului;
        }
    }
}
