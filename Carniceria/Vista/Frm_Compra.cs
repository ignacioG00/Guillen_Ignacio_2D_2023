﻿using Carniceria;
using System.Media;
using TextBox = System.Windows.Forms.TextBox;

namespace Vista
{
    public partial class Frm_Compra : Form
    {
        decimal cuenta = 0;
        decimal total = 0;
        decimal kilosLlevados = 0;
        public Usuario userAux;
        private SoundPlayer sonidoCompra = new SoundPlayer();

        static List<Producto> listAux = new List<Producto>()
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
            LimpiarVentana();
            cb_tipoPago.DataSource = Enum.GetValues(typeof(Negocio.TipoPago));
        }

        private List<Producto> RetornarCopiaListAux(List<Producto> productos) 
        {
            List<Producto> listCopia = new List<Producto>();
            foreach (var item in productos)
            {
                if (item.Stock>0)
                {
                    Producto nuevoProducto = new Producto(item.PrecioPorKilo, item.Stock, item.CorteDeCarne);
                    listCopia.Add(nuevoProducto);
                }
            }
            return listCopia;
        }
        private void Frm_Compra_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Negocio.Clientes.Count; i++)
            {
                cb_listaClientes.Items.Add(Negocio.Clientes[i].Mail);
            }
            CargarCarnes();
        }

        private void btn_anotarPedido_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("DESEA AGREGAR EL PRODUCTO?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                sonidoCompra.SoundLocation = @"C:\Escritorio\UTN\Guillen_Ignacio_2D_2023\Carniceria\Vista\Properties\Data\sonidos\correct.wav";
                sonidoCompra.Play();
                HacerPedido();
            }
            else
            {
                sonidoCompra.SoundLocation = @"C:\Escritorio\UTN\Guillen_Ignacio_2D_2023\Carniceria\Vista\Properties\Data\sonidos\error.wav";
                sonidoCompra.Play();
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
                sonidoCompra.SoundLocation = @"C:\Escritorio\UTN\Guillen_Ignacio_2D_2023\Carniceria\Vista\Properties\Data\sonidos\error.wav";
                sonidoCompra.Play();
                MessageBox.Show("ERROR. NO HAY PEDIDOS CREADOS", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btn_actualizarLista_Click(object sender, EventArgs e)
        {
            sonidoCompra.SoundLocation = @"C:\Escritorio\UTN\Guillen_Ignacio_2D_2023\Carniceria\Vista\Properties\Data\sonidos\correct.wav";
            sonidoCompra.Play();
            ActualizarListas();
        }

        private void btn_realizarPago_Click(object sender, EventArgs e)
        {
            Cliente clienteAux;

            if (string.IsNullOrEmpty(tb_montoMax.Text) || decimal.Parse(tb_montoMax.Text) < 0)
            {
                sonidoCompra.SoundLocation = @"C:\Escritorio\UTN\Guillen_Ignacio_2D_2023\Carniceria\Vista\Properties\Data\sonidos\error.wav";
                sonidoCompra.Play();
                MessageBox.Show("COLOQUE MONTO VALIDO PARA REALIZAR COMPRA (debe ser un numero mayor a 0)!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Negocio.SelectorUsuario(userAux.Mail) == "vendedor")
            {
                if (string.IsNullOrEmpty(cb_listaClientes.Text))
                {
                    sonidoCompra.SoundLocation = @"C:\Escritorio\UTN\Guillen_Ignacio_2D_2023\Carniceria\Vista\Properties\Data\sonidos\error.wav";
                    sonidoCompra.Play();
                    MessageBox.Show("ERROR.ELIJA UN CLIENTE!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                clienteAux = Cliente.RetornarCliente(cb_listaClientes.Text, Negocio.Clientes);
            }
            else
            {
                clienteAux = Cliente.RetornarCliente(userAux.Mail, Negocio.Clientes);
            }
            clienteAux.MontoMax = decimal.Parse(tb_montoMax.Text);
            decimal totalConRecargo = total * (decimal)1.05;

            DialogResult resultado = MessageBox.Show("DESEA REALIZAR EL PAGO? \n" + rtb_cuenta.Text +
                "\nSi eligio credito tendra un 5% de recargo.\n" +
                "Total c/credito: $" + totalConRecargo + " / " +
                "Total s/credito: $" + total +
                "\n Saldo de " + clienteAux.Nombre +
                ": $" + clienteAux.MontoMax
                , "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes && total > 0 && clienteAux.MontoMax > total)
            {
                sonidoCompra.SoundLocation = @"C:\Escritorio\UTN\Guillen_Ignacio_2D_2023\Carniceria\Vista\Properties\Data\sonidos\caja.wav";
                sonidoCompra.Play();
                clienteAux.ProductosComprados = RetornarCopiaListAux(listAux);
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
                    sonidoCompra.SoundLocation = @"C:\Escritorio\UTN\Guillen_Ignacio_2D_2023\Carniceria\Vista\Properties\Data\sonidos\error.wav";
                    sonidoCompra.Play();
                    MessageBox.Show("ERROR NO COLOCO NINGUNA CANTIDAD EN KILOS!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (clienteAux.MontoMax < total)
                {
                    sonidoCompra.SoundLocation = @"C:\Escritorio\UTN\Guillen_Ignacio_2D_2023\Carniceria\Vista\Properties\Data\sonidos\error.wav";
                    sonidoCompra.Play();
                    MessageBox.Show("EL MONTO MAXIMO ES MENOR AL DE LA COMPRA, AGREGAR MONTO!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    sonidoCompra.SoundLocation = @"C:\Escritorio\UTN\Guillen_Ignacio_2D_2023\Carniceria\Vista\Properties\Data\sonidos\error.wav";
                    sonidoCompra.Play();
                    MessageBox.Show("VENTA NO REALIZADA!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    clienteAux.ProductosComprados.Clear();
                }
            }
            VaciarStockComprado();
        }
        private void cb_tipoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_tipoPago.Text == "credito")
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
            sonidoCompra.SoundLocation = @"C:\Escritorio\UTN\Guillen_Ignacio_2D_2023\Carniceria\Vista\Properties\Data\sonidos\correct.wav";
            sonidoCompra.Play();
            Frm_Historial historial = new Frm_Historial();
            historial.Show();
        }

        private void btn_limpiarRtb_Click(object sender, EventArgs e)
        {
            sonidoCompra.SoundLocation = @"C:\Escritorio\UTN\Guillen_Ignacio_2D_2023\Carniceria\Vista\Properties\Data\sonidos\correct.wav";
            sonidoCompra.Play();
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

        static void VaciarStockComprado()
        {
            for (int i = 0; i < listAux.Count; i++)
            {
                listAux[i].Stock = 0;
            }
        }

        /// <summary>
        /// Realiza el pago de la compra realizada por un cliente y descuenta su monto máximo disponible.
        /// </summary>
        /// <param name="cliente">El objeto cliente que realizó la compra.</param>
        /// <param name="montoACobrar">El monto total a cobrar por la compra.</param>
        private void RealizarPago(Cliente cliente, decimal montoACobrar)
        {
            cliente.MontoMax -= total;
            string factura = "* FACTURA DE LA COMPRA * \n";
            for (int i = 0; i < cliente.ProductosComprados.Count; i++)
            {
                if (cliente.ProductosComprados[i].Stock > 0)
                {
                    factura += cliente.ProductosComprados[i].CorteDeCarne.ToString() + " " + cliente.ProductosComprados[i].Stock + "\n";
                }
            }
            Factura facturaAux = new Factura(cliente.Nombre, userAux.Nombre, cliente.ProductosComprados, montoACobrar);
            Negocio.ListFacturaAux.Add(facturaAux);
            MessageBox.Show(factura, "COMPRA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarVentana();
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
                    if (item == listAux[i])
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
                if (decimal.TryParse(tb_kg.Text, out decimal result))
                {
                    kilosLlevados += result;
                }
                else
                {
                    sonidoCompra.SoundLocation = @"C:\Escritorio\UTN\Guillen_Ignacio_2D_2023\Carniceria\Vista\Properties\Data\sonidos\error.wav";
                    sonidoCompra.Play();
                    MessageBox.Show("ERROR. ELIJE UNA CANTIDAD VALIDA!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

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
                                Negocio.Heladera.QuitarProducto(Negocio.Heladera.ListaCarnes, Negocio.Heladera.ListaCarnes[i].CorteDeCarne, kilosLlevados);
                                total += cuenta;
                                rtb_cuenta.AppendText(item.ToString() + " " + kilosLlevados + " kg" + "\n");
                            }
                            else
                            {
                                sonidoCompra.SoundLocation = @"C:\Escritorio\UTN\Guillen_Ignacio_2D_2023\Carniceria\Vista\Properties\Data\sonidos\error.wav";
                                sonidoCompra.Play();
                                MessageBox.Show($"ERROR. NO HAY STOCK DE: {item}!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                break;
                            }
                        }
                    }
                    rtb_cuenta.AppendText(cuenta + "\n");
                }
                kilosLlevados = 0;
                lb_total.Text = "total: " + total + " PESOS";
                ActualizarListas();
            }
            else
            {
                sonidoCompra.SoundLocation = @"C:\Escritorio\UTN\Guillen_Ignacio_2D_2023\Carniceria\Vista\Properties\Data\sonidos\error.wav";
                sonidoCompra.Play();
                MessageBox.Show("ERROR NO COLOCO NINGUNA CANTIDAD EN KILOS!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Actualiza la lista del datagriedview y recarga el combolistbox en caso de añadirse un nuevo producto.
        /// </summary>
        public void ActualizarListas()
        {
            sonidoCompra.SoundLocation = @"C:\Escritorio\UTN\Guillen_Ignacio_2D_2023\Carniceria\Vista\Properties\Data\sonidos\correct.wav";
            sonidoCompra.Play();
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

        private void tb_montoMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // solo permitir un punto decimal
            if ((e.KeyChar == ',') && (((TextBox)sender).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void tb_kg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // solo permitir un punto decimal
            if ((e.KeyChar == ',') && (((TextBox)sender).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }
        private void LimpiarVentana()
        {
            tb_kg.Text = "";
            tb_montoMax.Text = "";
            rtb_cuenta.Text = "";
            lb_total.Text = "Total: ";
        }
    }
}
