using System;
using System.IO;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            String text = "Este texto vai ser salvo em um arquivo txt ";

            File.WriteAllText(@"C:\Users", text);

            Console.WriteLine("Ola");
            Console.ReadLine();
        }
    }
}
