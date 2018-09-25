using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Lemonade_Stand
{
    public class Weather
    {

        public int GenerateDailyForcast()
        {
            Random random = new Random();
            int todayWeather = random.Next(50, 100);
            return todayWeather;
        }
    }
}
