using Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.source
{
    class Faculty : IFaculty
    {
        int idOfFaculty;
        string nameOfFaculty;

        public string facultyName
        {
            get
            {
                return nameOfFaculty;
            }

            set
            {
                nameOfFaculty = value;
            }
        }

        public int facultyId
        {
            get
            {
                return idOfFaculty;
            }

            set
            {
                idOfFaculty = value;
            }
        }

        public Faculty(int facultyId, string facultyName)
        {
            idOfFaculty = facultyId;
            nameOfFaculty = facultyName;
        }
    }
}
