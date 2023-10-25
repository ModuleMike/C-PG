
deck newDeck = new deck();


public class deck
{
    public deck()
    {
        CardColor[] Colors = new CardColor[] { CardColor.Red, CardColor.Green, CardColor.Blue, CardColor.Yellow, };
        CardRank[] Ranks = new CardRank[] { CardRank.One, CardRank.Two, CardRank.Three,CardRank.Four, CardRank.Five, CardRank.Six, CardRank.Seven,
            CardRank.Eight, CardRank.Nine,CardRank.Ten, CardRank.Dollars, CardRank.Ampersand, CardRank.Exponent,CardRank.Modulo };
        foreach (CardColor color in Colors)
        {
            foreach (CardRank rank in Ranks)
            {
                Card card = new Card(color, rank);
                Console.WriteLine($"The {card._color} {card._rank}");
            }

        }
    }




    public class Card
    {
        public CardColor _color { get; set; }
        public CardRank _rank { get; set; }
        public Card(CardColor Color, CardRank Rank)
        {
            _color = Color;
            _rank = Rank;
        }
        public static void NumberOrFace(CardRank Rank)
        {
            if ((int)Rank > 10)
            {
                Console.WriteLine($"Card is a Face Card");
            }
            else
                Console.WriteLine($"Card is a Number Card");
        }
    }
    public enum CardColor
    {
        Red,
        Green,
        Blue,
        Yellow
    }
    public enum CardRank
    {
        One = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Dollars = '$',
        Modulo = '%',
        Exponent = '^',
        Ampersand = '&'
    }
}