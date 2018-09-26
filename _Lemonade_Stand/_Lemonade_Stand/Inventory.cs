using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Lemonade_Stand
{
    public class Inventory
    {
        //   I want the basic Lemonade Stand gameplay to be present
        //  double Wallet = 20.00;
        //  int Lemons = 0; int Sugar = 0; int IceCubes = 0;


    
       //  the ability to make a recipe for my lemonade, 
      // so that I can include x-amount of lemons, x-amount of sugar, and x-amount of ice.
      public void SetRecipe(int lemons = 4, int sugar = 4, int iceCubes = 4)
        {
             Console.WriteLine("Your Curent Recipe Is Basic" + lemons + " : Lemons" + sugar + " : Sugars" + iceCubes + " : Ice Cubes");
             Console.WriteLine("You Have a Basic Lemonade Recipe : Tape [YES] If you Like To Make a New Reicipe!!");
             string CustomRecipe =Console.ReadLine();
             Console.WriteLine(CustomRecipe.ToUpper());

                if (CustomRecipe == "YES")
                {

                }




        }


    }
}
