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
        
        int conditionBuyerNumber;
        int tempBuyerNumber;
        int priceBuyerNumber;
        double buyerNumber;
        public int totalNumberofBuyers;
        

        List<string> names = new List<string>();
        //Constructor
        public Customer()
        {

            totalNumberofBuyers = 0;
           
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
            else   //is sunny
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
            else //temp is 90
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

        public void RunBuyerDay(Weather weather, Player player)
        {
            for (int i = 0; i < 100; i++)
            {
                names.Add("buyer");
            }
            //Open/Closed Principle is used here.  This function is open to extension in that the names list can change, but is closed to modification.
            for (int i = 0; i < names.Count(); i++)
            {
                
                GetConditionBuyerNumber(weather);
                GetTempBuyerNumber(weather);
                SellPriceBuyerNumber(player.recipe);
                BuyerNumber();
                
                if (buyerNumber>= 5 && player.pitcher.cupsLeftInPitcher > 0 && player.inventory.cups.Count() > 1 && player.inventory.lemons.Count() > player.recipe.amountOfLemons && player.inventory.sugarCubes.Count() > player.recipe.amountOfSugarCubes && player.inventory.iceCubes.Count() > player.recipe.amountOfIceCubes)
                {
                    
                    
                    Console.WriteLine(names[i]+ " is a buyer");
                    player.wallet.AddMoneyForSale(player.recipe);
                    totalNumberofBuyers++;
                    player.pitcher.cupsLeftInPitcher--;
                    if(player.pitcher.cupsLeftInPitcher == 0)
                    {
                        if (player.inventory.lemons.Count() >= player.recipe.amountOfLemons)
                        {
                            player.inventory.lemons.RemoveRange(0, player.recipe.amountOfLemons);

                            if (player.inventory.lemons.Count() < player.recipe.amountOfLemons)
                            {
                                Console.WriteLine("Your lemons have been depleted for the day.  This day of selling is over.  You must replentish if you have enough in your wallet.");
                            }

                        }
                        else
                        {
                            Console.WriteLine("Your lemons have been depleted for the day.  This day of selling is over.");
                            
                        }
                        if (player.inventory.sugarCubes.Count() >= player.recipe.amountOfSugarCubes)
                        {
                            player.inventory.sugarCubes.RemoveRange(0, player.recipe.amountOfSugarCubes);

                            if (player.inventory.sugarCubes.Count() < player.recipe.amountOfSugarCubes)
                            {
                                Console.WriteLine("Your sugar cubes have been depleted for the day.  This day of selling is over.  You must replentish if you have enough in your wallet.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Your sugar cubes have been depleted for the day.  This day of selling is over.");
                            
                        }
                                                    
                        if (player.inventory.iceCubes.Count() >= player.recipe.amountOfIceCubes)
                        {
                            player.inventory.iceCubes.RemoveRange(0, player.recipe.amountOfIceCubes);

                            if (player.inventory.iceCubes.Count() < player.recipe.amountOfIceCubes)
                            {
                                Console.WriteLine("Your ice cubes have been depleted for the day.  This day of selling is over.  You must replentish if you have enough in your wallet.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Your ice cubes have been depleted for the day.  This day of selling is over.");
                            
                        }
                            
                        if (player.inventory.cups.Count() >= 1)
                        {
                            player.inventory.cups.Remove(player.inventory.cups[0]);
                        }
                        else
                        {
                            Console.WriteLine("Your cup inventory has been depleted for the day.  This day of selling is over.");
                            
                        }
                        //Reset Pitcher to 8 cups
                        player.pitcher.cupsLeftInPitcher = 8;

                    }

                }
                
                

                
                
               
                




            }
            

        }



        public void CustomerMakesDecisionTEST()
        {

            //GetConditionBuyerNumber(weather);
            //GetTempBuyerNumber(weather);
            //SellPriceBuyerNumber(recipe);
            //BuyerNumber();

            //if (buyerNumber >= 7.5)
            //{
            //    Console.WriteLine(names[i] + " is a buyer");
            //    wallet.AddMoneyForSale(recipe);
            //    totalNumberofBuyers++;
            //    pitcher.cupsLeftInPitcher--;
            //    if (pitcher.cupsLeftInPitcher == 0)
            //    {
            //        if (inventory.lemons.Count() >= recipe.amountOfLemons)
            //        {
            //            inventory.lemons.RemoveRange(0, recipe.amountOfLemons);
            //        }
            //        else
            //        {
            //            Console.WriteLine("Your lemons have been depleted for the day.  This day of selling is over.");
            //        }
            //        if (inventory.sugarCubes.Count() >= recipe.amountOfSugarCubes)
            //        {
            //            inventory.sugarCubes.RemoveRange(0, recipe.amountOfSugarCubes);
            //        }
            //        else
            //        {
            //            Console.WriteLine("Your sugar cubes have been depleted for the day.  This day of selling is over.");
            //        }

            //        if (inventory.iceCubes.Count() >= recipe.amountOfIceCubes)
            //        {
            //            inventory.iceCubes.RemoveRange(0, recipe.amountOfIceCubes);
            //        }
            //        else
            //        {
            //            Console.WriteLine("Your ice cubes have been depleted for the day.  This day of selling is over.");
            //        }

            //        if (inventory.cups.Count() >= 1)
            //        {
            //            inventory.cups.Remove(inventory.cups[0]);
            //        }
            //        else
            //        {
            //            Console.WriteLine("Your cup inventory has been depleted for the day.  This day of selling is over.");
            //        }

            //        Console.ReadLine();


            //    }
            }

    }
}



