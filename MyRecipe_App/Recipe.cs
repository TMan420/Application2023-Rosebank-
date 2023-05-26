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
        public Recipe() 
        {
            string[] Ingedient = new string[0];
            string[] Unit      = new string[0];
            string[] Steps     = new string[0];
            double[] Quantity  = new double[0];
            double[] Calories  = new double[0];
        }
        public void CreateRecipe() 
        {
            Console.WriteLine("My Recipe Class");
        }
    }
}
