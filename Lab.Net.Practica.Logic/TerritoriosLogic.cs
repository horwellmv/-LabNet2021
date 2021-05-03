using Lab.Net.Practica.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab.Net.Practica.Logic
{
    public class TerritoriosLogic: ComunLogic, IMetodosLogic<Territories> // Uso de interfaz tipo generico
    {
        public List<Territories> GetAll()
        {
            return context.Territories.ToList();
        }

        public void add(Territories toAdd)
        {
            context.Territories.Add(toAdd);
            context.SaveChanges();
        }

        public void update(Territories toUpdate)
        {
            var territoryForUpdate = context.Territories.Find(toUpdate.TerritoryID); // Metodo para encontrar el registro
            territoryForUpdate.TerritoryDescription = toUpdate.TerritoryDescription;
            context.SaveChanges();
        }

        public void delete(string id)
        {
            var idForDelete = context.Territories.Find(id); // Metodo para encontrar el registro
            context.Territories.Remove(idForDelete);
            context.SaveChanges();
        }

       
      
    }
}
