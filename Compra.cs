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
    public partial class frmCompra : Form
    {
        Form form;
        public frmCompra(Form Form)
        {
            InitializeComponent();
            form = Form;
        }

        private void frmCompra_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCompra_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Show();
        }
    }
}