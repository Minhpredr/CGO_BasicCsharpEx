using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_08_ke_thua
{
    public class Person
    {
        public string name;
        public void getname()
        {
            Console.WriteLine("name{0}",name);
        }
        public class Citizen : Person
        {
            public string location;
            public void getlocation()
            {
                Console.WriteLine("location{0}",location);
            }
        }
    }
}
