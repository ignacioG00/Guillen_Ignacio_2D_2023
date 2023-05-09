using Carniceria;
using Microsoft.VisualBasic.Logging;
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
            CargarCarnes();
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

            if (string.IsNullOrEmpty(tb_montoMax.Text))
            {
                MessageBox.Show("COLOQUE MONTO MAXIMO PARA REALIZAR COMPRA!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Negocio.SelectorUsuario(userAux.Dni) == "vendedor")
            {
                clienteAux = Cliente.RetornarCliente(int.Parse(cb_listaClientes.Text), Negocio.Clientes);
            }
            else
            {
                clienteAux = Cliente.RetornarCliente(userAux.Dni, Negocio.Clientes);
            }
            clienteAux.MontoMax = decimal.Parse(tb_montoMax.Text);
            decimal totalConRecargo = total * (decimal)1.05;

            DialogResult resultado = MessageBox.Show("DESEA REALIZAR EL PAGO? \n" + rtb_cuenta.Text +
                "\nSi eligio credito tendra un 5% de recargo.\n" +
                "Total con credito: $" + totalConRecargo +
                "\n Saldo de " + clienteAux.Nombre +
                ": $" + clienteAux.MontoMax
                , "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes && total > 0 && clienteAux.MontoMax > total)
            {
                clienteAux.ProductosComprados = listAux;
                if (cb_tipoPago.Text == "Credito")
                {
                    clienteAux.MontoMax -= totalConRecargo;
                    RealizarPago(clienteAux, totalConRecargo);
                }
                else
                {
                    RealizarPago(clienteAux, total);
                }
            }
            else
            {
                if (tb_kg.Text == "" || int.Parse(tb_kg.Text) < 1)
                {
                    MessageBox.Show("ERROR NO COLOCO NINGUNA CANTIDAD EN KILOS!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (clienteAux.MontoMax < total)
                {
                    MessageBox.Show("EL MONTO MAXIMO ES MENOR AL DE LA COMPRA, AGREGAR MONTO!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("VENTA NO REALIZADA!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
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

        private void Frm_Compra_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        /// <summary>
        /// Realiza el pago de la compra realizada por un cliente y descuenta su monto máximo disponible.
        /// </summary>
        /// <param name="cliente">El objeto cliente que realizó la compra.</param>
        /// <param name="montoACobrar">El monto total a cobrar por la compra.</param>
        private void RealizarPago(Cliente cliente, decimal montoACobrar)
        {
            cliente.MontoMax -= total;

            for (int i = 0; i < cliente.ProductosComprados.Count; i++)
            {
                if (cliente.ProductosComprados[i].Stock > 0)
                {
                    rtb_cuenta.AppendText(cliente.ProductosComprados[i].CorteDeCarne.ToString() + " " + cliente.ProductosComprados[i].Stock + "\n");
                }
            }

            Factura facturaAux = new Factura(cliente.Nombre, userAux.Nombre, cliente.ProductosComprados, montoACobrar);
            Negocio.ListFacturaAux.Add(facturaAux);
            total = 0;
            cuenta = 0;
        }
        /// <summary>
        /// Método para anular los pedidos realizados por el cliente.
        /// Este método limpia la cuenta del cliente y el total a cobrar, y recorre los productos comprados por el cliente para cargarles los productos que compro.
        /// </summary>
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

        /// <summary>
        /// Hace un pedido de carne según los elementos seleccionados en CheckedListBox y la cantidad ingresada en el TextBox de kilos.
        /// Actualiza el stock de la carne seleccionada y la cuenta total del pedido.
        /// </summary>
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
                                MessageBox.Show($"ERROR. NO HAY STOCK DE: {item}!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        /// <summary>
        /// Actualiza la lista del datagriedview y recarga el combolistbox en caso de añadirse un nuevo producto.
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
        public void CargarCarnes()
        {
            /// <summary>
            /// Carga la lista de cortes de carne del objeto Negocio en un ComboListBox.
            /// </summary>
            /// 
            clb_carnes.Items.Clear();
            for (int i = 0; i < Negocio.ListaCarnes.Count; i++)
            {
                clb_carnes.Items.Add(Negocio.ListaCarnes[i].CorteDeCarne);
            }
        }
        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
