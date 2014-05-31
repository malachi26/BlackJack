/* Program Written by
 * Novice Programmer
 * Malachi
 * 5/10/2011
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CS1PersonBlackJack
{
    public partial class Form1 : Form
    {
        //Variables

        //Deck of Cards object
        public Card[] Deck = new Card[52];

        public static string strPlayerHand = "you have a total of ";
        public static string strDealerHand = "The Dealer has a Total of ";
        public int intPlayerHand = 0;
        public int intDealerHand = 0;

        //Random Number Function
        public Random random = new Random();

        //my Random Number to pick a card
        public int intCardNum;

        //How Many Decks Variable
        public int intHowMany;

        //Hands until Deck Needs to be shuffled Variable
        public int intCountDown;


        //Methods


        //Shuffle Method
        public void Shuffle()
        {
            //Deck of Cards Created

            //Aces
            Deck[0] = new Card("C:\\Users\\Lyle\\Documents\\Visual Studio 2010\\Projects\\CS1PersonBlackJack\\CS1PersonBlackJack\\Images\\DeckOfCards\\AceOfClubs.jpg", "Ace of Clubs", 11, intHowMany);
            Deck[1] = new Card("C:\\Users\\Lyle\\Documents\\Visual Studio 2010\\Projects\\CS1PersonBlackJack\\CS1PersonBlackJack\\Images\\DeckOfCards\\AceOfDiamonds.jpg", "Ace of Diamonds", 11, intHowMany);
            Deck[2] = new Card("C:\\Users\\Lyle\\Documents\\Visual Studio 2010\\Projects\\CS1PersonBlackJack\\CS1PersonBlackJack\\Images\\DeckOfCards\\AceOfSpades.jpg", "Ace of Spades", 11, intHowMany);
            Deck[3] = new Card("C:\\Users\\Lyle\\Documents\\Visual Studio 2010\\Projects\\CS1PersonBlackJack\\CS1PersonBlackJack\\Images\\DeckOfCards\\AceOfHearts.jpg", "Ace of Hearts", 11, intHowMany);

            //Dueces
            Deck[4] = new Card("C:\\Users\\Lyle\\Documents\\Visual Studio 2010\\Projects\\CS1PersonBlackJack\\CS1PersonBlackJack\\Images\\DeckOfCards\\2OfClubs.jpg", "Two of Clubs", 2, intHowMany);
            Deck[5] = new Card("C:\\Users\\Lyle\\Documents\\Visual Studio 2010\\Projects\\CS1PersonBlackJack\\CS1PersonBlackJack\\Images\\DeckOfCards\\2OfDiamonds.jpg", "Two of Diamonds", 2, intHowMany);
            Deck[6] = new Card("C:\\Users\\Lyle\\Documents\\Visual Studio 2010\\Projects\\CS1PersonBlackJack\\CS1PersonBlackJack\\Images\\DeckOfCards\\2OfSpades.jpg", "Two of Spades", 2, intHowMany);
            Deck[7] = new Card("C:\\Users\\Lyle\\Documents\\Visual Studio 2010\\Projects\\CS1PersonBlackJack\\CS1PersonBlackJack\\Images\\DeckOfCards\\2OfHearts.jpg", "Two of Hearts", 2, intHowMany);

            //threes
            Deck[8] = new Card("C:\\Users\\Lyle\\Documents\\Visual Studio 2010\\Projects\\CS1PersonBlackJack\\CS1PersonBlackJack\\Images\\DeckOfCards\\3OfClubs.jpg", "Three of Hearts", 3, intHowMany);
            Deck[9] = new Card("C:\\Users\\Lyle\\Documents\\Visual Studio 2010\\Projects\\CS1PersonBlackJack\\CS1PersonBlackJack\\Images\\DeckOfCards\\3OfDiamonds.jpg", "Three of Diamonds", 3, intHowMany);
            Deck[10] = new Card("C:\\Users\\Lyle\\Documents\\Visual Studio 2010\\Projects\\CS1PersonBlackJack\\CS1PersonBlackJack\\Images\\DeckOfCards\\3OfSpades.jpg", "Three of Spades", 3, intHowMany);
            Deck[11] = new Card("C:\\Users\\Lyle\\Documents\\Visual Studio 2010\\Projects\\CS1PersonBlackJack\\CS1PersonBlackJack\\Images\\DeckOfCards\\3OfHearts.jpg", "Three of Hearts", 3, intHowMany);

            //Fours
            Deck[12] = new Card("C:\\Users\\Lyle\\Documents\\Visual Studio 2010\\Projects\\CS1PersonBlackJack\\CS1PersonBlackJack\\Images\\DeckOfCards\\4OfClubs.jpg", "Four of Clubs", 4, intHowMany);
            Deck[13] = new Card("C:\\Users\\Lyle\\Documents\\Visual Studio 2010\\Projects\\CS1PersonBlackJack\\CS1PersonBlackJack\\Images\\DeckOfCards\\4OfDiamonds.jpg", "Four of Diamonds", 4, intHowMany);
            Deck[14] = new Card("C:\\Users\\Lyle\\Documents\\Visual Studio 2010\\Projects\\CS1PersonBlackJack\\CS1PersonBlackJack\\Images\\DeckOfCards\\4OfSpades.jpg", "Four of Spades", 4, intHowMany);
            Deck[15] = new Card("C:\\Users\\Lyle\\Documents\\Visual Studio 2010\\Projects\\CS1PersonBlackJack\\CS1PersonBlackJack\\Images\\DeckOfCards\\4OfHearts.jpg", "Four of Hearts", 4, intHowMany);

            //Fives
            Deck[16] = new Card("C:\\Users\\Lyle\\Documents\\Visual Studio 2010\\Projects\\CS1PersonBlackJack\\CS1PersonBlackJack\\Images\\DeckOfCards\\5OfClubs.jpg", "Five of Clubs", 5, intHowMany);
            Deck[17] = new Card("C:\\Users\\Lyle\\Documents\\Visual Studio 2010\\Projects\\CS1PersonBlackJack\\CS1PersonBlackJack\\Images\\DeckOfCards\\5OfDiamonds.jpg", "Five of Diamonds", 5, intHowMany);
            Deck[18] = new Card("C:\\Users\\Lyle\\Documents\\Visual Studio 2010\\Projects\\CS1PersonBlackJack\\CS1PersonBlackJack\\Images\\DeckOfCards\\5OfSpades.jpg", "Five of Spades", 5, intHowMany);
            Deck[19] = new Card("C:\\Users\\Lyle\\Documents\\Visual Studio 2010\\Projects\\CS1PersonBlackJack\\CS1PersonBlackJack\\Images\\DeckOfCards\\5OfHearts.jpg", "Five of Hearts", 5, intHowMany);

            //Sixes
            Deck[20] = new Card("C:\\Users\\Lyle\\Documents\\Visual Studio 2010\\Projects\\CS1PersonBlackJack\\CS1PersonBlackJack\\Images\\DeckOfCards\\6OfClubs.jpg", "Six of Clubs", 6, intHowMany);
            Deck[21] = new Card("C:\\Users\\Lyle\\Documents\\Visual Studio 2010\\Projects\\CS1PersonBlackJack\\CS1PersonBlackJack\\Images\\DeckOfCards\\6OfDiamonds.jpg", "Six of Diamonds", 6, intHowMany);
            Deck[22] = new Card("C:\\Users\\Lyle\\Documents\\Visual Studio 2010\\Projects\\CS1PersonBlackJack\\CS1PersonBlackJack\\Images\\DeckOfCards\\6OfSpades.jpg", "Six of Spades", 6, intHowMany);
            Deck[23] = new Card("C:\\Users\\Lyle\\Documents\\Visual Studio 2010\\Projects\\CS1PersonBlackJack\\CS1PersonBlackJack\\Images\\DeckOfCards\\6OfHearts.jpg", "Six of Hearts", 6, intHowMany);

            //Sevens
            Deck[24] = new Card("C:\\Users\\Lyle\\Documents\\Visual Studio 2010\\Projects\\CS1PersonBlackJack\\CS1PersonBlackJack\\Images\\DeckOfCards\\7OfClubs.jpg", "Seven of Clubs", 7, intHowMany);
            Deck[25] = new Card("C:\\Users\\Lyle\\Documents\\Visual Studio 2010\\Projects\\CS1PersonBlackJack\\CS1PersonBlackJack\\Images\\DeckOfCards\\7OfDiamonds.jpg", "Seven of Diamonds", 7, intHowMany);
            Deck[26] = new Card("C:\\Users\\Lyle\\Documents\\Visual Studio 2010\\Projects\\CS1PersonBlackJack\\CS1PersonBlackJack\\Images\\DeckOfCards\\7OfSpades.jpg", "Seven of Spades", 7, intHowMany);
            Deck[27] = new Card("C:\\Users\\Lyle\\Documents\\Visual Studio 2010\\Projects\\CS1PersonBlackJack\\CS1PersonBlackJack\\Images\\DeckOfCards\\7OfHearts.jpg", "Seven of Hearts", 7, intHowMany);

            //Eights
            Deck[28] = new Card("C:\\Users\\Lyle\\Documents\\Visual Studio 2010\\Projects\\CS1PersonBlackJack\\CS1PersonBlackJack\\Images\\DeckOfCards\\8OfClubs.jpg", "Eight of Clubs", 8, intHowMany);
            Deck[29] = new Card("C:\\Users\\Lyle\\Documents\\Visual Studio 2010\\Projects\\CS1PersonBlackJack\\CS1PersonBlackJack\\Images\\DeckOfCards\\8OfDiamonds.jpg", "Eight of Diamonds", 8, intHowMany);
            Deck[30] = new Card("C:\\Users\\Lyle\\Documents\\Visual Studio 2010\\Projects\\CS1PersonBlackJack\\CS1PersonBlackJack\\Images\\DeckOfCards\\8OfSpades.jpg", "Eight of Spades", 8, intHowMany);
            Deck[31] = new Card("C:\\Users\\Lyle\\Documents\\Visual Studio 2010\\Projects\\CS1PersonBlackJack\\CS1PersonBlackJack\\Images\\DeckOfCards\\8OfHearts.jpg", "Eight of Hearts", 8, intHowMany);

            //Nines
            Deck[32] = new Card("C:\\Users\\Lyle\\Documents\\Visual Studio 2010\\Projects\\CS1PersonBlackJack\\CS1PersonBlackJack\\Images\\DeckOfCards\\9OfClubs.jpg", "Nine of Clubs", 9, intHowMany);
            Deck[33] = new Card("C:\\Users\\Lyle\\Documents\\Visual Studio 2010\\Projects\\CS1PersonBlackJack\\CS1PersonBlackJack\\Images\\DeckOfCards\\9OfDiamonds.jpg", "Nine of Diamonds", 9, intHowMany);
            Deck[34] = new Card("C:\\Users\\Lyle\\Documents\\Visual Studio 2010\\Projects\\CS1PersonBlackJack\\CS1PersonBlackJack\\Images\\DeckOfCards\\9OfSpades.jpg", "Nine of Spades", 9, intHowMany);
            Deck[35] = new Card("C:\\Users\\Lyle\\Documents\\Visual Studio 2010\\Projects\\CS1PersonBlackJack\\CS1PersonBlackJack\\Images\\DeckOfCards\\9OfHearts.jpg", "Nine of Hearts", 9, intHowMany);

            //Tens
            Deck[36] = new Card("C:\\Users\\Lyle\\Documents\\Visual Studio 2010\\Projects\\CS1PersonBlackJack\\CS1PersonBlackJack\\Images\\DeckOfCards\\TenOfClubs.jpg", "Ten of Clubs", 10, intHowMany);
            Deck[37] = new Card("C:\\Users\\Lyle\\Documents\\Visual Studio 2010\\Projects\\CS1PersonBlackJack\\CS1PersonBlackJack\\Images\\DeckOfCards\\TenOfDiamonds.jpg", "Ten of Diamonds", 10, intHowMany);
            Deck[38] = new Card("C:\\Users\\Lyle\\Documents\\Visual Studio 2010\\Projects\\CS1PersonBlackJack\\CS1PersonBlackJack\\Images\\DeckOfCards\\TenOfSpades.jpg", "Ten of Spades", 10, intHowMany);
            Deck[39] = new Card("C:\\Users\\Lyle\\Documents\\Visual Studio 2010\\Projects\\CS1PersonBlackJack\\CS1PersonBlackJack\\Images\\DeckOfCards\\TenOfHearts.jpg", "Ten of Hearts", 10, intHowMany);

            //Jacks
            Deck[40] = new Card("C:\\Users\\Lyle\\Documents\\Visual Studio 2010\\Projects\\CS1PersonBlackJack\\CS1PersonBlackJack\\Images\\DeckOfCards\\JackOfClubs.jpg", "Jack of Clubs", 10, intHowMany);
            Deck[41] = new Card("C:\\Users\\Lyle\\Documents\\Visual Studio 2010\\Projects\\CS1PersonBlackJack\\CS1PersonBlackJack\\Images\\DeckOfCards\\JackOfDiamonds.jpg", "Jack of Diamonds", 10, intHowMany);
            Deck[42] = new Card("C:\\Users\\Lyle\\Documents\\Visual Studio 2010\\Projects\\CS1PersonBlackJack\\CS1PersonBlackJack\\Images\\DeckOfCards\\JackOfSpades.jpg", "Jack of Spades", 10, intHowMany);
            Deck[43] = new Card("C:\\Users\\Lyle\\Documents\\Visual Studio 2010\\Projects\\CS1PersonBlackJack\\CS1PersonBlackJack\\Images\\DeckOfCards\\JackOfHearts.jpg", "Jack of Hearts", 10, intHowMany);

            //Queens
            Deck[44] = new Card("C:\\Users\\Lyle\\Documents\\Visual Studio 2010\\Projects\\CS1PersonBlackJack\\CS1PersonBlackJack\\Images\\DeckOfCards\\QueenOfClubs.jpg", "Queen of Clubs", 10, intHowMany);
            Deck[45] = new Card("C:\\Users\\Lyle\\Documents\\Visual Studio 2010\\Projects\\CS1PersonBlackJack\\CS1PersonBlackJack\\Images\\DeckOfCards\\QueenOfDiamonds.jpg", "Queen of Diamonds", 10, intHowMany);
            Deck[46] = new Card("C:\\Users\\Lyle\\Documents\\Visual Studio 2010\\Projects\\CS1PersonBlackJack\\CS1PersonBlackJack\\Images\\DeckOfCards\\QueenOfSpades.jpg", "Queen of Spades", 10, intHowMany);
            Deck[47] = new Card("C:\\Users\\Lyle\\Documents\\Visual Studio 2010\\Projects\\CS1PersonBlackJack\\CS1PersonBlackJack\\Images\\DeckOfCards\\QueenOfHearts.jpg", "QUeen of Hearts", 10, intHowMany);

            //Kings
            Deck[48] = new Card("C:\\Users\\Lyle\\Documents\\Visual Studio 2010\\Projects\\CS1PersonBlackJack\\CS1PersonBlackJack\\Images\\DeckOfCards\\KingOfClubs.jpg", "King of Clubs", 10, intHowMany);
            Deck[49] = new Card("C:\\Users\\Lyle\\Documents\\Visual Studio 2010\\Projects\\CS1PersonBlackJack\\CS1PersonBlackJack\\Images\\DeckOfCards\\KingOfDiamonds.jpg", "King of Diamonds", 10, intHowMany);
            Deck[50] = new Card("C:\\Users\\Lyle\\Documents\\Visual Studio 2010\\Projects\\CS1PersonBlackJack\\CS1PersonBlackJack\\Images\\DeckOfCards\\KingOfSpades.jpg", "King of Spades", 10, intHowMany);
            Deck[51] = new Card("C:\\Users\\Lyle\\Documents\\Visual Studio 2010\\Projects\\CS1PersonBlackJack\\CS1PersonBlackJack\\Images\\DeckOfCards\\KingOfHearts.jpg", "King of Hearts", 10, intHowMany);
        }

        ////BlackJack Methods

        //Bust Method
        public bool isBust()
        {
            bool isBust;
            if (intPlayerHand > 21)
            {

                isBust = true;
                MessageBox.Show("I am sorry but you went over 21", "BUSTED!", MessageBoxButtons.OK);
                btnNewHand.Visible = true;
                btnHit.Visible = false;
                btnStand.Visible = false;
                return isBust;
            }
            else
            {
                return isBust = false;
            }
        }

        //Card Image Method
        public void stretch()
        {
            //set all the Picture Boxes to stretch so that the pictures show up right.
            picPlay1a.SizeMode = PictureBoxSizeMode.StretchImage;
            picPlay1b.SizeMode = PictureBoxSizeMode.StretchImage;
            picPlay1c.SizeMode = PictureBoxSizeMode.StretchImage;
            picPlay1d.SizeMode = PictureBoxSizeMode.StretchImage;
            picDeal1.SizeMode = PictureBoxSizeMode.StretchImage;
            picDeal2.SizeMode = PictureBoxSizeMode.StretchImage;
            picDeal3.SizeMode = PictureBoxSizeMode.StretchImage;
            picDeal4.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        //New Hand Method
        public void NewHand()
        {
            //Reset Player's hand
            picPlay1a.ImageLocation = "";
            picPlay1b.ImageLocation = "";
            picPlay1b.Visible = false;
            picPlay1c.ImageLocation = "";
            picPlay1c.Visible = false;
            picPlay1d.ImageLocation = "";
            picPlay1d.Visible = false;
            intPlayerHand = 0;

            //Reset Dealer's Hand
            picDeal1.ImageLocation = "";
            picDeal2.ImageLocation = "";
            picDeal2.Visible = false;
            picDeal3.ImageLocation = "";
            picDeal3.Visible = false;
            picDeal4.ImageLocation = "";
            picDeal4.Visible = false;
            intDealerHand = 0;
        }
        //Reset Hands
        public void Reset()
        {
            picDeal1.ImageLocation = "";
            picDeal2.ImageLocation = "";
            picDeal3.ImageLocation = "";
            picDeal4.ImageLocation = "";
            picDeal2.Visible = false;
            picDeal3.Visible = false;
            picDeal4.Visible = false;

            picPlay1b.ImageLocation = "";
            picPlay1a.ImageLocation = "";
            picPlay1c.ImageLocation = "";
            picPlay1d.ImageLocation = "";
            picPlay1c.Visible = false;
            picPlay1d.Visible = false;
        }

        //Dealer Play
        public void DealerPlay()
        {
            while (intDealerHand < 17)
            {
                if (picDeal3.Visible == false)
                {
                    intCardNum = NewCard();
                    picDeal2.Visible = true;
                    picDeal3.ImageLocation = Deck[intCardNum].CardLocation;
                    picDeal3.BringToFront();
                    intDealerHand += Deck[intCardNum].intValue;
                    picDeal3.Visible = true;
                    DealAce(ref intDealerHand);
                }
                else if (picDeal3.Visible == true)
                {
                    intCardNum = NewCard();
                    picDeal4.ImageLocation = Deck[intCardNum].CardLocation;
                    intDealerHand += Deck[intCardNum].intValue;
                    picDeal4.Visible = true;
                    picDeal4.BringToFront();
                    DealAce(ref intDealerHand);
                }
            }

            //Determine the Victor
            if (intDealerHand > 21)
            {
                //Dealer loses the Hand if he has more than 21.
                MessageBox.Show("Dealer has Busted, this Means that you win" + "\n" + strDealerHand + intDealerHand.ToString() + "\n" +
                    strPlayerHand + intPlayerHand.ToString(), "Dealer Busted", MessageBoxButtons.OK);
                btnNewHand.Visible = true;
                txtBank.Text = ((Convert.ToInt32(txtBet.Text) * 2) + (Convert.ToInt32(txtBank.Text))).ToString();
            }
            else
            {
                WhoWon();
            }
        }

        //Check to see who won the Hand
        public void WhoWon()
        {
            if (intDealerHand > intPlayerHand && intDealerHand < 22)
            {
                MessageBox.Show("I am sorry.  you Lost!" + "\n" + strDealerHand + intDealerHand.ToString() + "\n" +
                    strPlayerHand + intPlayerHand.ToString(), "Dealer Won", MessageBoxButtons.OK);
            }
            else if (intDealerHand == intPlayerHand)
            {
                MessageBox.Show("You Tied with the Dealer, NoBody Won" + "\n" + strDealerHand + intDealerHand.ToString() + "\n" +
                    strPlayerHand + intPlayerHand.ToString(), "Push", MessageBoxButtons.OK);
                txtBank.Text = (Convert.ToInt32(txtBet.Text) + Convert.ToInt32(txtBank.Text)).ToString();
            }
            else
            {
                MessageBox.Show("You Beat the Dealer!!  Good For you!!" + "\n" + strDealerHand + intDealerHand.ToString() + "\n" +
                    strPlayerHand + intPlayerHand.ToString(), "You Win!", MessageBoxButtons.OK);
                txtBank.Text = ((Convert.ToInt32(txtBet.Text) * 2) + (Convert.ToInt32(txtBank.Text))).ToString();
            }

            btnNewHand.Visible = true;
        }

        //Method for Retrieving a new card if it is available.
        public int NewCard()
        {
            intCardNum = random.Next(0, 52);
            bool isAvailable = false;

            while (isAvailable == false)
            {
                if (Deck[intCardNum].intNumAvail < 1)
                {
                    isAvailable = false;
                    intCardNum = random.Next(0, 52);
                }
                else
                {
                    isAvailable = true;
                }
            }

            return intCardNum;
        }

        //Method for Double ACES
        public void PlayDoubleAceCheck(ref int Count)
        {
            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (picPlay1a.ImageLocation == Deck[i].CardLocation && picPlay1b.ImageLocation == Deck[j].CardLocation)
                    {
                        Count -= 10;
                    }
                }
            }
        }

        //Same Method for Double Aces for the Dealer
        public void DealDoubleAceCheck(ref int Count)
        {
            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (picDeal1.ImageLocation == Deck[i].CardLocation && picDeal2.ImageLocation == Deck[j].CardLocation)
                    {
                        Count -= 10;
                    }
                }
            }
        }

        //  Game InterFace
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            //call my picture stretching method
            stretch();

        }

        private void btnSetDecks_Click(object sender, EventArgs e)
        {
            btnSetDecks.Visible = false;
            lblHowManyDecks.Visible = false;
            txtHowManyDecks.Visible = false;

            try
            {
                intHowMany = Convert.ToInt32(txtHowManyDecks.Text);
                intCountDown = intHowMany * 6;
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message +
                    "/n Deck Count Should Be A Number", "Non-Number Error", MessageBoxButtons.OK);
                txtHowManyDecks.Focus();
                return;
            }
            btnDeal.Visible = true;

            //Create the Deck and/or Shuffle
            Shuffle();

        }

        private void txtHowManyDecks_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDeal_Click(object sender, EventArgs e)
        {
            if (intCountDown == 0)
            {
                btnSetDecks.Visible = true;
                txtHowManyDecks.Visible = true;
                lblHowManyDecks.Visible = true;
                btnDeal.Visible = false;
                return;
            }
            intCountDown -= 1;

            //Betting
            txtBet.ReadOnly = false;
            txtBank.Text = (Convert.ToInt32(txtBank.Text) - Convert.ToInt32(txtBet.Text)).ToString();

            intCardNum = NewCard();

            //show Hit & Stand Buttons
            btnHit.Visible = true;
            btnStand.Visible = true;

            //Reset the Table
            Reset();

            //player's first card

            picPlay1a.ImageLocation = Deck[intCardNum].CardLocation;

            //Every time the Deal button is hit it automatically resets the player and dealer Count
            intPlayerHand = Deck[intCardNum].intValue;
            lblPlayerHand.Text = strPlayerHand + intPlayerHand.ToString();
            lblPlayerHand.Visible = true;

            //Dealers first Card
            intCardNum = NewCard();
            picDeal1.ImageLocation = Deck[intCardNum].CardLocation;
            intDealerHand = Deck[intCardNum].intValue;
            lblDealerHand.Text = strDealerHand + intDealerHand.ToString();
            lblDealerHand.Visible = true;

            //player's second Card
            picPlay1b.Visible = true;
            intCardNum = NewCard();
            picPlay1b.ImageLocation = Deck[intCardNum].CardLocation;
            intPlayerHand += Deck[intCardNum].intValue;
            PlayDoubleAceCheck(ref intPlayerHand);
            lblPlayerHand.Text = strPlayerHand + intPlayerHand.ToString();

            //Dealer's Second Card not Shown yet
            picDeal2.Visible = false;
            intCardNum = NewCard();
            picDeal2.ImageLocation = Deck[intCardNum].CardLocation;
            intDealerHand += Deck[intCardNum].intValue;
            DealDoubleAceCheck(ref intDealerHand);

            if (intPlayerHand == 21 && intDealerHand == 21)
            {
                //Display a push Message
                MessageBox.Show("You and the Dealer have a Black Jack, No one wins.", "Push", MessageBoxButtons.OK);
                picDeal2.Visible = true;

                //Hide the Hit and Stand Buttons
                btnHit.Visible = false;
                btnStand.Visible = false;

                //Display the NewHand Button
                btnNewHand.Visible = true;

                //Return the players bet
                txtBank.Text = (Convert.ToInt32(txtBet.Text) + Convert.ToInt32(txtBank.Text)).ToString();
            }
            else if (intPlayerHand == 21)
            {
                //Display A Winning Message
                MessageBox.Show("Black Jack BaBY!!", "You Win!", MessageBoxButtons.OK);
                picDeal2.Visible = true;

                //Hide the Deal and Stand Buttons
                btnHit.Visible = false;
                btnStand.Visible = false;

                //Display the NewHand Button
                btnNewHand.Visible = true;

                //Give Player 1.5 + his bet for winning
                txtBank.Text = ((Convert.ToInt32(txtBet.Text) * 2.5) + (Convert.ToInt32(txtBank.Text))).ToString();
            }
            else if (intDealerHand == 21)
            {
                //Display a Dealer BlackJack
                picDeal2.Visible = true;
                MessageBox.Show("Dealer has a BlackJack, sorry you lose", "You Lose", MessageBoxButtons.OK);

                //Hide the Deal and Stand Buttons
                btnHit.Visible = false;
                btnStand.Visible = false;

                //Display the NewHand Button
                btnNewHand.Visible = true;
            }

            btnDeal.Visible = false;

        }

        private void btnHit_Click(object sender, EventArgs e)
        {

            if (picPlay1c.Visible == false)
            {
                intCardNum = NewCard();
                picPlay1c.ImageLocation = Deck[intCardNum].CardLocation;
                picPlay1c.BringToFront();
                intPlayerHand += Deck[intCardNum].intValue;
                picPlay1c.Visible = true;
                PlayerAce(ref intPlayerHand);
                lblPlayerHand.Text = strPlayerHand + intPlayerHand.ToString();
                isBust();
                return;
            }
            else if (picPlay1c.Visible == true)
            {
                intCardNum = NewCard();
                picPlay1d.ImageLocation = Deck[intCardNum].CardLocation;
                picPlay1d.BringToFront();
                intPlayerHand += Deck[intCardNum].intValue;
                picPlay1d.Visible = true;
                PlayerAce(ref intPlayerHand);
                lblPlayerHand.Text = strPlayerHand + intPlayerHand.ToString();
                isBust();
                btnDeal.Visible = false;
                btnHit.Visible = false;
            }
        }

        private void btnStand_Click(object sender, EventArgs e)
        {
            btnStand.Visible = false;
            picDeal2.Visible = true;
            btnHit.Visible = false;
            DealerPlay();
        }

        private void btnNewHand_Click(object sender, EventArgs e)
        {
            //txtHowManyDecks.Visible = true;
            //lblHowManyDecks.Visible = true;
            //btnSetDecks.Visible = true;
            btnNewHand.Visible = false;
            btnDeal.Visible = true;
            NewHand();
        }

        //If Dealers Hand is Greater than 21 check for an Ace and Change it accordingly
        public void DealAce(ref int Count)
        {
            if (Count > 21)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (picDeal1.ImageLocation == Deck[i].CardLocation)
                    {
                        Count -= 10;
                        return;
                    }
                    else if (picDeal2.ImageLocation == Deck[i].CardLocation)
                    {
                        Count -= 10;
                        return;
                    }
                    else if (picDeal3.ImageLocation == Deck[i].CardLocation)
                    {
                        Count -= 10;
                        return;
                    }
                    else if (picDeal4.ImageLocation == Deck[i].CardLocation)
                    {
                        Count -= 10;
                        return;
                    }
                }
            }

        }

        //Player Check for Ace over 21
        public void PlayerAce(ref int Count)
        {
            if (Count > 21)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (picPlay1d.Visible == false)
                    {
                        if (picPlay1a.ImageLocation == Deck[i].CardLocation)
                        {
                            Count -= 10;
                            return;
                        }
                        else if (picPlay1b.ImageLocation == Deck[i].CardLocation)
                        {
                            Count -= 10;
                            return;
                        }
                        else if (picPlay1c.ImageLocation == Deck[i].CardLocation)
                        {
                            Count -= 10;
                            return;
                        }
                    }
                    else if (picPlay1d.Visible == true)
                    {
                        if (picPlay1d.ImageLocation == Deck[i].CardLocation)
                        {
                            Count -= 10;
                            return;
                        }
                    }
                }
            }
        }
    }
}
