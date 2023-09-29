using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaArtesania
{
    class CarritoDeCompras
    {
        private List<Producto> productos = new List<Producto>();

        public void AgregarProducto(Producto producto)
        {
            productos.Add(producto);
        }

        public decimal CalcularPrecioTotal()
        {
            decimal total = 0;
            foreach (var producto in productos)
            {
                total += producto.Precio;
            }
            return total;
        }

        public void MostrarContenido()
        {
            Console.WriteLine("Contenido del carrito de compras:");
            foreach (var producto in productos)
            {
                Console.WriteLine(producto.ObtenerCaracteristicas());
            }
        }
    }
}
