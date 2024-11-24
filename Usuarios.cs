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
    public partial class frmUsuarios : Form
    {
        Form form;
        public frmUsuarios(Form Form)
        {
            InitializeComponent();
            form = Form;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUsuarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Show();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadastraUsuario frmCadastraUsuario = new frmCadastraUsuario(this);
            frmCadastraUsuario.Show();
            this.Hide();
        }
    }
}
