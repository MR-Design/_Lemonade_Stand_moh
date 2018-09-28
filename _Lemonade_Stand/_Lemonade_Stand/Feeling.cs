using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Lemonade_Stand
{
    public class Feeling
    {
        Random random = new Random();
        public double hight; public double medium; public double low;
        public  double BuyingChanceByFeeling;
        public double inAHurry;
        public double thirsty;
        public double notThursty;


        public void BuyingChanceFeelingProperties()
        {
            

             hight = random.Next((90 / 100), 1);
             medium = random.Next((50 / 100), (90 / 100));
             low = random.Next(0, (50 / 100));
        }

        public double BuyingChancesByFeeling()
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
