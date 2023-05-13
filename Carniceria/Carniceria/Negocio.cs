using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Carniceria
{
    public static class Negocio
    {
        static List<Producto> listaCarnes;
        static List<Cliente> clientes ;
        static List<Vendedor> vendedores;
        static Heladera heladera;
        static List<Factura> listFacturaAux = new();

        public enum TipoPago
        {
            efectivo,
            debito,
            credito
        }

        public static List<Producto> ListaCarnes { get => listaCarnes; set => listaCarnes = value; }
        public static List<Cliente> Clientes { get => clientes; set => clientes = value; }
        static List<Vendedor> Vendedores { get => vendedores; set => vendedores = value; }
        public static Heladera Heladera { get => heladera; set => heladera = value; }
        public static List<Factura> ListFacturaAux { get => listFacturaAux; set => listFacturaAux = value; }

        static Negocio()
        {
            InstanciarClientes();
            InstanciarVendedores();
            HardcodearProductos();
        }

        /// <summary>
        /// Inicializa la lista de productos de carne y la heladera.
        /// </summary>
        static void HardcodearProductos() 
        {
           listaCarnes = new List<Producto>()
            {
                new Producto(1000, 10, "Bondiola"),
                new Producto(1200, 10, "Vacio"),
                new Producto(1500, 10, "Tira de Asado"),
                new Producto(2500, 10, "Chorizo"),
                new Producto(1800, 10, "Costillar")
            };
            heladera = new Heladera(listaCarnes) ;
        }
        /// <summary>
        /// Inicializa la lista de clientes.
        /// </summary>
        static void InstanciarClientes()
        {
            clientes = new List<Cliente>()
            {
                new Cliente(20000,new List<Producto>(),"Ricardo","richard@gmail.com","ric123"),
                new Cliente(20000,new List<Producto>(),"Ramon","ramon@gmail.com", "ric123"),
                new Cliente(20000,new List<Producto>(),"Romualdo","romualdo@gmail.com", "ric123")
            };
        }
        /// <summary>
        /// Inicializa la lista de vendedores.
        /// </summary>
        static void InstanciarVendedores()
        {
            vendedores = new List<Vendedor>()
            {
                new Vendedor("Lucas","lucas@gmail.com","1234"),
                new Vendedor("Leo","leo@gmail.com", "1234"),
                new Vendedor("Lautaro","lautaro@gmail.com", "1234")
            };
        }

        /// <summary>
        /// Función que busca un usuario en la lista de clientes y vendedores para loguearlo en el sistema.
        /// </summary>
        /// <param name="idUser">El número de identificación del usuario.</param>
        /// <param name="password">El usuario logueado en caso de que se encuentre en la lista de clientes o vendedores, de lo contrario retorna null.</param>
        /// <returns> El usuario logueado en caso de que se encuentre en la lista de clientes o vendedores, de lo contrario retorna null.</returns>
        public static Usuario LoguearUsuario(string mail, string password)
        {
            foreach (Cliente cli in Clientes)
            {
                if (cli.Mail == mail && cli.ComprobarContra(password))
                    return cli;
            }
            foreach (Vendedor vend in Vendedores)
            {
                if (vend.Mail == mail && vend.ComprobarContra(password))
                    return vend;
            }
            return null;
        }
        /// <summary>
        /// Función que determina si un usuario es un cliente o vendedor a partir de su número de identificación.
        /// </summary>
        /// <param name="idUser"> El número de identificación del usuario.</param>
        /// <returns>"cliente" si el usuario se encuentra en la lista de clientes, "vendedor" si se encuentra en la lista de vendedores, de lo contrario retorna null.</returns>
        public static string SelectorUsuario(string mailUser)
        {
            
            foreach (var cli in clientes)
            {
                
                if (mailUser == cli.Mail)
                {
                    return "cliente";
                }
            }
            foreach (var vend in vendedores)
            {
                if (mailUser == vend.Mail)
                {
                    return "vendedor";
                }
            }
            return "error";
        }

    }
}
