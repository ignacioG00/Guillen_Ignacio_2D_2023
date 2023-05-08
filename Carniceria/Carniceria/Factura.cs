using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carniceria
{
    public class Factura
    {
        string nombreCliente;
        string nombreVendedor;
        List<Producto> productosVendidos;
        decimal montoVenta;

        public Factura(string nombreCliente, string nombreVendedor, List<Producto> productosVendidos, decimal montoVenta)
        {
            this.NombreCliente = nombreCliente;
            this.NombreVendedor = nombreVendedor;
            this.ProductosVendidos = productosVendidos;
            this.MontoVenta = montoVenta;
        }

        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string NombreVendedor { get => nombreVendedor; set => nombreVendedor = value; }
        public List<Producto> ProductosVendidos { get => productosVendidos; set => productosVendidos = value; }
        public decimal MontoVenta { get => montoVenta; set => montoVenta = value; }

        
    }
}
