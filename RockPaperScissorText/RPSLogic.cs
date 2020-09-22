using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorText
{
    class RPSLogic
    {
        public const int minimumAge = 13;
        public static int playerAge;
        public static string permission;
        public static int computerRPSRandomNum;
        public static string rpsComputerPlays;
        public static string playerRPSChoice;
        public static int playerRPSNumValue;
        public static int yourScore = 0;
        public static string youchose = "null";
        



        //This is the start of your code.
        public static void AgeValidation()
        {


            Console.WriteLine("What is your age?");
            playerAge = Convert.ToInt32(Console.ReadLine());

            if (playerAge >= 13)
            {
                Console.WriteLine("You are old enough to play Rock Paper Scissors.");
                //call another function here.
                RPSChoices();
            }
            else
            {

                Console.WriteLine($"Sorry, you have to be at least {minimumAge} to play Rock Paper Scissors");
                //call another function here. or close the program.
                Console.WriteLine("I'm sorry, I did not understand that. Please try again.");
                AdditionalPermission();
            }

        }


        public static void AdditionalPermission()
        {

            Console.WriteLine("Do you have your parents permission to play? Enter Yes or No");
            permission = Console.ReadLine().ToLower();

            if (permission == "yes" || permission == "y")
            {
                Console.WriteLine("Fantastic. But I am still going to need to see a permission slip.");
            }
            else if (permission == "no" || permission == "n")
            {
                Console.WriteLine("Ouch. Better off either way. Try again when you're older.");
            }
            else
            {
                Console.WriteLine("I'm sorry, I did not understand that. Please try again.");
                AdditionalPermission();
            }
        }

        public static void RPSChoices()
        {

            Random computerRandomRPS = new Random();
            computerRPSRandomNum = computerRandomRPS.Next(1, 4);

            Console.WriteLine("Let's Play Rock Paper Scissor.");
            Console.WriteLine($"Your current score is {yourScore}.");

            // TODO: Ask the Hooman to enter 'R' for Rock, 'P' for Paper, or 'S' for Scissors.
            Console.WriteLine("Hello Hooman! Please enter 'R' for rock, 'P' for Paper, or 'S' for Scissors");
            // TODO: Assign the user input of R, P, S to the variable playerRPSChoice. HINT... use .ToLower() so that capitalization does not matter from the user.
            playerRPSChoice = Console.ReadLine().ToLower();

            if (playerRPSChoice == "r" || playerRPSChoice == "rock")
            {
                Console.WriteLine("You Chose Rock!");
                playerRPSNumValue = 3;
                youchose = "rock";
                
            }
            else if (playerRPSChoice == "p" || playerRPSChoice == "paper")
            {
                Console.WriteLine("You Chose Paper!");
                playerRPSNumValue = 2;
                youchose = "paper";
                
            }
            else if (playerRPSChoice == "s" || playerRPSChoice == "scissors")
            {
                Console.WriteLine("You Chose Scissors!");
                playerRPSNumValue = 1;
                youchose = "scissors";
                
            }
            else
            {
                Console.WriteLine("I didn't understand your choice");
                RPSChoices();
            }
            



            //Control Logic the displays the Computers RPS choice. Based on computer's "choice": assigns Rock, Paper or Scissor to rpsComputerPlays.
            switch (computerRPSRandomNum)
            {
                case 4:
                    Console.WriteLine("PC Rolled a 4. Oops that wasn't supposed to happen.");
                    break;
                case 3:
                    Console.WriteLine($"PC chose a {computerRPSRandomNum}. That is equal to Rock");
                    rpsComputerPlays = "Rock";
                    break;
                case 2:
                    Console.WriteLine($"PC chose a {computerRPSRandomNum}. That is equal to Paper");
                    rpsComputerPlays = "Paper";
                    break;
                case 1:
                    Console.WriteLine($"PC chose a {computerRPSRandomNum}. That is equal to Scissors");
                    rpsComputerPlays = "Scissors";
                    break;
            }

            // TODO: Add a Switch Statement based on playerRPSChoice. It should output to the screen what they chose (for example: Console.WriteLine($"You chose Rock");. AND assign a value to playerRPSNumValue. The playerRPSNumValue should be the same as the computerRPSRandomNum. So r = 3, p = 2 and s = 1.

            WinnerLoserLogic();
            Console.WriteLine($"Your score is {yourScore}");
            Console.WriteLine("Would you like to play again? 'Y' for Yes, 'N' for No.");
            string playAgain = Console.ReadLine().ToLower();
            // TODO: Add a Switch Statement to ask the player if they want to play again. If yes, call the method "RPSChoices();" if no, exit the program.

            if (playAgain == "yes" || playAgain == "y")
            {
               Console.ReadLine();
                Console.WriteLine("Lets Play Again!");
                RPSChoices();
            }
            else if (playAgain == "yes")
            {
                Console.ReadLine();
                Console.WriteLine("Lets Play Again!");
                RPSChoices();
            }
            else if (playAgain == "no" || playAgain == "n")
            {
                Console.WriteLine("Game Over.");
            }
            















            if (playerRPSChoice == "yes")
            {

            }

        }

        public static void WinnerLoserLogic()
        {
            Console.WriteLine($"Player Chose {playerRPSChoice}.");
            Console.WriteLine($"PC Chose {rpsComputerPlays}.");

            // TODO: Add logic to determine the winner between the player and computer. You may use either an Else If Statement or Switch Statement to do it. 

            if (playerRPSNumValue == computerRPSRandomNum)
            {
                Console.WriteLine($"You chose {youchose} and computer chose {rpsComputerPlays} which is a tie!");
            }
            else if (playerRPSNumValue == 1 && computerRPSRandomNum == 2)
            {
                Console.WriteLine($"You chose {youchose} and computer chose {rpsComputerPlays}, you win!");
                yourScore++;
            }
            else if (playerRPSNumValue == 2 && computerRPSRandomNum == 3)
            {
                Console.WriteLine($"You chose {youchose} and computer chose {rpsComputerPlays}, you win!");
                yourScore++;
            }
            else if (playerRPSNumValue == 3 && computerRPSRandomNum == 1)
            {
                Console.WriteLine($"You chose {youchose} and computer chose {rpsComputerPlays}, you win!");
                yourScore++;
            }
            else
            {
                Console.WriteLine($"You chose {youchose} and computer chose {rpsComputerPlays}, you lose!");
                yourScore--;
            }


            // TODO: based on whether the player wins or loses, increment or decrement the variable "yourScore". This will be ++yourScore if they win or --yourScore if they lose. If it is a tie, there should be no change. 


        }
    }
}
