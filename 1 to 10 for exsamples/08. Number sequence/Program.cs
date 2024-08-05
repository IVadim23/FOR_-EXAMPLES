using System;

namespace NumberSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int maxNumber = int.MinValue;
            int minNumber = int.MaxValue;

            for (int number = 1; number <= n; number++)
            {
                int value = int.Parse(Console.ReadLine());
                if (value > maxNumber)
                {
                    maxNumber = value;
                }
                if (value < minNumber)
                {
                    minNumber = value;
                }
            }
            Console.WriteLine($"Max number: {maxNumber}");
            Console.WriteLine($"Min number: {minNumber}");
        }
    }
}