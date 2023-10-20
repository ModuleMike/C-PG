namespace VinFletchersArrows
{
    public class Arrow
    {
        private Head _headType;
        private Fletch _fletchingType;
        private float _length, _min, _max;

        public void SelectOrder()
        {
            _headType = ConsoleIO.HeadSelect();
            _fletchingType = ConsoleIO.FletchSelect();
            _length = ConsoleIO.LengthSelect(_min, _max);
        }

        public float CheckOut()
        {
            return (float)_headType + (float)_fletchingType + (_length * 0.05f);
        }
    }
    public enum Head
    {
        Steel = 10,
        Wood = 3,
        Obsidian = 5
    }
    public enum Fletch
    {
        Plastic = 10,
        Turkeyfeathers = 5,
        Goosefeathers = 3
    }
}