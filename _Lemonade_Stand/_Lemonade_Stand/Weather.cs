using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Lemonade_Stand
{
    public class Weather
    {
        public double  todayWeather;
        public double todayTemp;
        public  string  todayForecast;

        public  void  GenerateDailyTemp()
        {
            Random random = new Random();
            todayTemp = random.Next(50, 110);            
        }

        public void GenerateDailyWeather()
        {
            Random random = new Random();
            todayWeather = random.Next(1, 4);
            if (todayWeather == 1)
            {
               todayForecast = "Cold";
            }
            else if (todayWeather == 2)
            {
                todayForecast = "Cloudy";

            }
            else if (todayWeather == 3)
            {
                todayForecast = "Sunny";
            }
            else
            {
                todayForecast = "Muggy";
            }
            return;
        }
        public void TodayForecast()
        {
            GenerateDailyWeather();
            GenerateDailyTemp();
            Console.WriteLine("Today's Forecast :" + todayTemp  + " Degrees and It's a " + todayForecast + " Day");
            Console.ReadLine();
        }
    }
}
