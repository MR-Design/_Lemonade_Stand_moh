using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Lemonade_Stand
{
    public class Day
    {


        public Weather weather = new Weather();
        public int todaySalles;
        public void TodaysInfo(Inventory inventory)
        {
            //Console.WriteLine(" Reminder !!! You Have  " + "$ " + inventory.Wallet);
            weather.TodayForecast();
        }

        public void GetTodayNumberOfSalles(Customer customer, Feeling feeling)
        {
            feeling.BuyingChancesByFeeling();

            Random customers = new Random();


            if (weather.todayForecast == "Cold" && weather.todayTemp < 60 && feeling.BuyingChanceByFeeling <20)//&& customer.BuyingChanceByPrice == feeling.low)
            {
                todaySalles += customers.Next(0, 20);
            }
            else if (weather.todayForecast == "Cloudy"|| weather.todayForecast == "Muggy"|| weather.todayForecast == "Sunny"
                && weather.todayTemp < 75 && feeling.BuyingChanceByFeeling <49) //&& customer.BuyingChanceByPrice == feeling.medium)
            {
                todaySalles += customers.Next(20, 50);
            }
            else if (weather.todayForecast == "Muggy" && weather.todayTemp < 90 && feeling.BuyingChanceByFeeling <49) //&& customer.BuyingChanceByPrice == feeling.hight)
            {
                todaySalles += customers.Next(50, 150);
            }
            else if (weather.todayForecast == "Sunny"|| weather.todayForecast == "Muggy" && weather.todayTemp > 90 && feeling.BuyingChanceByFeeling >20) //&& customer.BuyingChanceByPrice == feeling.hight)
            {
                todaySalles += customers.Next(150, 200);
            }

            //return;
            Console.WriteLine("Your Number Of Salles Today  =" + todaySalles);
            Console.ReadLine();

        }

        public void getDay()
        {

        } 
    }
}

