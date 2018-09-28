using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Lemonade_Stand
{
    class Game
    {
        // member variables (HAS A)
        Player player;
        Store store;

        public Game()
        {
            player = new Player();
            store = new Store();
        }

        public void RunGame()
        {
            // do stuff
            // do more stuff
            store.SellLemons(player);
            // end day stuff
        }
    }
}
