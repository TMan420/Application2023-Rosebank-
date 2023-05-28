using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRecipe_App
{
    class Recipe
    {
        private string[] Ingedient;
        private string[] Unit;
        private string[] Steps;
        private string[] Group;
        private double[] Quantity;
        private double[] Calories;
        public Recipe() 
        {
            string[] Ingedient = new string[0];
            string[] Unit      = new string[0];
            string[] Steps     = new string[0];
            string[] Group     = new string[0];
            double[] Quantity  = new double[0];
            double[] Calories  = new double[0];
        }
        public void CreateRecipe()
        {
            // Asks the user to enter the amount of ingredients required for the recipe and then Initialising the array with a size which is set according to the user Input
            Console.Write("Enter the total number of Ingredients: ");
            Console.WriteLine();
            Console.WriteLine();
            int Input1 = int.Parse(Console.ReadLine());
            Console.Clear();
            Ingedient = new string[Input1];
            Quantity = new double[Input1];
            Unit = new string[Input1];
            Calories = new double[Input1];
            Group = new string[Input1];

            // Asks the user to enter the details of each ingredient
            for (int i = 0; i < Input1; i++)
            {
                Console.WriteLine($"Enter the details for the Ingredients > {i + 1}:");
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("Name: ");
                Console.WriteLine();
                Ingedient[i] = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Total Calories");
                Calories[i] = double.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Quantity: ");
                Console.WriteLine();
                Quantity[i] = double.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Unit of measurement: ");
                Console.WriteLine();
                Console.WriteLine();
                Unit[i] = Console.ReadLine();

           
                Console.Clear();
                while (true)
                {
                    Console.WriteLine("Food Group: ");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("1: Starchy Foods");
                Console.WriteLine("2: Fruit & Vegetables");
                Console.WriteLine("3: Chicken, Fish, Meat & Eggs");
                Console.WriteLine("5: Milk & Dairy Products");
                Console.WriteLine("4: Fats & Oils");
                Console.WriteLine("6: Dry Beans");
                Console.WriteLine("7: Water");
                Console.WriteLine();
                string Input3 = Console.ReadLine();
                Console.WriteLine();
                
                    switch (Input3)
                    {
                        case "1" or "one" or "ONE" or "One":
                            Group[i] = "Starchy Foods";
                            break;
                        case "2" or "two" or "TWO" or "Two":
                            Group[i] = "Fruits & Vegetables";
                            break;
                        case "3" or "three" or "THREE" or "Three":
                            Group[i] = "Chicken, fish, meat & Eggs";
                            break;
                        case "4" or "four" or "FOUR" or "Four":
                            Group[i] = "Milk & Dairy Products";
                            break;
                        case "5" or "five" or "FIVE" or "Five":
                            Group[i] = "Fats & Oils";
                            break;
                        case "6" or "six" or "SIX" or "Six":
                            Group[i] = "Dry Beans";
                            break;
                        case "7" or "seven" or "SEVEN" or "Seven":
                            Group[i] = "Water";
                            break;
                        default:
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Please choose a number from the list Below");
                            break;
                    }
                }
            }

            // Asks the user to identify the amount of steps in the recipe
            Console.Write("Enter the number of Steps: ");
            int Input2 = int.Parse(Console.ReadLine());

            // Initialising the array with a size which is set according to the user Input
            Steps = new string[Input2];

            // Ask the user to enter the details for each step of the recipe
            for (int i = 0; i < Input2; i++)
            {
                Console.Write($"Enter step #{i + 1}: ");
                Steps[i] = Console.ReadLine();
            }
        }
    }
}
