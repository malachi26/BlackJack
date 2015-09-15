using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace CS1PersonBlackJack
{
    public class Card : IEquatable<Card>
    {
        public string Name;
        protected string CardImageString;
        protected Image CardImage;

        public override bool Equals(object obj)
        {
            return base.Equals((Card)obj);
        }
        public bool Equals(Card obj)
        {
            return this.Name == obj.Name;
        }

        public override int GetHashCode()
        {
            int result = 13;
            unchecked //let overflow wrap the Int32, doesn't matter
            {
                result = result * 7 + this.Name.GetHashCode();
                result = result * 7 + this.CardImage.GetHashCode();
            }
            return result;
        }

        public Card (string name, string imageString)
        {

        }

    }
    public class BlackJackCard : Card
    {
        //Number of Cards available
        public int Value;
        public BlackJackCard (int value, string name, string imageString)
        {
            this.Value = value;
            this.Name = name;
            this.CardImageString = imageString;
        }
        public BlackJackCard(int value, string name, Image cardImage)
        {
            this.Value = value;
            this.Name = name;
            this.CardImage = cardImage;
        }


        //private int _intNumAvail;
        //public int intNumAvail
        //{
        //    get
        //    {
        //        return _intNumAvail;
        //    }
        //    set
        //    {
        //        _intNumAvail = value;
        //    }
        //}
        ////value of the Card
        //private int _intValue;
        //public int intValue
        //{
        //    get
        //    {
        //        return _intValue;
        //    }
        //    set
        //    {
        //        _intValue = value;
        //    }
        //}
        ////name of the card
        //private string _strCardName;
        //public string strCardName
        //{
        //    get
        //    {
        //        return _strCardName;
        //    }
        //    set
        //    {
        //        _strCardName = value;
        //    }
        //}
        ////this will be the variable that holds the location
        ////of the Card Picture
        //private string _CardLocation;
        //public string CardLocation
        //{
        //    get
        //    {
        //        return _CardLocation;
        //    }
        //    set
        //    {
        //        _CardLocation = value;
        //    }
        //}
        ////Card Constructor
        //public Card(string strCardLocation, string strCard, int intCardVal, int intDecks)
        //{
        //    CardLocation = strCardLocation;
        //    strCardName = strCard;
        //    intValue = intCardVal;
        //    intNumAvail = intDecks;
        //}
    }

    public class Deck
    {
        public int CardsLeft;
        private string _DeckImageFolder;
        protected List<Card> DeckOfCards;
    }

    public class Shoe
    {

    }


    //TODO:  not sure if I need this Class yet

    public class PlayerHand
    {
        private object _objFirstCard;
        public object objFirstCard
        {
            get
            {
                return _objFirstCard;
            }
            set
            {
                _objFirstCard = value;
            }
        }
        private object _objSecondCard;
        public object objSecondCard
        {
            get
            {
                return _objSecondCard;
            }
            set
            {
                _objSecondCard = value;
            }
        }
    }
}
