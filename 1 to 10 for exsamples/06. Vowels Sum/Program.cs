using System;

namespace _06._Vowels_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();//all positions in the text(0 to last

            //we repeat: take the position symbol + check
            //start: 0
            //end: length - 1
            //change: +1

            int sum = 0; //sum of the vowels
            for (int position = 0; position <= text.Length - 1; position++)
            {
                char symbol = text[position];
                //checking if it is: a, e, i, o ,u

                if (symbol == 'a')
                {
                    sum += 1;
                }
                else if (symbol == 'e')
                {
                    sum += 2;
                }
                else if (symbol == 'i')
                {
                    sum += 3;
                }
                else if (symbol == 'o')
                {
                    sum += 4;
                }
                else if (symbol == 'u')
                {
                    sum += 5;
                }
            }

            Console.WriteLine(sum);


        }
    }
}

