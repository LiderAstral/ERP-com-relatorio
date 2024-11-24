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
    public partial class frmGatos : Form
    {
        Form form;
        string id, nome, cores, cpf;
        public frmGatos(Form form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void frmGatos_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadastraGato frmCadastraGato = new frmCadastraGato(this);
            frmCadastraGato.Show();
            this.Hide();
        }

        private void frmGatos_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmCadastraGato frmCadastraGato = new frmCadastraGato(this, id, nome, cores, cpf);
            frmCadastraGato.Show();
            this.Hide();
        }
    }
}
