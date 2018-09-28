using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Lemonade_Stand
{
    public class Game
    {
        // member variables (HAS A)
        public Player player = new Player();
        // public Weather weather = new Weather();
        public Day day = new Day();
        //public Customer customer = new Customer();
        // public Feeling feeling = new Feeling();
        // public Inventory inventory = new Inventory()



        public void RunGame()
        {
            player.SetInventory(day);
            player.SetRecipe();
            player.SetTodaysInfos(day);
            player.SetPrice();
            player.MoneyMadeToday(day);
            player.GetProfit();
        }
    }
}
