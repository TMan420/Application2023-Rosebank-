using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MyRecipe_App
{
    class Recipe
    {
        private string[] Ingredient;
        private string[] Unit;
        private string[] Steps;
        private string[] Group;
        private double[] Quantity;
        private double[] Calories;
        public Recipe()
        {
            string[] Ingredient = new string[0];
            string[] Unit = new string[0];
            string[] Steps = new string[0];
            string[] Group = new string[0];
            double[] Quantity = new double[0];
            double[] Calories = new double[0];
        }
        public void CreateRecipe()
        {
            // Asks the user to enter the amount of ingredients required for the recipe and then Initialising the array with a size which is set according to the user Input
            Console.Write("Enter the total number of Ingredients: ");
            Console.WriteLine();
            Console.WriteLine();
            int Input1 = int.Parse(Console.ReadLine());
            Console.Clear();
            Ingredient = new string[Input1];
            Quantity = new double[Input1];
            Unit = new string[Input1];
            Calories = new double[Input1];
            Group = new string[Input1];

            //The loop ammount is set by the user above
            for (int i = 0; i < Input1; i++)
            {
                // Asks the user to enter the details of each ingredient
                Console.WriteLine($"Ingredient -> {i + 1}:");
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("Name of Ingredient: ");
                Console.WriteLine();
                Ingredient[i] = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Total Calories: (Unit of Energy)");
                Calories[i] = double.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.Write("How Much (Quantity)" );
                Console.WriteLine();
                Quantity[i] = double.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Unit of measurement: ( KG, G, TBBS,TSP, L, ML)");
                Console.WriteLine();
                Unit[i] = Console.ReadLine();
                Console.Clear();
                //Food Group
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
                        Console.Clear();
                        break;
                    case "2" or "two" or "TWO" or "Two":
                        Group[i] = "Fruits & Vegetables";
                        Console.Clear();
                        break;
                    case "3" or "three" or "THREE" or "Three":
                        Group[i] = "Chicken, fish, meat & Eggs";
                        Console.Clear();
                        break;
                    case "4" or "four" or "FOUR" or "Four":
                        Group[i] = "Milk & Dairy Products";
                        Console.Clear();
                        break;
                    case "5" or "five" or "FIVE" or "Five":
                        Group[i] = "Fats & Oils";
                        Console.Clear();
                        break;
                    case "6" or "six" or "SIX" or "Six":
                        Group[i] = "Dry Beans";
                        Console.Clear();
                        break;
                    case "7" or "seven" or "SEVEN" or "Seven":
                        Group[i] = "Water";
                        Console.Clear();
                        break;
                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Please choose a number from the list Below");
                        break;
                }

            }

            // Asks the user to identify the amount of steps in the recipe
            Console.Clear();
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
            Console.Clear();

        }
        public void Display() 
        {
            Console.WriteLine("------------------------------------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Ingredients:");
            Console.WriteLine("");
            for (int i = 0; i < Ingredient.Length; i++)
            {
                Console.WriteLine("");
                Console.WriteLine(i + 1 + $") {Quantity[i]} {Unit[i]} of {Ingredient[i]}");
                Console.WriteLine($"Calories = {Calories[i]}");
                Console.WriteLine("");
            }
            Console.WriteLine("------------------------------------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Total Calories:");
            Console.WriteLine("");
            double sum = 0;
            Array.ForEach(Calories, i => sum = sum + i);
            Console.WriteLine(sum);
            Console.WriteLine("");

            // Display the steps
            Console.WriteLine("------------------------------------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Steps:");
            Console.WriteLine("");
            for (int x = 0; x < Steps.Length; x++)
            {
                Console.WriteLine(x + 1 +$") {Steps[x]}");
                Console.WriteLine("");
            }
            Console.WriteLine("------------------------------------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Please Press Enter: ");
            Console.ReadLine();
            Console.WriteLine("------------------------------------------------------------------------------------");
            Console.Clear();
        }
        public void Scale(double factor)
        {
            // Multiply all the quantities by the scaling factor
            for (int i = 0; i < Quantity.Length; i++)
            {
                Quantity[i] *= factor;
            }
            Console.Clear();
        }
        public void Reset()
        {
            // Reset all the quantities back into their original values
            for (int h = 0; h < Quantity.Length; h++)
            {
                Quantity[h] /= 2;
            }
            Console.Clear();
        }
        public void Clear()
        {
            // Reset all the arrays to make them empty
            Ingredient = new string[0];
            Quantity = new double[0];
            Unit = new string[0];
            Steps = new string[0];
            Console.Clear();
        }
        public void myList() 
        {
                Console.Clear();
                Console.WriteLine("List of Ingredients");
                List<string> MyIngredients = new List<string>();
                MyIngredients.AddRange(Ingredient);
                foreach (string ing in MyIngredients)
                    Console.WriteLine(ing);
                Console.WriteLine();

                Console.WriteLine("List of Calories");
                List<double> CaloryList = new List<double>();
                CaloryList.AddRange(Calories);
                foreach (double cals in CaloryList)
                    Console.WriteLine(cals);
                Console.WriteLine();

                Console.WriteLine("List of Food Groups");
                List<string> MyFoodGroups = new List<string>();
                MyFoodGroups.AddRange(Group);
                foreach (string MFG in Group)
                    Console.WriteLine(MFG);
                Console.WriteLine();
            Console.ReadLine();
            Console.Clear();
        }
    }
}
