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
        public Usuario userAux;

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
        private void Frm_Compra_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Negocio.Clientes.Count; i++)
            {
                cb_listaClientes.Items.Add(Negocio.Clientes[i].Dni);
            }
            if (Negocio.SelectorUsuario(userAux.Dni) == "cliente")
            {
                cb_listaClientes.Hide();
                lb_venderA.Text = "Cliente Actual: " + userAux.Nombre;
                MessageBox.Show("INGRESE MONTO A GASTAR PARA PODER REALIZAR LA COMPRA.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btn_anotarPedido_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("DESEA AGREGAR EL PRODUCTO?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                HacerPedido();
            }
            else
            {
                MessageBox.Show("PEDIDO NO CARGADO", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btn_anularCompra_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("DESEA BORRAR LA LISTA DE VENTAS? SE BORRARAN LOS PEDIDOS DETALLADOS", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes && total > 0)
            {
                AnularPedidos(); 
            }
            else
            {
                MessageBox.Show("ERROR. NO HAY PEDIDOS CREADOS", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btn_actualizarLista_Click(object sender, EventArgs e)
        {
            ActualizarListas();
        }

        private void btn_realizarPago_Click(object sender, EventArgs e)
        {
            Cliente clienteAux;
            if (Negocio.SelectorUsuario(userAux.Dni) == "vendedor" && !string.IsNullOrEmpty(tb_montoMax.Text))
            {
                clienteAux = Cliente.RetornarCliente(int.Parse(cb_listaClientes.Text), Negocio.Clientes);
                clienteAux.MontoMax = decimal.Parse(tb_montoMax.Text);
            }
            else
            {
                if (!string.IsNullOrEmpty(tb_montoMax.Text))
                {
                    clienteAux = Cliente.RetornarCliente(userAux.Dni, Negocio.Clientes);
                    clienteAux.MontoMax = decimal.Parse(tb_montoMax.Text);
                }
                else
                {
                    MessageBox.Show("COLOQUE MONTO MAXIMO PARA REALIZAR COMPRA!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            DialogResult resultado = MessageBox.Show("DESEA REALIZAR EL PAGO? \n" + rtb_cuenta.Text +
                "\nSi eligio credito tendra un 5% de recargo.\n" +
                "Total con credito: $" + (total * (decimal)1.05) +
                "\n Saldo de " + clienteAux.Nombre +
                ": $" + clienteAux.MontoMax
                , "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes && total > 0 && clienteAux.MontoMax > total)
            {
                clienteAux.ProductosComprados = listAux;
                if (cb_tipoPago.Text == "Credito")
                {
                    total = total * (decimal)1.05;
                    clienteAux.MontoMax -= total;
                    RealizarPago(clienteAux, total);
                }
                else
                {
                    RealizarPago(clienteAux, total);
                }
            }
            else
            {
                if (resultado == DialogResult.Yes && tb_kg.Text == "" && int.Parse(tb_kg.Text)<1)                
                {
                    MessageBox.Show("ERROR NO COLOCO NINGUNA CANTIDAD EN KILOS!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (clienteAux.MontoMax<total)
                    {
                        MessageBox.Show("EL MONTO MAXIMO ES MENOR AL DE LA COMPRA, AGREGAR MONTO!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    MessageBox.Show("VENTA NO REALIZADA!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
        }
        private void RealizarPago(Cliente cliente, decimal montoACobrar)
        {
            cliente.MontoMax -= total;
            
            for (int i = 0; i < cliente.ProductosComprados.Count; i++)
            {
                if (cliente.ProductosComprados[i].Stock > 0)
                {
                    rtb_cuenta.Text += cliente.ProductosComprados[i].CorteDeCarne.ToString() + " " + cliente.ProductosComprados[i].Stock + "\n";
                    
                }
            }
            Factura facturaAux = new Factura(cliente.Nombre, userAux.Nombre, cliente.ProductosComprados, montoACobrar);
            Negocio.ListFacturaAux.Add(facturaAux);
            total = 0;
            cuenta = 0;
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
                            if (Negocio.Heladera.ListaCarnes[i].Stock > int.Parse(tb_kg.Text))
                            {
                                listAux[i].Stock += kilosLlevados;
                                cuenta = Negocio.Heladera.ListaCarnes[i].PrecioPorKilo * Decimal.Parse(tb_kg.Text);
                                Negocio.Heladera.QuitarProducto(Negocio.Heladera.ListaCarnes, item.ToString(), kilosLlevados);
                                total += cuenta;
                                rtb_cuenta.AppendText(item.ToString() + " " + kilosLlevados + " kg" + "\n");
                            }
                            else
                            {
                                MessageBox.Show("ERROR. NO HAY STOCK DE: " + item.ToString() + "!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                break;
                            }
                            
                        }
                        
                    }
                    rtb_cuenta.AppendText(cuenta + "\n");
                }

                kilosLlevados = 0;
                lb_total.Text = "total: " + total + " PESOS";
                rtb_cuenta.AppendText("----------------------------\n");
                rtb_cuenta.AppendText("Esta gastando: " + total + "$" + "\n");
                rtb_cuenta.AppendText("----------------------------\n");
                ActualizarListas();

            }
            else
            {
                MessageBox.Show("ERROR NO COLOCO NINGUNA CANTIDAD EN KILOS!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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

        private void cb_tipoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_tipoPago.Text == "Credito")
            {
                lb_total.Text = "total: " + (total * (decimal)1.05) + " PESOS";
            }
            else
            {
                lb_total.Text = "total: " + total + " PESOS";
            }
        }

        private void btn_historial_Click(object sender, EventArgs e)
        {
            Frm_Historial historial = new Frm_Historial();
            historial.Show();
        }

        private void btn_limpiarRtb_Click(object sender, EventArgs e)
        {
            rtb_cuenta.Clear();
        }

        private void Frm_Compra_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }
    }
}
