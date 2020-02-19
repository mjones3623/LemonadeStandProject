using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Store
    {
        // member variables (HAS A)
        private double pricePerLemon;
        private double pricePerSugarCube;
        private double pricePerIceCube;
        private double pricePerCup;

        public string yesOrNo;
        public string buyerItemChoice;

        public List<string> names;


        // constructor (SPAWNER)
        public Store()
        {
            pricePerLemon = .5;
            pricePerSugarCube = .1;
            pricePerIceCube = .01;
            pricePerCup = .05;

            names = new List<string> { "lemon", "sugar", "ice", "cup" };

            yesOrNo = null;
            buyerItemChoice = null;                      

    }

        // member methods (CAN DO)

        public void DisplayItemPrices()
        {
            Console.WriteLine("Price per lemon:       $0.50\n");
            Console.WriteLine("Price per sugar cube:  $0.10\n");
            Console.WriteLine("Price per ice cube:    $0.01\n");
            Console.WriteLine("Price per cup:         $0.05\n");
        }

        //Gets user input for amount of items to purchase, calculates the total amount, checks if wallet has enough money.      
        public void SellLemons(Player player)
        {
            int lemonsToPurchase = UserInterface.GetNumberOfItems("lemons");
            double transactionAmount = CalculateTransactionAmount(lemonsToPurchase, pricePerLemon);
            if(player.wallet.Money >= transactionAmount)
            {
                PerformTransaction(player.wallet, transactionAmount);
                player.inventory.AddLemonsToInventory(lemonsToPurchase);
            }
        }
        //Gets user input for amount of items to purchase, calculates the total amount, checks if wallet has enough money.
        public void SellSugarCubes(Player player)
        {
            int sugarToPurchase = UserInterface.GetNumberOfItems("sugar");
            double transactionAmount = CalculateTransactionAmount(sugarToPurchase, pricePerSugarCube);
            if(player.wallet.Money >= transactionAmount)
            {
                PerformTransaction(player.wallet, transactionAmount);
                player.inventory.AddSugarCubesToInventory(sugarToPurchase);
            }
        }
        //Gets user input for amount of items to purchase, calculates the total amount, checks if wallet has enough money.
        public void SellIceCubes(Player player)
        {
            int iceCubesToPurchase = UserInterface.GetNumberOfItems("ice cubes");
            double transactionAmount = CalculateTransactionAmount(iceCubesToPurchase, pricePerIceCube);
            if(player.wallet.Money >= transactionAmount)
            {
                PerformTransaction(player.wallet, transactionAmount);
                player.inventory.AddIceCubesToInventory(iceCubesToPurchase);
            }
        }

        //Gets user input for amount of items to purchase, calculates the total amount, checks if wallet has enough money.
        public void SellCups(Player player)
        {
            int cupsToPurchase = UserInterface.GetNumberOfItems("cups");
            double transactionAmount = CalculateTransactionAmount(cupsToPurchase, pricePerCup);
            if(player.wallet.Money >= transactionAmount)
            {
                PerformTransaction(player.wallet, transactionAmount);
                player.inventory.AddCupsToInventory(cupsToPurchase);
            }
        }

        private double CalculateTransactionAmount(int itemCount, double itemPricePerUnit)
        {
            double transactionAmount = itemCount * itemPricePerUnit;
            return transactionAmount;
        }

        private void PerformTransaction(Wallet wallet, double transactionAmount)
        {
            wallet.PayMoneyForItems(transactionAmount);
        }
        
        public void GoShopping(Player player)
        {
            Console.WriteLine("Would you like to go (or continue) shopping?  Type yes or no" );
            yesOrNo = Console.ReadLine();
            if(yesOrNo == "yes")
            {
                Console.WriteLine("Which item would you like to purchase?  Enter lemon, sugar, ice, or cup");
                buyerItemChoice = Console.ReadLine();

                
                switch (buyerItemChoice)
                {
                    case "lemon":
                        SellLemons(player);
                        player.inventory.DisplayAllInventory();
                        player.wallet.DisplayWalletBallance();
                        GoShopping(player);
                        
                        break;
                    case "sugar":
                        SellSugarCubes(player);
                        player.inventory.DisplayAllInventory();
                        player.wallet.DisplayWalletBallance();
                        GoShopping(player);
                        
                        break;
                    case "ice":
                        SellIceCubes(player);
                        player.inventory.DisplayAllInventory();
                        player.wallet.DisplayWalletBallance();
                        GoShopping(player);
                        
                        break;
                    case "cup":
                        SellCups(player);
                        player.inventory.DisplayAllInventory();
                        player.wallet.DisplayWalletBallance();
                        GoShopping(player);
                        
                        break;
                    default:
                        Console.WriteLine("NOT VALID");
                        Console.WriteLine("Check spelling and case.  Hit enter to continue");
                            Console.ReadLine();
                        GoShopping(player);
                        break;

                }
            }
            else if (yesOrNo == "no")
            {
                
            }
            else
            {
                Console.WriteLine("NOT VALID");
                Console.WriteLine("Check spelling and case.  Hit enter to continue");
                Console.ReadLine();
                GoShopping(player);
            }

        }
    }
}
