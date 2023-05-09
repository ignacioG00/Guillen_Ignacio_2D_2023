using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carniceria
{
    public class Heladera
    {
        List<Producto> listaCarnes = new List<Producto>();

        public List<Producto> ListaCarnes { get => listaCarnes; set => listaCarnes = value; }

        public Heladera(List<Producto> carnes)
        {
            listaCarnes = carnes;
        }

        public void ReponerProducto(List<Producto> carnes, string corteDeCarne,decimal cantidad)
        {
            foreach (Producto p in carnes)
            {
                if (p.CorteDeCarne == corteDeCarne && p.Stock<50)
                {
                    p.Stock += cantidad;
                    break; // Detener la iteración una vez que se ha encontrado el producto
                }
            }
        }

        public void QuitarProducto(List<Producto> carnes, string producto, decimal cantidad) 
        {
            foreach (Producto p in carnes)
            {
                if (p.CorteDeCarne == producto && p.Stock > cantidad)
                {
                    p.Stock -= cantidad;
                    break; // Detener la iteración una vez que se ha encontrado el producto
                }
            }
        }


    }
}
