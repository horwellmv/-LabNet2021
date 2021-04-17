using System;
namespace EjercicioPOO
{
    public class Automovil : Transporte // Clase hereda de clase Abstracta
    {

        public Automovil(int numeroPasajeros) // Cosntructor de la clase local
        {
            this.numeroPasajeros = $"Automovil : {numeroPasajeros} pasajeros";
        }


        // desarrollo de los metods heredados de la clase abstracta

        public override string Avanzar()
        {
            return $"Estoy avanzando!";
        }


        public override string Detenerse() 
        {
            return $"Estoy detenido!";
        }
    }
}
