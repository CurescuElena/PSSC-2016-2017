using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    //defineste lista de discipline
    //calculeaza media unui student la o anumita disciplina
    class Decanat
    {
        private Discipline _discipline;
       
        string NumeStudent { get; }
        string NumarMatricol { get; }
        private Student _student;
        public Decanat()
        {
            _discipline = new Discipline();
            _student = new Student(NumeStudent, NumarMatricol);
        }
    }
}
