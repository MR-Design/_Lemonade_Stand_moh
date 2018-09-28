using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Lemonade_Stand
{
    public class Weather
    {
         int Cold;
         int Cloudy;
        int Muggy;
        int Sunny;
         int todayWeather;
        int todayTemp;
        int todayForecast;

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
                todayWeather = Cold;
            }
            else if (todayWeather == 2)
            {
                todayWeather = Cloudy;
            }
            else if (todayWeather == 3)
            {
                todayWeather = Muggy;
            }
            else
            {
                todayWeather = Sunny;
            }
        }

        public void TodayForecast()
        {
            string todayForecast = (todayTemp + todayWeather).ToString();
            Console.WriteLine("Today's Forecast :"+ todayTemp +"Degrees and It's a "+ todayWeather+ " Day");


        }
    }
}
