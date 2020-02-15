using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    abstract class Item
    {
        // member variables (HAS A)

        public string name;
        public List<string> names;

        // constructor (SPAWNER)
        static Item()
        {
           

        }
        public Item()
        {
            names = new List<string> { "lemon", "sugarCube", "IceCube", "cup", };
        }

        // member methods (CAN DO)

        public abstract string chooseName();
    }
}
