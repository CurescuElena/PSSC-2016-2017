using Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.source
{
    class UniversityPerson : IUniversityPerson
    {
        string address;
        int id;
        string name;
        string phone;
        List<Subject> subjects;
        Departament depart;
        public string personAddress
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        public int personId
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string personName
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string personPhone
        {
            get
            {
                return phone;
            }

            set
            {
                phone = value;
            }
        }

        public List<Subject> subjectList
        {
            get
            {
                return subjects;
            }

            set
            {
                subjects = value;
            }
        }

        public UniversityPerson(int personId, string personName, string personAddress, string personPhone, List<Subject> subjectList, Departament departament)
        {
            id = personId;
            name = personName;
            address = personAddress;
            phone = personPhone;
            subjects = subjectList;
            depart = departament;
        }

        public void addSubject(Subject subject)
        {
            throw new NotImplementedException();
        }
    }
}
