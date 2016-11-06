namespace Models.Generics.ValueObjects
{
    public class CreditsValueObject
    {
        private int _credits;
        public int Count { get { return _credits; } set { _credits = value; } }

        public CreditsValueObject()
        {
        }

        public CreditsValueObject(int credits)
        {
            _credits = credits;
        }
    }
}
