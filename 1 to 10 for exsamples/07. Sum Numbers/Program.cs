using System;


namespace _07._Sum_Numbers
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                int n = int.Parse(Console.ReadLine()); //number of numbers 


            //numbers from first to last
            //repeat: read the value + sum the value
            //start: the first number (1)
            //end: ​​last number (n)
            //change: +1

            int sum = 0; //sum of numbers

            for (int number = 1; number <= n; number++)
                {
                    int value = int.Parse(Console.ReadLine()); //the value of the number
                sum = sum + value; //sum += value;

                }

                Console.WriteLine(sum);
            }
        }
    }

  
