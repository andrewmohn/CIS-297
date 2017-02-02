using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Yahtzee
{
    public partial class yahtzeeGame : Form
    {
        //Die objects for each die
        private Die one;
        private Die two;
        private Die three;
        private Die four;
        private Die five;

        //Variables for gameplay elements
        private int rollCount;

        public yahtzeeGame()
        {
            InitializeComponent();
            one = new Die((DateTime.Now - DateTime.Today).TotalMilliseconds + 50);
            two = new Die((DateTime.Now - DateTime.Today).TotalMilliseconds + 100);
            three = new Die((DateTime.Now - DateTime.Today).TotalMilliseconds + 208);
            four = new Die((DateTime.Now - DateTime.Today).TotalMilliseconds + 840);
            five = new Die((DateTime.Now - DateTime.Today).TotalMilliseconds + 0411510);
            rollCount = 0;
        }

        //Change two a bordered label to indicate that the die is being held
        private void dieOne_Click(object sender, EventArgs e)
        {
            if (dieOne.BorderStyle == BorderStyle.None)
            {
                dieOne.BorderStyle = BorderStyle.FixedSingle;
                one.keepDie();
            }
            else
            {
                dieOne.BorderStyle = BorderStyle.None;
                one.unKeepDie();
            }
        }
        private void dieTwo_Click(object sender, EventArgs e)
        {
            if (dieTwo.BorderStyle == BorderStyle.None)
            {
                dieTwo.BorderStyle = BorderStyle.FixedSingle;
                two.keepDie();
            }
            else
            {
                dieTwo.BorderStyle = BorderStyle.None;
                two.unKeepDie();
            }
        }
        private void dieThree_Click(object sender, EventArgs e)
        {
            if (dieThree.BorderStyle == BorderStyle.None)
            {
                dieThree.BorderStyle = BorderStyle.FixedSingle;
                three.keepDie();
            }
            else
            {
                dieThree.BorderStyle = BorderStyle.None;
                three.unKeepDie();
            }
        }
        private void dieFour_Click(object sender, EventArgs e)
        {
            if (dieFour.BorderStyle == BorderStyle.None)
            {
                dieFour.BorderStyle = BorderStyle.FixedSingle;
                four.keepDie();
            }
            else
            {
                dieFour.BorderStyle = BorderStyle.None;
                four.unKeepDie();
            }
        }
        private void dieFive_Click(object sender, EventArgs e)
        {
            if (dieFive.BorderStyle == BorderStyle.None)
            {
                dieFive.BorderStyle = BorderStyle.FixedSingle;
                five.keepDie();
            }
            else
            {
                dieFive.BorderStyle = BorderStyle.None;
                five.unKeepDie();
            }
        }

        private void ButtonRoll_Click(object sender, EventArgs e)
        {
            if (rollCount < 3)
            {
                rollCount++;
                dieOne.Text = one.rollDie().ToString();
                dieTwo.Text = two.rollDie().ToString();
                dieThree.Text = three.rollDie().ToString();
                dieFour.Text = four.rollDie().ToString();
                dieFive.Text = five.rollDie().ToString();
            }
            else
            {
                MessageBox.Show("You have made three rolls.", "Too Many Rolls", MessageBoxButtons.OK);
            }
            return;
        }

        private void ButtonAccept_Click(object sender, EventArgs e)
        {
            String option = saveAsTextBox.Text;

            int[] rolls = new int[5] { one.dieValue(), two.dieValue(), three.dieValue(), four.dieValue(), five.dieValue() };
            int score = 0, count = 0, temp;

            if(option == "Aces" && scoreAces.Text == " ")
            {
                //Count 1s and mark score
                for(int i = 0; i < rolls.Length; i++)
                {
                    if(rolls[i] == 1)
                    {
                        score += 1;
                    }
                }
                scoreAces.Text = score.ToString();
            }
            else if(option == "Twos" && scoreTwos.Text == " ")
            {
                //Count 2s and mark score
                for (int i = 0; i < rolls.Length; i++)
                {
                    if (rolls[i] == 2)
                    {
                        score += 2;
                    }
                }
                scoreTwos.Text = score.ToString();
            }
            else if (option == "Threes" && scoreThrees.Text == " ")
            {
                //Count 3s and mark score
                for (int i = 0; i < rolls.Length; i++)
                {
                    if (rolls[i] == 3)
                    {
                        score += 3;
                    }
                }
                scoreThrees.Text = score.ToString();
            }
            else if (option == "Fours" && scoreFours.Text == " ")
            {
                //Count 4s and mark score
                for (int i = 0; i < rolls.Length; i++)
                {
                    if (rolls[i] == 4)
                    {
                        score += 4;
                    }
                }
                scoreFours.Text = score.ToString();
            }
            else if (option == "Fives" && scoreFives.Text == " ")
            {
                //Count 5s and mark score
                for (int i = 0; i < rolls.Length; i++)
                {
                    if (rolls[i] == 5)
                    {
                        score += 5;
                    }
                }
                scoreFives.Text = score.ToString();
            }
            else if (option == "Sixes" && scoreSixes.Text == " ")
            {
                //Count 6s and mark score
                for (int i = 0; i < rolls.Length; i++)
                {
                    if (rolls[i] == 6)
                    {
                        score += 6;
                    }
                }
                scoreSixes.Text = score.ToString();
            }
            else if (option == "Three of a Kind" && threeOfAKindScore.Text == " ")
            {
                //Count the dice
                for(int i = 0; i < 3; i++)
                {
                    //Check the first three dice and count matched dice
                    //One of the matching dice must be in the first three, the last two dice 
                    //do not need to be checked.
                    for(int j = i+1; j < rolls.Length; j++)
                    {
                        //If the two match
                        if(rolls[i] == rolls[j])
                        {
                            count++;
                        }
                    }//If more than three matches occur
                    if(count >= 2)
                    {
                        //There can only be one instance of three of a kind occuring
                        //We take the initial value that it is found and multiply it
                        //So even if a four of a kind is in the roll, it is scored as three
                        score = rolls[i] * 3;
                        threeOfAKindScore.Text = score.ToString();
                        i = 3; //Break the loop
                    }
                    //Reset count to go around again.
                    count = 0;
                }
            }
            else if (option == "Four of a Kind")
            {
                //Count the dice
                for (int i = 0; i < 2; i++)
                {
                    //Check the first two dice and count matched dice
                    //One of the matching dice must be in the first two, the last three dice values
                    //do not need to be checked.
                    for (int j = i + 1; j < rolls.Length; j++)
                    {
                        //If the two match
                        if (rolls[i] == rolls[j])
                        {
                            count++;
                        }
                    }//If more than three matches occur
                    if (count >= 3)
                    {
                        //There can only be one instance of four of a kind occuring
                        //We take the initial value that it is found and multiply it
                        score = rolls[i] * 4;
                        fourOfAKindScore.Text = score.ToString();
                        i = 3; //Break the loop
                    }
                    //Reset count to go around again.
                    count = 0;
                }
            }
            else if (option == "Full House")
            {
                
            }
            else if (option == "Small Straight")
            {
                //Sort
                for(int i = 0; i < rolls.Length-1; i++)
                {
                    for(int j = 0; j < rolls.Length; j++)
                    {
                        if(rolls[i] > rolls[j])
                        {
                            temp = rolls[i];
                            rolls[i] = rolls[j];
                            rolls[j] = temp;
                        }
                    }
                }

                for(int i = 0, j = 0; i < rolls.Length - 1; i++)
                {
                    if(rolls[i] + 1 == rolls[i+1])
                    {
                        j++;
                    }

                    if(j >= 3)
                    {
                        smallStraightScore.Text = score.ToString();
                    }
                }
            }
            else if (option == "Large Straight")
            {

            }
            else if (option == "Yahtzee")
            {

            }
            else if (option == "Chance")
            {

            }
            else
            {
                MessageBox.Show("This has already been filled.", "Can't do that", MessageBoxButtons.OK);
                return;
            }
            rollCount = 0;
            return;
        }
    }
}
