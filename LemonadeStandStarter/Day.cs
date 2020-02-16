using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Day
    {
        //Variables
        public Weather weather;
        public List<Customer> customers;

        //Constructor

        public Day()
        {
            NewWeatherDay();
            
        }


        //Methods

        public void NewWeatherDay()
        {
            weather = new Weather();

        }
        public void AddCustomersToList()
        {
            
        }




    }
}
