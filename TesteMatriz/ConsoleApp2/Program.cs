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

            int[] numeros = new int[3];

            numeros[0] = 10;
            numeros[1] = 4;
            numeros[2] = 50;

            int[] numero = new int[] { 1, 3, 4, 5 };

            Console.WriteLine("Numeros " + numero[2]);

            for (int i = 0; i <  numeros.Length; i++)
            {
                Console.WriteLine("Numero da Matriz " + numeros[i]);

            }
            

            String[] nome = new String[] { "Pedro", "Luiz" };

            foreach(String nomes in nome)
            {
                Console.WriteLine("Nome " + nomes);
            }
            Console.ReadLine();

        }
    }
}
