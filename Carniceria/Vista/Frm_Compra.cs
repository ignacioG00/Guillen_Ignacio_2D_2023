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
        decimal kilosLlevados= 0;
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
            if (!string.IsNullOrEmpty(tb_kg.Text))
            {
                kilosLlevados += Decimal.Parse(tb_kg.Text);
                foreach (var item in clb_carnes.CheckedItems)
                {
                    foreach (var tipoCarne in Negocio.Heladera.ListaCarnes)
                    {
                        if (tipoCarne.CorteDeCarne == item.ToString())
                        {
                            
                            cuenta = tipoCarne.PrecioPorKilo * Decimal.Parse(tb_kg.Text);
                            total += cuenta;
                            rtb_cuenta.AppendText(item.ToString() + kilosLlevados + " kg" + "\n");
                        }
                    }
                    rtb_cuenta.AppendText(cuenta + "\n");
                }
                rtb_cuenta.AppendText("----------------------------\n");
                rtb_cuenta.AppendText("Esta gastando: " + total + "$" + "\n");
                rtb_cuenta.AppendText("----------------------------\n");
                lb_total.Text = "total: " + total + " PESOS";
            }
            else
            {
                MessageBox.Show("ERROR NO COLOCO NINGUNA CANTIDAD EN KILOS!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("DESEA ANULAR LA COMPRA? SE BORRARA TODO EL PEDIDO MARCADO", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                rtb_cuenta.Clear();
                lb_total.Text = "total: ";
                cuenta = 0;
                total = 0;
                kilosLlevados = 0;
            }
        }
    }
}
