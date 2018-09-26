using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Lemonade_Stand
{
    public class Weather
    {
        int Cold; int Cloudy; int Mogy; int Sunny;
        public int GenerateDailyTemp()
        {
            Random random = new Random();
            int todayTemp = random.Next(50, 110);
            return todayTemp;
            
            
            
        }
        // Rainy , Suny , cloudy 
        public int GenerateDailyWeather()
        {
            Random random = new Random();
            int todayWeather = random.Next(0, 3);
            

            if (todayWeather == 0)
            {
                todayWeather = Cold;
            }
            else if (todayWeather == 1)
            {
                todayWeather = Cloudy;
            }

            else if (todayWeather == 2)
            {
                todayWeather = Mogy;
            }
            else
            {
                todayWeather = Sunny;
            }

            Console.WriteLine(" The Weather ToDay Is " + todayWeather);
            return todayWeather;
        }


    }
}
