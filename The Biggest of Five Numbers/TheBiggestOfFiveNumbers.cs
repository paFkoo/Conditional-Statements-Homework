using System;
    class TheBiggestOfFiveNumbers
    {
        static void Main()
        {
            //Write a program that finds the biggest of five numbers by using only five if statements.
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("If the program breaks when you enter a double or a float number,try entering it with a ' , '");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Enter the first number: ");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            double secondNumber = double.Parse(Console.ReadLine());
            Console.Write("Enter the third number: ");
            double thirdNumber = double.Parse(Console.ReadLine());
            Console.Write("Enter the fourth number: ");
            double fourthNumber = double.Parse(Console.ReadLine());
            Console.Write("Enter the fifth number: ");
            double fifthNumber = double.Parse(Console.ReadLine());
            double theBigOne = firstNumber;
            if (theBigOne <= secondNumber)
            {
                theBigOne = secondNumber;
            }
            if ( theBigOne <= thirdNumber)
            {
                theBigOne = thirdNumber;
            }
            if ( theBigOne <= fourthNumber)
            {
                theBigOne = fourthNumber;
            }
            if ( theBigOne <= fifthNumber)
            {
                theBigOne = fifthNumber;
            }
            Console.WriteLine("{0} is the biggest number", theBigOne);
        }
    }
