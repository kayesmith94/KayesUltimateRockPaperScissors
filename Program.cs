using System;
using System.Collections.Generic;

namespace KayesUltimateRockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            { 
                Console.WriteLine("Hello, gamer!" + '\n' + "Press any key to play a game.");
                Console.ReadLine();
                Console.WriteLine("Welcome to Kaye's happy gamezone. Choose a game by its letter:");
                Console.WriteLine("a) Rock Paper Scissors");
                Console.WriteLine("b) BlackJack");
                Console.WriteLine("c) Yahtzee");
                var gameChoice = Console.ReadLine();
                if (ValidateMultipleChoiceInput(new List<string> {"a","b","c"},gameChoice))
                {

                    switch (gameChoice)
                    {
                        case "a":
                            Console.WriteLine("Starting Rock Paper Scissors..." + '\n');
                            RockPaperScissors();
                            break;
                        case "b":
                        case "c":
                            Console.WriteLine("cool so Rock Paper Scissors. That's what you chose right? Oh we're star--" + '\n');
                            RockPaperScissors();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("You must pick a b or c."); //validate function should do this
                }
            }
        }

        static void RockPaperScissors()
        {
            Console.WriteLine("Welcome to Rock Paper Scissors. Choose a)Rock, b)Paper or c)Scissors.");
            var weapon = Console.ReadLine().ToLower();
            string ourResponse=String.Empty;
            if (ValidateMultipleChoiceInput(new List<string> { "a", "b", "c" }, weapon))
            {
                switch (weapon)
                {
                    case "a":
                        weapon = "rock";
                        ourResponse = "paper";
                        break;
                    case "b":
                        weapon = "paper";
                        ourResponse = "scissors";
                        break;
                    case "c":
                        weapon = "scissors";
                        ourResponse = "rock";
                        break;
                }

                Console.WriteLine($"You chose {weapon}. We chose {ourResponse}. You Lose. We win! Let's play again." + '\n' + '\n');
            }
            else
            {
                Console.WriteLine("You must pick a b or c."); //validate function should do this
            }
        }

        static bool ValidateMultipleChoiceInput(List<string> choices, string userInput)
        {
            if(choices.Contains(userInput)) return true;
            else { return false;}
        }

    }
}
