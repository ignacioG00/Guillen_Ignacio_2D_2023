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

namespace Vista
{
    public partial class Frm_Historial : Form
    {
        public Frm_Historial()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActualizarListas();
        }

        public void ActualizarListas()
        {
            dgv_histFacturas.Rows.Clear();
            for (int i = 0; i < Negocio.ListFacturaAux.Count; i++)
            {
                int n = dgv_histFacturas.Rows.Add();

                dgv_histFacturas.Rows[n].Cells[0].Value = Negocio.ListFacturaAux[i].NombreVendedor;
                dgv_histFacturas.Rows[n].Cells[1].Value = Negocio.ListFacturaAux[i].NombreCliente;
                for (int j = 0; j < Negocio.ListFacturaAux[i].ProductosVendidos.Count; j++)
                {
                    if (Negocio.ListFacturaAux[i].ProductosVendidos[j].Stock>0)
                    {
                        dgv_histFacturas.Rows[n].Cells[2].Value += Negocio.ListFacturaAux[i].ProductosVendidos[j].CorteDeCarne + " " + Negocio.ListFacturaAux[i].ProductosVendidos[j].Stock + "kg \n";
                    }
                }
                dgv_histFacturas.Rows[n].Cells[3].Value = Negocio.ListFacturaAux[i].MontoVenta;

            }
        }

        private void Frm_Historial_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }
    }
}
