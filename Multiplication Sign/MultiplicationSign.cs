using System;
    class MultiplicationSign
    {
        static void Main(string[] args)
        {
            /*Write a program that shows the sign (+, - or 0) of the product 
             * of three real numbers, without calculating it.*/
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("If the program breaks when you enter a double or a float number,try entering it with a '' , '' or backwards");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Enter first number: ");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            double secondNumber = double.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            double thirdNumber = double.Parse(Console.ReadLine());
            double result = firstNumber * secondNumber * thirdNumber;
            if ( result == 0)
            {
                Console.WriteLine("0");
            }
            else if (result < 0)
            {
                Console.WriteLine("-");
            }
            else
            {
                Console.WriteLine("+");
            }
        }
    }
