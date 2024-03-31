//Create a console application that plays rock - paper - scissors

//There should be a menu with three options:

//Play
//The user picks rock paper or scissors option
//The application picks rock paper scissors on random
//The user pick and the application pick are shown on the screen
//The application shows the winner
//The application saves 1 score to the user or the computer in the background
//When the user hits enter it returns to the main menu

//Stats
//It shows how many wins the user and how many wins the computer has
//It shows the percentage of the wins and losses of the user
//When the user hits enter it returns to the main menu

//Exit
//It closes the application

using GameApp.Enums;
using System;
using System.Collections.Generic;

int playerScore = 0;
int computerScore = 0;

while (true)
{
    try
    {
        Console.WriteLine("Choose one option: Play, Stats or Exit:");
        string input = Console.ReadLine().ToLower();
        if (input == "play" || input == "stats" || input == "exit")
        {
            if (input == "play")
            {
                try
                {
                    Console.WriteLine($"\nNow we are playing. Choose game option:");
                    foreach (ChoiceEnum choice in Enum.GetValues(typeof(ChoiceEnum))) //dynamically print the choices
                    {
                        Console.WriteLine(choice.ToString());
                    }
                    string inputChoice = Console.ReadLine().ToLower();

                    //iterrate enums and check if input is one of those
                    bool correctInput = false;
                    foreach (ChoiceEnum choice in Enum.GetValues(typeof(ChoiceEnum)))
                    {
                        if (choice.ToString().ToLower() == inputChoice)
                        {
                            correctInput = true;
                            break;
                        }
                    }

                    if (correctInput)
                    {
                        int inputCom = new Random().Next(1, 4);
                        string inputComputer = Enum.GetName(typeof(ChoiceEnum), inputCom).ToLower();
                        Console.WriteLine($"\nYou chose: {inputChoice.ToUpper()}. The computer chose: {inputComputer.ToUpper()}.\n");

                        if (inputComputer == inputChoice)
                        {
                            Console.WriteLine("It's a tie!\n");
                        }
                        else
                        {
                            switch (inputChoice)
                            {
                                case "rock":
                                    if (inputComputer == "paper")
                                    {
                                        Console.WriteLine("You lost!\n");
                                        computerScore++;
                                    }
                                    else
                                    {
                                        Console.WriteLine("You won!\n");
                                        playerScore++;
                                    }
                                    break;
                                case "paper":
                                    if (inputComputer == "rock")
                                    {
                                        Console.WriteLine("You won!\n");
                                        playerScore++;
                                    }
                                    else
                                    {
                                        Console.WriteLine("You lost!\n");
                                        computerScore++;
                                    }
                                    break;
                                case "scissors":
                                    if (inputComputer == "rock")
                                    {
                                        Console.WriteLine("You lost!\n");
                                        computerScore++;
                                    }
                                    else
                                    {
                                        Console.WriteLine("You won!\n");
                                        playerScore++;
                                    }
                                    break;
                            }
                        }
                    }
                    else
                    {
                        throw new Exception("Invalid game input! Please try again.\n");

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.ReadLine();
            }

            if (input == "stats")
            {
                if (playerScore == 0 && computerScore == 0)
                {
                    Console.WriteLine("Player and Computer haven't won any games.");
                }
                else if (playerScore == 0)
                {
                    PrintScores(playerScore, computerScore, 0, 100);
                }
                else if (computerScore == 0)
                {
                    PrintScores(playerScore, computerScore, 100, 0);
                }
                else
                {
                    float percentageWon = (playerScore / (playerScore + computerScore)) * 100;
                    float percentageLost = 100 - percentageWon;
                    PrintScores(playerScore, computerScore, percentageWon, percentageLost);
                }
                Console.ReadLine();
            }
            if (input == "exit")
            {
                break;
            }
        }
        else
        {
            throw new Exception("Invalid input! Please try again.\n");
        }
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
    //finally
    //{
    //    Console.WriteLine("There was a readline for option made.");
    //}
}

void PrintScores(int playerScore, int computerScore, float percentageWon, float percentageLost)
{
    Console.WriteLine($"\nThe player has: {playerScore} wins. \nThe computer has: {computerScore} wins.");
    Console.WriteLine($"You have won {percentageWon}% of the time and have lost {percentageLost}% of the time.\n");
}