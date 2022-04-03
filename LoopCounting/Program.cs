using System;

namespace LoopCounting
{
    class Program
    {
        static void Main(string[] args)
        {
            //цикл выводит в консоли значение  от 1 до 10
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i+1);
            }

            Console.WriteLine(); //пустая строка консоли
            //цикл выводит на экран значение от 10 до 1

            for (int i = 10; i > 0; i--)//i-- i = i-1
            {
                Console.WriteLine(i);
            }
        }
    }
}
