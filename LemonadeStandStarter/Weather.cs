using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    public class Weather 
    {
        
        //Variables
        public string condition;
        public int temperature;
        List<string> weatherConditionList;
        List<int> temperatureList;
        public Random rnd;
        public Random rnd2;

        //Constructor
        public Weather()
        {

            rnd = new Random();
            rnd2 = new Random();
            
            weatherConditionList = new List<string> { "rainy", "overcast", "sunny" };
            temperatureList = new List<int> { 70, 80, 90};

            



        }

        //Methods

        public void GetTemperature(Random rnd)
        {
            int randomTemperatureNumber = rnd.Next(0, 2);
            temperature = temperatureList[randomTemperatureNumber];

        }
        public void GetCondition(Random rnd2)
        {
            int randomWeatherNumber = rnd2.Next(0, 2);
            condition = weatherConditionList[randomWeatherNumber];
        }

        //Display Current day's forecast
        public void DisplayCondition()
        {
            Console.WriteLine("Today's condition forecast is:     " +condition);
            Console.WriteLine("Today's temperature forecast is:   " +temperature);
        }


       


    }
}
