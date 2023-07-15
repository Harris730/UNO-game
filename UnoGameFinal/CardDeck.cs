using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnoGameFinal
{
    internal class CardDeck
    {
        public Card[] DeckOfCards = new Card[108];
        public CardDeck()
        {
            int Count = 0;

            foreach (CardColor color in Enum.GetValues(typeof(CardColor)))
            {

                if (color != CardColor.Neutral)
                {
                    foreach (CardType cardType in Enum.GetValues(typeof(CardType)))
                    {
                        if (cardType == CardType.One || cardType == CardType.Two || cardType == CardType.Three || cardType == CardType.Four || cardType == CardType.Five || cardType == CardType.Six || cardType == CardType.Seven || cardType == CardType.Eight || cardType == CardType.Nine)
                        {
                            DeckOfCards[Count] = new Card();
                            DeckOfCards[Count].C_Color = color;
                            DeckOfCards[Count].C_Type = cardType;
                            DeckOfCards[Count].Special = "No";
                            DeckOfCards[Count].ImagePath = @"F:\Mohammad\BUI 6\VP\UNO\Cards\" + color.ToString() + @"\" + cardType.ToString() + @".png";

                            Count++;

                            DeckOfCards[Count] = new Card();

                            DeckOfCards[Count].C_Color = color;
                            DeckOfCards[Count].C_Type = cardType;
                            DeckOfCards[Count].Special = "No";
                            DeckOfCards[Count].ImagePath = @"F:\Mohammad\BUI 6\VP\UNO\Cards\" + color.ToString() + @"\" + cardType.ToString() + @".png";

                            Count++;
                            DeckOfCards[Count] = new Card();

                        }
                        else if (cardType == CardType.Skip || cardType == CardType.Reverse || cardType == CardType.DrawTwo)
                        {
                            DeckOfCards[Count] = new Card();

                            DeckOfCards[Count].C_Color = color;
                            DeckOfCards[Count].C_Type = cardType;
                            DeckOfCards[Count].Special = "Yes";
                            DeckOfCards[Count].ImagePath = @"F:\Mohammad\BUI 6\VP\UNO\Cards\" + color.ToString() + @"\" + cardType.ToString() + @".png";

                            Count++;

                            DeckOfCards[Count] = new Card();

                            DeckOfCards[Count].C_Color = color;
                            DeckOfCards[Count].C_Type = cardType;
                            DeckOfCards[Count].Special = "Yes";
                            DeckOfCards[Count].ImagePath = @"F:\Mohammad\BUI 6\VP\UNO\Cards\" + color.ToString() + @"\" + cardType.ToString() + @".png";

                            Count++;
                            DeckOfCards[Count] = new Card();

                        }
                        else if (cardType == CardType.Zero)
                        {
                            DeckOfCards[Count] = new Card();

                            DeckOfCards[Count].C_Color = color;
                            DeckOfCards[Count].C_Color = color;
                            DeckOfCards[Count].C_Type = cardType;
                            DeckOfCards[Count].Special = "No";
                            DeckOfCards[Count].ImagePath = @"F:\Mohammad\BUI 6\VP\UNO\Cards\" + color.ToString() + @"\" + cardType.ToString() + @".png";

                            Count++;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < 4; i++)
                    {
                        DeckOfCards[Count] = new Card();

                        DeckOfCards[Count].C_Color = color;
                        DeckOfCards[Count].C_Type = CardType.DrawFour;
                        DeckOfCards[Count].Special = "Yes";
                        DeckOfCards[Count].ImagePath = @"F:\Mohammad\BUI 6\VP\UNO\Cards\Neutral\DrawFour.png";

                        Count++;
                    }
                    for (int i = 0; i < 4; i++)
                    {
                        DeckOfCards[Count] = new Card();

                        DeckOfCards[Count].C_Color = color;
                        DeckOfCards[Count].C_Type = CardType.Wild;
                        DeckOfCards[Count].Special = "Yes";
                        DeckOfCards[Count].ImagePath = @"F:\Mohammad\BUI 6\VP\UNO\Cards\Neutral\Wild.png";

                        Count++;
                    }
                }
            }
        }

        public CardDeck(string Discard)
        {
            DeckOfCards = new Card[1];
            DeckOfCards[0] = new Card();
            DeckOfCards[0].Special = "Nothing";
        }

        public void AddCardToDeck(CardColor color, CardType cardType)
        {
            if (DeckOfCards[0].Special == "Nothing")
            {
                DeckOfCards[0].C_Color = color;
                DeckOfCards[0].C_Type = cardType;
                DeckOfCards[0].ImagePath = @"F:\Mohammad\BUI 6\VP\UNO\Cards\" + color.ToString() + @"\" + cardType.ToString() + @".png";
                if (cardType == CardType.Reverse || cardType == CardType.DrawTwo || cardType == CardType.DrawFour || cardType == CardType.Skip || cardType == CardType.Wild)
                    DeckOfCards[0].Special = "Yes";
                else
                    DeckOfCards[0].Special = "No";
            }
            else
            {
                Card[] Pile = new Card[DeckOfCards.Length + 1];
                for (int i = 0; i < DeckOfCards.Length; i++)
                {
                    Pile[i] = new Card();
                    Pile[i].C_Color = DeckOfCards[i].C_Color;
                    Pile[i].C_Type = DeckOfCards[i].C_Type;
                    Pile[i].Special = DeckOfCards[i].Special;
                    Pile[i].ImagePath = DeckOfCards[i].ImagePath;
                }
                Pile[DeckOfCards.Length] = new Card();
                Pile[DeckOfCards.Length].C_Color = color;
                Pile[DeckOfCards.Length].C_Type = cardType;
                if (cardType == CardType.Reverse || cardType == CardType.DrawTwo || cardType == CardType.DrawFour || cardType == CardType.Skip || cardType == CardType.Wild)
                   Pile[DeckOfCards.Length].Special = "Yes";
                else
                    Pile[DeckOfCards.Length].Special = "No";

                Pile[DeckOfCards.Length].ImagePath = @"F:\Mohammad\BUI 6\VP\UNO\Cards\" + color.ToString() + @"\" + cardType.ToString() + @".png";

                DeckOfCards = Pile;
            }
        }

        public void DiscardToDeck(CardDeck CD)
        {
            CardDeck newDiscard = new CardDeck("Discard");
            for(int i = 0;i< DeckOfCards.Length; i++)
            {
                newDiscard.DeckOfCards = this.DrawCards(this.DeckOfCards.Length);
            }
            for(int i =0;i<newDiscard.DeckOfCards.Length;i++)
            {
                CD.AddCardToDeck(newDiscard.DeckOfCards[i].C_Color, newDiscard.DeckOfCards[i].C_Type);
            }
        }

        public void ShuffleDeck()
        {
            Random random = new Random();

            for (int i = DeckOfCards.Length - 1; i > 0; i--)
            {
                int k = random.Next(i + 1);
                Card Temp = DeckOfCards[i];
                DeckOfCards[i] = DeckOfCards[k];
                DeckOfCards[k] = Temp;
            }
        }

        public Card[] DrawCards(int Count)
        {
            int length1 = DeckOfCards.Length - 1;
            Card[] NewPlayerHand = new Card[Count];

            for (int i = 0; i < Count; i++, length1--)
            {
                NewPlayerHand[i] = DeckOfCards[length1];
            }

            Card[] NewDeck = new Card[DeckOfCards.Length - Count];
            for (int i = 0; i < DeckOfCards.Length - Count; i++)
            {
                NewDeck[i] = new Card();

                NewDeck[i] = DeckOfCards[i];
            }

            DeckOfCards = NewDeck;

            return NewPlayerHand;
        }

    }
}
