using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Customer
    {
        //Variables
        string name;
        int conditionBuyerNumber;
        int tempBuyerNumber;





        List<string> names = new List<string>();
        //Constructor
       

        
        public Customer()
        {

            AddNamesToList();



        }

        //Methods
        
        //Add 100 names to list.  This is the potential number of customers
        public void AddNamesToList()
        {
            for (int i = 0; i < 100; i++)
            {
                
                names.Add(name);
            }

        }
        public void GetConditionBuyerNumber(Weather weather)
        {
            if (weather.condition == "rain")
            {
                int rng = new Random().Next(1, 6);
                conditionBuyerNumber = rng;
            }
            else if(weather.condition == "overcast")
            {
                int rng = new Random().Next(6, 11);
                conditionBuyerNumber = rng;
            }
            else
            {
                int rng = new Random().Next(11, 16);
                conditionBuyerNumber = rng;
            }
        }
        public void GetTempBuyerNumber(Weather weather)
        {
            if (weather.temperature == 70)
            {
                int rng = new Random().Next(1, 6);
                tempBuyerNumber = rng;
            }
            else if (weather.temperature == 80)
            {
                int rng = new Random().Next(6, 11);
                tempBuyerNumber = rng;
            }
            else
            {
                int rng = new Random().Next(11, 16);
                tempBuyerNumber = rng;
            }
        }
        public void SellPriceBuyerNumber(Recipe cupPrice)
        {
            if (recipe.pricePerCup == 70)
            {
                int rng = new Random().Next(1, 6);
                tempBuyerNumber = rng;
            }
            else if (weather.temperature == 80)
            {
                int rng = new Random().Next(6, 11);
                tempBuyerNumber = rng;
            }
            else
            {
                int rng = new Random().Next(11, 16);
                tempBuyerNumber = rng;
            }


        }
    
}



