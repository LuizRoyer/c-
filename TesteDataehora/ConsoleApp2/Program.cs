using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;
            //  Console.WriteLine(dt.ToString()); // 19/03/2007 14:00
            //Console.WriteLine(dt.ToShortDateString()); //20/09/2017
            //Console.WriteLine(dt.ToShortTimeString()); // mostra as horas

            // Console.WriteLine(dt.ToLongDateString()); // terça - 10/02/2009

            //Console.WriteLine(dt.Month); // pega so o mes


            DateTime niver = DateTime.Parse("12/7/1996");

            
               Console.ReadLine();
        }
    }
}
