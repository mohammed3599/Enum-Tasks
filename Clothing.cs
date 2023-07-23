using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
  2. Create an enum called ClothingSize to represent different clothing
  sizes(Small, Medium, Large, etc.). Write a program that prompts the user
  to enter their clothing size and displays a message based on the entered 
  value.Use an if-else statement to handle different cases.
  */
namespace Enum_Task
{
    internal class Clothing
    {
        public static void ClothingSize1()
        {
            Console.WriteLine();
            Console.WriteLine("Task 2");
            Console.Write("Enter Your Size: ");
            string input = (Console.ReadLine());
            ClothingSize size;

            try
            {
                size = (ClothingSize)Enum.Parse(typeof(ClothingSize), input.ToUpper());
                //string Size = input.ToUpper();
            }
            catch
            {
                Console.WriteLine("Wrong choice");
                return;
            }

            if (ClothingSize.SMALL == size)
            {

                Console.WriteLine("Your Size between 26-30");

            }
            else if (ClothingSize.MEDIUM == size)

            {
                Console.WriteLine("Your Size between 31-36");
            }
            else if (ClothingSize.LARGE == size)
            {
                Console.WriteLine("Your Size between 37-40");
            }
            else if (ClothingSize.EXTRALARGE == size)
            {
                Console.WriteLine("Your Size between 41-46");
            }

            else
            {
                Console.WriteLine("");
            }
            Console.WriteLine();
            Console.WriteLine("===================");

        }
        enum ClothingSize
        {
            SMALL,
            MEDIUM,
            LARGE,
            EXTRALARGE,
        }
    }
}
