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
            /*
                        Car c1 = new Car();
                        c1.Modelo = "Bola";
                        c1.Nome = "Gol";
                        c1.Year = 1999;

                        Car c2 = new Car();
                        c2.Modelo = "Ap";
                        c2.Nome = "Parati";
                        c2.Year = 2000;

                         //c2 = null; exclui da memoria 

                        Console.WriteLine("Carro 1 :" + c1.Nome);
                        Console.WriteLine("Carro 2 :" + c2.Nome);

            */

            Car c3 = new Car("Fusca", "vw", 1998);


            Car.MetodoStatico();
            Console.WriteLine("Nome do Carro " + c3.Nome);
            Console.ReadLine();


        }
    }

    class Car
    {
        public string Nome { get; set; }
        public String Modelo { get; set; }
        public int Year { get; set; }

        public Car() { }

        public Car(String pNome, String pModelo, int pYear)
        {

            this.Nome = pNome;
            this.Modelo = pModelo;
            this.Year = pYear;

        }

        public static void MetodoStatico()
        {
            Console.WriteLine("Meu metodo statico ");
        }
    }
}
