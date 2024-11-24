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
    public partial class frmPagamento : Form
    {
        private Form form;
        private string total;
        private string cpf;
        public frmPagamento(Form Form, string Total, string CPF)
        {
            InitializeComponent();
            form = Form;
            total = Total;
            cpf = CPF;
        }

        private void cbxCPF_CheckedChanged(object sender, EventArgs e)
        {
            txtCPF.Enabled = cbxCPF.Checked;
        }

        private void frmPagamento_Load(object sender, EventArgs e)
        {
            txtCPF.Text = cpf;
            txtTotal.Text = total;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPagamento_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Show();
        }

        private void btnProsseguir_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Close();
        }
    }
}
