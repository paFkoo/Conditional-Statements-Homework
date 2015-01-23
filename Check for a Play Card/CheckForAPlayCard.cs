using System;
    class CheckForAPlayCard
    {
        static void Main()
        {
            /*Classical play cards use the following signs to designate the 
             * card face: `2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. Write a program 
             * that enters a string and prints “yes” if it is a valid card sign or “no” otherwise. Examples:*/
            Console.Write("Enter a card: ");
            string a = Console.ReadLine();
            int b;

            if (a == "J" || a == "Q" || a == "K" || a == "A")
            {
                Console.WriteLine("Yes");
            }
            else
            {
                b = int.Parse(a);
                if (b >= 2 && b <= 10)
                {
                    Console.WriteLine("Yes!");
                }
                else
                {
                    Console.WriteLine("NOOOOOO!!!");
                }
            }


        }
    }
