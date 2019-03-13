using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        private static Boolean Menu()
        {
            
            
            Console.WriteLine("Escolha uma opção");
            Console.WriteLine("1 Para ");
            Console.WriteLine("2 Para");
            Console.WriteLine("3 Para sair");
            String opc = Console.ReadLine();

            

            if(opc == "1")
            {
                
                Console.WriteLine();
                 
                return true;
            }else if(opc == "2")
            {
                Console.WriteLine();
                
                return true;
            }
            else if(opc == "3")
            {

                Console.WriteLine();
                return false;
            }
            else
            {
                Console.WriteLine("Opção nao encontrada");
                Console.WriteLine();
                Console.Clear();

                return true;
            }
           
            
            
        }


        

        static void Main(string[] args)
        {
            bool sair = true;

            /* while (sair == true)
             {
                 Menu();

                 sair = Menu();
             }*/
            
            do
            {

            } while (Menu() == true);

        }
    }
}
