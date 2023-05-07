using Carniceria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Vista
{
    public partial class Frm_Compra : Form
    {
        decimal cuenta = 0;
        decimal total = 0;
        decimal kilosLlevados = 0;
        List<Producto> listAux = new List<Producto>() 
        {
            new Producto(1000, 0, "Bondiola"),
            new Producto(1200, 0, "Vacio"),
            new Producto(1500, 0, "Tira de Asado"),
            new Producto(2500, 0, "Chorizo"),
            new Producto(1800, 0, "Costillar")
        };

        public Frm_Compra()
        {
            InitializeComponent();
            ActualizarListas();
        }

        public void ActualizarListas()
        {
            dgv_listaCarnes.Rows.Clear();
            for (int i = 0; i < Negocio.Heladera.ListaCarnes.Count; i++)
            {
                int n = dgv_listaCarnes.Rows.Add();

                dgv_listaCarnes.Rows[n].Cells[0].Value = Negocio.Heladera.ListaCarnes[i].CorteDeCarne;
                dgv_listaCarnes.Rows[n].Cells[1].Value = Negocio.Heladera.ListaCarnes[i].Stock;
                dgv_listaCarnes.Rows[n].Cells[2].Value = Negocio.Heladera.ListaCarnes[i].PrecioPorKilo;
            }
        }

        private void btn_anotarPedido_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("DESEA REALIZAR LA VENTA?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                HacerPedido();
            }
            else
            {
                MessageBox.Show("VENTA ANULADA", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
            }
        }

        private void Frm_Compra_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Negocio.Clientes.Count; i++)
            {
                cb_listaClientes.Items.Add(Negocio.Clientes[i].Nombre);
            }

        }

        private void btn_anularCompra_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("DESEA BORRAR LA LISTA DE VENTAS? SE BORRARAN LOS PEDIDOS DETALLADOS", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                AnularPedidos();
            }

        }

        private void AnularPedidos() 
        {
            rtb_cuenta.Clear();
            lb_total.Text = "total: ";
            cuenta = 0;
            total = 0;
            foreach (var item in Negocio.Heladera.ListaCarnes)
            {
                for (int i = 0; i < listAux.Count; i++)
                {
                    if (item.CorteDeCarne == listAux[i].CorteDeCarne)
                    {
                        item.Stock += listAux[i].Stock;
                        listAux[i].Stock = 0;
                    }
                }
            }
        }

        private void HacerPedido()
        {

            if (!string.IsNullOrEmpty(tb_kg.Text))
            {
                kilosLlevados += Decimal.Parse(tb_kg.Text);
                foreach (var item in clb_carnes.CheckedItems)
                {
                    for (int i = 0; i < Negocio.Heladera.ListaCarnes.Count; i++)
                    {
                        if (item.ToString() == Negocio.Heladera.ListaCarnes[i].CorteDeCarne)
                        {
                            listAux[i].Stock += kilosLlevados;
                            cuenta = Negocio.Heladera.ListaCarnes[i].PrecioPorKilo * Decimal.Parse(tb_kg.Text);
                            Negocio.Heladera.QuitarProducto(Negocio.Heladera.ListaCarnes, item.ToString(), kilosLlevados);
                            total += cuenta;
                            rtb_cuenta.AppendText(item.ToString() + " " + kilosLlevados + " kg" + "\n");
                        }
                    }
                    rtb_cuenta.AppendText(cuenta + "\n");
                }
                kilosLlevados = 0;
                rtb_cuenta.AppendText("----------------------------\n");
                rtb_cuenta.AppendText("Esta gastando: " + total + "$" + "\n");
                rtb_cuenta.AppendText("----------------------------\n");
                lb_total.Text = "total: " + total + " PESOS";
                ActualizarListas();

            }
            else
            {
                MessageBox.Show("ERROR NO COLOCO NINGUNA CANTIDAD EN KILOS!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_actualizarLista_Click(object sender, EventArgs e)
        {
            ActualizarListas();
        }

        private void btn_realizarPago_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("DESEA REALIZAR EL PAGO? \n" + rtb_cuenta.Text, "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                
            }
            else
            {
                AnularPedidos();
            }
        }
    }
}
