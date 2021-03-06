using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlackJack.Models
{
    public enum CardSuit
    {
        Hearts,
        Clubs,
        Diamonds,
        Spades
    }
    public enum CardValue
    {
        Ace = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13
    }
    public class Card
    {
        public CardSuit Suit { get; set; }
        public CardValue Value { get; set; }
        public bool IsVisible { get; set; } = true;

        public bool IsTenCard
        {
            get
            {
                return Value == CardValue.Ten
                    || Value==CardValue.Jack
                    || Value==CardValue.Queen
                    || Value==CardValue.King;
            }
        }

        public string ImageName { get; set; }


        public int Score
        {
            get
            {
                if(Value==CardValue.King 
                    || Value==CardValue.Queen 
                    || Value==CardValue.Jack)
                {
                    return 10;
                }
                if(Value==CardValue.Ace)
                { 
                    return 11;
                }
                else
                {
                    return (int)Value;
                }
            }
        }
    }

    public class CardDeck
    {
        protected Stack<Card> Cards { get; set; } = new Stack<Card>();

        public CardDeck()
        {
            for(int i=0;i<4;i++)
            {
                for (int j=1;j<14;j++)
                {
                    var myCard = new Card { Suit = (CardSuit)i, Value = (CardValue)j };
                    Add(myCard);
                }
            }
        }

        public void Shuffle()
        {
            
        }
        public int Count
        {
            get
            {
                return Cards.Count;
            }
        }
        public Card Draw()
        {
            return Cards.Pop();
        }
        public void Add(Card card)
        {
            Cards.Push(card);
        }

        
    }

}
