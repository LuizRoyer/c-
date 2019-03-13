using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                String content = File.ReadAllText(@"C:");
                Console.WriteLine(content);



                
            }
            catch( Exception ex)
            {
                Console.WriteLine("Ocorreu Erro");
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
