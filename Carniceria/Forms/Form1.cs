using System;
using System.Windows.Forms;

namespace Forms
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Negocio.LoguearUsuario();
        }
    }
}
