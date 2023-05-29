using System;

namespace MyRecipe_App
{
    internal class Program //Class
    {
        static void Main(string[] args) //MAIN Method
        {
            Recipe recipe = new Recipe();
            while (true)//This keeps the menu running continuously without having to restart the program
            {
                Console.ForegroundColor = ConsoleColor.Blue; //Font Color
                Console.WriteLine("WELCOME");
                Console.WriteLine();
                Console.WriteLine("ENTER 1 - ENTER RECIPE DETAILS");
                Console.WriteLine("ENTER 2 - DISPLAY RECIPE");
                Console.WriteLine("ENTER 3 - SCALE RECIPE");
                Console.WriteLine("ENTER 4 - RESET QUANTITIES");
                Console.WriteLine("ENTER 5 - CLEAR RECIPE ");
                Console.WriteLine("ENTER 6 - LIST");
                Console.WriteLine("ENTER 7 - EXIT");
                Console.WriteLine();
                string MENU = Console.ReadLine(); //Calling the switch Function
                switch (MENU) //This method handles Errors
                {

                    case "1" or "one" or "ONE" or "One": //ONE
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        recipe.CreateRecipe();
                        break;
                    case "2" or "two" or "TWO" or "Two":
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        recipe.Display();
                        break;
                    case "3" or "three" or "THREE" or "Three":
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write("Enter scaling factor (0.5, 2, or 3): ");
                        double factor = double.Parse(Console.ReadLine());
                        recipe.Scale(factor);
                        break;
                    case "4" or "four" or "FOUR" or "Four":
                        Console.Clear();
                        recipe.Reset();
                        break;
                    case "5" or "five" or "FIVE" or "Five":
                        Console.Clear();
                        recipe.Clear();
                        break;
                    case "6" or "six" or "SIX" or "Six":
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        recipe.MyList();
                        break;

                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("                             <<PLEASE ENTER A NUMBER FROM THE LIST>>");
                        break;
                }
            }
        }
    }
}
