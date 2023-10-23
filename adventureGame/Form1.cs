//Noah Tantner
//23rd of October, 2023
//It is a choose your own adventure game, loosely depicting what going to a German festival/party is like.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace adventureGame
{
    public partial class Form1 : Form
    {
        int page = 1;
        int chanceNumber;
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();

            outputLabel.Text = "You're on vacation in Germany. You " +
                               "and you're friends decide to go to a village festival";
            option1Label.Text = "Order Beer.";
            option2Label.Text = "Don't order Beer.";
        }

        private void option1Button_Click(object sender, EventArgs e)
        {
            chanceNumber = random.Next(1, 101);
            if (page == 1)
            {
                page = 2;
            }
            else if (page == 2)
            {
                page = 4;
            }
            else if (page == 3)
            {
                page = 1;
            }
            else if (page == 4)
            {
                page = 6;
            }
            else if (page == 5)
            {
                page = 12;
            }
            else if (page == 6)
            {
                page = 1;
            }
            else if (page == 7)
            {
                page = 10;
            }
            else if (page == 8)
            {
                page = 13;
            }
            else if (page == 9)
            {
                page = 1;
            }
            else if (page == 10)
            {
                page = 1;
            }
            else if (page == 11 && chanceNumber > 50)
            {
                page = 19;
            }
            else if (page == 11 && chanceNumber < 50)
            {
                page = 17;
            }
            else if (page == 12)
            {
                page = 1;
            }
            else if (page == 13)
            {
                page = 1;
            }
            else if (page == 14)
            {
                page = 15;
            }
            else if (page == 15)
            {
                page = 1;
            }
            else if (page == 16)
            {
                page = 1;
            }
            else if (page == 17)
            {
                page = 1;
            }
            else if (page == 18)
            {
                page = 1;
            }
            else if (page == 19 && chanceNumber > 50)
            {
                page = 22;
            }
            else if (page == 19 && chanceNumber < 50)
            {
                page = 21;
            }
            else if (page == 20)
            {
                page = 1;
            }
            else if (page == 21)
            {
                page = 1;
            }
            else if (page == 22)
            {
                page = 1;
            }
            if (page != 4)
            {
                option3Button.Visible = false;
                option3Label.Visible = false;
            }

            //all done... I think
            displayContent(page);
        }
        private void option2Button_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 3;
            }
            else if (page == 2)
            {
                page = 5;
            }
            else if (page == 3)
            {
                page = 99;
            }
            else if (page == 4)
            {
                page = 9;
            }
            else if (page == 5)
            {
                page = 8;
            }
            else if (page == 6)
            {
                page = 99;
            }
            else if (page == 7)
            {
                page = 11;
            }
            else if (page == 8)
            {
                page = 14;
            }
            else if (page == 9)
            {
                page = 99;
            }
            else if (page == 10)
            {
                page = 99;
            }
            else if (page == 11)
            {
                page = 16;
            }
            else if (page == 12)
            {
                page = 99;
            }
            else if (page == 13)
            {
                page = 99;
            }
            else if (page == 14)
            {
                page = 18;
            }
            else if (page == 15)
            {
                page = 99;
            }
            else if (page == 16)
            {
                page = 99;
            }
            else if (page == 17)
            {
                page = 99;
            }
            else if (page == 18)
            {
                page = 99;
            }
            else if (page == 19)
            {
                page = 20;
            }
            else if (page == 20)
            {
                page = 99;
            }
            else if (page == 21)
            {
                page = 99;
            }
            else if (page == 22)
            {
                page = 99;
            }
            if (page != 4)
            {
                option3Button.Visible = false;
                option3Label.Visible = false;
            }
            displayContent(page);
            //should be done
        }

        


        public void displayContent(int pageNumber)
        {

            switch (pageNumber)
            {
                case 1:
                    outputLabel.Text = "You're on vacation in Germany." +
                        " You and you're friends decide to go to a village festival. Order Beer?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    imageBox.Image = Properties.Resources.germans_Drinking;
                    break;
                case 2:
                    outputLabel.Text = "You order a couple beers with the boys " +
                        "and you all start getting a bit drunk. Drink more?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    imageBox.Image = Properties.Resources.more_guys_drinking;
                    break;
                case 3:
                    outputLabel.Text = "While most of your friends drink and have fun, " +
                        "you sit around and have the most boring night of your life. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    imageBox.Image = Properties.Resources.bored_Man;
                    break;
                case 4:
                    outputLabel.Text = "You get blasted with the boys and the group of you " +
                        "tries to think of some fun shenanigans to get up to. What do you do?";
                    option1Label.Text = "Start a fight";
                    option2Label.Text = "Drink more";
                    option3Label.Text = "Steal a street sign";
                    option3Button.Visible = true;
                    option3Label.Visible = true;
                    imageBox.Image = Properties.Resources.drinking_with_the_boys;

                    break;
                case 5:
                    outputLabel.Text = "You decide to stop drinking. Still somehow you find " +
                        "that after a couple minutes a bottle finds itself into your hands." +
                        " How did it get there you wonder?";
                    option1Label.Text = "Drink bottle";
                    option2Label.Text = "Don't drink bottle";
                    imageBox.Image = Properties.Resources.beer_in_hand;

                    break;
                case 6:
                    outputLabel.Text = "You start a fight with the Germans at the festival, " +
                        "but the fight soon dissolves because you're all to drunk to " +
                        "stand upright. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    imageBox.Image = Properties.Resources.drunk_fight;
                    break;
                case 7:
                    outputLabel.Text = "You steal a street sign and make a run for it. " +
                        "Wait a minute. Where are you running to? " +
                        "Should you stop this hilarious tomfoolery?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    imageBox.Image = Properties.Resources.street_sign;
                    break;
                case 8:
                    outputLabel.Text = "You resist the temptation to drink more, for now," +
                        " and decide to search for your friends, John and Jack. " +
                        "Which friend do you look for?";
                    option1Label.Text = "Jack";
                    option2Label.Text = "John";
                    imageBox.Image = Properties.Resources.man_looking_around_confused1;
                    break;
                case 9:
                    outputLabel.Text = "You die of alcohol poisoning. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    imageBox.Image = Properties.Resources.man_dead_from_alcohol;
                    break;
                case 10:
                    outputLabel.Text = "The group of you thinks about the situation again " +
                        "and all of you agree to go back to your place. You leave the street sign by the roadside. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    imageBox.Image = Properties.Resources.group_walking_away;
                    break;
                case 11:
                    outputLabel.Text = "You arrive at a village and someone sees what you're doing and calls the police on you.";
                    option1Label.Text = "Explain the situation.";
                    option2Label.Text = "Make a run for it.";
                    imageBox.Image = Properties.Resources.polizisten;
                    break;
                case 12:
                    outputLabel.Text = "You drink the bottle. And another. This process repeats itself. " +
                        "You fall asleep in the middle of the festival and wake up hours later. " +
                        "You have no Idea what happened or where you are. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    imageBox.Image = Properties.Resources.man_wakes_up_confused;
                    break;
                case 13:
                    outputLabel.Text = "You find Jack in a corner of the field, crouching down low and pooping on the ground. " +
                        "Unfortunately he forgot to pull his pants down. The two of you decide to call it a day and go home, " +
                        "although it does feel like you forgot something... Play again?";
                    imageBox.Image = Properties.Resources.two_guys_walking_away;
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 14:
                    outputLabel.Text = "You find John in a corner of the festival laying unconscious " +
                        "on the ground next to a bunch of other people. He has vomit on his clothes.";
                    option1Label.Text = "Leave him.";
                    option2Label.Text = "Help him.";
                    imageBox.Image = Properties.Resources.man_unconscious;
                    break;
                case 15:
                    outputLabel.Text = "You leave your friend in this precarious situation and feel guilty for the rest of your life. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    imageBox.Image = Properties.Resources.walking_away;
                    break;
                case 16:
                    outputLabel.Text = "The police comes after you on bicylcles, catches you and all of you get put under arrest. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    imageBox.Image = Properties.Resources.polizei_auf_fahrrad;
                    break;
                case 17:
                    outputLabel.Text = "You explain the situation and the police lets you go on your merry way. " +
                        "Thus you keep going, street sign in hand, looking for further adventures!. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    imageBox.Image = Properties.Resources.guys_walking_into_adventure;
                    break;
                case 18:
                    outputLabel.Text = "You try and pick John up of the ground, but you are too drunk. " +
                        "You fall on top of his vomit covered clothes and fall asleep yourself.. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    imageBox.Image = Properties.Resources.unconscious_man_on_carptt;
                    break;
                case 19:
                    outputLabel.Text = "You explain the situation and the police tries to arrest you. " +
                        "Some of your friends try to resist and get tazed and pepper sprayed. What do you do?";
                    option1Label.Text = "Help";
                    option2Label.Text = "Don't help";
                    imageBox.Image = Properties.Resources.pepper_spray;
                    break;
                case 20:
                    outputLabel.Text = "While your friends get absolutely demolished by the police, you make a run for it." +
                        "You're friends will NEVER forgive you. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    imageBox.Image = Properties.Resources.running_from_police;
                    break;
                case 21:
                    outputLabel.Text = "You try and and tackle one of the policemen, but he pepper sprays you. " +
                        "You fall to the floor in pain and not much later find yourself in prison. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    imageBox.Image = Properties.Resources.sitting_in_jail;
                    break;
                case 22:
                    outputLabel.Text = "You karate kick one of the policemen in the face. " +
                        "The others see that and run for their lives. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    imageBox.Image = Properties.Resources.karate_kick;
                    break;
                case 99:
                    outputLabel.Text = "Thank you for playing";
                    Refresh();
                    Thread.Sleep(2000);
                    Close();
                    break;
                default:
                    break;
            }
        }

        private void option3Button_Click(object sender, EventArgs e)
        {
            if (page == 4)
            {
                page = 7;
                option3Button.Visible = false;
                option3Label.Visible = false;
            }
            displayContent(page);
        }
    }
}

