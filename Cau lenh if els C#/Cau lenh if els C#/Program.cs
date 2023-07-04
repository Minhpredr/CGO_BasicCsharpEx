using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau_lenh_if_els_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int ngaysinh = int.Parse(input);
            string input2 = Console.ReadLine();
            int thangsinh = int.Parse(input2);
            string input3 = Console.ReadLine();
            int namsinh = int.Parse(input3);
            DateTime localDate = DateTime.Now;
            System.Console.WriteLine("Datetime Now is :" + localDate);
            if (thangsinh == 4) {
            if (ngaysinh == 7 ) {
                Console.WriteLine("haha");
            }
            }
            else
            {
                System.Console.WriteLine("no birthday");
            }


        }
    }
}
