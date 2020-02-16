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

        //Constructor
        public Weather()
        {
                    
                     
            weatherConditionList = new List<string> { "rainy", "overcast", "sunny" };
            temperatureList = new List<int> { 70, 80, 90, 100 };

            GetTemperature();
            GetCondition();



        }

        //Methods

        public void GetTemperature()
        {
            int randomTemperatureNumber = new Random().Next(0, 3);
            temperature = temperatureList[randomTemperatureNumber];

        }
        public void GetCondition()
        {
            int randomWeatherNumber = new Random().Next(0, 2);
            condition = weatherConditionList[randomWeatherNumber];
        }



       


    }
}
