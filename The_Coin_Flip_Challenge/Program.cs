//****************************************************************
//*   Filename: The_Coin_Flip_Challenge                          *
//*   Author: Kevin Balias                                       *
//*   Class: C# .Net                                             *
//*   Date:  9/14/2023                                           *
//*   Purpose: Computer guessing Game                            *
//*                                                              *
//*                                                              *
//****************************************************************


using System;

public class Coinflip
{

    // INPUT Player Name Variables
    static string playerName;

    // INPUT COIN FLIP CHOICE
    static int computerChoice;
    static int playerChoice;

    // INPUT Score Variables 
    static int playerScore = 0;

    // START
    public static void Main(string[] args)
    {

        Console.WriteLine("Hello, what is your name?");
        playerName = Console.ReadLine();

        Console.WriteLine(playerName + ", do you want play the COIN FLIP CHALLENGE?");
        string playerAnswer = Console.ReadLine();

        if (playerAnswer.ToLower() == "no")
        {

            Console.WriteLine("You are a coward, " + playerName + "!");
            Environment.Exit(0);
        }
        else if (playerAnswer.ToLower() == "yes")
        {

            Console.WriteLine("Welcome to the COIN FLIP CHALLENGE. You will have 5 rounds to guess the correct coin flip result: 0 (heads) or 1 (tails). Let's begin!");

            Random random = new Random();

            for (int i = 1; i <= 5; i++)
            {

                computerChoice = random.Next(2);

                Console.WriteLine(playerName + ", enter 0 (heads) or 1 (tails)");
                string playerInput = Console.ReadLine();

                if (int.TryParse(playerInput, out playerChoice))
                {

                    if (playerChoice == 0 || playerChoice == 1)
                    {

                        if (playerChoice == computerChoice)
                        {

                            Console.WriteLine("Correct, " + playerName + "! You scored 1 point!");
                            playerScore++;
                        }
                        else
                        {

                            Console.WriteLine("Wrong answer, " + playerName + ".");
                        }
                    }
                    else
                    {

                        Console.WriteLine("Invalid choice, " + playerName + "! Please enter either 0 (heads) or 1 (tails).");
                    }
                }
                else
                {

                    Console.WriteLine("Invalid input, " + playerName + "! Please enter a valid integer 0 or 1.");
                }
            }
        }
        else
        {

            Console.WriteLine("Invalid answer, " + playerName + "!");
        }

        Console.WriteLine();
        Console.WriteLine("Game over " + playerName + "! Your total score is: " + playerScore);
    }
}
