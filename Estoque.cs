﻿using System;
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
    public partial class frmEstoque : Form
    {
        private Form form;
        public frmEstoque(Form Form)
        {
            InitializeComponent();
            form = Form;
        }

        private void frmEstoque_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEstoque_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Show();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastroEstoque frmCadastroEstoque = new CadastroEstoque(this);
            frmCadastroEstoque.Show();
            this.Hide();
        }
    }
}
