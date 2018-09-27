using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Lemonade_Stand
{
    class Player
    {
        Inventory inventory = new Inventory();
  
      

            public void SetInventory()
            {
                Console.WriteLine(" You Have " + inventory.Numlemons + " : Lemons" +
                inventory.NumSugar + " : Sugars" + inventory.NumiceCubes + " : Ice Cubes" + inventory.NumCups + " :  Cups");
                Console.WriteLine(" You Have " + "$ "+inventory.Wallet);
                Console.WriteLine(" Press any Key To Get More Inventories");
                Console.ReadKey();

                inventory.GetInventory();
                inventory.PlayerCanBuyOrNo();
            }


        // I Need to Shpw User The Money he have , The Weather  then He decide how Much he wanna sel


        //  the ability to make a recipe for my lemonade, 
        // so that I can include x-amount of lemons, x-amount of sugar, and x-amount of ice.
        int lemons = 4;  int sugar = 4;  int iceCubes = 4;
        public void SetRecipe()
        {
            Console.WriteLine("Your Curent Recipe Is Basic" + lemons + " : Lemons" + sugar + " : Sugars" + iceCubes + " : Ice Cubes");
            Console.WriteLine("You Have a Basic Lemonade Recipe : Tape [YES] If you Like To Make a New Reicipe!!");
            string CustomRecipe = Console.ReadLine();
            Console.WriteLine(CustomRecipe.ToUpper());

            if (CustomRecipe == "YES")
            {
                // Function MakeRecipe.
                inventory.MakeRecipe();
            }
            else
            {
                // Break statement
                return;
            }



        }
    }
}
