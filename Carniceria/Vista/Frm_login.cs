using Carniceria;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Vista
{
    public partial class Frm_Login : Form
    {
        Frm_Heladera heladera = new Frm_Heladera();
        Frm_Compra compras = new Frm_Compra();
        Usuario userAux;
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            ValidarIngreso(tb_usuario.Text, tb_contra.Text);
            if (userAux is not null)
            {
                if (Negocio.SelectorUsuario(userAux.Mail) == "vendedor")
                {
                    heladera.BackColor = Color.RosyBrown;
                    heladera.Show();
                    compras.BackColor = Color.RosyBrown;
                    compras.userAux = userAux;
                    compras.cb_listaClientes.Show();
                    compras.btn_historial.Show();
                    compras.lb_venderA.Text = "Vender a:";
                    compras.Show();
                }
                else if (Negocio.SelectorUsuario(userAux.Mail) == "cliente")
                {
                    compras.BackColor = Color.LightGreen;
                    compras.userAux = userAux;
                    compras.cb_listaClientes.Hide();
                    compras.btn_historial.Hide();
                    compras.lb_venderA.Text = "Cliente Actual: " + userAux.Nombre;
                    MessageBox.Show("INGRESE MONTO A GASTAR PARA PODER REALIZAR LA COMPRA.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    compras.Show();
                }
            }
        }
        private void btn_autoVendedor_Click(object sender, EventArgs e)
        {
            tb_usuario.Text = "lucas@gmail.com";
            tb_contra.Text = "1234";
        }

        private void btn_autoCliente_Click(object sender, EventArgs e)
        {
            tb_usuario.Text = "romualdo@gmail.com";
            tb_contra.Text = "ric123";
        }

        public void ValidarIngreso(string email, string contra)
        {
            if (String.IsNullOrEmpty(email))
            {
                MessageBox.Show("ERROR. ESCRIBA EL USUARIO!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                userAux = null;
            }
            else if (String.IsNullOrEmpty(contra))
            {
                MessageBox.Show("ERROR. ESCRIBA CONTRASEÑA!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                userAux = null;

            }
            else if (Negocio.LoguearUsuario(email, contra) is null)
            {
                MessageBox.Show("ERROR. EL USUARIO NO EXISTE!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                userAux = null;
            }
            else
            {
                userAux = Negocio.LoguearUsuario(email, contra);
            }
        }
    }
}