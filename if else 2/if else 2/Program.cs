using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" nhap ngay sinh cua ban: ");
            string input = Console.ReadLine();

            DateTime dob = DateTime.Parse(input);
            DateTime dob_year = new DateTime(DateTime.Now.Year, dob.Month, dob.Day);
            if (dob_year > DateTime.Now)
            {
                Console.WriteLine("ngay sinh nhat sap toi con " + (dob_year - DateTime.Now).TotalDays);
            }
            else if (dob_year == DateTime.Now.Date)
            {
                Console.WriteLine("Happy birthdayyyyyyyyyyy");
            }
            else
            {
                dob_year = dob_year.AddYears(1);
                Console.WriteLine("ngay sinh nhat sap toi con " + (dob_year - DateTime.Now).TotalDays);
            }



            //Console.WriteLine("dob: " + dob.ToString());
            Console.ReadKey();
            
        }
    }
}
