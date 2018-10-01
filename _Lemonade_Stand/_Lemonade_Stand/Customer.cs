using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Lemonade_Stand
{
    public class Customer
    {
        public Feeling feeling = new Feeling();
            public double BuyingChanceByPrice;
           public double price;
            public void BuyingChancesByPrice()
            {
                if (price <= 1 && price > 0.75)
                {
                    BuyingChanceByPrice = feeling.low;
                }
                else if (price < 0.74 && price > 0.5)
                {
                    BuyingChanceByPrice = feeling.medium;
                }
                else
                {
                    BuyingChanceByPrice = feeling.hight;
                }

            }
        


        
    }
    


     
}
