using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class TesteCalculadora
    {
        static void Main(string[] args)
        {

            Calculadora calc = new Calculadora();
            calc.Somar(10,5);
            calc.Subtrair(10,5);
            calc.Dividir(30, 2);
            calc.Multiplicar(4, 5);


            

            Console.WriteLine("Soma do valores "+calc.Somar(20,5));
            Console.WriteLine("Subtração dos valores "+calc.Subtrair(20, 5));
            Console.WriteLine("Multiplicação dos valores "+calc.Multiplicar(20, 5));
            Console.WriteLine("Divisao dos valores "+calc.Dividir(20, 5));

            Console.WriteLine("Teste");
            Console.ReadLine();
        }

            
    }
}
