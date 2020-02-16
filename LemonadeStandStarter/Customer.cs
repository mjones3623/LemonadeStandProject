using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Customer
    {
        


        List<int> names = new List<int>();

        public Customer()
        {

            AddNamesToList();



        }
        public void AddNamesToList()
        {
            for (int i = 0; i < 100; i++)
            {
                
                names.Add(i);
            }

        }


    }
    
}



