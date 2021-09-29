using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DND_DiceRoller_Library;

namespace DND_DiceRoller_App
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Greeting();
            MainGameplayLoop();
            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                MainGameplayLoop();
            }
            else
            {
                Console.WriteLine("Press Enter to roll again, or Escape to Quit.");
            }

        }

        private static void MainGameplayLoop()
        {
            do
            {
                DiceSelection();
                Console.WriteLine();
                UserRollOutput();
                Console.WriteLine("Press Enter to roll again, or Escape to Quit.");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }

        private static void UserRollOutput()
        {
            string diceSelection = UserDiceSelection();
            Console.WriteLine($"Your Roll: {DiceRoll(diceSelection)}");
        }
        private static string UserDiceSelection()
        {
            return Console.ReadLine().ToUpper();
        }

        private static void DiceSelection()
        {
            Console.WriteLine("Which dice do you want to roll?");
            Console.WriteLine("Your choices are: D4, D6, D8, D10, D12, D20");
            Console.Write("Type your selection: ");
        }

        private static void Greeting()
        {
            Console.WriteLine("Greetings, Welcome to the dice roller.");
        }

        private static int DiceRoll(string diceSelection)
        {
            int roll = 0;
            switch (diceSelection)
            {
                case "D4":
                    roll = DiceRoller.RollD4();
                    break;
                case "D6":
                    roll = DiceRoller.RollD6();
                    break;
                case "D8":
                    roll = DiceRoller.RollD8();
                    break;
                case "D10":
                    roll = DiceRoller.RollD10();
                    break;
                case "D12":
                    roll = DiceRoller.RollD12();
                    break;
                case "D20":
                    roll = DiceRoller.RollD20();
                    break;

            }
            return roll;
        }
    }


    
}
