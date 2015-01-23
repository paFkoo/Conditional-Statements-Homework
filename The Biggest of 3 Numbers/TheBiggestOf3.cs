using System;
    class TheBiggestOf3
    {
        static void Main(string[] args)
        {
            //Write a program that finds the biggest of three numbers.
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("If the program breaks when you enter a double or a float number,try entering it with a ' , '");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Enter the first number: ");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            double secondNumber = double.Parse(Console.ReadLine());
            Console.Write("Enter the third number: ");
            double thirdNumber = double.Parse(Console.ReadLine());
            if ( firstNumber == secondNumber && firstNumber == thirdNumber)
            {
                Console.WriteLine("The three numbers are equal!");
            }
            else
            {
                if (firstNumber > secondNumber && firstNumber > thirdNumber)
                {
                    Console.WriteLine("{0} is the biggest!", firstNumber);
                }
                else
                {
                    if (secondNumber > firstNumber && secondNumber > thirdNumber)
                    {
                        Console.WriteLine("{0} is the biggest!", secondNumber);
                    }
                    else
                    {
                        Console.WriteLine("{0} is the biggest!", thirdNumber);
                    }
                }
            }
        }
    }
