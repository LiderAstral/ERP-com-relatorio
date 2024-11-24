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
    public partial class frmCadastraUsuario : Form
    {
        Form form;
        string id;
        public frmCadastraUsuario(Form Form)
        {
            InitializeComponent();
            form = Form;
        }
        public frmCadastraUsuario(Form Form, string Id)
        {
            InitializeComponent();
            form = Form;
            id = Id;
        }

        private void cbxLogs_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbxRelatorios_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbxUsuários_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbxEstoque_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbxVenda_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbxAgendaVet_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbxAgendaBanho_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbxAvaliacao_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbxCadastro_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtHoras_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSalario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtCargo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cbxCompra_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCadastraUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Show();
        }
    }
}
