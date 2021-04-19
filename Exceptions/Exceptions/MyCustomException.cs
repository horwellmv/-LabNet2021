using System;
namespace Exceptions
{
    public class MyCustomException : Exception // Heredamos de la clase Exception
    {
        public MyCustomException() : base ("Mensaje de error personalizado de MyCustomException") // Usamos constructor de base para mensaje Personalizado
        {
            
        }




    }


}
