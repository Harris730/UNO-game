using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnoGameFinal
{
    public enum CardColor
    {
        Red,
        Green,
        Blue,
        Yellow,
        Neutral
    }

    public enum CardType
    {
        Zero,
        One,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Reverse,
        Skip,
        DrawTwo,
        DrawFour,
        Wild
    }
    internal class Card
    {
        public CardType C_Type { get; set; }
        public CardColor C_Color { get; set; }

        public string Special { get; set; }
        public string ImagePath { get; set; }

    }
}
