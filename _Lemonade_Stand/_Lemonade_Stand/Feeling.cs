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
        public int BuyingChanceByFeeling;
        public double GenerateBuyingChanceByFeeling;
        //public double inAHurry;
        //public double thirsty;
        //public double notThursty;


        public void BuyingChanceFeelingProperties()
        {


            GenerateBuyingChanceByFeeling = random.Next(1, 3);
           
        }

        public void BuyingChancesByFeeling()
        {
            BuyingChanceFeelingProperties();
            if (GenerateBuyingChanceByFeeling ==1)
            {
                BuyingChanceByFeeling = random.Next(0, 20);
            }
            else if (GenerateBuyingChanceByFeeling == 2)
            {
                BuyingChanceByFeeling = random.Next(20, 50); 
            }
            else if (GenerateBuyingChanceByFeeling == 3)
            {
                BuyingChanceByFeeling = random.Next(50, 100);

            }

            Console.WriteLine("customer feeling   = " + BuyingChanceByFeeling);
            Console.ReadLine();
            //return BuyingChanceByFeeling;
        }
    }
}
