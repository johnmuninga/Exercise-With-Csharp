using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace App{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            int[] quantity = new int[3];
            string[] productNames = new string[3];
            double[] price = new double[3];

            while(true)
            {


                int choice = menu();
                if (choice == 0)
                {
                    System.Console.WriteLine("Good Bye~");
                    break;

                }
                else if (choice == 1)
                {
                    Populate(productNames, quantity, price);
                    Console.WriteLine();
                }
                else if (choice == 2)
                {
                    Buy(productNames, quantity, price);
                    Console.WriteLine();
                }
                else if (choice == 3)
                {
                    DisplayArray(productNames, quantity, price);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("This option doesn't exist");
                    Console.WriteLine();
                }

            }
            Console.ReadKey();

        }

        //Menu method
        static int menu()
        {
            Console.WriteLine("1: Populate the array");
            Console.WriteLine("2: Buy the product");
            Console.WriteLine("3: Display");
            Console.WriteLine("0: Exit");
            Console.Write("Selected option: ");
            int choice = int.Parse(Console.ReadLine());
            return choice;

        }

        // Method to populate the array
        static void Populate(string[] productNames, int[] quantity, double[] price)
        {
            Random rand = new Random();
            for (int i = 0; i < productNames.Length; i++)
            {
                Console.Write($"Enter product name {i + 1}: ");
                productNames[i] = Console.ReadLine();

                quantity[i] = rand.Next(5, 61);

                Console.Write($"Enter the price for {productNames[i]}: ");
                price[i] = double.Parse(Console.ReadLine());

            }
            Console.WriteLine();
        }

        // Method to display the array
        static void DisplayArray(string[] productNames, int[] quantity, double[] price)
        {
            Console.WriteLine($"Product Name \t Quantity \t Price \t ");
            Console.WriteLine($"============ \t ========= \t ===== \t ");
            for (int i = 0; i < productNames.Length; i++)
            {
                
                Console.WriteLine($"{productNames[i]} \t \t {quantity[i]} \t \t R{price[i]}");
            }
        }

        //Method that return the index of the product searched
        static int SearchProduct(string[] productNames)
        {
            Console.Write("Enter the product name: ");
            string productName = Console.ReadLine();

            for (int i = 0; i < productNames.Length; i++)
            {
                if (productNames[i] == productName)
                {
                    return i;
                }
            }

            return -1;
        }

        //method to buy a product
        static void Buy(string[] productNames, int[] quantity, double[] prices)
        {

            int index = SearchProduct(productNames);

            if (index == -1)
            {
                Console.WriteLine("Item not found.");
                return;
            }

            Console.Write($"Enter the amount tendered: ");
            double amountPaid = double.Parse(Console.ReadLine());

            
            if (amountPaid >= prices[index])
            {
                if (quantity[index] > 0)
                {
                    quantity[index]--;
                    double change = amountPaid - prices[index];
                    Console.WriteLine($"Purchase successful! Your change: R{change}");
                }
                else
                {
                    Console.WriteLine("Product is out of stock.");
                }
            }
            else
            {
                Console.WriteLine("Amount Insufficient.");
            }
        }
    }
}

// See https://aka.ms/new-console-template for more information

