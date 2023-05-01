using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Carniceria
{
    internal class Vendedor : Usuario
    {
        public Vendedor(string nombre, int dni, string user, int contraseña) : base(nombre, dni, user, contraseña)
        {

        }

        public void VenderA(Cliente cliente , Producto producto) 
        {
            if (Clientes.Contains(cliente) && Producto.Contains(producto))
            {
                cliente.ComprarProducto(producto, PrecioPorKilo);
                Producto productoVendido = Productos.FirstOrDefault(p => p.Id == producto.Id);
                productoVendido.Cantidad--;
            }
        }


    }
}
