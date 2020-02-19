using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Player 
    {
        // member variables (HAS A)

        public string name;   
        public Inventory inventory;
        public Wallet wallet;
        public Recipe recipe;
        public Pitcher pitcher;

        
        // constructor (SPAWNER)
        public Player()
        {

            recipe = new Recipe();
            name = "current player";
            inventory = new Inventory();
            wallet = new Wallet();
            pitcher = new Pitcher();
        }
        // member methods (CAN DO)




    }
}
