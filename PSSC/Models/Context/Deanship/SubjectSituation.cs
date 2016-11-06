using Models.Generics;
using Models.Generics.ValueObjects;
using Models.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Context.Deanship
{
    public class SubjectSituation
    {
        public AttendanceValueObject Attendance { get; internal set; }
        public List<GradeValueObject> ExamGrades { get; internal set; }
        public GradeValueObject ActivityGrade { get; internal set; }

        public SubjectSituation()
        {

        }

        public SubjectSituation(AttendanceValueObject attendance, List<GradeValueObject> examGrades, GradeValueObject activityGrade)
        {
            Attendance = attendance;
            ExamGrades = examGrades;
            ActivityGrade = activityGrade;
        }

        public void AddExamGrade(GradeValueObject examGrade)
        {
            ExamGrades.Add(examGrade);
        }

        public void AddActivityGrade(GradeValueObject activityGrade)
        {
            ActivityGrade = activityGrade;
        }

        public void AddAttendance(AttendanceValueObject attendance)
        {
            Attendance = attendance;
        }

        public decimal GetExamAverage(EvaluationType type)
        {
            GradeValueObject average;

            if (type.Equals(EvaluationType.Distributed))
            {
                average = new GradeValueObject((ExamGrades[0].Value + ExamGrades[1].Value) / 2);
            }
            else
            {
                average = new GradeValueObject(ExamGrades[0].Value);
            }

            return average.Value;
        }
    }
}
