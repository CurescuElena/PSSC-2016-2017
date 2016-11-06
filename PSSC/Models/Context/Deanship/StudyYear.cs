using Models.Common.Subject;
using Models.Generics;
using Models.Generics.ValueObjects;
using Models.Subject;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Context.Deanship
{
    //Aggregate Root
    public class StudyYear
    {
        private List<Subject> _definedSubjects;
        public ReadOnlyCollection<Subject> Subjects { get { return _definedSubjects.AsReadOnly(); } }

        public StudyYear()
        {

        }

        public StudyYear(List<Subject> definedSubjects)
        {
            _definedSubjects = definedSubjects;
        }

        public void DefineSubject(PlainTextValueObject subjectName, CreditsValueObject credits, EvaluationType type, ProportionValueObject activity)
        {
            _definedSubjects.Add(new Subject(new SubjectInformation(subjectName, credits, type, activity)));
        }

        public void DefineSubject(PlainTextValueObject subjectName, CreditsValueObject credits, EvaluationType type, ProportionValueObject activity,Common.Professor.Professor professor)
        {
            _definedSubjects.Add(new Subject(new Common.Subject.SubjectInformation(subjectName, credits, type, activity, professor)));
        }

        public void SignUpStudentToSubject(PlainTextValueObject subjectName, Common.Student.Student student)
        {
            _definedSubjects.Find(d => d.SubjectInfo.Name == subjectName).SignUpStudent(student);
        }

        public GradeValueObject CalculateStudentAverage(PlainTextValueObject subjectName, RegistrationNumberValueObject regNumber)
        {
            return _definedSubjects.Find(d => d.SubjectInfo.Name == subjectName).GetAverageForStudent(regNumber);
        }

        public void PublishGradeReports(IReportPublisher publisher)
        {

        }
    }
}
