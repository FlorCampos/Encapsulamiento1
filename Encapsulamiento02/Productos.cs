using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamiento02
{
    class Productos
    {
        //
        private string nombre;
        private double precio;
        //
        public Productos()
        {
        }

        public Productos(string nombre, double precio)
        {
            this.Nombre = nombre;
            this.Precio = precio;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public double Precio { get => precio; set => precio = value; }
    }
}
