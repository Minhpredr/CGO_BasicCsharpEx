using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_07_class
{
    internal class myclass
    {
         string name;
         int age;

        public myclass(string name="user", int age=1)
        {
            this.name = name;
            this.age = age;
        }


        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }

        public void xuat()


        {
            Console.WriteLine("[Person]");
        }
    }

    class HCN
    {
       private float dai, rong;

        public HCN(float dai=0, float rong=12)
        {
            this.dai = dai;
            this.rong = rong;
        }

        public float Dai { get => dai; set => dai = value; }
        public float Rong { get => rong; set => rong = value; }

        public float Per()
        {
            return(dai + rong )*2;    
        }
        public float Area()
        {
            return dai * rong;
        }
        public void Display() {
            Console.WriteLine("{0}:{1}", dai, rong);
        
        }
    }
}
