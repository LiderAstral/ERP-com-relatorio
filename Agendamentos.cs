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
    public partial class frmAgendamentos : Form
    {
        private int tipo;
        private Form form;
        public frmAgendamentos(int Tipo, Form Form)
        {
            InitializeComponent();
            tipo = Tipo;
            form = Form;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmAgendamentos_Load(object sender, EventArgs e)
        {
            if (tipo == 1)
                lblAgendamento.Text += " Banho e Tosa";
            else if (tipo == 2)
                lblAgendamento.Text += " Veterinario";
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAgendamentos_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Show();
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            frmCadastraAgendamento frmCadastraAgendamento = new frmCadastraAgendamento(tipo, this);
            frmCadastraAgendamento.Show();
            this.Hide();
        }
    }
}
