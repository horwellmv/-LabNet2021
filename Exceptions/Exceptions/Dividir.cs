using System;
namespace Exceptions
{
    public class Dividir
    {


        public static double DividirPorCero(int numeroDividendo)
        {
            try // Intentamos hacer la division por cero.
            {
                return numeroDividendo / 0;
                
            }
            catch (Exception ex) // Lanzamos la excepcion.
            {
                throw ex;
            }

        }





        public static decimal DividirDosNumeros(decimal numeroDivindendo, decimal numeroDivisor)
        {

            try
            {
                    return (numeroDivindendo / numeroDivisor); // realiza calculo 

            }
            catch ( Exception ex) // DivideByZeroException
            {
                throw ex;
            }
            

        }

    }
}
