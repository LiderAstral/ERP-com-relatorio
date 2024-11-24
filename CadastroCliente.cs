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
    public partial class frmCadastroCliente : Form
    {
        private Form form;
        private string nome, email, telefone, endereco;
        public frmCadastroCliente(Form Form)
        {
            InitializeComponent();
            form = Form;
        }
        public frmCadastroCliente(Form Form, string Nome, string Email, string Telefone, string Endereco)
        {
            InitializeComponent();
            form = Form;
            txtNome.Text = Nome;
            txtEmail.Text = Email;
            txtTelefone.Text = Telefone;
            txtEndereco.Text = Endereco;
        }

        private void frmCadastroCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            nome = txtNome.Text;
            email = txtEmail.Text;
            telefone = txtTelefone.Text;
            endereco = txtEndereco.Text;
        }

        private void frmCadastroCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Show();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
