using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Variaveis
    {
        static void Main(string[] args)
        {
            // comentario uma linha
            /*
             * comentario varias linhas
             */

            int x; int y;

            x = 400000009; // aceita apenas 9 digitos
            y = 6;

            //  Console.WriteLine(x + y);
            //  Console.ReadLine();


            Console.WriteLine("Informe  seu nome ");
            String nome = Console.ReadLine();


            Console.WriteLine("Bem Vindo " + nome);
            Console.ReadLine();


        }
    }
}
