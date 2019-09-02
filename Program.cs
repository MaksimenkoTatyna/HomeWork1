using System;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            String name;
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("Hello " + name + "!");

            String numberOne;
            String numberTwo;
            Console.WriteLine("Enter first number");
            numberOne = Console.ReadLine();
            Console.WriteLine("Enter second number");
            numberTwo = Console.ReadLine();

            int intOne;
            int intTwo;
            if (int.TryParse(numberOne, out intOne) && int.TryParse(numberTwo, out intTwo))
            {
                if (intTwo == 0 )
                {
                    Console.WriteLine("Secons number can not be 0");
                }
                else
                {
                    int result = intOne / intTwo;
                    Console.WriteLine("Result = " + result);
                }
            }
            else
            {
                Console.WriteLine("You have to enter a number");
            }     
            Console.ReadKey(true);
        }
    }
}
