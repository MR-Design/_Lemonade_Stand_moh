using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Lemonade_Stand
{
    class Player
    {
        int Lemons = 4; int Sugar = 4; int IceCubes = 4;
        Inventory inventory = new Inventory();
        Day day = new Day();
  
      

            public void SetInventory()
            {
                Console.WriteLine(" You Have " + inventory.Numlemons + " : Lemons" +
                inventory.NumSugar + " : Sugars" + inventory.NumiceCubes + " : Ice Cubes" + inventory.NumCups + " :  Cups");
                Console.WriteLine(" You Have " + "$ "+inventory.Wallet);
                Console.WriteLine(" Press any Key To Get More Inventories");
                Console.ReadKey();

                inventory.GetInventory();
                inventory.PlayerCanBuyOrNo();
                day.TodaysInfo();
            }

        

        
            public void SetRecipe()
            {
                Console.WriteLine("Your Curent Recipe Is Basic" + Lemons + " : Lemons" + Sugar + " : Sugars" + IceCubes + " : Ice Cubes");
                Console.WriteLine("You Have a Basic Lemonade Recipe : Tape [YES] If you Like To Make a New Reicipe!!");
                string CustomRecipe = Console.ReadLine();
                Console.WriteLine(CustomRecipe.ToUpper());

                if (CustomRecipe == "YES")
                {
                    inventory.MakeRecipe();
                }
                else
                {
                    // Break statement
                }



             }

            public void SetTodaysInfos()
            {
                 day.TodaysInfo();
            }


        public int PerCupPrice;
            public void SetPrice()
            {
                    Console.WriteLine("Please Set Your Price Per Cup Choose Between  [ (0) To (1) ]");
                    PerCupPrice = Convert.ToInt32(Console.ReadLine());


        }
    }
}
