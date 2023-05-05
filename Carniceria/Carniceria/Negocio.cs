﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

         public static List<Producto> ListaCarnes { get => listaCarnes; set => listaCarnes = value; }
         static List<Cliente> Clientes { get => clientes; set => clientes = value; }
         static List<Vendedor> Vendedores { get => vendedores; set => vendedores = value; }
         public static Heladera Heladera { get => heladera; set => heladera = value; }

        static Negocio()
        {
            InstanciarClientes();
            InstanciarVendedores();
            HardcodearProductos();
        }

        public static void HardcodearProductos() 
        {
           listaCarnes = new List<Producto>()
            {
                new Producto(1000, 10, "Bondiola"),
                new Producto(1200, 10, "Vacio"),
                new Producto(1500, 10, "Tira de Asado"),
                new Producto(2500, 10, "Choripan"),
                new Producto(1800, 10, "Costillar")
            };
            heladera = new Heladera(listaCarnes) ;
        }
        public static void InstanciarClientes()
        {
            clientes = new List<Cliente>()
            {
                new Cliente(20000,null,"Ricardo",22222,"ric123"),
                new Cliente(20000,null,"Ramon",21563, "ric123"),
                new Cliente(20000,null,"Romualdo",21562, "ric123")
                //int montoMax, List<Producto> productosComprados,string nombre, int dni, string user, string contraseña
            };
        }
        public static void InstanciarVendedores()
        {
            vendedores = new List<Vendedor>()
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
