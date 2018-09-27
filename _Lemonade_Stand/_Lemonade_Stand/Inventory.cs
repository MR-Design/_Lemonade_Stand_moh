using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 
using System.Threading.Tasks;

namespace _Lemonade_Stand
{
    public class Inventory
    {
        public double Plemons = 100/1000; public double Psugar = 50 / 1000;
        public double PiceCubes = 25 / 1000; public double Pcups = 20 / 1000;
        double CostOfRecipe; int Nlemons; int Nsugar; int NiceCubes; int Ncups;
        double InventoryCost;



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
        public void GetCostOfRecipe()
        {
            CostOfRecipe = (Nlemons * Plemons) + (Nsugar * Psugar) + (NiceCubes * PiceCubes);
        }

        public void GetInventoryCost()
        {
            InventoryCost = CostOfRecipe + (Pcups * Ncups);
        }


    }
}
