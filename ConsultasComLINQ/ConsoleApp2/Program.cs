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
            List<Car> lista = new List<Car>()
            {
                new Car(){Nome ="Palio", Marca ="Fiat",Year =1999},
            new Car() { Nome = "Gol", Marca = "vw" , Year=2000 },
            new Car() { Nome = "Parati", Marca = "vw",Year =2013 },
            new Car() { Nome = "HB20", Marca = "Honda", Year =2017 }
            };

            // LINQ Query
            // var vw = from Car in lista where Car.Marca == "vw" select Car;


            // LINQ metodo
/*
            var vw = lista.Where(p => p.Marca == " vw");
            var ordena = lista.OrderByDescending(p => p.Year);


            Console.WriteLine(lista.Exists(p => p.Year ==2017)); // verifica se tem um carro de 2017 retorna booleano

            foreach (var car in ordena)
            {
                Console.WriteLine(car.Year + "  " + car.Nome);
            }
            */









            Console.ReadLine();
        }
    }

    class Car
    {
        public String Nome { get; set; }
        public String Marca { get; set; }
        public int Year { get; set; }
    }
}



