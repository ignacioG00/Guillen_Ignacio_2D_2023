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
            
            foreach (var item in collection)
            { }
               


                
            if (Negocio.LoguearUsuario(int.Parse(tb_usuario.Text), tb_contra.Text) == )
            {
                
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