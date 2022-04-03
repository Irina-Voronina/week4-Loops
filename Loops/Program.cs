using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++) //i++ = i + 1
            {
                Console.WriteLine($"{i} Vampire is not a career choice");
                //i = i + 1
            }

            Console.WriteLine("Have a nice day!");

            //DRY - Do not repeat yourself

        }
    }
}
