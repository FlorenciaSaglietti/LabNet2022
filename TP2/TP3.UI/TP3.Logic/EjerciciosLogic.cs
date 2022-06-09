using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3.Entities;

namespace TP3.Logic
{
    public class EjerciciosLogic
    {
        public void Ejecutar()
        {
            Console.WriteLine("Seleccione que base de datos quiere ver (1-3): ");
            Console.WriteLine("1: Tabla Categories");
            Console.WriteLine("2: Tabla Employees");
            Console.WriteLine("3: Tabla Territories");
            var seleccion = int.Parse(Console.ReadLine());

            switch (seleccion)
            {
                case 1:
                    this.CategoriesLogic();
                    break;
                case 2:
                    this.EmpleyeesLogic();
                    break;
                case 3:
                    this.TerritoriesLogic();
                    break;
           
            }
        }

        private void TerritoriesLogic()
        {
            TerritoriesLogic territoriesLogic = new TerritoriesLogic();

            Console.WriteLine("Seleccione que quiere hacer (1-2): ");
            Console.WriteLine("1: Listar Territories");
            Console.WriteLine("2: Guardar nuevo Territories");

            var seleccion = int.Parse(Console.ReadLine());

            switch (seleccion)
            {
                case 1:
                    GetAllTerritories(territoriesLogic);
                    break;
                case 2:
                    AddTerritories(territoriesLogic);
                    break;
            }
        }

        private void EmpleyeesLogic()
        {
            EmployeesLogic employeesLogic = new EmployeesLogic();

            Console.WriteLine("Seleccione que quiere hacer (1-2): ");
            Console.WriteLine("1: Listar Employees");
            Console.WriteLine("2: Eliminar un Employee");

            var seleccion = int.Parse(Console.ReadLine());

            switch (seleccion)
            {
                case 1:
                    GetAllEmployees(employeesLogic);
                    break;
                case 2:
                    DeleteEmployees(employeesLogic);
                    break;
            }
        }

        private void CategoriesLogic()
        {
            CategoriesLogic categoriesLogic = new CategoriesLogic();

            Console.WriteLine("Seleccione que quiere hacer (1-2): ");
            Console.WriteLine("1: Listar Categories");
            Console.WriteLine("2: Modificar Categories");

            var seleccion = int.Parse(Console.ReadLine());

            switch (seleccion)
            {
                case 1:
                    GetAllCategories(categoriesLogic);
                    break;
                case 2:
                    UpdateCategories(categoriesLogic);
                    break;
            }
        }

        private static void GetAllCategories(CategoriesLogic categoriesLogic)
        {
            foreach (Categories categories in categoriesLogic.GetAll())
            {
                Console.WriteLine($"{categories.CategoryName} - {categories.Description}");
            }
        }

        private void GetAllEmployees(EmployeesLogic employeesLogic)
        {
            foreach (Employees employees in employeesLogic.GetAll())
            {
                Console.WriteLine($"{employees.LastName} - {employees.FirstName}");
            }
        }

        private void DeleteEmployees(EmployeesLogic employeesLogic)
        {
            var EmployeesAEliminar = employeesLogic.GetAll().LastOrDefault();

            employeesLogic.Delete(EmployeesAEliminar.EmployeeID);
        }

        private void UpdateCategories(CategoriesLogic categoriesLogic)
        {
            var CategoriesAModificar = categoriesLogic.GetAll().LastOrDefault();
            categoriesLogic.Update(CategoriesAModificar);
        }

        private void AddTerritories(TerritoriesLogic territoriesLogic)
        {
            var lastTerritories = territoriesLogic.GetAll().LastOrDefault();
            var TerritoryId = int.Parse(lastTerritories.TerritoryID) + 1;

            var newTerritories = new Territories();
            newTerritories.TerritoryID = TerritoryId.ToString();
            newTerritories.RegionID = 4;
            newTerritories.TerritoryDescription = "Territorio de prueba";

            territoriesLogic.Add(newTerritories);

        }

        private static void GetAllTerritories(TerritoriesLogic territoriesLogic)
        {
            foreach (Territories territories in territoriesLogic.GetAll())
            {
                Console.WriteLine($"{territories.TerritoryID} - {territories.TerritoryDescription}");
            }
        }
    }
}
