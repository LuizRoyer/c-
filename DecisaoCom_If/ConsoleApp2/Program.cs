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

            Console.WriteLine("Escolha uma opção 1 , 2, ou 3");
            String opc = Console.ReadLine();

            String mensagem;
            /*
            if(opc == "1")
        
               mensagem ="Parabens opcao 1";
            else if( opc =="2")
           
                mensagem = "Bom estou na opcao 2";

            else if(opc == "3")
         
                mensagem = "Ultima opcao";
           
            else
            {
                mensagem = "Opção Invalida";
            }
            */

            mensagem= (opc == "1") ? "opcao 1" : "outra Opcao";
            Console.WriteLine(mensagem);
            Console.ReadLine();

            

        }
    }
}
