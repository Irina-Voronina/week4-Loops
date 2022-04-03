using System;

namespace RandomValue
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();

            int myRandom = 0;

            for(int i = 0; i < 5; i++)
            {
                myRandom = rnd.Next(1, 11);
                Console.WriteLine($"My random number: {myRandom}");
            }

            Console.WriteLine(myRandom);
        }


    }
}
