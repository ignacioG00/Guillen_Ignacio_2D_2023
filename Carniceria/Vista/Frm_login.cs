using Carniceria;

namespace Vista
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Negocio.LoguearUsuario(int.Parse(tb_usuario.Text), tb_contra.Text);
        }

        private void btn_autocompletar_Click(object sender, EventArgs e)
        {


        }
    }
}