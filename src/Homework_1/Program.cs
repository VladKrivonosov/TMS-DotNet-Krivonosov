using System;

namespace homework1
{
    class Program
    {
        enum Week
        {
            None = 0,
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5,
            Saturday = 6,
            Sunday = 7
        }

        static void Main(string[] args)
        {


            try
            {
                int day;
                Console.WriteLine("enter the day number of the week:");
                day = Convert.ToInt32(Console.ReadLine());

                if (day <= 7 && day >= 1)
                {
                    var dayOfWeek = (Week)day;

                    Console.WriteLine(day + " day of week it is: \n" + dayOfWeek.ToString());
                }
                else
                    Console.WriteLine("invalid weekday number \nenter from 1 to 7");

            }

            catch
            {
                Console.WriteLine("The entered value is not a number");
            }
            Console.ReadKey();
        }
    }
}