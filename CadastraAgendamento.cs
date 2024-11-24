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
    public partial class frmCadastraAgendamento : Form
    {
        private Form form;
        private int tipo;
        public frmCadastraAgendamento(int Tipo, Form Form)
        {
            InitializeComponent();
            tipo = Tipo;
            form = Form;
        }
        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmCadastraAgendamento_Load(object sender, EventArgs e)
        {
            if (tipo == 1)
                lblAgendamento.Text += " Banho e Tosa";
            else if (tipo == 2)
            {
                lblAgendamento.Text += " Veterinario";
                cbxBanho.Visible = false;
                cbxTosa.Visible = false;
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCadastraAgendamento_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Show();
        }
    }
}
