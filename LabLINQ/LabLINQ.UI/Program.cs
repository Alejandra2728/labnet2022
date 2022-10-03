using LabLINQ.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabLINQ.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            bool salir = false;
            bool result;
            int opcion2;
            while (!salir)
            {
                CustomerLogic cl = new CustomerLogic();

                Console.WriteLine("1. Ejercicio 1");
                Console.WriteLine("2. Ejercicio 2");
                Console.WriteLine("3. Ejercicio 3");
                Console.WriteLine("4. Ejercicio 4");
                Console.WriteLine("5. Ejercicio 5");
                Console.WriteLine("6. Ejercicio 6");
                Console.WriteLine("7. Ejercicio 7");
                Console.WriteLine("8. Ejercicio 8");
                Console.WriteLine("9. Ejercicio 9");
                Console.WriteLine("10. Ejercicio 10");
                Console.WriteLine("11. Ejercicio 11");
                Console.WriteLine("12. Ejercicio 12");
                Console.WriteLine("13. Ejercicio 13");
                Console.WriteLine("14. Salir");
                Console.WriteLine("Elige una de las opciones");

               string opcion = (Console.ReadLine());

                result = Int32.TryParse(opcion, out opcion2);
                if (!result)
                {
                    System.Console.WriteLine("Invalido debes ingresat un numero");
                }

                Console.WriteLine("---------------------------------------------------------------------------");
                switch (opcion2)
                {
                    case 1:
                        foreach (var customerLogic in cl.EjercicioUno())
                        {
                            Console.WriteLine($"Address= {customerLogic.Address} ContactName= {customerLogic.ContactName}" +
                                $"ContactTitle= {customerLogic.ContactTitle}  CompanyName={customerLogic.CompanyName}");
                        }
                     
                        break;

                    case 2:
                        foreach (var customerLogic in cl.EjercicioDos())
                        {
                            Console.WriteLine($"ProductName= {customerLogic.ProductName} UnitsInStoc=" +
                                $"{customerLogic.UnitsInStock}");
                        }
                     
                        break;

                    case 3:
                        foreach (var customerLogic in cl.EjercicioTres())
                        {
                            Console.WriteLine($"ProductName= {customerLogic.ProductName} UnitsInStock= {customerLogic.UnitsInStock} " +
                                $"UnitPrice= {customerLogic.UnitPrice}");
                        }
                       
                        break;
                    case 4:
                        foreach (var customerLogic in cl.EjercicioCuatro())
                        {
                            Console.WriteLine($"Address= {customerLogic.Address} Region= {customerLogic.Region}");
                        }
                       
                        break;
                    case 5:
                        cl.EjercicioCinco();
                       
                        break;

                    case 6:
                        cl.EjercicioSeis();
                       
                        break;

                    case 7:
                        cl.EjercicioSiete();
                       
                        break;
                    case 8:
                        cl.EjercicioOcho();
                      
                        break;
                    case 9:
                        foreach (var customerLogic in cl.EjercicioNueve())
                        {
                            Console.WriteLine($"ProductName= {customerLogic.ProductName}");
                        }
                     
                        break;

                    case 10:
                        foreach (var customerLogic in cl.EjercicioDiez())
                        {
                            Console.WriteLine($"UnitsInStock= {customerLogic.UnitsInStock}");
                        }
                        
                        break;

                    case 11:
                        cl.EjercicioOnce();
                      
                        break;
                    case 12:
                        cl.EjercicioDoce();
                      
                        break;
                    case 13:
                        cl.EjercicioTrece();
                      
                        break;
                    case 14:
                        Console.WriteLine("Chaoooooooooooo");
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Elige una opcion entre 1 y 13");
                       
                        break;
                }
                Console.WriteLine("---------------------------------------------------------------------------");
            }

            Console.ReadKey();
        }
    }
}
