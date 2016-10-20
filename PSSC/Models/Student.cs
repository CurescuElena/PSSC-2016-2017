using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Student
    {
        public string Nume { get; internal set; }
        public string NumarMatricol { get; internal set; }

        public List<Discipline> _discipline;
        public List<Note> _note;
        bool promovat;
        
        public Student(string nume, string numarMatricol)
        {
            Nume = nume;
            NumarMatricol = numarMatricol;

            _discipline = new List<Discipline>();
            _note = new List<Note>();
        }
   
        public void CalculeazaMediaGenerala()
        {

        }
        public void GenereazaRapoarteNoteDisciplina()
        {

        }
        public void GenereazaRaportMedieGenerala()
        {

        }
        public void GenereazaStareStudenti()
        {

        }
    }
}
