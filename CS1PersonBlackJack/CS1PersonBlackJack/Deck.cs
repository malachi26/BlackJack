using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS1PersonBlackJack
{

    public class Card
    {
        //Number of Cards available
        private int _intNumAvail;
        public int intNumAvail
        {
            get
            {
                return _intNumAvail;
            }
            set
            {
                _intNumAvail = value;
            }
        }
        //value of the Card
        private int _intValue;
        public int intValue
        {
            get
            {
                return _intValue;
            }
            set
            {
                _intValue = value;
            }
        }
        //name of the card
        private string _strCardName;
        public string strCardName
        {
            get
            {
                return _strCardName;
            }
            set
            {
                _strCardName = value;
            }
        }
        //this will be the variable that holds the location
        //of the Card Picture
        private string _CardLocation;
        public string CardLocation
        {
            get
            {
                return _CardLocation;
            }
            set
            {
                _CardLocation = value;
            }
        }
        //Card Constructor
        public Card(string strCardLocation, string strCard, int intCardVal, int intDecks)
        {
            CardLocation = strCardLocation;
            strCardName = strCard;
            intValue = intCardVal;
            intNumAvail = intDecks;
        }
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
