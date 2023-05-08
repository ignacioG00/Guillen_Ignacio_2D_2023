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
                heladera.BackColor = Color.Red;
                heladera.Show();
                compras.BackColor = Color.Red;
                compras.userAux = userAux;
                compras.Show();
            }
            else if (Negocio.SelectorUsuario(userAux.Dni) == "cliente")
            {
                compras.BackColor = Color.Green;
                compras.userAux = userAux;
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

        private void Frm_Login_Load(object sender, EventArgs e)
        {

        }
    }
}