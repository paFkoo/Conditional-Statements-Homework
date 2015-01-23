using System;
    class ExchangeIfGreater
    {
        static void Main(string[] args)
        {
            /*Write an if-statement that takes two double variables a and b and exchanges their 
             * values if the first one is greater than the second one. As a result print the 
             * values a and b, separated by a space.*/
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("If the program breaks when you add a double or a float number, try entering it with a ' , ' or backwards!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Enter a number: ");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.Write("Enter a second number: ");
            double secondNumber = double.Parse(Console.ReadLine());
            double thirdNumber;
            if (firstNumber > secondNumber)
            {
                thirdNumber = firstNumber;
                firstNumber = secondNumber;
                secondNumber = thirdNumber;
                Console.WriteLine("{0} {1}", firstNumber, secondNumber);
            }
        }
    }
