using System;

namespace for_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int donvi = 5;
            int i = 1;
            while (i <= 10)
            {
                int product = donvi * i;
                Console.WriteLine(donvi + "x" + i + "=" + product);
                i -= 2;
            }

        }
    }
}
