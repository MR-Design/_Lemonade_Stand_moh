using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Lemonade_Stand
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Game game = new Game();
            game.RunGame();

            Feeling feeling = new Feeling();

            //feeling.BuyingChancesByFeeling();
            //------ Testing  the  Feeling Stuff --------//




            //------ Testing  the  Salles per Day --------//
            //Player player = new Player();
            //Customer customer = new Customer();
            //Feeling feeling = new Feeling();
            //Day day = new Day();
            //customer.BuyingChancesByPrice();
            //day.weather.TodayForecast();
            //feeling.BuyingChanceFeelingProperties();
            //feeling.BuyingChancesByFeeling();


            //day.GetTodayNumberOfSalles(customer);//, feeling);



        }
    }
}
