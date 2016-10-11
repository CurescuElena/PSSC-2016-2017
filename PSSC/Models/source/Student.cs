using Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.source
{
    class Student : UniversityPerson, IStudent
    {
        int studyYear;
        Timetable timeTable;
        public int yearOfStudy
        {
            get
            {
                return studyYear;
            }

            set
            {
                studyYear = value;
            }
        }
        public Student(int personId, string personName, string personAddress, string personPhone, List<Subject> subjectList, Departament departament, int yearOfStudy, Timetable timetable)
           : base(personId, personName, personAddress, personPhone,subjectList, departament)
        {
            studyYear = yearOfStudy;
            timeTable = timetable;
        }
}
}
