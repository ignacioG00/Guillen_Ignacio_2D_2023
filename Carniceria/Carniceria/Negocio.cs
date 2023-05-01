using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Carniceria
{
    public static class Negocio
    {
        static List<Producto> productos = new List<Producto>();
        static List<Cliente> clientes = new List<Cliente>();
        static List<Vendedor> vendedores = new List<Vendedor>();
        static Heladera heladera;

        static Negocio()
        {
            InstanciarProductos();
            InstanciarHeladera();
            InstanciarClientes();
            InstanciarVendedores();
        }

        private static void InstanciarProductos() 
        {
            productos = new List<Producto>()
            {
                new Producto(1000, 10, "Bondiola"),
                new Producto(1200, 10, "Vacio"),
                new Producto(1500, 10, "Tira de Asado"),
                new Producto(2500, 10, "Choripan"),
                new Producto(1800, 10, "Costillar")
            };
        }

        private static void InstanciarHeladera() 
        {
            heladera = new Heladera(productos);
        }
        private static void InstanciarClientes()
        {
            clientes = new List<Cliente>()
            {
                new Cliente(20000,null,"Ricardo",21564,"ric123",123456),
            new Cliente(20000,null,"Ramon",21563, "ric123", 123456),
                new Cliente(20000,null,"Romualdo",21562, "ric123", 123456)
                //int montoMax, List<Producto> productosComprados,string nombre, int dni, string user, string contraseña
            };
        }
        private static void InstanciarVendedores()
        {
            vendedores = new List<Vendedor>()
            {
                new Vendedor("Lucas",21564,"lic123",123456),
            new Vendedor("Leo",21563, "lic123", 123456),
                new Vendedor("Lautaro",21562, "lic123", 123456)
            };
        }

        public static Usuario LoguearUsuario(int idUser, string password)
        {
            foreach (Cliente item in clientes)
            {
                if (item.Dni == idUser && item.ComprobarContra(password))
                    return item;
            }
            foreach (Vendedor item in vendedores)
            {
                if (item.Dni == idUser && item.ComprobarContra(password))
                    return item;
            }
            return null;
        }



    }
}
