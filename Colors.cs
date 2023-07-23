using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
3.Create an enum called FavoriteColor to represent different favorite colors (Red, Blue, Green, etc.).
Write a program that asks the user to enter their favorite color.
If the entered color is one of the enum values, display a message confirming their choice.
If the entered color is not in the enum, display a message stating that it is not a valid favorite color.
*/

namespace Enum_Task
{
    internal class Colors
    {
        public static void FavoraiteColor1()
        {
            Console.WriteLine();
            Console.WriteLine("Task 3");
            Console.Write("Enter Your Favorite Color: ");
            string input = (Console.ReadLine());

            FavoraitesColor color;

            try
            {
                color = (FavoraitesColor)Enum.Parse(typeof(FavoraitesColor), input.ToUpper());
            }
            catch
            {
                Console.WriteLine("it is not a valid favorite color");
                return;
            }

            if (FavoraitesColor.RED == color)
            {

                Console.WriteLine("Your Favorite Color is Red");

            }
            else if (FavoraitesColor.BLUE == color)

            {
                Console.WriteLine("Your Favorite Color is Blue");
            }
            else if (FavoraitesColor.GREEN == color)
            {
                Console.WriteLine("Your Favorite Color is Green");
            }
            else if (FavoraitesColor.BLACK == color)
            {
                Console.WriteLine("Your Favorite Color is Black");
            }

            else
            {
                Console.WriteLine("it is not a valid favorite color");
            }
            Console.WriteLine();
            Console.WriteLine("===================");
        }
        enum FavoraitesColor
        {
            RED,
            BLUE,
            GREEN,
            BLACK,
        }

    }
}
