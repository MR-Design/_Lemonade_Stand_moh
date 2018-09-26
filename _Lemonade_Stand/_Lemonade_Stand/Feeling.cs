using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Lemonade_Stand
{
    public class Feeling
    {
        public double hight; public double medium; public double low;
        double BuyingChanceByFeeling;


        public void BuyingChanceFeelingProperties()
        {
            Random random = new Random();

            double hight = random.Next((90 / 100), 1);
            double medium = random.Next((50 / 100), (90 / 100));
            double low = random.Next(0, (50 / 100));
        }

        private double BuyingChancesByFeeling(double inAHurry, double thirsty, double notThursty)
        {
            if (BuyingChanceByFeeling == inAHurry)
            {
                BuyingChanceByFeeling = medium;
            }
            else if (BuyingChanceByFeeling == thirsty)
            {
                BuyingChanceByFeeling = hight;
            }
            else
            {
                BuyingChanceByFeeling = low;

            }

            return BuyingChanceByFeeling;
        }
    }
}
