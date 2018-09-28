using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Lemonade_Stand
{
    class Store
    {
        // member variable (HAS A)

        public void SellLemons(Player player)
        {

            player.inventory.Wallet -= 10;
        }

        public void SellSugar(Player player)
        {

            player.inventory.Wallet -= 10;
        }
    }
}
