using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Lemonade_Stand
{
    public class Inventory
    {
        public double lemons = 100/1000; public double sugar = 50 / 1000; public double iceCubes = 25 / 1000;
        double CostOfRecipe; int Nlemons; int Nsugar; int NiceCubes;

        public void GetCostOfRecipe()
        {
            CostOfRecipe = (Nlemons * lemons) + (Nsugar * sugar) + (NiceCubes * iceCubes);
        }

        public void MakeRecipe()
        {
            Console.WriteLine("Alright let's Make a New Recipe");

            Console.WriteLine("Enter How Many Lemens you Would Like");
            Nlemons = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter How Many Sugar you Would Like");
            Nsugar = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter How Many Lemens you Would Like");
            NiceCubes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Here's Your Recipe "+Nlemons+" lemons "+ Nsugar+" sugar And  "  +NiceCubes+ " iceCubes");


        }

    }
}
