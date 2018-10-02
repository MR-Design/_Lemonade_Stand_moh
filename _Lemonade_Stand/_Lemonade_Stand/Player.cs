using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Lemonade_Stand
{
    public class Player
    {
        public Inventory inventory = new Inventory();

        public int Lemons = 4; public int Sugar = 4; public int IceCubes = 4;
        public double PerCupPrice;
        public double profit;
        public double TodaySalles;







        public void SetInventory(Day day)
        {
            Console.WriteLine(" You Have " + inventory.Numlemons + ":Lemons " +
            inventory.NumSugar + ": Sugars  " + inventory.NumiceCubes +":Ice Cubes " + inventory.NumCups + ":Cups  In Your Inventory");
            Console.WriteLine(" Total Money You Have  " + "$ "+inventory.Wallet);
            Console.WriteLine(" Press any Key To Get More Inventories");
            Console.ReadKey();

            inventory.GetInventory();
            // Need To Tell Playyer How Much Money Left
            inventory.PlayerCanBuyOrNoAndMAkeRecipe();
            //day.TodaysInfo(inventory);
        }

        

        
        public void SetRecipe()
        {
            Console.WriteLine("Your Curent Recipe Is Basic" + Lemons + " : Lemons" + Sugar + " : Sugars" + IceCubes + " : Ice Cubes");
            Console.WriteLine("You Have a Basic Lemonade Recipe : Tape [YES] If you Like To Make a New Reicipe!!");
            string CustomRecipe = Console.ReadLine();
            Console.WriteLine(CustomRecipe.ToUpper());

            if (CustomRecipe == "YES" )// I shoud Check if Player Have enought Inventory to
            {
                inventory.MakeRecipe();
                
                
            }
            else
            {
            Console.WriteLine("Okay We Stick With the Basic Recipe " + Lemons + " : Lemons"
                + Sugar + " : Sugars" + IceCubes + " : Ice Cubes");
                    inventory.GetCostOfBasicRecipe();
            }
        }

        public void SetTodaysInfos(Day day)
        {
                day.TodaysInfo(inventory);
        }

     
        public void SetPrice()  
       {
            
            
                Console.WriteLine("Please Set Your Price Per Cup Choose Between  [ ($0.00) To ($1.00) ]");
                PerCupPrice = Convert.ToDouble(Console.ReadLine());
                if (PerCupPrice <= 1)
                {
                    Console.WriteLine("your Price for today  $" + PerCupPrice);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("SORRY !! INVALID INPUT... Try Another Price.");
                    Console.ReadLine();
                    SetPrice();
                }
            
      
            
           
        }
            

        public void MoneyMadeToday( Day day)
        {
           // inventory.PlayerWallet();

            TodaySalles += day.todaySalles * PerCupPrice;
            inventory.Wallet += TodaySalles;
          
            Console.WriteLine("You Made On Salles $" + TodaySalles);
            Console.WriteLine("Here Your New Wallet $" + inventory.Wallet);
          

            Console.ReadLine();

          
        }

        public void GetProfit()
        {
            profit = (inventory.Wallet) - inventory.InventoryCost;
            Console.WriteLine("Your Total Profit  is  $"+ profit);
            Console.ReadLine();
            
        }

    }

}
