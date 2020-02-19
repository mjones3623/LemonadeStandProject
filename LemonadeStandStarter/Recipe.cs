using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Recipe
    {

        //Variables
        public int amountOfLemons;
        public int amountOfSugarCubes;
        public int amountOfIceCubes;
        public double pricePerCup;
        public string answer;
        public string recipeAnswer;
        public string recipeAnswer2;


        //Constructor
        public Recipe()
        {
            //Recipe and Price values represent suggested starting values that would result in a cost of $0.36 per cup and a $0.04 profit per cup
            amountOfLemons = 4;
            amountOfSugarCubes = 4;
            amountOfIceCubes = 10;
            pricePerCup = 0.40;
            answer = "";
            recipeAnswer = "";
            recipeAnswer2 = "";

        }

        //Methods
        public void DisplayRecipe()
        {
            Console.WriteLine("This is your current recipe and selling price (per cup).  The number of recipe items represent the number per pitcher.\n");
            Console.WriteLine("Number of lemons per pitcher:          " + amountOfLemons);
            Console.WriteLine("Number of sugar cubes per pitcher:     " + amountOfSugarCubes);
            Console.WriteLine("Number of ice cubes pitcher:           " + amountOfIceCubes);
            Console.WriteLine("This is your current selling price:    " + pricePerCup);
            Console.WriteLine("Hit enter to continue.....");
            Console.WriteLine();
        }
            
        public void ChangeRecipe()
        {
            Console.WriteLine("Would you like to change (or continue changing) your recipe or the price per cup you are charging?.  Enter yes or no.");
            recipeAnswer = Console.ReadLine();

            if (recipeAnswer == "yes")
            {
                Console.WriteLine("We will add one item at a time.  Please enter (type) either lemon, ice, sugar, or price.");
                recipeAnswer2 = Console.ReadLine();
                switch (recipeAnswer2)
                {
                    case "lemon":
                        ChangeNumLemRecipe();
                        DisplayRecipe();
                        ChangeRecipe();
                        break;
                    case "ice":
                        ChangeNumIceRecipe();
                        DisplayRecipe();
                        ChangeRecipe();
                        break;
                    case "sugar":
                        ChangeNumSugarRecipe();
                        DisplayRecipe();
                        ChangeRecipe();
                        break;
                    case "price":
                        ChangePricePerCup();
                        DisplayRecipe();
                        ChangeRecipe();
                        break;
                   

                }
            }
            else if (recipeAnswer == "no")
            {
                Console.WriteLine("Done with recipe changes");
            }
            else
            {
                Console.WriteLine("INVALID ENTRY.  Please check spelling and case.  Hit enter and try again.");
                Console.ReadLine();
                ChangeRecipe();
            }
        }
               
        public void ChangeNumLemRecipe()
        {
            Console.WriteLine("The pre-set recipe value of the number of LEMONS in a pitcher is 4.  Would you like to change it? Type yes or no");
            answer = Console.ReadLine();

            if (answer == "yes")
            {
                Console.WriteLine("please enter the new TOTAL number of lemons you would like in your recipe.");
                amountOfLemons = Convert.ToInt32(Console.ReadLine());
            }
            else if (answer == "no")
            {
                ChangeRecipe();
            }
            else
            {
                Console.WriteLine("Please enter a valid option (check spelling/case):");
                ChangeNumLemRecipe();
            }

        }
        public void ChangeNumIceRecipe()
        {
            Console.WriteLine("The pre-set recipe value of the number of ICE CUBES in a pitcher is 10.  Would you like to change it? Type yes or no");
            answer = Console.ReadLine();

            if (answer == "yes")
            {
                Console.WriteLine("please enter the new TOTAL number of ice cubes you would like in your recipe.");
                amountOfIceCubes = Convert.ToInt32(Console.ReadLine());
            }
            else if (answer == "no")
            {
                ChangeRecipe();
            }
            else
            {
                Console.WriteLine("Please enter a valid option (check spelling/case):");
                ChangeNumIceRecipe();
            }
        }
        public void ChangeNumSugarRecipe()
        {
            Console.WriteLine("The pre-set recipe value of the number of sugar cubes in a pitcher is 4.  Would you like to change it? Type yes or no");
            answer = Console.ReadLine();
            if (answer == "yes")
            {
                Console.WriteLine("please enter the new TOTAL number of SUGAR CUBES you would like in your recipe.");
                amountOfSugarCubes = Convert.ToInt32(Console.ReadLine());
            }
            else if (answer == "no")
            {
                ChangeRecipe();
            }
            else
            {
                Console.WriteLine("Please enter a valid option (check spelling/case):");
                ChangeNumSugarRecipe();
            }

        }
        public void ChangePricePerCup()
        {
            Console.WriteLine("The pre-set selling price for a cup of lemonade at your stand is 0.40.  Would you like to change it? Type yes or no");
            answer = Console.ReadLine();
            if (answer == "yes")
            {
                Console.WriteLine("please enter the new PRICE PER CUP you would like to charge your customers.");
                pricePerCup = Convert.ToDouble(Console.ReadLine());
            }
            else if (answer == "no")
            {
                ChangeRecipe();
            }
            else
            {
                Console.WriteLine("Please enter a valid option (check spelling/case):");
                ChangePricePerCup();
            }

        }



        
    }
}
