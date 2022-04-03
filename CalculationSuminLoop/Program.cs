using System;

namespace CalculationSuminLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //программа генерирует 10 случайных чисел (от 1 до 10), выводит их значение на экран
            //программа подсчитывает сумму этих чисел и выводит сумму на экран

            Console.WriteLine("Посчитать сумму десяти случайных чисел");

            Random rnd = new Random();
            int sum = 0;

            for (int i = 1; i < 11; i++)
            {
                int myRandom = rnd.Next(1, 11);
                sum = sum + myRandom;
                Console.WriteLine($"{i} Random nr: {myRandom}");
            }
            Console.WriteLine($"Summa = {sum}", sum);




        }


    }
           
    
}
