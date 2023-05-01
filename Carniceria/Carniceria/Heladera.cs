using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carniceria
{
    internal class Heladera
    {
        List<Producto> Carnes = new List<Producto>();

        public Heladera(List<Producto> carnes)
        {
            Carnes = carnes;
        }

        public void ReponerProducto(List<Producto> carnes, Producto producto)
        {
            foreach (Producto p in carnes)
            {
                if (p.CorteDeCarne == producto.CorteDeCarne && p.Stock < 1)
                {
                    p.Stock += 10;
                    break; // Detener la iteración una vez que se ha encontrado el producto
                }
            }
        }

        public void QuitarProducto(List<Producto> carnes, Producto producto, decimal cantidad) 
        {
            foreach (Producto p in carnes)
            {
                if (p.CorteDeCarne == producto.CorteDeCarne && p.Stock > cantidad)
                {
                    p.Stock -= cantidad;
                    break; // Detener la iteración una vez que se ha encontrado el producto
                }
                else
                {
                    break;
                }
            }
        }


    }
}
