namespace Models
{
    public class Coeficient
    {
        private int _numarator;
        private int _numitor;

        public float fractie { get { return _numarator / _numitor; } }

        public Coeficient(int numarator, int numitor)
        {
            _numarator = numarator;
            _numitor = numitor;
        }
    }
}