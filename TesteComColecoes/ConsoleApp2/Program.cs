using System;
using System.Collections;
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
            Livro lv1 = new Livro();

            c1.Modelo = " Fusca";
            lv1.Titulo = "fui nao voltei";

            /*ArrayList minhaLista = new ArrayList();
            minhaLista.Add(c1);
            minhaLista.Add(lv1);


            foreach(Car car in minhaLista)
            {
                Console.WriteLine(car.Modelo);
            } 


            // List<T>

            List<Car> lista = new List<Car>();
            lista.Add(c1);
           */







            Console.ReadLine();
           
        }
    }

    class Car
    {
        public String Modelo { get; set; }
        public int Ano { get; set; }
    }

    class Livro
    {
        public String Titulo { get; set; }
        public String Autor { get; set; }
        public String Editor { get; set; }
    }
}
