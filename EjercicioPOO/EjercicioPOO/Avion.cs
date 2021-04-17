using System;
namespace EjercicioPOO
{
    public class Avion : Transporte // Clase hereda de clase Abstracta
    {

        public Avion (int numeroPasajeros) // Cosntructor de la clase local
        {
            this.numeroPasajeros = $"Avion : {numeroPasajeros} pasajeros";
        }


        // desarrollo de los metods heredados de la clase abstracta

        public override string Avanzar()
        {
            return $"Estoy avanzando!";
        }


        public override string Detenerse() 
        {
            return $"Solo puedo detenerme si estoy en pista!";
        }
    }
}
