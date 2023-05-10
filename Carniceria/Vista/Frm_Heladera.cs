﻿using Carniceria;
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
        public Frm_Heladera()
        {
            InitializeComponent();
        }

        private void Frm_Heladera_Load(object sender, EventArgs e)
        {
            ActualizarListas();
            CargarCarnes();
        }

        /// <summary>
        /// Carga la lista de cortes de carne del objeto Negocio en un ComboBox.
        /// </summary>
        public void CargarCarnes() 
        {
            cb_listaCarnes.Items.Clear();   
            for (int i = 0; i < Negocio.ListaCarnes.Count; i++)
            {
                cb_listaCarnes.Items.Add( Negocio.ListaCarnes[i].CorteDeCarne);
            }
        }

        /// <summary>
        /// Actualiza la lista de carnes en dgv y en el combobox.
        /// </summary>
        public void ActualizarListas()
        {
            CargarCarnes();
            dgv_listaCarnes.Rows.Clear();
            for (int i = 0; i < Negocio.Heladera.ListaCarnes.Count; i++)
            {
                int n = dgv_listaCarnes.Rows.Add();

                dgv_listaCarnes.Rows[n].Cells[0].Value = Negocio.Heladera.ListaCarnes[i].CorteDeCarne;
                dgv_listaCarnes.Rows[n].Cells[1].Value = Negocio.Heladera.ListaCarnes[i].Stock;
                dgv_listaCarnes.Rows[n].Cells[2].Value = Negocio.Heladera.ListaCarnes[i].PrecioPorKilo;
            }
        }
        private void btn_actualizarLista_Click(object sender, EventArgs e)
        {
            ActualizarListas();
        }

        private void btn_fijarPrecioxKilo_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Negocio.Heladera.ListaCarnes.Count; i++)
            {
                if (cb_listaCarnes.Text == Negocio.Heladera.ListaCarnes[i].CorteDeCarne)
                {
                    if (decimal.TryParse(tb_fijarPrecio.Text, out decimal result))
                    {
                        Negocio.Heladera.ListaCarnes[i].PrecioPorKilo = result;
                    }
                    else
                    {
                        MessageBox.Show("Ingrese un valor numérico válido");
                    }
                }
            }
        }
        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_nuevoProducto_Click(object sender, EventArgs e)
        {
            if (Producto.CorteNoExistente(Negocio.Heladera.ListaCarnes, tb_nombreCorte.Text))
            {
                if (decimal.TryParse(tb_precioxkilo.Text, out decimal result))
                {
                    Negocio.Heladera.ListaCarnes.Add(new Producto(result, 0, tb_nombreCorte.Text));
                    ActualizarListas();
                    CargarCarnes();
                }
                else
                {
                    MessageBox.Show("Ingrese un valor numérico válido");
                }
            }
        }

        private void btn_reponerCarnes_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(tb_cantAReponer.Text, out decimal result))
            {
                Negocio.Heladera.ReponerProducto(Negocio.Heladera.ListaCarnes, cb_listaCarnes.Text, result);
                ActualizarListas();
            }
            else
            {
                MessageBox.Show("Ingrese un valor numérico válido");
            }
        }
    }
}
