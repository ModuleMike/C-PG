namespace VinFletchersArrows
{
    public class Arrow
    {
        private Head _headType;
        private Fletch _fletchingType;
        private float _length;
        private float _min = 60f;
        private float _max = 100f;

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


        public float CustomArrow()
        {
            return (float)_headType + (float)_fletchingType + (_length * 0.05f);
        }
        public static float EliteArrow()
        {
            return (float)Head.Steel + (float)Fletch.Plastic + 95f * 0.05f;
        }
        public static float BeginnerArrow()
        {
            return (float)Head.Wood + (float)Fletch.Goosefeathers + 75f * 0.05f;
        }
        public static float MarksmanArrow()
        {
            return (float)Head.Steel + (float)Fletch.Turkeyfeathers + 65f * 0.05f;
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
    public enum EliteArrow
    {
        Elite = 1,
        Beginner = 2,
        Marksman = 3
    }
}