using Carniceria;
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
            userAux = Negocio.LoguearUsuario(int.Parse(tb_usuario.Text), tb_contra.Text);
            if (Negocio.SelectorUsuario(userAux.Dni) == "vendedor")
            {
                heladera.BackColor = Color.RosyBrown;
                heladera.Show();
                compras.BackColor = Color.RosyBrown;
                compras.userAux = userAux;
                compras.cb_listaClientes.Show();
                compras.lb_venderA.Text = "Vender a:";
                compras.Show();
            }
            else if (Negocio.SelectorUsuario(userAux.Dni) == "cliente")
            {
                compras.BackColor = Color.LightGreen;
                compras.userAux = userAux;
                compras.cb_listaClientes.Hide();
                compras.lb_venderA.Text = "Cliente Actual: " + userAux.Nombre;
                MessageBox.Show("INGRESE MONTO A GASTAR PARA PODER REALIZAR LA COMPRA.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                compras.Show();
            }

        }
        private void btn_autoVendedor_Click(object sender, EventArgs e)
        {
            tb_usuario.Text = "21564";
            tb_contra.Text = "1234";
        }

        private void btn_autoCliente_Click(object sender, EventArgs e)
        {
            tb_usuario.Text = "22222";
            tb_contra.Text = "ric123";
        }
    }
}