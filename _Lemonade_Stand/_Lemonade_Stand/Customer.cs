using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Lemonade_Stand
{
    class Customer
    {
        double hight; double medium; double low;
        double CustomerBuyingChance;


        public void BuyingChanceProperties()
        {
            Random random = new Random();

            double hight = random.Next((90 / 100), 1);
            double medium = random.Next((50 / 100), (90 / 100));
            double low = random.Next(0, (50 / 100));
        }

        public double CustomersBuyingChance(double inAHurry, double thirsty, double notThursty)
        {
            if (CustomerBuyingChance == inAHurry)
            {
                CustomerBuyingChance = medium;
            }
            else if (CustomerBuyingChance == thirsty)
            {
                CustomerBuyingChance = hight;
            }
            else
            {
                CustomerBuyingChance = low;

            }

            return CustomerBuyingChance;
        }
    }
}
