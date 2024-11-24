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
    public partial class frmAreaComum : Form
    {
        public frmAreaComum()
        {
            InitializeComponent();
        }

        private void AreaComum_Load(object sender, EventArgs e)
        {

        }

        private void frmAreaComum_FormClosed(object sender, FormClosedEventArgs e)
        {
           Application.Exit();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmClientes frmClientes = new frmClientes(this);
            frmClientes.Show();
            this.Hide();
        }

        private void btnBanho_Click(object sender, EventArgs e)
        {
            frmAgendamentos frmAgendamentos = new frmAgendamentos(1, this);
            frmAgendamentos.Show();
            this.Hide();
        }

        private void btnVeterinario_Click(object sender, EventArgs e)
        {
            frmAgendamentos frmAgendamentos = new frmAgendamentos(2, this);
            frmAgendamentos.Show();
            this.Hide();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            frmEstoque frmEstoque = new frmEstoque(this);
            frmEstoque.Show();
            this.Hide();
        }
    }
}
