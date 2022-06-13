using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5.Entities;

namespace TP5.Logic
{
    public class EjerciciosLogic : BaseLogic
    {
        public void Ejecutar()
        {
            Console.WriteLine("Seleccione que ejercicio quiere ver (1-10): ");
            //Console.WriteLine("1: Tabla Categories");
            //Console.WriteLine("2: Tabla Employees");
            //Console.WriteLine("3: Tabla Territories");
            var seleccion = int.Parse(Console.ReadLine());

            switch (seleccion)
            {
                case 1:
                    this.GetAllCustomer();
                    break;
                case 2:
                    this.ProductosSinStock();
                    break;
                case 3:
                    this.ProductosConStock();
                    break;
                case 4:
                    this.CustomerRegionWA();
                    break;
                case 5:
                    this.ProductoPorID(789);
                    break;
                case 6:
                    this.NombresCustomer();
                    break;
                case 8:
                    this.CustomerPrimerosTres();
                    break;
            }
        }
        public List<Customers> GetAllCustomer()
        {
            var customer = from c in context.Customers
                           select c;

            foreach (var c in customer)
            {
                Console.WriteLine("CustomerID: " + c.CustomerID.ToString() + ", ContactName: " + c.ContactName + ", ContactTitle: " + c.ContactTitle);
            }

            return customer.ToList();
        }

        public List<Products> ProductosSinStock()
        {
            var productos = from p in context.Products
                            where p.UnitsInStock == 0
                            select p;

            foreach (var p in productos)
            {
                Console.WriteLine("ProductID: " + p.ProductID.ToString() + ", ProductName: " + p.ProductName + ", UnitsInStock: " + p.UnitsInStock);
            }

            return productos.ToList();
        }

        public List<Products> ProductosConStock()
        {
            var productos = from p in context.Products
                            where (p.UnitPrice > 3 && p.UnitsInStock > 0)
                            select p;

            foreach (var p in productos)
            {
                Console.WriteLine("ProductID: " + p.ProductID.ToString() + ", ProductName: " + p.ProductName + ", UnitsInStock: " + p.UnitsInStock + ", UnitPrice: " + p.UnitPrice);
            }

            return productos.ToList();
        }

        public List<Customers> CustomerRegionWA()
        {
            var customer = from c in context.Customers
                           where c.Region == "WA"
                           select c;

            foreach (var c in customer)
            {
                Console.WriteLine("CustomerID: " + c.CustomerID.ToString() + ", ContactName: " + c.ContactName + ", ContactTitle: " + c.ContactTitle + ", Region: " + c.Region);
            }

            return customer.ToList();
        }

        public Products ProductoPorID(int iD)
        {
            var productos = context.Products.FirstOrDefault(x => x.ProductID == iD);

            if (productos != null)
            {
                Console.WriteLine("ProductID: " + productos.ProductID.ToString() + ", ProductName: " + productos.ProductName + ", UnitsInStock: " + productos.UnitsInStock);
            }
            else
            {
                Console.WriteLine("No se encuentra el producto.");
            }

            return productos;
        }

        public List<string> NombresCustomer()
        {
            var customer = from c in context.Customers
                           select c.ContactName;

            foreach (var c in customer)
            {
                Console.WriteLine("Nombre Customer en minúscula: " + c.ToLower());
                Console.WriteLine("Nombre Customer en mayúscula: " + c.ToUpper());
            }

            return customer.ToList();
        }

        //public void CustomerOrdersJoin()
        //{
        //    //var query = context.Customers
        //    //    .Join(context.Orders,
        //    //          customer => customer,
        //    //          orders => orders,
        //    //          (customer, orders) => customer);

        //    var query = from customers in context.Customers
        //                join orders in context.Orders on customers equals orders.CustomerID
        //                where c.
        //                select 
        //}

        public void CustomerPrimerosTres()
        {
            var customer = context.Customers.Take(3).Where(x => x.Region == "WA");

            foreach (var c in customer)
            {
                Console.WriteLine("CustomerID: " + c.CustomerID.ToString() + ", ContactName: " + c.ContactName + ", ContactTitle: " + c.ContactTitle + ", Region: " + c.Region);
            }
        }
    }
}
