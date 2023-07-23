using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
1.Create an enum called DaysOfWeek to represent the days of the week (Sunday, Monday, Tuesday, etc.).
Write a program that prompts the user to enter a day of the week and displays a message based on the entered value.
Use the switch statement to handle different cases.

    */

namespace Enum_Task
{
    internal class DaysOfWeek
    {
        public DayOfWeeks Days;

        public DaysOfWeek(DayOfWeeks Days)
        {
            this.Days = Days;
        }

        public static void DaysOfWeek1()
        {
            Console.WriteLine("Task 1");
            Console.Write("Enter The Day: ");
            string input = (Console.ReadLine());
            // string days = input.ToLower();

            DayOfWeeks day;

            if (Enum.TryParse(input, true, out day))
            {
                switch (day)
                {
                    case DayOfWeeks.SUNDAY:
                        Console.WriteLine("Should you go to shopping ");
                        break;

                    case DayOfWeeks.MONDAY:
                        Console.WriteLine("You have nothing to do");
                        break;

                    case DayOfWeeks.TUSDAY:
                        Console.WriteLine("You have a test");
                        break;

                    case DayOfWeeks.WEDNESDAY:
                        Console.WriteLine("Go to GYM");
                        break;

                    case DayOfWeeks.THURSDAY:
                        Console.WriteLine("You have an interview");
                        break;

                    case DayOfWeeks.FRIDAY:
                        Console.WriteLine("You have nothing to do");
                        break;

                    case DayOfWeeks.SATURDAY:
                        Console.WriteLine("You have nothing to do");
                        break;

                }
            }
            else
            {
                Console.WriteLine("Wrong choice");
            }

            Console.WriteLine();
            Console.WriteLine("===================");


        }

    }
    enum DayOfWeeks
    {
        SUNDAY,
        MONDAY,
        TUSDAY,
        WEDNESDAY,
        THURSDAY,
        FRIDAY,
        SATURDAY,
    }
}

