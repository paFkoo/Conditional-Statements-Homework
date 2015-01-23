using System;
    class PlayWithIntDoubleAndString
    {
        static void Main()
        {
            /*Write a program that, depending on the user’s choice, inputs an int, double or string variable.
If the variable is int or double, the program increases it by one.
If the variable is a string, the program appends * at the end.
Print the result at the console. Use switch statement.*/
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("If the program breaks when you enter a double or a float number,try entering it with a ' , '");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("1 for int\n2 for string\n3 for double\nChoose a type: ");
            int something = int.Parse(Console.ReadLine());
            switch (something)
            {
                case 1: Console.Write("Enter a integer: ");
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine(a + 1);break;
                case 2: Console.Write("Enter a string: ");
                    string b = Console.ReadLine();
                    Console.WriteLine("{0}*", b);break;
                case 3: Console.Write("Enter a double: ");
                    double c = double.Parse(Console.ReadLine());
                    Console.WriteLine(c+1);break;
            }


        }
    }
