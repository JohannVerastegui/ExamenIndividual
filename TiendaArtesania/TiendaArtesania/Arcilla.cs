using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaArtesania
{
    class Arcilla
    {
        public double Peso { get; set; }
        public string Tamaño { get; set; }
        public string Color { get; set; }

        public Arcilla(string nombre, decimal precio, double peso, string tamaño, string color)
            : base(nombre, precio)
        {
            Peso = peso;
            Tamaño = tamaño;
            Color = color;
        }

        public override string ObtenerCaracteristicas()
        {
            return base.ObtenerCaracteristicas() +
                $", Peso: {Peso} kg, Tamaño: {Tamaño}, Color: {Color}";
        }
    }
}
