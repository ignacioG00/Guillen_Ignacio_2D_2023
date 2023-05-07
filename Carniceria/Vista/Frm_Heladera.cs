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
    public partial class Frm_Heladera : Form
    {
       //BindingSource dataGridView1;
        public Frm_Heladera()
        {
            InitializeComponent();
        }

        private void Frm_Heladera_Load(object sender, EventArgs e)
        {
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

        private void btn_bondiola_Click(object sender, EventArgs e)
        {
            Negocio.Heladera.ReponerProducto(Negocio.Heladera.ListaCarnes, "Bondiola");
            ActualizarListas();
        }

        private void btn_vacio_Click(object sender, EventArgs e)
        {
            Negocio.Heladera.ReponerProducto(Negocio.Heladera.ListaCarnes, "Vacio");
            ActualizarListas();
        }

        private void btn_tiraAsado_Click(object sender, EventArgs e)
        {
            Negocio.Heladera.ReponerProducto(Negocio.Heladera.ListaCarnes, "Tira de Asado");
            ActualizarListas();
        }

        private void btn_chorizo_Click(object sender, EventArgs e)
        {
            Negocio.Heladera.ReponerProducto(Negocio.Heladera.ListaCarnes, "Choripan");
            ActualizarListas();
        }

        private void btn_costillar_Click(object sender, EventArgs e)
        {
            Negocio.Heladera.ReponerProducto(Negocio.Heladera.ListaCarnes, "Costillar");
            ActualizarListas();
        }

        private void btn_actualizarLista_Click(object sender, EventArgs e)
        {
            ActualizarListas();
        }
    }
}
