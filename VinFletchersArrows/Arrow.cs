namespace VinFletchersArrows
{
    public class Arrow
    {
        private ArrowHead _headType { get; set; }
        private Fletching _fletchingType { get; set; }
        private float _length { get; set; }
        private float _min = 60;
        private float _max = 100;
        public void ArrowBuild()
        {
            float _min = 60;
            float _max = 100;
            _headType = ConsoleIO.HeadSelection();
            _fletchingType = ConsoleIO.FletchingSelection();
            _length = ConsoleIO.LengthSelection(_min, _max);
        }

        public float GetCost()
        {
            return (float)_headType + (float)_fletchingType + (_length * 0.05f);
        }
    }
    public enum ArrowHead
    {
        Steel = 10,
        Wood = 3,
        Obsidian = 5
    }
    public enum Fletching
    {
        Plastic = 10,
        TurkeyFeathers = 5,
        GooseFeathers = 3
    }
}