using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dem_uoc_so = 0;
            int n = 10;
            for(int i=1; i<=n; i++)
            {
                if(n%i==0) dem_uoc_so++;
            }
            if (dem_uoc_so == 2)
                Console.WriteLine("{0} la so nt", n);
            else Console.WriteLine("{0}ko la snt ", n);
            Console.ReadKey();
        }
    }
}
