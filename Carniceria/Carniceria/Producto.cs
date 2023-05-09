using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carniceria
{
    public class Producto
    {
        private decimal precioPorKilo;
        private decimal stock;
        private string corteDeCarne;

        public Producto(decimal precioPorKilo, decimal stock, string corteDeCarne)
        {
            this.PrecioPorKilo = precioPorKilo;
            this.stock = stock;
            this.corteDeCarne = corteDeCarne;
        }

        public decimal Stock { get { return stock; } set { stock = value; } }
        public string CorteDeCarne { get { return corteDeCarne; } }

        public decimal PrecioPorKilo { get => precioPorKilo; set => precioPorKilo = value; }

        public static bool CorteNoExistente(List<Producto> listCarnes,string nombreCorte)
        {
            int contador = 0;
            for (int i = 0; i < Negocio.ListaCarnes.Count; i++)
            {
                if (nombreCorte == Negocio.ListaCarnes[i].CorteDeCarne)
                {
                    contador +=1;
                }
            }
            return (contador == 0);
        }
    }
}
