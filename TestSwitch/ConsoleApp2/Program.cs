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
            Console.ForegroundColor = ConsoleColor.Red;

            String opc;
            do
            {
                opc = Console.ReadLine();

                switch (opc)
                {
                    case "1":
                        Console.WriteLine("Opçao 1");
                        break;
                    case "2":
                        Console.WriteLine("Opcao 2");
                        break;
                    case "3":

                        Console.WriteLine("Opcao 3 ");
                        Console.WriteLine("duas linhas ");

                        break;



                    default:
                        Console.WriteLine("Opcao nao encontrada");
                        break;
                }
            } while (opc != "0");

            Console.ReadLine();
        }
    }
}
