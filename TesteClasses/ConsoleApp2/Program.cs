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
            Car c1 = new Car();
            c1.Propriedade = "carro";
            c1.Modelo = "gol";
            c1.Year = 2017;
            c1.Cor = "Azul";


            Console.WriteLine(c1.Modelo + " Com a cor "+ c1.Cor);
            Console.WriteLine("Valor do carro "+"{0:C}", c1.ValorCarro());
            Console.ReadLine();
        }

    } // -------- outra classe -------------------------

        class Car
        {

            public String Propriedade { get; set; }
            public String Modelo { get; set; }
            public int Year { get; set; }
            public String Cor { get; set; }


        public decimal ValorCarro()
        {
            decimal valorCarro;

            if (Year > 2000)
                valorCarro = 50000.0M;
            else
                valorCarro = 20000.0M;

            return valorCarro;



        }


        } 

    
}
