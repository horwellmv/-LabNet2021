using Lab.Net.Practica.Data;

namespace Lab.Net.Practica.Logic
{
    public class ComunLogic
    {
        protected readonly NorthwindContext context;

        public ComunLogic()
        {
            context = new NorthwindContext();
        } 



    }
}
