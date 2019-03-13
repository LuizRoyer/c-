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


           //minhaString =" MInha \"aaaa\" vida";
            String minhaString = "E se eu precisar \n de uma nova linha";
            // \n para pular linha


            String test = String.Format("{0} --- {1}", "Seu ", "Nome");

            String numero = String.Format("{0:N}", 1999222);
            // para dinheiro "{0:C}",899.00
            String tel = String.Format(" {0:(##) ####-####}", 4733345699);  //para configurar telefone

            StringBuilder strBulder = new StringBuilder(); 

            for (int i= 0; i< 55; i++)
            {
                strBulder.Append("--");
                strBulder.Append(i);

            }


            Console.WriteLine(strBulder);
            Console.ReadLine();
        }
    }
}
