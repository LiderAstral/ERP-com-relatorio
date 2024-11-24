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
    public partial class frmCadastraGato : Form
    {
        Form form;
        string id;
        public frmCadastraGato(Form Form)
        {
            form = Form;
            InitializeComponent();
        }

        public frmCadastraGato(Form Form, string Id, string nome, string cores, string cpf)
        { 
            InitializeComponent();
            txtCores.Text = cores;
            txtNome.Text = nome;
            txtCPF.Text = cpf;
            form = Form;
            id = Id;
        }

        private void frmCadastraGato_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCadastraGato_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Show();
        }

        private void txtCores_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
