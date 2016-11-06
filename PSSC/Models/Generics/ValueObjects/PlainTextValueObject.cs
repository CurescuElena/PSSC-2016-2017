using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Generics.ValueObjects
{
    public class PlainTextValueObject
    {
        private string _text;
        public string Text { get { return _text; } }

        public PlainTextValueObject(string text)
        {
            _text = text;
        }
    }
}
