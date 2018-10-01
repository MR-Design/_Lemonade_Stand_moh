using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Lemonade_Stand
{
    public class Game
    {
        public int GameDay =1;
        public int GameRotation;
        public string Restart;
        // member variables (HAS A)
        public Player player = new Player();
        // public Weather weather = new Weather();
        public Day day = new Day();
        public Customer customer = new Customer();
        public Feeling feeling = new Feeling();
        // public Inventory inventory = new Inventory()

        public void RotateGame()
        {
            Console.WriteLine(" Press any Number To Play An Other Day ");
            GameDay = Convert.ToInt32(Console.ReadLine());
            GameRotation = GameDay++;
            if (GameDay < 8)
            {
                RunGame();
            } 
            else
            {
                
                Console.WriteLine(" The Week Is Ended And Here Is your ToTal Profit  $"+ player.profit);
                Console.ReadLine();
                Console.WriteLine(" Press 'S' To Start a new Game ");
                Console.WriteLine(Restart.ToUpper());
                 Restart = Console.ReadLine();
                if (Restart == "S")
                {
                    //  Run a New Game Here
                }
            }
        }

        public void RunGame()
        {
            player.SetInventory(day);
            player.SetRecipe();
            player.SetTodaysInfos(day);
            player.SetPrice();
            day.GetTodayNumberOfSalles(customer, feeling);
            player.MoneyMadeToday(day);
            player.GetProfit();
            RotateGame();
        }
    }
}
