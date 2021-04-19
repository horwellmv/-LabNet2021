using System;
namespace Exceptions
{
    public class Logic 
    {
        public static void MyException()
        {
            DateTime? fechaSinFormato = null; // Fecha permite campo null

            try
            {
                string datoFecha = fechaSinFormato.Value.ToString("MM,yy"); // Generamos la exception
            }
            catch (Exception ex)
            {
                throw ex; // Lanzamos la exception en el metodo.
            }

        }


       public static void LlamandoMyCustomException() // Metodo que lanza la exception
        {

            throw new MyCustomException(); // Lanzamos nuestra Exception Customizada.
        }



           



    }
}
