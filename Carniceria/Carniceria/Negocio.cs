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
        private static object Frm_Heladera;

        internal static List<Producto> Productos { get => productos; set => productos = value; }
        internal static List<Cliente> Clientes { get => clientes; set => clientes = value; }
        internal static List<Vendedor> Vendedores { get => vendedores; set => vendedores = value; }
        internal static Heladera Heladera { get => heladera; set => heladera = value; }

        static Negocio()
        {
            InstanciarProductos();
            InstanciarHeladera();
            InstanciarClientes();
            InstanciarVendedores();
        }

        private static void InstanciarProductos() 
        {
            Productos = new List<Producto>()
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
            Heladera = new Heladera(Productos);
        }
        private static void InstanciarClientes()
        {
            Clientes = new List<Cliente>()
            {
                new Cliente(20000,null,"Ricardo",22222,"ric123"),
            new Cliente(20000,null,"Ramon",21563, "ric123"),
                new Cliente(20000,null,"Romualdo",21562, "ric123")
                //int montoMax, List<Producto> productosComprados,string nombre, int dni, string user, string contraseña
            };
        }
        private static void InstanciarVendedores()
        {
            Vendedores = new List<Vendedor>()
            {
                new Vendedor("Lucas",21564,"1234"),
                new Vendedor("Leo",21563, "1234"),
                new Vendedor("Lautaro",21562, "1234")
            };
        }

        public static Usuario LoguearUsuario(int idUser, string password)
        {
            foreach (Cliente item in Clientes)
            {
                if (item.Dni == idUser && item.ComprobarContra(password))
                    return item;
            }
            foreach (Vendedor item in Vendedores)
            {
                if (item.Dni == idUser && item.ComprobarContra(password))
                    return item;
            }
            return null;
        }

        public static void SelectorUsuario(int idUser)
        {
            
            foreach (var cli in clientes)
            {
                
                if (idUser == cli.Dni)
                {
                    return Frm_Heladera;
                }
            }
            foreach (var vend in vendedores)
            {
                if (idUser == vend.Dni)
                {
                    return Form.Show();
                }
            }


        }

    }
}
