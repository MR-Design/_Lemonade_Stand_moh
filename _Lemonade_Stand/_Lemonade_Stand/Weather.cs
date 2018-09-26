using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Lemonade_Stand
{
    public class Weather
    {
        int Cold; int Cloudy; int Muggy; int Sunny;
        int todayWeather;

        private int GenerateDailyTemp()
        {
            Random random = new Random();
            int todayTemp = random.Next(50, 110);
            return todayTemp;  
        }

        private void GenerateDailyWeather()
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


    }
}
