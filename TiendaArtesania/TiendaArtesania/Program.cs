using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaArtesania
{
    class Program
    {
        static void Main(string[] args)
        {
            CarritoDeCompras carrito = new CarritoDeCompras();

            while (true)
            {
                Console.WriteLine("¿Qué deseas hacer?");
                Console.WriteLine("1. Agregar producto al carrito");
                Console.WriteLine("2. Ver contenido del carrito");
                Console.WriteLine("3. Finalizar la compra");
                Console.WriteLine("4. Salir del sistema");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        MostrarListaProductos();
                        AgregarProductoAlCarrito(carrito);
                        break;
                    case "2":
                        carrito.MostrarContenido();
                        break;
                    case "3":
                        decimal precioTotal = carrito.CalcularPrecioTotal();
                        Console.WriteLine($"Precio total del carrito: {precioTotal:C}");
                        Console.WriteLine("Compra finalizada. ¿Deseas crear un nuevo carrito? (si/no)");
                        string respuesta = Console.ReadLine();
                        if (respuesta.ToLower() == "si")
                        {
                            carrito = new CarritoDeCompras();
                        }
                        else
                        {
                            Console.WriteLine("Gracias por comprar. ¡Hasta luego!");
                            return;
                        }
                        break;
                    case "4":
                        Console.WriteLine("Saliendo del sistema. ¡Hasta luego!");
                        return;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, elige una opción válida.");
                        break;
                }
            }
        }

        static void MostrarListaProductos()
        {
            Console.WriteLine("Lista de productos:");
            Console.WriteLine("1. Producto de tela");
            Console.WriteLine("2. Producto de arcilla");
        }

        static void AgregarProductoAlCarrito(CarritoDeCompras carrito)
        {
            Console.WriteLine("Selecciona el tipo de producto (1 para tela, 2 para arcilla):");
            string opcionProducto = Console.ReadLine();

            switch (opcionProducto)
            {
                case "1":
                    AgregarProductoTelaAlCarrito(carrito);
                    break;
                case "2":
                    AgregarProductoArcillaAlCarrito(carrito);
                    break;
                default:
                    Console.WriteLine("Opción no válida. No se pudo agregar el producto al carrito.");
                    break;
            }
        }

        static void AgregarProductoTelaAlCarrito(CarritoDeCompras carrito)
        {
            Console.WriteLine("Ingresa el nombre del producto de tela:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingresa el tamaño:");
            string tamaño = Console.ReadLine();
            Console.WriteLine("Ingresa el material:");
            string material = Console.ReadLine();
            Console.WriteLine("Ingresa el color:");
            string color = Console.ReadLine();
            Console.WriteLine("Ingresa el precio:");
            decimal precio = decimal.Parse(Console.ReadLine());

            Tela productoTela = new Tela(nombre, precio, tamaño, material, color);
            carrito.AgregarProducto(productoTela);
            Console.WriteLine("Producto de tela agregado al carrito.");
        }

        static void AgregarProductoArcillaAlCarrito(CarritoDeCompras carrito)
        {
            Console.WriteLine("Ingresa el nombre del producto de arcilla:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingresa el peso (kg):");
            double peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el tamaño:");
            string tamaño = Console.ReadLine();
            Console.WriteLine("Ingresa el color:");
            string color = Console.ReadLine();
            Console.WriteLine("Ingresa el precio:");
            decimal precio = decimal.Parse(Console.ReadLine());

            Arcilla productoArcilla = new Arcilla(nombre, precio, peso, tamaño, color);
            carrito.AgregarProducto(productoArcilla);
            Console.WriteLine("Producto de arcilla agregado al carrito.");
        }
    }
}
