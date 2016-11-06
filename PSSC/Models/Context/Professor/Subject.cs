using Models.Generics;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Common.Student;
using Models.Common.Subject;
using Models.Generics.ValueObjects;

namespace Models.Context.Professor
{
    //Entity
    public class Subject
    {
        public SubjectInformation SubjectInfo { get; internal set; }

        private Dictionary<Common.Student.Student, SubjectSituation> _signedUpStudentsGrades;
        public Dictionary<Common.Student.Student, SubjectSituation> SignedUpStudentsGrades { get { return _signedUpStudentsGrades; } }

        public Subject()
        {
            _signedUpStudentsGrades = new Dictionary<Common.Student.Student, SubjectSituation>();
        }

        public Subject(Dictionary<Common.Student.Student, SubjectSituation> signedUpStudentsGrades, SubjectInformation subjectInfo)
        {
            _signedUpStudentsGrades = signedUpStudentsGrades;
            SubjectInfo = subjectInfo;
        }

        public Subject(SubjectInformation subjectInfo) : this()
        {
            SubjectInfo = subjectInfo;
        }

        public void SignUpStudent(Common.Student.Student student)
        {
            _signedUpStudentsGrades.Add(student, new SubjectSituation());
        }

        public GradeValueObject GetAverageForStudent(RegistrationNumberValueObject regNumber)
        {
            SubjectSituation situation = _signedUpStudentsGrades.First(d => d.Key.RegNumber == regNumber).Value;

            decimal activityGrade = situation.ActivityGrade.Value;
            decimal examAverage = situation.GetExamAverage(SubjectInfo.Evaluation);
            decimal proportion = SubjectInfo.ActivityProportion.Fraction;

            return new GradeValueObject(activityGrade * proportion + (1 - proportion) * examAverage);
        }

        public SubjectSituation GetSituationForStudent(RegistrationNumberValueObject regNumber)
        {
            return _signedUpStudentsGrades.First(d => d.Key.RegNumber == regNumber).Value;
        }
    }
}
