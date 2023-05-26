using System;

namespace MyRecipe_App
{
    internal class Program //Class
    {
        static void Main(string[] args) //MAIN Method
        {
            while (true)//This keeps the menu running continuously without having to restart the program
            {
                Console.ForegroundColor = ConsoleColor.Blue; //Font Color
                Console.WriteLine("WELCOME");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("ENTER 1 - ENTER RECIPE DETAILS");
                Console.WriteLine("ENTER 2 - DISPLAY RECIPE");
                Console.WriteLine("ENTER 3 - SCALE RECIPE");
                Console.WriteLine("ENTER 4 - RESET QUANTITIES");
                Console.WriteLine("ENTER 5 - CLEAR RECIPE ");
                Console.WriteLine("ENTER 6 - EXIT");
                Console.WriteLine();
                string MENU = Console.ReadLine(); //Calling the switch Function
                switch (MENU) //This method handles Errors
                {

                    case "1" or "one" or "ONE" or "One": //ONE
                        Console.Clear();

                        break;
                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("                                                              <<TRY AGAIN>>");
                        break;
                }
            }
        }
    }
}
