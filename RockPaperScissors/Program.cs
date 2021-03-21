﻿using System;
using System.Threading;

namespace RockPaperScissors
{
    static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Rock Paper Scissors game");
            GreetUser();
            Console.WriteLine("To choose rock enter R");
            Console.WriteLine("To choose paper enter P");
            Console.WriteLine("To choose scissors enter S");

            var userScore = 0;
            var computerScore = 0;

            string userChoice = null;
            string computerChoice = "paper";

            while (true)
            {
                var input = Console.ReadLine()?.ToUpper();
                switch (input)
                {
                    case "R":
                        userChoice = "rock";
                        break;
                    case "P":
                        userChoice = "paper";
                        break;
                    case "S":
                        userChoice = "scissors";
                        break;
                    default:
                        Console.WriteLine("No choice detected");
                        break;
                }

                //Check the user and computers choice

                if (userChoice == computerChoice)
                {
                    Console.WriteLine("tie");
                }
                else switch (userChoice)
                {
                    case "rock" when computerChoice == "paper":
                        Console.WriteLine("Computer chooses paper");
                        Thread.Sleep(1500);
                        PrintColorMessage(ConsoleColor.Red, "Oops! paper covers rock");
                        computerScore++;
                        break;
                    case "rock" when computerChoice == "scissors":
                        Console.WriteLine("Computer chooses scissors");
                        Thread.Sleep(1500);
                        PrintColorMessage(ConsoleColor.Green, "Yay! your rock smashes the scissors");
                        userScore++;
                        break;
                    case "scissors" when computerChoice == "paper":
                        Console.WriteLine("Computer chooses paper");
                        Thread.Sleep(1500);
                        PrintColorMessage(ConsoleColor.Green, "Yay! your sharp scissors slices the computer open");
                        userScore++;
                        break;
                    case "scissors" when computerChoice == "rock":
                        Console.WriteLine("Computer chooses rock");
                        Thread.Sleep(1500);
                        PrintColorMessage(ConsoleColor.Red, "Oops! your scissors has been smashed by the rock");
                        computerScore++;
                        break;
                    case "paper" when computerChoice == "scissors":
                        Console.WriteLine("Computer chooses scissors");
                        Thread.Sleep(1500);
                        PrintColorMessage(ConsoleColor.Red, "Oops! the scissors slices your paper");
                        computerScore++;
                        break;
                    case "paper" when computerChoice == "rock":
                        Console.WriteLine("Computer chooses rock");
                        Thread.Sleep(1500);
                        PrintColorMessage(ConsoleColor.Green, "Yay! your paper covers the rock");
                        userScore++;
                        break;
                }

                Console.WriteLine("Your score: {0} vs Computer Score: {1}", userScore, computerScore);

            }
        }

        // Ask users name and greet
        private static void GreetUser()
        {
            // Ask users name
            Console.WriteLine("What is your name?");

            // Get user input
            var inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, Welcome to Rock-Paper-Scissors", inputName);
        }
        
        // Print color message
        private static void PrintColorMessage(ConsoleColor color, string message)
        {
            // Change text color
            Console.ForegroundColor = color;

            // Tell user its not a number
            Console.WriteLine(message);

            // Reset text color
            Console.ResetColor();
        }
    }
}