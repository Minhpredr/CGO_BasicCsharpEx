using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_Buoi10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //viet bai toan : nhap 2 so ava b xuat kq a/b
            Console.Write("nhap 2 so ava b");
            float a=int.Parse(Console.ReadLine());
            float b = int.Parse(Console.ReadLine());
            Console.WriteLine("kq phep chia: {0}, ", a / b);
            Console.ReadKey();  
        }
    }
}
