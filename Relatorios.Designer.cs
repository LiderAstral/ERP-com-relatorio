namespace ERP_com_relatorio
{
    partial class frmRelatorios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelatorios));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dteInicio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dteFim = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.btnGerar = new System.Windows.Forms.Button();
            this.grdRelatorios = new System.Windows.Forms.DataGridView();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Registro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRelatorios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(113)))), ((int)(((byte)(166)))));
            this.label1.Location = new System.Drawing.Point(128, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 52);
            this.label1.TabIndex = 25;
            this.label1.Text = "Relatório";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // dteInicio
            // 
            this.dteInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.dteInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dteInicio.Location = new System.Drawing.Point(58, 163);
            this.dteInicio.Name = "dteInicio";
            this.dteInicio.Size = new System.Drawing.Size(185, 40);
            this.dteInicio.TabIndex = 27;
            this.dteInicio.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(113)))), ((int)(((byte)(166)))));
            this.label2.Location = new System.Drawing.Point(51, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 38);
            this.label2.TabIndex = 26;
            this.label2.Text = "Data Início";
            // 
            // dteFim
            // 
            this.dteFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.dteFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dteFim.Location = new System.Drawing.Point(327, 163);
            this.dteFim.Name = "dteFim";
            this.dteFim.Size = new System.Drawing.Size(185, 40);
            this.dteFim.TabIndex = 29;
            this.dteFim.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(113)))), ((int)(((byte)(166)))));
            this.label3.Location = new System.Drawing.Point(320, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 38);
            this.label3.TabIndex = 28;
            this.label3.Text = "Data Fim";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(113)))), ((int)(((byte)(166)))));
            this.label4.Location = new System.Drawing.Point(594, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 38);
            this.label4.TabIndex = 30;
            this.label4.Text = "Filtro";
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.BackColor = System.Drawing.Color.White;
            this.cmbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.Items.AddRange(new object[] {
            "Login",
            "Vendas",
            "Compras",
            "Gatos",
            "Usuários",
            "Agendamentos"});
            this.cmbFiltro.Location = new System.Drawing.Point(601, 161);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(228, 41);
            this.cmbFiltro.TabIndex = 48;
            // 
            // btnGerar
            // 
            this.btnGerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(113)))), ((int)(((byte)(166)))));
            this.btnGerar.FlatAppearance.BorderSize = 0;
            this.btnGerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerar.ForeColor = System.Drawing.Color.White;
            this.btnGerar.Location = new System.Drawing.Point(868, 163);
            this.btnGerar.Margin = new System.Windows.Forms.Padding(0);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(103, 38);
            this.btnGerar.TabIndex = 49;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = false;
            // 
            // grdRelatorios
            // 
            this.grdRelatorios.AllowUserToAddRows = false;
            this.grdRelatorios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdRelatorios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.grdRelatorios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdRelatorios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(113)))), ((int)(((byte)(166)))));
            this.grdRelatorios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdRelatorios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdRelatorios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Usuario,
            this.DataHora,
            this.Tipo,
            this.Registro});
            this.grdRelatorios.Location = new System.Drawing.Point(58, 244);
            this.grdRelatorios.Name = "grdRelatorios";
            this.grdRelatorios.Size = new System.Drawing.Size(883, 310);
            this.grdRelatorios.TabIndex = 50;
            // 
            // Usuario
            // 
            this.Usuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Usuario.HeaderText = "Usuário";
            this.Usuario.MinimumWidth = 180;
            this.Usuario.Name = "Usuario";
            this.Usuario.Width = 180;
            // 
            // DataHora
            // 
            this.DataHora.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DataHora.HeaderText = "Data e Hora";
            this.DataHora.MinimumWidth = 180;
            this.DataHora.Name = "DataHora";
            this.DataHora.Width = 180;
            // 
            // Tipo
            // 
            this.Tipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.MinimumWidth = 180;
            this.Tipo.Name = "Tipo";
            this.Tipo.Width = 180;
            // 
            // Registro
            // 
            this.Registro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Registro.HeaderText = "Registro";
            this.Registro.MinimumWidth = 300;
            this.Registro.Name = "Registro";
            this.Registro.Width = 300;
            // 
            // btnDownload
            // 
            this.btnDownload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(113)))), ((int)(((byte)(166)))));
            this.btnDownload.FlatAppearance.BorderSize = 0;
            this.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownload.ForeColor = System.Drawing.Color.White;
            this.btnDownload.Location = new System.Drawing.Point(586, 567);
            this.btnDownload.Margin = new System.Windows.Forms.Padding(0);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(138, 38);
            this.btnDownload.TabIndex = 51;
            this.btnDownload.Text = "Baixar Log";
            this.btnDownload.UseVisualStyleBackColor = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(113)))), ((int)(((byte)(166)))));
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.White;
            this.btnVoltar.Location = new System.Drawing.Point(803, 567);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(0);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(138, 38);
            this.btnVoltar.TabIndex = 52;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // frmRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(154)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(1001, 625);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.grdRelatorios);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.cmbFiltro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dteFim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dteInicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1017, 664);
            this.MinimumSize = new System.Drawing.Size(1017, 664);
            this.Name = "frmRelatorios";
            this.Text = "Relatórios do Sistema";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmRelatorios_FormClosed);
            this.Load += new System.EventHandler(this.frmRelatorios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRelatorios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dteInicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dteFim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbFiltro;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.DataGridView grdRelatorios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Registro;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btnVoltar;
    }
}