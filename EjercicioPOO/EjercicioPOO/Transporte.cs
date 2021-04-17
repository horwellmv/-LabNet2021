using System;
namespace EjercicioPOO
{
    public abstract class Transporte // CLASE ABSTRACTA
    {
        public string numeroPasajeros { get; set; } // Metod get and set de variable numeroPasajeros.


        //---------- Metods abstractos que obligaran a las clases hijas a desarrollar estos metods.

        public abstract string Avanzar(); // Primer metod abstracto de la clase

        public abstract string Detenerse(); // Segundo metod abstracto de la clase



    }
}
