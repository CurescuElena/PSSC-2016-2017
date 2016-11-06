using Models.Generics.ValueObjects;
using Models.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Common.Subject
{
   public class SubjectInformation
    {
        public PlainTextValueObject Name { get; internal set; }
        public CreditsValueObject Credits { get; internal set; }
        public Professor.Professor Professor { get; internal set; }
        public ProportionValueObject ActivityProportion { get; internal set; }
        public EvaluationType Evaluation { get; internal set; }
     //   public SubjectInformation SubjectInfo { get; internal set; }
        public SubjectInformation()
        {

        }

        public SubjectInformation(PlainTextValueObject name, CreditsValueObject credits, EvaluationType type, ProportionValueObject activity)
        {
            Name = name;
            Credits = credits;
            Evaluation = type;
            ActivityProportion = activity;
        }

        public SubjectInformation(PlainTextValueObject name, CreditsValueObject credits, EvaluationType type, ProportionValueObject activity, Professor.Professor professor)
            : this(name, credits, type, activity)
        {
            Professor = professor;
        }
    }
}
