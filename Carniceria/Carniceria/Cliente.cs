using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carniceria
{
    internal class Cliente : Usuario
    {
        int montoMax;
        List<Producto> productosComprados = new();

        public Cliente(int montoMax, List<Producto> productosComprados, string nombre, int dni, string contraseña) : base(nombre, dni, contraseña)
        {
            this.montoMax = montoMax;
            this.productosComprados = productosComprados;
        }

        public int MontoMax { get { return montoMax; } }
    }
}
