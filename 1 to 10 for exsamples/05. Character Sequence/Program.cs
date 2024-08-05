using System;

namespace _05._Character_Sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
         string tex = Console.ReadLine();
            for (int pos = 0; pos <= tex.Length-1; pos++)
            {
                char c = tex[pos];  
                Console.WriteLine(c);
            }

        }
    }
}
