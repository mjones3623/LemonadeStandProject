using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Weather
    {
        
        //Variables
        public string weatherCondition;
        int temperature;
        List<string> weatherConditionList;
        List<int> temperatureList;

        //Constructor
        public Weather()
        {
            weatherCondition = "sunny";
            temperature = 90;
            weatherConditionList = new List<string> { "rainy", "overcast", "sunny" };
            temperatureList = new List<int> { 70, 80, 90, 100 };
            
        //Methods
        }
        public void randomWeatherCondition()
        {
            int randomWeatherNumber = new Random().Next(0,2);
            weatherCondition = weatherConditionList[randomWeatherNumber];
        }
        public void randomTemperature()
        {
            int randomTemperatureNumber = new Random().Next(0,3);
            temperature = temperatureList[randomTemperatureNumber];
        }

    }
}
