using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Game Game = new Game();
            //Game.runGame();

            Player player = new Player();
            Customer customer = new Customer();
            Weather weather = new Weather();
            Recipe recipe = new Recipe();

            recipe.pricePerCup = .5;

            Store store = new Store();

            store.SellLemons(player);
           
            Console.ReadLine();
        }
    }
}
