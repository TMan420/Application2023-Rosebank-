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
        private double[] Quantity;
        private double[] Calories;
        private double[] Group;
        public Recipe() 
        {
            string[] Ingedient = new string[0];
            string[] Unit      = new string[0];
            string[] Steps     = new string[0];
            double[] Quantity  = new double[0];
            double[] Calories  = new double[0];
            double[] Group     = new double[0];
        }
        public void CreateRecipe()
        {
            // Asks the user to enter the amount of ingredients required for the recipe
            Console.Write("Enter the total number of Ingredients: ");
            int Input1 = int.Parse(Console.ReadLine());

            // Making the arrays fit with the correct size
            Ingedient = new string[Input1];
            Quantity = new double[Input1];
            Unit = new string[Input1];

            // Asks the user to enter the details of each ingredient
            for (int i = 0; i < Input1; i++)
            {
                Console.WriteLine($"Enter the details for ingredient #{i + 1}:");
                Console.Write("Name: ");
                Ingedient[i] = Console.ReadLine();
                Console.Write("Quantity: ");
                Quantity[i] = double.Parse(Console.ReadLine());
                Console.Write("Unit of measurement: ");
                Unit[i] = Console.ReadLine();
            }

            // Asks the user to identify the amount of steps in the recipe
            Console.Write("Enter the number of steps: ");
            int Input2 = int.Parse(Console.ReadLine());

            // Making the steps array fit with the correct size
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
