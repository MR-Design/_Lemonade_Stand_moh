﻿using System;
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
        public int Numlemons;
        public int NumSugar;
        public int NumiceCubes;
        public int NumCups;
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

            Console.WriteLine("Enter How Many Lemens you Would Like .. NOTE!! Will Cost You $"+ Picelemons);
            nNlemons = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter How Many Sugar you Would Like.. NOTE!! Will Cost You $" + Picesugar);
            nNsugar = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter How Many Lemens you Would Like.. NOTE!! Will Cost You $" + PiceCubes);
            nNiceCubes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter How Many Cuop you Would Like.. NOTE!! Will Cost You $" + Picecups);
            nNcups = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("You Have " + Numlemons + " Lemons " + NumSugar +
                " Sugar And  " + NumiceCubes + " IceCubes" + NumCups + " Cups");

            Numlemons += nNlemons;
            NumSugar += nNlemons;
            NumiceCubes += nNlemons;
            NumCups += nNlemons;

        }


        public void CurrentInvetories()
        {
            CurrentInvetory += (Numlemons) + (NumSugar) + (NumiceCubes) + (NumCups);
        }

        public void GetInventoryCost()
        {
            InventoryCost += (Numlemons * Picelemons) + (NumSugar * Picesugar) + (NumiceCubes * PiceCubes) + (NumCups * Picecups);
        }
     
        public void PlayerWallet()
        {
            Wallet -= InventoryCost;
        }

        public void PlayerCanBuyOrNoAndMAkeRecipe()
        {
            if (Wallet < 0)
            {
                Console.WriteLine("Sorry You Don't have Money !! Start The Game Gain");
// I need Function to Start Game Agan from Scratch.... Try !! Catch
            }
            else if (Wallet <= InventoryCost)
            {
                Console.WriteLine("Sorry You Don't have enought Money :( You Are Short "+Wallet +" $ /n Try To Bay Less Inventories");
                GetInventory();
            }
            else
            {
                Console.WriteLine(" You Still Have " + "$ " + Wallet);
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
