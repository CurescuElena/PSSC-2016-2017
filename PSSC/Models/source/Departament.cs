using Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.source
{
    class Departament : Faculty, IDepartament
    {
        string nameOfDepartament;
        public List<UniversityPerson> idList { get; internal set; }

        public string departamentName
        {
            get
            {
                return nameOfDepartament;
            }

            set
            {
                nameOfDepartament = value;
            }
        }

        public Departament (int facultyId, string facultyName, string departamentName) : base (facultyId, facultyName)
        {
            nameOfDepartament = departamentName;
        }
    }
}
