using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicios manejo de exceptions. Punto 1");

            //------------------------------------------------------------------
            // Realizar metodo para dividir por cero, capturar exception y lanzarla. usar finally.

            try
            {
                Dividir.DividirPorCero(1); // Llamamos al metodo y le damos valor por parametro a dividir por cero.
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n\t{ex.Message}");
            }

            finally
            {
                Console.WriteLine("\n\tMetodo Dividir por cero: [[EJECUTADO]]");

            }


            //------------------------------------------------------------------
            // Realizar metodo para divir dos numeros

            
            try
            {
                Console.WriteLine($"\n------------------------------\nEjercicios Metodo de division punto 2:\n\t ");
                Console.WriteLine("\n\tIngrese numero a dividir: ");
                int numeroDivindendo = int.Parse(Console.ReadLine());
                Console.WriteLine("\n\tIngrese numero divisor: ");
                int numeroDivisor = int.Parse(Console.ReadLine());
                
                Console.WriteLine($"\n\tResultado: ");
                Console.WriteLine($"\n\t{Dividir.DividirDosNumeros(numeroDivindendo, numeroDivisor)}");
                
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"\n\tSolo puedes dividir por cero al llegar a modo Dios\n\t{ex.Message}");
                
            }
            catch(Exception ex)
            {
                Console.WriteLine($"\n\tSeguro Ingreso una letra o no ingreso nada!\n\t{ex.Message}");

            }

            finally
            {
                Console.WriteLine("\n\tMetodo Dividir dos numeros: [[EJECUTADO]]");
            }






            // -----------------------------------------------------------------
            // Realizar metodo para lanzar exception y atrapar desde el main.
            // Deberá mostrar el mensaje de la excepción y el tipo de la excepción.
            Console.WriteLine("\n------------------------------\n" +
                "Ejercicio metodo de lanzado de exception hacia el MAIN punto 3:");

            try
            {
                Logic.MyException();
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"\n\t{ex.StackTrace}\n\n\t{ex.Message}");
            }

            finally
            {
                Console.WriteLine("\n\tMetodo lanzar exception: [[EJECUTADO]]");

            }




            // -----------------------------------------------------------------
            // Realizar metodo para lanzar exception Customizada y atrapar desde el main.
            // Deberá mostrar el mensaje de la excepción y el tipo de la excepción.



            Console.WriteLine("\n------------------------------\n" +
                "Ejercicio metodo de lanzado de exception customizada " +
                "hacia el MAIN punto 4:");

            try
            {
                Logic.LlamandoMyCustomException(); // Llamamos a nuestro metodo 
            }
            catch (MyCustomException ex)
            {
                Console.WriteLine($"\n\t{ex.StackTrace}\n\n\t{ex.Message}"); // Atrapamos el error Exception
            }

            finally
            {
                Console.WriteLine("\n\tMetodo lanzar exception Customizada: [[EJECUTADO]]"); // Ejecutamos linea finally.

            }



            Console.ReadLine();
        }


    }
}
