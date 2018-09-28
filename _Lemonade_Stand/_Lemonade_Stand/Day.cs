using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Lemonade_Stand
{
    public class Day
    {
        Weather weather = new Weather();
        public double todaySalles = 0;
        public void TodaysInfo(Inventory inventory)
        {
            Console.WriteLine(" Reminder !!! You Have  " + "$ " + inventory.Wallet);
            weather.TodayForecast();
        }

        public void GetTodayNumberOfSalles(Customer customer, Feeling feeling)
        {
            Random customers = new Random();


            if (weather.todayWeather == 1 && weather.todayTemp < 60 && customer.BuyingChanceByPrice == feeling.low)
            {
                todaySalles += customers.Next(0, 20);
            }
            else if (weather.todayWeather == 2 && weather.todayTemp < 75 && customer.BuyingChanceByPrice == feeling.medium)
            {
                todaySalles += customers.Next(20, 50);
            }
            else if (weather.todayWeather == 3 && weather.todayTemp < 90 && customer.BuyingChanceByPrice == feeling.hight)
            {
                todaySalles += customers.Next(50, 150);
            }
            else if (weather.todayWeather > 3 && weather.todayTemp > 90 && customer.BuyingChanceByPrice == feeling.hight)
            {
                todaySalles += customers.Next(150, 200);
            }

            return;
        }
    }
}
