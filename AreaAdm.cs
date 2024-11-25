using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_com_relatorio
{
    public partial class frmAreaAdm : Form
    {
        public frmAreaAdm()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmAreaAdm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            frmUsuarios frmUsuarios = new frmUsuarios(this);
            frmUsuarios.Show();
            this.Hide();
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            frmRelatorios frmRelatorios = new frmRelatorios(this);
            frmRelatorios.Show();
            this.Hide();
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            frmCompra frmCompra = new frmCompra(this);
            frmCompra.Show();
            this.Hide();
        }
    }
}
