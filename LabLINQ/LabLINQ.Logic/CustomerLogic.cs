using LabLINQ.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabLINQ.Logic
{
    public class CustomerLogic : BaseLogic
    {
        public List<Customers> EjercicioUno()
        {
            var queryCostumers = from c in _context.Customers select c;
            return queryCostumers.ToList();
        }
        public List<Products> EjercicioDos()
        {
            var product = from p in _context.Products
                          where p.UnitsInStock != 0
                          select p;
            return product.ToList();
        }

        public List<Products> EjercicioTres()
        {
            var product = from p in _context.Products
                          where p.UnitsInStock != 0 && p.UnitPrice > 3
                          select p;
            return product.ToList();
        }

        public List<Customers> EjercicioCuatro()
        {
            var customer = _context.Customers.Where(c => c.Region.Equals("WA")).ToList();
            return customer;
        }

        public void EjercicioCinco()
        {
            var productNulo789 = _context.Products.Where(p => p.ProductID.Equals(789)).FirstOrDefault();
            if (productNulo789 == null)
            {
                Console.WriteLine("Producto 189 no existe");
            }

        }

        public void EjercicioSeis()
        {
            var queryCostumers = from c in _context.Customers select c;
            foreach (var c in queryCostumers)
            {
                Console.WriteLine($"ContactName= {c.ContactName.ToLower()} ContactName= {c.ContactName.ToUpper()}");
            }
        }

        public void EjercicioSiete()
        {

            DateTime fecha = new DateTime(1997, 01, 01);
            var customerOrders = from c in _context.Customers
                                 join o in _context.Orders
                                 on c.CustomerID equals o.CustomerID
                                 where c.Region == "WA" && o.OrderDate > fecha
                                 select new { c.Region, o.OrderDate };
            foreach (var order in customerOrders)
            {
                Console.WriteLine($"{order}");
            }
        }
        public void EjercicioOcho()
        {
            DateTime fecha = new DateTime(1997, 01, 01);
            var custOrders = (from c in _context.Customers
                              join o in _context.Orders
                              on c.CustomerID equals o.CustomerID
                              where c.Region == "WA" && o.OrderDate > fecha
                              select new { c.Region, o.OrderDate }).Take(3);
            foreach (var order in custOrders)
            {
                Console.WriteLine($"{order}");
            }
        }
        public List<Products> EjercicioNueve()
        {
            var listProducto = _context.Products.OrderBy(p => p.ProductName).ToList();
            return listProducto;

        }
        public List<Products> EjercicioDiez()
        {
            var listProductoStock = _context.Products.OrderByDescending(p => p.UnitsInStock
            ).ToList();
            return listProductoStock;

        }
        public void EjercicioOnce()
        {
            var categoriesProducts = from c in _context.Categories
                                     join o in _context.Products
                                     on c.CategoryID equals o.CategoryID
                                     select new { c.CategoryName, o.ProductName };
            foreach (var categorie in categoriesProducts)
            {
                Console.WriteLine($"{categorie}");
            }
        }
        public void EjercicioDoce()
        {
            var productFirst = (from p in _context.Products select p).First();

            Console.WriteLine($"Id = {productFirst.ProductID} - Producto= {productFirst.ProductName} - Precio= {productFirst.UnitPrice}");
        }
        public void EjercicioTrece()
        {
            var customerOrderCantidad = (from c in _context.Customers
                                         join o in _context.Orders
                                         on c.CustomerID equals o.CustomerID
                                         group c by o.CustomerID into g 
                                         
                                         select new {g.Key}
                                       );

            foreach (var customer in customerOrderCantidad)
            {
                Console.WriteLine(customer);
            }
        }

    }   
}
