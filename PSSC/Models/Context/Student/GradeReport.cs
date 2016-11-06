using Models.Generics;
using Models.Generics.ValueObjects;
using Models.Subject;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Context.Student
{
    //Aggregate Root
    public class GradeReport
    {
        private ReadOnlyCollection<KeyValuePair<Common.Subject.SubjectInformation, SubjectSituation>> _gradeReport;

        public GradeReport(ReadOnlyCollection<KeyValuePair<Common.Subject.SubjectInformation, SubjectSituation>> gradeReport)
        {
            _gradeReport = gradeReport;
        }

        public SubjectSituation GetSubjectSituation(PlainTextValueObject subjectName)
        {
            return _gradeReport.First(d => d.Key.Name == subjectName).Value;
        }
    }
}