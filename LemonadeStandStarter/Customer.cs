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
        int name;
        int conditionBuyerNumber;
        int tempBuyerNumber;
        int priceBuyerNumber;
        double buyerNumber;
        int totalNumberofBuyers;





        List<int> names = new List<int>();
        //Constructor
        public Customer()
        {

            totalNumberofBuyers = 0;
            name = 0;
        }

        //Methods
        
        public int GetConditionBuyerNumber(Weather weather)
        {
            if (weather.condition == "rainy")
            {
                int rng = new Random().Next(1, 6);
                conditionBuyerNumber = rng;
            }
            else if (weather.condition == "overcast")
            {
                int rng = new Random().Next(6, 11);
                conditionBuyerNumber = rng;
            }
            else
            {
                int rng = new Random().Next(11, 16);
                conditionBuyerNumber = rng;
            }
            return conditionBuyerNumber;
        }
        public int GetTempBuyerNumber(Weather weather)
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
            return tempBuyerNumber;
        }
        public void SellPriceBuyerNumber(Recipe cupPrice)
        {
            if (cupPrice.pricePerCup < .35)
            {
                int rng = new Random().Next(11,16);
                priceBuyerNumber = rng;
            }
            else if (cupPrice.pricePerCup > .35 && cupPrice.pricePerCup < .45)
            {
                int rng = new Random().Next(6,11);
                priceBuyerNumber = rng;
            }
            else
            {
                int rng = new Random().Next(1,6);
                priceBuyerNumber = rng;
            }

            // return priceBuyerNumber;
        }
        public double BuyerNumber()
        {
            buyerNumber = (conditionBuyerNumber + tempBuyerNumber + priceBuyerNumber) / 3;
            return buyerNumber;
        }

        public void RunBuyerDay(Weather weather, Recipe recipe)
        {

            for (int i = 0; i < 100; i++)
            {
                names.Add(name);
                GetConditionBuyerNumber(weather);
                GetTempBuyerNumber(weather);
                SellPriceBuyerNumber(recipe);
                BuyerNumber();
                
                if (buyerNumber>= 7.5)
                {
                    totalNumberofBuyers++;
                }
                    
                Console.WriteLine(totalNumberofBuyers);
                Console.ReadLine();
            }
            

        }

    }
}



