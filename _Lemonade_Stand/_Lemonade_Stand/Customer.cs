using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Lemonade_Stand
{
    class Customer
    {
         string hight;  string medium;  string low;
        string CustomerBuyingChance;

        public string CustomersBuyingChance(string inAHurry, string thirsty, string notThursty)
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
