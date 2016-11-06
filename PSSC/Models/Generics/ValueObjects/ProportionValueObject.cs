namespace Models.Generics.ValueObjects
{
    public class ProportionValueObject
    {
        private int _numerator;
        private int _denominator;
        public decimal Fraction { get { return _numerator / _denominator; } }

        public ProportionValueObject(int numerator, int denominator)
        {
            _numerator = numerator;
            _denominator = denominator;
        }
    }
}
