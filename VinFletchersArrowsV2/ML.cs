namespace VinFletchersArrows
{
    public class ML
    {
        public static string S_CapFirst(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }
            string _input = input.Trim();
            char _upper = char.ToUpperInvariant(_input[0]);
            string _outsub = _input.Substring(1);
            return _upper + _outsub;
        }

    }
}