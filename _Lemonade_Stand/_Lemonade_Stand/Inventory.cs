using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 
using System.Threading.Tasks;

namespace _Lemonade_Stand
{
    public class Inventory  
    {
        // Player player = new Player();

        public double Picelemons = 0.1;
        public double Picesugar = 0.05;
        public double PiceCubes = 0.02;
        public double Picecups = 0.02;
        public double CostOfBasicRecipe ;
        public int Numlemons =0;
        public int NumSugar =0;
        public int NumiceCubes=0;
        public int NumCups=0;
        public int nNlemons;
        public int nNsugar;
        public int nNiceCubes;
        public int nNcups;
        public double InventoryCost; 
        public double Wallet = 20.00;
        public double CurrentInvetory = 0;

 //        I want the basic Lemonade Stand gameplay to be present

        public void GetInventory()
        {

            Console.WriteLine("Enter How Many Lemens you Would Like .. !!  Cost  $"+ Picelemons);
            nNlemons = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter How Many Sugar you Would Like.. !!  Cost  $" + Picesugar);
            nNsugar = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter How Many Ice Cubes you Would Like.. !!  Cost  $" + PiceCubes);
            nNiceCubes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter How Many Cups you Would Like.. !!  Cost  $" + Picecups);
            nNcups = Convert.ToInt32(Console.ReadLine());

            

            Numlemons += nNlemons;
            NumSugar += nNsugar;
            NumiceCubes += nNiceCubes;
            NumCups += nNcups;

            Console.WriteLine("You Bought  "+Numlemons+"Lemons " + NumSugar+
                "Sugar And  "+NumiceCubes+"IceCubes "+NumCups+" Cups");
            GetInventoryCost();
            PlayerWallet();
        }


        public void CurrentInvetories()
        {
            CurrentInvetory += (Numlemons) + (NumSugar) + (NumiceCubes) + (NumCups);
        }

        public void GetInventoryCost()
        {
            InventoryCost += (Numlemons * Picelemons) + (NumSugar * Picesugar) + (NumiceCubes * PiceCubes) + (NumCups * Picecups);
            Console.WriteLine("Your Inventory Cost =  $" + InventoryCost);
        }

        public void PlayerWallet()
        {
            Wallet -= InventoryCost;
            Console.WriteLine("Money Left In Your Wallet $" + Wallet);
        }

        public void PlayerCanBuyOrNoAndMAkeRecipe()
        {
            if (Wallet < 0)
            {
                Console.WriteLine("Sorry You Don't have Money !! Maybe you wanna Start The Game Again?");
// I need Function to Start Game Agan from Scratch.... Try !! Catch
            }
            else if (Wallet <= InventoryCost)
            {
                Console.WriteLine("Sorry You Don't have enought Money :( You Are Short "+Wallet +" $ /n Try To Bay Less Inventories");
                GetInventory();
            }
            else
            {
          //      Console.WriteLine(" You Still Have " + "$ " + Wallet);
            }
        }
        

        public void MakeRecipe()
        {
            Console.WriteLine("Alright let's Make a New Recipe");

            Console.WriteLine("Enter How Many Lemens you Would Like");
            Numlemons = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter How Many Sugar you Would Like");
            NumSugar = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter How Many Lemens you Would Like");
            NumiceCubes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Here's Your Recipe "+Numlemons+" lemons "+ NumSugar+" sugar And  "  +NumiceCubes+ " iceCubes");
        }

        public void DontMakeRecipe()
        {

        }
        public void GetCostOfBasicRecipe()
        {
            CostOfBasicRecipe += (4 * Picelemons) + (4 * Picesugar) + (4 * PiceCubes) + (4 * Picecups);

        }

        


    }
}
