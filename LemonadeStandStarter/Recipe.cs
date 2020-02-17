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

        //Constructor
        public Recipe()
        {
            //Recipe and Price values represent suggested starting values that would result in a cost of $0.36 per cup and a $0.04 profit per cup
            amountOfLemons = 4;
            amountOfSugarCubes = 4;
            amountOfIceCubes = 10;
            pricePerCup = 0.40;
            answer = "";
        }

        //Methods
        //amountOfLemons = Convert.ToInt32(Console.ReadLine());
        public void ChangeNumLemRecipe()
        {
            Console.WriteLine("The pre-set recipe value of the number of lemons in a pitcher is 4.  Would you like to change it? Type yes or no");
            answer = Console.ReadLine();

            if (answer == "yes")
            {
                amountOfLemons = Convert.ToInt32(Console.ReadLine());
            }
            else if (answer == "no")
            {
                return;
            }
            else
            {
                Console.WriteLine("Please enter a valid option:");
                ChangeNumLemRecipe();
            }

        }
        public void ChangeNumIceRecipe()
        {
            Console.WriteLine("The pre-set recipe value of the number of ice cubes in a pitcher is 4.  Would you like to change it? Type yes or no");
            answer = Console.ReadLine();

            if (answer == "yes")
            {
                amountOfIceCubes = Convert.ToInt32(Console.ReadLine());
            }
            else if (answer == "no")
            {
                return;
            }
            else
            {
                Console.WriteLine("Please enter a valid option:");
                ChangeNumIceRecipe();
            }
        }
        public void ChangeNumSugarRecipe()
        {
            Console.WriteLine("The pre-set recipe value of the number of ice cubes in a pitcher is 4.  Would you like to change it? Type yes or no");
            answer = Console.ReadLine();
            if (answer == "yes")
            {
                amountOfSugarCubes = Convert.ToInt32(Console.ReadLine());
            }
            else if (answer == "no")
            {
                return;
            }
            else
            {
                Console.WriteLine("Please enter a valid option:");
                ChangeNumSugarRecipe();
            }




        }



        
    }
}
