using System;

namespace _03._Numbers_1.N_with_Step_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int n =  int.Parse(Console.ReadLine());
            for (int num = 1; num <= n; num += 3)
            {
                Console.WriteLine(num);
            }
        }
    }
}
