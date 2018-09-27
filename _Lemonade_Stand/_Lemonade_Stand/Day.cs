using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Lemonade_Stand
{
    class Day
    {
        Weather weather = new Weather();
        Inventory inventory = new Inventory();

        public void TodaysInfo()
        {
            Console.WriteLine(" Reminder !!! You Have  " + "$ " + inventory.Wallet);
            weather.TodayForecast();
        }
    }
}
