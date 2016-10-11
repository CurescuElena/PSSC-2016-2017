using Models.source;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Interface
{
    interface IUniversityPerson
    {
        int personId
        {
            get;
            set;
        }
        string personName
        {
            get;
            set;
        }
        string personAddress
        {
            get;
            set;
        }
        string personPhone
        {
            get;
            set;
        }
        List<Subject> subjectList
        {
            get;
            set;
        }
        void addSubject(Subject subject);
    }
}
