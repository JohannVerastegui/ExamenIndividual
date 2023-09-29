using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaArtesania
{
    class Tela : Producto
    {
        public string Tamaño { get; set; }
        public string Material { get; set; }
        public string Color { get; set; }

        public Tela(string nombre, decimal precio, string tamaño, string material, string color)
            : base(nombre, precio)
        {
            Tamaño = tamaño;
            Material = material;
            Color = color;
        }

        public override string ObtenerCaracteristicas()
        {
            return base.ObtenerCaracteristicas() +
                $", Tamaño: {Tamaño}, Material: {Material}, Color: {Color}";
        }
    }
}
