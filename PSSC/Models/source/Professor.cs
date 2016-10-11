using Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.source
{
    class Professor : UniversityPerson, IProfessor
    {
        PositionType posType;
        public PositionType position
        {
            get
            {
                return posType;
            }

            set
            {
                posType = value;
            }
        }

        Professor (int personId, string personName, string personAddress, string personPhone, List<Subject> subjectList, Departament departament, PositionType position)
           : base(personId, personName, personAddress, personPhone,subjectList, departament) 
        {
            posType = position;
        }
        public void verifyStudents()
        {
            throw new NotImplementedException();
        }
    }
}
