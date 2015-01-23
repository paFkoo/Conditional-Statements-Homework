using System;
    class Sort3Numbers
    {
        static void Main()
        {
            //Write a program that enters 3 real numbers and prints them sorted in descending order.
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("If the program breaks when you enter a double or a float number,try entering it with a ' , '");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Enter the first number: ");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            double secondNumber = double.Parse(Console.ReadLine());
            Console.Write("Enter the third number: ");
            double thirdNumber = double.Parse(Console.ReadLine());
            if ( firstNumber == secondNumber && secondNumber == thirdNumber)
            {
                Console.WriteLine("{0} {1} {2}", firstNumber , secondNumber , thirdNumber);
            }
            else
            {
                if (firstNumber >= secondNumber && secondNumber>= thirdNumber)
                {
                    Console.WriteLine("{0} {1} {2}", firstNumber , secondNumber , thirdNumber);
                }
                else
                {
                    if (thirdNumber >= secondNumber && secondNumber >= firstNumber)
                    {
                        Console.WriteLine("{0} {1} {2}", thirdNumber , secondNumber , firstNumber);
                    }
                    else
                    {
                        if ( secondNumber >= firstNumber && firstNumber >= thirdNumber)
                        {
                            Console.WriteLine("{0} {1} {2}", secondNumber, firstNumber , thirdNumber);
                        }
                        else
                        {
                            if ( secondNumber >= thirdNumber && thirdNumber >= firstNumber)
                            {
                                Console.WriteLine("{0} {1} {2}", secondNumber, thirdNumber, firstNumber);
                            }
                            else
                            {
                                if ( firstNumber >= thirdNumber && thirdNumber >= secondNumber)
                                {
                                    Console.WriteLine("{0} {1} {2}",firstNumber , thirdNumber , secondNumber);
                                }
                            }
                        }
                    }

                }
            }
        }
    }
