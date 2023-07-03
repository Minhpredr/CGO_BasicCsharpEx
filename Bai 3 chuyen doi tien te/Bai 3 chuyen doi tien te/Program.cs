using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3_chuyen_doi_tien_te
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int tigia = 23000;
            Console.WriteLine("Enter dola: ");
            string input=Console.ReadLine();
            int dola = int.Parse(input);
            Console.WriteLine("gia tri la: " + dola * tigia);
            Console.ReadKey();
        }
    }
}

