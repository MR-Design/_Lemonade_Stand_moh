using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Lemonade_Stand
{
    class Customer
    {
        public class Prices : Feeling
        {
            double BuyingChanceByPrice;
            double price;
            public void BuyingChancesByPrice()
            {
                if (price <= 1 && price > 75 / 100)
                {
                    BuyingChanceByPrice = low;
                }
                else if (price < 74 / 100 && price > 50 / 100)
                {
                    BuyingChanceByPrice = medium;
                }
                else
                {
                    BuyingChanceByPrice = hight;
                }

            }
        }


        
    }
    


     
}
