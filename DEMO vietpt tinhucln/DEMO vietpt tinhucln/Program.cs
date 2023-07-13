using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_vietpt_tinhucln
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            int donvi;
            for (i = 1; i <= 10; i++)
            {
                for (donvi = 1; donvi <= 10; donvi++)
                {
                    Console.WriteLine(i+"x"+donvi+"="+donvi*i);
                }
                Console.WriteLine();

            }

        }
    }
}

