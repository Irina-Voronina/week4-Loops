using System;

namespace ForLoopPINValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //программа просит пользователя ввести ПИН-код
            //программа проверяет, соотвествует ли веденный ПИН-код значению "1234"
            //если веденное значение соответствует "1234", в консоли выводится "Welcome"
            //и программа завершает свою работу.
            //если введенный ПИН-код неверный, то программа просит снова ввести код
            //у пользователя 3 попытки

            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter PIN:");
                string userPIN = Console.ReadLine();

                if(userPIN == "1234")
                {
                    Console.WriteLine("Welcome");
                    break;
                }
                else
                {
                    Console.WriteLine($"Login failed. You tried to login {i+1}/3 times.");
                    if(i == 2)
                    {
                        Console.WriteLine("No attempts left. Try again later.");
                    }
                         
                }

            }

        }
    }
}
