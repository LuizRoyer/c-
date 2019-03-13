using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        private static void HelloWord()
        {
            Console.WriteLine("OLa");
            Console.ReadLine();

        }

        private static String RetornarMetodo()
        {
            String a = "Metodo com retorno ";
            return a;
        }

        private static int Somar (int a , int b)
        {

            return a + b;
        }


        static void Main(string[] args)
        {
            HelloWord();
            String volta = RetornarMetodo();
            Console.WriteLine(RetornarMetodo());

            Console.WriteLine("outro exemplo de " + volta);

            Console.WriteLine("usando o Metodo Somar " +Somar(8,9));


            Console.ReadLine();
        }
    }
}
