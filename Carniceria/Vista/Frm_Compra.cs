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
    public partial class Frm_Compra : Form
    {
        public Frm_Compra()
        {
            InitializeComponent();
        }

        private void Frm_Compra_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void Frm_Compra_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }
    }
}
