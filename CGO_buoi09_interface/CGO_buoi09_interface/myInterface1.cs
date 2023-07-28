using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_buoi09_interface
{
     interface flyable
    {
        string Fly();

    }
    public class Bird : flyable
    {
        public string Fly() { 

        }
    }
}
