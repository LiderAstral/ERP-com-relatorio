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
    public partial class frmVenda : Form
    {
        private Form form;
        public frmVenda(Form Form)
        {
            InitializeComponent();
            form = Form;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmVenda_Load(object sender, EventArgs e)
        {

        }

        private void frmVenda_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Show();
        }
    }
}
