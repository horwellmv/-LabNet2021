using Lab.Net.Practica.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Lab.Net.Practica.Logic
{
    public class CategoriasLogic : ComunLogic, IMetodosLogic<Categories> // Uso de interfaz tipo generico
    {
        public List<Categories> GetAll()
        {
            return context.Categories.ToList();
        }

        public void add(Categories toAdd)
        {
            context.Categories.Add(toAdd);
            context.SaveChanges();
        }

        public void update(Categories toUpdate)
        {
            var categoryForUpdate = context.Categories.Find(toUpdate.CategoryID); // Metodo para encontrar el registro
            categoryForUpdate.CategoryName = toUpdate.CategoryName;
            context.SaveChanges();
        }

        public void delete(int id)
        {
            var idForDelete = context.Categories.Find(id); // Metodo para encontrar el registro
            context.Categories.Remove(idForDelete);
            context.SaveChanges();
        }

      
    }
}
