using Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.source
{
    class Subject : ISubject
    {
        string nameOfSubject;
        int yaerOfSubject;
        public string subjectName
        {
            get
            {
                return nameOfSubject;
            }

            set
            {
                nameOfSubject = value;
            }
        }

        public int subjectYear
        {
            get
            {
                return yaerOfSubject;
            }

            set
            {
                yaerOfSubject = value;
            }
        }
        public Subject(string subjectName)
        {
            nameOfSubject = subjectName;
        }
        public Subject(string subjectName, int subjectYear)
        {
            nameOfSubject = subjectName;
            yaerOfSubject = subjectYear;
        }
    }
}
