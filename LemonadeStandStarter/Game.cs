using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Game 
    {
        //Variables
        int currentDay;
        Player player;
        List<Day> days;
        int day;
        Store store = new Store();

        // Day day;


        //Constructor
        public Game()
        {
            // instantiate player and store
            player = new Player();

            day = 1;
            
        }
        //Methods

       
        
        public void runGame()
        {
            //Outside of Day loop

            Weather weather = new Weather();
           
            Customer customer = new Customer();



            

           
            
            WriteIntroduction();


            for (int i = 0; i <= 6; i++)
            {
                Console.WriteLine("Lets play!  This is day:  "+day);

                //Establish and display the day's weather

                weather.GetCondition(weather.rnd2);
                weather.GetTemperature(weather.rnd);
                weather.DisplayCondition();



                //Display current inventory

                player.inventory.DisplayAllInventory();

                //Add to inventory

                store.DisplayItemPrices();
                player.wallet.DisplayWalletBallance();
                store.GoShopping(player);

                //View and change recipe

                player.recipe.DisplayRecipe();
                player.recipe.ChangeRecipe();

                //Run Day

                customer.RunBuyerDay(weather, player);
               
                player.wallet.DisplayWalletBallance();

                Console.WriteLine("Total number of cups of lemonade sold for all days plaid so far:     " +customer.totalNumberofBuyers);
                
                Console.WriteLine("This is the end of day:  "+day);
                day++;

                Console.WriteLine("Hit Enter to continue...");
                Console.ReadLine();

            }
            







        }

        public void WriteIntroduction()
        {
            Console.WriteLine("You have 7 days to make as much money as possible running a lemonade stand. You will have control over pricing, quality control, inventory control, and purchasing supplies. Buy your ingredients, set your recipe, and start selling!\n");
            Console.WriteLine("Although you start with a small inventory, you have a wallet with money and can go shiping. Make sure you buy enough of all your ingredients, or you won’t be able to sell!  At first, you are offered a default recipe. Go with the default recipe, but try to experiment a little bit and see if you can find a better one. \n");
            Console.WriteLine("You’ll also have to deal with the weather, which will play a big part when customers are deciding whether or not to buy your lemonade. Read the weather report every day! When the temperature drops, or the weather turns bad (overcast, cloudy, rain), don’t expect them to buy nearly as much as they would on a hot, hazy day, so buy accordingly. Feel free to set your prices higher on those hot, muggy days too, as you’ll make more profit, even if you sell a bit less lemonade.\n");
            
            Console.WriteLine("At the end of 7 days you can compare your starting wallet amount to what you end up with to see how much money you made. Play again, and try to beat your high score!\n");
            
            
            Console.WriteLine("Hit Enter");
            Console.ReadLine();
            
        }


        

        


           
        
        
        
        
        

    }
}   
