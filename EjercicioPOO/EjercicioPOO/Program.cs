using System;
using System.Collections.Generic;

namespace EjercicioPOO
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Transporte> ListaTransportes = new List<Transporte> // Lista de objetos instaniciados de las clases Automovil y Avion 
            {

                new Automovil (5), new Automovil(4), new Automovil(3),new Automovil(2),new Automovil(1),
                new Avion(100), new Avion(90), new Avion(80), new Avion(70), new Avion(60),


            };


            foreach (var obTransporte in ListaTransportes)
            {
                Console.WriteLine(obTransporte.numeroPasajeros);
            }



            Console.ReadLine();
        }
    }
}
