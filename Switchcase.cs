using System;
using System.Reflection.Metadata.Ecma335;
namespace assignment
{
    class SwitchExample
    {
        public static void Main()

        {

            Console.WriteLine("press 'y' to start");
            char ch = Convert.ToChar(Console.ReadLine());
            while (ch == 'y')
            {
                Console.WriteLine("Press 1 for factorial, 2 for fibbonacci, 3 for prime no.");

                int x = Convert.ToInt32(Console.ReadLine());
                if (x == 1 || x == 2 || x == 3)
                {
                    switch (x)
                    {
                        case 1:
                            Console.WriteLine("Enter the number for finding the factorial");
                            int v = Convert.ToInt32(Console.ReadLine());

                            int f = 1;
                            while (v > 1)
                            {
                                f = f * v;
                                v--;
                            }
                            Console.WriteLine("Factorial of number is " + f);



                            break;


                        case 2:

                            int a = 0;
                            int b = 1;
                            Console.WriteLine("Enter the length of the series");
                            int c = Convert.ToInt32(Console.ReadLine());
                            int s = 0;
                            Console.Write(a + " ");
                            Console.Write(b + " ");
                            while (c > 0)
                            {
                                s = a + b;
                                a = b;
                                b = s;
                                Console.Write(s + " ");
                                c--;
                            }


                            break;


                        case 3:
                            Console.WriteLine("Enter a number to check its prime or not");
                            int m = Convert.ToInt32(Console.ReadLine());
                            int count = 0;
                            for (int i = 2; i <= m / 2; i++)
                            {
                                if (m % i == 0)
                                {
                                    count++;
                                }

                            }
                            if (count == 0)
                            {
                                Console.WriteLine("Prime Number");
                            }
                            else
                            {
                                Console.WriteLine("Not a prime number");
                            }

                            break;


                    }
                }
                else
                {
                    Console.WriteLine("You entered a wrong option");


                }
                Console.WriteLine("\n" + "press y to continue or n to stop");
                ch = Convert.ToChar(Console.ReadLine());

            }
            Console.WriteLine("Code Ended thankyou.");
        }

    }
}