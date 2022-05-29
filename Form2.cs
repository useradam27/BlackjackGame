using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
{
    /// <summary>
    /// Form class for table and game logic
    /// </summary>
    public partial class Table_Form : Form
    {
        /// <summary>
        /// number of decks to use
        /// </summary>
        private int numDecks;

        /// <summary>
        /// seed number to pass to shoe for random object
        /// </summary>
        private int seed;

        /// <summary>
        /// simple int to keep track of mode (s17/h17)
        /// </summary>
        private int mode;

        /// <summary>
        /// aShoe object for shoe to use
        /// </summary>
        private aShoe currentShoe;

        /// <summary>
        /// count for how many cards dearler has
        /// </summary>
        private int dealerCards;

        /// <summary>
        /// count for how many cards player has
        /// </summary>
        private int playerCards;

        /// <summary>
        /// array for all dealer cards
        /// </summary>
        private aCard[] dCards;

        /// <summary>
        /// array for all player cards
        /// </summary>
        private aCard[] pCards;

        /// <summary>
        /// value for bet amount
        /// </summary>
        private double bet;

        /// <summary>
        /// value for total money
        /// </summary>
        private double money;

        /// <summary>
        /// bool value to keep track of when a game is over
        /// </summary>
        private bool gameEnd;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="d"></param>
        /// <param name="s"></param>
        /// <param name="tn"></param>
        /// <param name="m"></param>
        public Table_Form(int d, int s, int tn, int m)
        {
            
            gameEnd = false; //game initialized to false
            bet = 0.0;
            numDecks = d;
            seed = s;
            mode = m;

            InitializeComponent();

            //hide hit, stand, and reset buttons whenever a game has not started yet
            //reset gets hidden to make sure the player does not reset the shoe mid hand
            hit_button.Visible = false;
            stand_button.Visible = false;

            dealerCards = 0;
            playerCards = 0;

            //the dealer and player can have up to 12 cards,
            //this is unlikely but since i only have 6 card spots
            //I wanted to account for when hands go over 6 cards,
            //so each spot/text box can be used twice
            dCards = new aCard[12];
            pCards = new aCard[12];

            tnum_lable.Text = tn.ToString();
            seed_num.Text = s.ToString();
            deck_num.Text = d.ToString();

            //set mode depending on if box from form 1 was checked
            if (mode == 1)
                mode_label.Text = "S17";
            else
                mode_label.Text = "H17";

            money_textbox.Text = "100";

            money = 100.00;

            //create shoe for form
            currentShoe = new aShoe(numDecks, seed);

            //output directions
            output_box.Text = "Take a seat and press Play to begin the game!";
            
        }

        /// <summary>
        /// closes table and decreaes table count when player choses end game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void close_table_button_Click(object sender, EventArgs e)
        {
            Menu_Form.tableCount--;
            Menu_Form.table_count.Text = Menu_Form.tableCount.ToString();
            this.Close();
        }

        /// <summary>
        /// gives player a card whenever they choose "hit"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hit_button_Click(object sender, EventArgs e)
        {
            //checks for errors
            if (errorCheck() > 0)
                return;

            //draws card for player
            aCard card = currentShoe.Draw();
            pCards[playerCards] = card;
            playerCards++;

            //places card in correct spot
            switch(playerCards % 6)
            {
                case 1:
                    player1.Text += "\n" + pCards[playerCards - 1].display();
                    break;
                case 2:
                    player2.Text += "\n" + pCards[playerCards - 1].display();
                    break;
                case 3:
                    player3.Text += "\n" + pCards[playerCards-1].display();
                    break;
                case 4:
                    player4.Text += "\n" + pCards[playerCards - 1].display();
                    break;
                case 5:
                    player5.Text += "\n" + pCards[playerCards - 1].display();
                    break;
                case 0:
                    player6.Text = "\n" + pCards[playerCards - 1].display();
                    break;

                default:
                    break;
            }

            //calculates values of hands
            calculateValues();

            //checks if player busted, initiates stand action if they did,
            //calls stand because that starts the dealer
            if (Int32.Parse(player_value_box.Text) > 21)
            {
                stand_button_Click(sender, e);
            }
        }

        /// <summary>
        /// initiates initial deal when player chooses "play"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void play_button_Click(object sender, EventArgs e)
        {
            //checks for errors
            if (errorCheck() > 0)
                return;

            //checks to see if this is the start of a new hand
            if(gameEnd)
            {
                dealerCards = 0;
                playerCards = 0;

                dCards = new aCard[6];
                pCards = new aCard[6];

                clearBoard();

                gameEnd = false;
            }

            //reset gets hidden when game starts so player does not reset shoe mid hand
            hit_button.Visible = true;
            stand_button.Visible = true;
            reset_button.Visible = false;
            play_button.Visible = false;

            //deals out initial cards
            InitialDeal(sender, e);

            //checks to see if player got natural blackjack
            naturalCheck();
        }

        /// <summary>
        /// checks if player got a natural blackjack
        /// </summary>
        private void naturalCheck()
        {
            bet = Double.Parse(bet_box.Text);

            //if player got natural balck jack
            if (Int32.Parse(player_value_box.Text) == 21)
            {
                //we draw a card for the dealer to see if they got it too 
                aCard dc1 = currentShoe.Draw();
                dCards[dealerCards] = dc1;
                dealerCards++;
                dealer2.Text = dCards[dealerCards - 1].display();

                calculateValues();

                //if they did, than its a tie
                if (Int32.Parse(dealer_value_box.Text) == 21)
                {
                    output_box.Text += "\n Tie!";
                }
                else
                {
                    //if not, player wins
                    money += (bet + (bet * .5));
                    money_textbox.Text = money.ToString();
                    output_box.Text += "\n Player wins with Blackjack!";
                }
                
                gameEnd = true;
                hit_button.Visible = false;
                stand_button.Visible = false;
                reset_button.Visible = true;
                play_button.Visible = true;
            }
        }

        /// <summary>
        /// clears board for new game
        /// </summary>
        private void clearBoard()
        {
            player1.Clear(); player2.Clear();
            player3.Clear(); player4.Clear();
            player5.Clear(); player5.Clear();

            dealer1.Clear(); dealer2.Clear();
            dealer3.Clear(); dealer4.Clear();
            dealer5.Clear(); dealer6.Clear();

            player_value_box.Clear();
            dealer_value_box.Clear();
        }

        /// <summary>
        /// sets up initial deal for game, 2 cards drawn for player, 1 for dealer
        /// </summary>
        private void InitialDeal(object sender, EventArgs e)
        {
            playerCards = 0;
            dealerCards = 0;

            //player cards
            aCard pc1 = currentShoe.Draw();
            pCards[playerCards] = pc1;
            playerCards++;
            aCard pc2 = currentShoe.Draw();
            pCards[playerCards] = pc2;
            playerCards++;

            //dealer card
            aCard dc1 = currentShoe.Draw();
            dCards[dealerCards] = dc1;
            dealerCards++;

            //display cards
            player1.Text = pc1.display();
            player2.Text = pc2.display();
            dealer1.Text = dc1.display();

            //calculate the card values
            calculateValues();

            //checks if player busted, initiates stand action if they did,
            //calls stand because that starts the dealer
            if (Int32.Parse(player_value_box.Text) > 21)
            {
                stand_button_Click(sender, e);
            }

        }

        /// <summary>
        /// adds up the values of the player and dealer hands
        /// </summary>
        private void calculateValues()
        {
            //values for hands
            int dval = 0;
            int pval = 0;

            //go through each card
            for(int i = 0; i < dealerCards; i++)
            {
                //if the card is an ace and puts the value over 21, change ace value to 1
                if(String.Equals(dCards[i].getFace(),"Ace") && (dval + dCards[i].getValue()) > 21)
                {
                    dCards[i].setValue(1);
                }
                dval += dCards[i].getValue();
            }

            //go through each card
            for (int j = 0; j < playerCards; j++)
            {
                //if the card is an ace and puts the value over 21, change ace value to 1
                if (String.Equals(pCards[j].getFace(), "Ace") && (pval + pCards[j].getValue()) > 21)
                {
                    pCards[j].setValue(1);
                }
                pval += pCards[j].getValue();
            }


            //display added values
            dealer_value_box.Text = dval.ToString();
            player_value_box.Text = pval.ToString();
        }

        /// <summary>
        /// initiates stand protocal when player chooses "stand"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stand_button_Click(object sender, EventArgs e)
        {
            //checks for errors
            if (errorCheck() > 0)
                return;

            //sets max for dealer to stop at depending on the mode
            int max = 0;
            if (mode == 1)
                max = 17;
            else
                max = 18;

            //dealer chooses cards until over the max or bust
            while (Int32.Parse(dealer_value_box.Text) < max)
            {
                aCard card = currentShoe.Draw();
                dCards[dealerCards] = card;
                dealerCards++;

                //puts card in correct spot
                switch (dealerCards % 6)
                {
                    case 1:
                        dealer1.Text += "\n" + dCards[dealerCards - 1].display();
                        break;
                    case 2:
                        dealer2.Text += "\n" + dCards[dealerCards - 1].display();
                        break;
                    case 3:
                        dealer3.Text += "\n" + dCards[dealerCards - 1].display();
                        break;
                    case 4:
                        dealer4.Text += "\n" + dCards[dealerCards - 1].display();
                        break;
                    case 5:
                        dealer5.Text +=  "\n" + dCards[dealerCards - 1].display();
                        break;
                    case 6:
                        dealer6.Text +=  "\n" + dCards[dealerCards - 1].display();
                        break;
                    default:
                        break;
                }
                //calculate hand values
                calculateValues();
            }
            
            //checks for winner
            calculateWinner();


        }

        /// <summary>
        /// goes through all win and lose conditions to declare winner and set payout
        /// </summary>
        public void calculateWinner()
        {
            bet = Double.Parse(bet_box.Text);

            if (Int32.Parse(dealer_value_box.Text) > 21 && Int32.Parse(player_value_box.Text) <= 21)
            {
                // dealer busts, player doesn't, player Wins
                money += (bet + (bet * .5));
                money_textbox.Text = money.ToString();
                output_box.Text += "\nPlayer Wins!";

            }
            else if (Int32.Parse(dealer_value_box.Text) <= 21 && Int32.Parse(player_value_box.Text) > 21)
            {
                // player busts, player doesn't, dealer wins
                money -= bet;
                money_textbox.Text = money.ToString();
                output_box.Text += "\nDealer Wins!";

            }
            else if (Int32.Parse(dealer_value_box.Text) > 21 && Int32.Parse(player_value_box.Text) > 21)
            {
                // both bust dealer wins
                money -= bet;
                money_textbox.Text = money.ToString();
                output_box.Text += "\nDealer Wins!";

            }
            else if (Int32.Parse(dealer_value_box.Text) <= 21 && Int32.Parse(player_value_box.Text) < Int32.Parse(dealer_value_box.Text))
            {
                //dealer didn't bust, player < dealer, dealer wins
                money -= bet;
                money_textbox.Text = money.ToString();
                output_box.Text += "\nDealer Wins!";
            }
            else if (Int32.Parse(player_value_box.Text) <= 21 && Int32.Parse(dealer_value_box.Text) < Int32.Parse(player_value_box.Text))
            {
                //player didn't bust, dealer < player, player wins
                money += (bet + (bet * .5));
                money_textbox.Text = money.ToString();
                output_box.Text += "\nPlayer Wins!";
            }
            else if(Int32.Parse(dealer_value_box.Text) == Int32.Parse(player_value_box.Text) && Int32.Parse(player_value_box.Text) <= 21)
            {
                //tie, no one wins
                output_box.Text += "\nTie!";
            }

            //check to see if player ran out of money
            moneyCheck();

            gameEnd = true;
            hit_button.Visible = false;
            stand_button.Visible = false;
            reset_button.Visible = true;
            play_button.Visible = true;
        }

        /// <summary>
        /// resets the shoe by refilling it with cards
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reset_button_Click(object sender, EventArgs e)
        {
            currentShoe.resetShoe();
            output_box.Text += "\n Shoe has been reset";
        }

        /// <summary>
        /// checks if the player still has enough money to play
        /// </summary>
        private void moneyCheck()
        {
            if (money <= 0)
            {
                MessageBox.Show("I'm sorry, you're all out of cash...");
                Menu_Form.tableCount--;
                Menu_Form.table_count.Text = Menu_Form.tableCount.ToString();
                this.Close();
            }
        }

        /// <summary>
        /// Checks to make sure bet box is not empty, has a double ammount (no text), and is a positive number
        /// </summary>
        /// <returns>number of errors found</returns>
        private int errorCheck()
        {
            int error = 0;

            if(string.IsNullOrEmpty(bet_box.Text))
            {
                MessageBox.Show("Please enter a bet ammount!");
                error++;
            }

            double val;
            if(!double.TryParse(bet_box.Text, out val))
            {
                MessageBox.Show("Please only enter a number into the bet box!");
                error++;
                return error; // return at this point because if not next check will cause error
            }

            if(Double.Parse(bet_box.Text) <= 0)
            {
                MessageBox.Show("Please enter a positive number for your bet!");
                error++;
            }

            return error;
        }
    }
}
