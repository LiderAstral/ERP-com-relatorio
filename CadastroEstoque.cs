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
    public partial class CadastroEstoque : Form
    {
        private Form form;
        public CadastroEstoque(Form Form)
        {
            InitializeComponent();
            form = Form;
        }

        private void CadastroEstoque_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void CadastroEstoque_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            form.Show();
        }
    }
}
