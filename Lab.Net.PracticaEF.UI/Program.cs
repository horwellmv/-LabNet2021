using Lab.Net.Practica.Entities;
using Lab.Net.Practica.Logic;
using System;

namespace Lab.Net.PracticaEF.UI
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\nPRACTICA ENTITY F. Horwell Murillo Valencia Lab.Net\nLlamamos a la Entity 'Categories' y  'Territories', posteriormente usaremos metodos de\n" +
                "ABM sobre la Entity territorios.\n");

            Console.ReadLine();

            CategoriasLogic myNewCategoryLogic = new CategoriasLogic(); // Instancia tabla Categorias

            foreach (Categories categoria in myNewCategoryLogic.GetAll())
            {
                Console.WriteLine($"ID: {categoria.CategoryID} Categoria: {categoria.CategoryName} Descripcion: {categoria.Description} ");
            }

            // Consulta de entidad territorios y Alta de nuevo territorio


            Console.WriteLine("\nObtenemos todos los registros de la tabla Territorios usando EntityF.\n");

            Console.ReadLine();

            TerritoriosLogic myNewTerritoryLogic = new TerritoriosLogic(); // Instancia de Territorio

            myNewTerritoryLogic.add(new Territories()
            {
                TerritoryID = "99999",
                TerritoryDescription = "My territorio usando EntityF",
                RegionID = 4
            });

            foreach (Territories territorio in myNewTerritoryLogic.GetAll())
            {
                Console.WriteLine($"Id: {territorio.TerritoryID} Zona: {territorio.TerritoryDescription} - Region: {territorio.RegionID}");
            }

            Console.WriteLine("\nAhora haremos una modificacion ...\n");

            Console.ReadLine();

            myNewTerritoryLogic.update(new Territories
            {
                TerritoryDescription = "Mi modificacion usando EntityF",
                TerritoryID = "99999"
            });

            foreach (Territories territorio in myNewTerritoryLogic.GetAll())
            {
                Console.WriteLine($"Id: {territorio.TerritoryID} Zona: {territorio.TerritoryDescription} - Region: {territorio.RegionID}");
            }


            Console.WriteLine("\nAhora ha sido modificada la descripcion del nuevo territorio ID: 99999 --------------\n");

            Console.ReadLine();

            // Baja de territorio creado anteriormente.
            myNewTerritoryLogic.delete("99999");

            foreach (Territories territorio in myNewTerritoryLogic.GetAll())
            {
                Console.WriteLine($"Id: {territorio.TerritoryID} Zona: {territorio.TerritoryDescription} - Region: {territorio.RegionID}");
            }

            Console.WriteLine("\nMi primer baja usando Entity, ya no existe el registro de nuestro territorio ID: 99999\n");

            Console.ReadLine();

            Console.WriteLine("\nSi compiló hasta aquí, estoy muy feliz!!\nGracias");

            Console.ReadLine();



        }




    }
}
