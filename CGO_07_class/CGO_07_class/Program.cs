using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_07_class
{
     class program
    {
        static void Main(string[] args) 
        {
           HCN h = new HCN(2,5);
            Console.WriteLine(h.Per());
            Console.WriteLine(h.Area());
            h.Display();
       

            Console.ReadKey();
            //1 25 19
        }
    }
}
