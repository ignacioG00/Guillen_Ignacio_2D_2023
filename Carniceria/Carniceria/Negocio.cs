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
        static List<Usuario> vendedores;
        static Heladera heladera;
        static List<Factura> listFacturaAux = new();
        
        public static List<Producto> ListaCarnes { get => listaCarnes; set => listaCarnes = value; }
        public static List<Cliente> Clientes { get => clientes; set => clientes = value; }
        static List<Usuario> Vendedores { get => vendedores; set => vendedores = value; }
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
                new Cliente(20000,new List<Producto>(),"Ricardo",22222,"ric123"),
                new Cliente(20000,new List<Producto>(),"Ramon",21563, "ric123"),
                new Cliente(20000,new List<Producto>(),"Romualdo",21562, "ric123")
                //int montoMax, List<Producto> productosComprados,string nombre, int dni, string user, string contraseña
            };
        }
        /// <summary>
        /// Inicializa la lista de vendedores.
        /// </summary>
        static void InstanciarVendedores()
        {
            vendedores = new List<Usuario>()
            {
                new Usuario("Lucas",21564,"1234"),
                new Usuario("Leo",21563, "1234"),
                new Usuario("Lautaro",21562, "1234")
            };
        }

        /// <summary>
        /// Función que busca un usuario en la lista de clientes y vendedores para loguearlo en el sistema.
        /// </summary>
        /// <param name="idUser">El número de identificación del usuario.</param>
        /// <param name="password">El usuario logueado en caso de que se encuentre en la lista de clientes o vendedores, de lo contrario retorna null.</param>
        /// <returns> El usuario logueado en caso de que se encuentre en la lista de clientes o vendedores, de lo contrario retorna null.</returns>
        public static Usuario LoguearUsuario(int idUser, string password)
        {
            foreach (Cliente item in Clientes)
            {
                if (item.Dni == idUser && item.ComprobarContra(password))
                    return item;
            }
            foreach (Usuario item in Vendedores)
            {
                if (item.Dni == idUser && item.ComprobarContra(password))
                    return item;
            }
            return null;
        }
        /// <summary>
        /// Función que determina si un usuario es un cliente o vendedor a partir de su número de identificación.
        /// </summary>
        /// <param name="idUser"> El número de identificación del usuario.</param>
        /// <returns>"cliente" si el usuario se encuentra en la lista de clientes, "vendedor" si se encuentra en la lista de vendedores, de lo contrario retorna null.</returns>
        public static string SelectorUsuario(int idUser)
        {
            
            foreach (var cli in clientes)
            {
                
                if (idUser == cli.Dni)
                {
                    return "cliente";
                }
            }
            foreach (var vend in vendedores)
            {
                if (idUser == vend.Dni)
                {
                    return "vendedor";
                }
            }
            return null;
        }

    }
}
