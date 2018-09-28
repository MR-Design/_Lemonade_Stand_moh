using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Lemonade_Stand
{
    class Player
    {
        public Inventory inventory = new Inventory();

        int Lemons = 4; int Sugar = 4; int IceCubes = 4;
        public double PerCupPrice;
        public double todaySalles =0;
        





            public void SetInventory(Day day)
            {
                Console.WriteLine(" You Have " + inventory.Numlemons + " : Lemons" +
                inventory.NumSugar + " : Sugars" + inventory.NumiceCubes + " : Ice Cubes" + inventory.NumCups + " :  Cups");
                Console.WriteLine(" You Have " + "$ "+inventory.Wallet);
                Console.WriteLine(" Press any Key To Get More Inventories");
                Console.ReadKey();

                inventory.GetInventory();
                inventory.PlayerCanBuyOrNoAndMAkeRecipe();
                day.TodaysInfo(inventory);
            }

        

        
            public void SetRecipe()
            {
                Console.WriteLine("Your Curent Recipe Is Basic" + Lemons + " : Lemons" + Sugar + " : Sugars" + IceCubes + " : Ice Cubes");
                Console.WriteLine("You Have a Basic Lemonade Recipe : Tape [YES] If you Like To Make a New Reicipe!!");
                string CustomRecipe = Console.ReadLine();
                Console.WriteLine(CustomRecipe.ToUpper());

                if (CustomRecipe == "YES" || inventory.Wallet >= inventory.InventoryCost)// I shoud Check if Player Has enought Inventory.
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
                    Console.WriteLine("Please Set Your Price Per Cup Choose Between  [ (0.00) To (1) ]");
                    PerCupPrice = Convert.ToDouble(Console.ReadLine());
            }
            

            public void Salles()
            {

            // Salles = PerCupPrice * TodaySalles

            }

            public void TodaySalles(Weather weather, Customer customer, Feeling feeling)
            {
                    Random customers = new Random();


            if (weather.todayWeather == 1 && weather.todayTemp < 60 && customer.BuyingChanceByPrice == feeling.low)
            {
                todaySalles = customers.Next(0, 20); 
            }
            else if (weather.todayWeather == 2 && weather.todayTemp < 75 && customer.BuyingChanceByPrice == feeling.medium)
            {
                todaySalles = customers.Next(20, 50); 
            }
            else if (weather.todayWeather == 3 && weather.todayTemp < 90 && customer.BuyingChanceByPrice == feeling.hight)
            {
                todaySalles = customers.Next(50, 150); 
            }
            else if (weather.todayWeather > 3 && weather.todayTemp > 90 && customer.BuyingChanceByPrice == feeling.hight)
                    {
                        todaySalles = customers.Next(150, 200); 
                    }
            return ;

        }
  
    }

}
