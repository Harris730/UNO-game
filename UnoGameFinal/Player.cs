using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnoGameFinal
{
    internal class Player
    {
        public Card[] PlayerHand = new Card[7];
        public string PlayerName;
        public string PlayerType;
        public Player()
        {

        }
        public Player(CardDeck cd)
        {
            PlayerHand = cd.DrawCards(7);
        }

        public Player(int i, CardDeck cd)
        {
            PlayerHand = cd.DrawCards(i);
        }

        public void AddCards(int Count, CardDeck cd)
        {
            int count2 = 0;

            Player p = new Player();
            p.PlayerHand = new Card[PlayerHand.Length + Count];
            Card[] cards = new Card[Count];
            cards = cd.DrawCards(Count);

            for (int i = 0; i < PlayerHand.Length; i++)
            {
                p.PlayerHand[i] = PlayerHand[i];
            }

            for (int i = PlayerHand.Length; i < PlayerHand.Length + Count; i++, count2++)
            {
                p.PlayerHand[i] = cards[count2];
            }
            this.PlayerHand = p.PlayerHand;
        }

        public void AddCard(Card C)
        {

            Player p = new Player();
            p.PlayerHand = new Card[PlayerHand.Length + 1];
            p.PlayerHand[PlayerHand.Length - 1] = new Card();
            p.PlayerHand[PlayerHand.Length - 1] = C;

            PlayerHand = p.PlayerHand;
        }

        public void RemoveCard(CardColor cc, CardType ct)
        {
            int index =0;
            
            for (int i = 0; i < PlayerHand.Length; i++)
            {
                if (PlayerHand[i].C_Color == cc && PlayerHand[i].C_Type == ct)
                {
                    index = i;
                    break;
                }
            }

            for(int i = index;i < PlayerHand.Length -1; i++)
            {
                PlayerHand[i] = PlayerHand[i + 1];
            }

            Array.Resize(ref PlayerHand, PlayerHand.Length-1);
        }
    }
}
