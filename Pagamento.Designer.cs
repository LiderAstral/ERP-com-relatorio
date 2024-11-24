namespace ERP_com_relatorio
{
    partial class frmPagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPagamento));
            this.txtTroco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRecebido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbxCPF = new System.Windows.Forms.CheckBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.btnProsseguir = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTroco
            // 
            this.txtTroco.Enabled = false;
            this.txtTroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTroco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(62)))), ((int)(((byte)(77)))));
            this.txtTroco.Location = new System.Drawing.Point(345, 365);
            this.txtTroco.Name = "txtTroco";
            this.txtTroco.ShortcutsEnabled = false;
            this.txtTroco.Size = new System.Drawing.Size(319, 40);
            this.txtTroco.TabIndex = 36;
            this.txtTroco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTroco.WordWrap = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(62)))), ((int)(((byte)(77)))));
            this.label4.Location = new System.Drawing.Point(338, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 38);
            this.label4.TabIndex = 35;
            this.label4.Text = "Troco";
            // 
            // txtRecebido
            // 
            this.txtRecebido.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecebido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(62)))), ((int)(((byte)(77)))));
            this.txtRecebido.Location = new System.Drawing.Point(345, 263);
            this.txtRecebido.Name = "txtRecebido";
            this.txtRecebido.ShortcutsEnabled = false;
            this.txtRecebido.Size = new System.Drawing.Size(319, 40);
            this.txtRecebido.TabIndex = 34;
            this.txtRecebido.Text = "0,00";
            this.txtRecebido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRecebido.WordWrap = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(62)))), ((int)(((byte)(77)))));
            this.label3.Location = new System.Drawing.Point(338, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 38);
            this.label3.TabIndex = 33;
            this.label3.Text = "Recebido";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(62)))), ((int)(((byte)(77)))));
            this.txtTotal.Location = new System.Drawing.Point(345, 163);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ShortcutsEnabled = false;
            this.txtTotal.Size = new System.Drawing.Size(319, 40);
            this.txtTotal.TabIndex = 32;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotal.WordWrap = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(62)))), ((int)(((byte)(77)))));
            this.label5.Location = new System.Drawing.Point(338, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 38);
            this.label5.TabIndex = 31;
            this.label5.Text = "Total";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(62)))), ((int)(((byte)(77)))));
            this.label1.Location = new System.Drawing.Point(138, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 52);
            this.label1.TabIndex = 38;
            this.label1.Text = "Pagamento";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // cbxCPF
            // 
            this.cbxCPF.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold);
            this.cbxCPF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(62)))), ((int)(((byte)(77)))));
            this.cbxCPF.Location = new System.Drawing.Point(324, 437);
            this.cbxCPF.Name = "cbxCPF";
            this.cbxCPF.Size = new System.Drawing.Size(217, 54);
            this.cbxCPF.TabIndex = 39;
            this.cbxCPF.Text = "CPF na nota";
            this.cbxCPF.UseVisualStyleBackColor = true;
            this.cbxCPF.CheckedChanged += new System.EventHandler(this.cbxCPF_CheckedChanged);
            // 
            // txtCPF
            // 
            this.txtCPF.Enabled = false;
            this.txtCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(62)))), ((int)(((byte)(77)))));
            this.txtCPF.Location = new System.Drawing.Point(345, 482);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.ShortcutsEnabled = false;
            this.txtCPF.Size = new System.Drawing.Size(319, 40);
            this.txtCPF.TabIndex = 40;
            this.txtCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCPF.WordWrap = false;
            // 
            // btnProsseguir
            // 
            this.btnProsseguir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(62)))), ((int)(((byte)(77)))));
            this.btnProsseguir.FlatAppearance.BorderSize = 0;
            this.btnProsseguir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProsseguir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProsseguir.ForeColor = System.Drawing.Color.White;
            this.btnProsseguir.Location = new System.Drawing.Point(765, 557);
            this.btnProsseguir.Margin = new System.Windows.Forms.Padding(0);
            this.btnProsseguir.Name = "btnProsseguir";
            this.btnProsseguir.Size = new System.Drawing.Size(121, 38);
            this.btnProsseguir.TabIndex = 42;
            this.btnProsseguir.Text = "Finalizar";
            this.btnProsseguir.UseVisualStyleBackColor = false;
            this.btnProsseguir.Click += new System.EventHandler(this.btnProsseguir_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(62)))), ((int)(((byte)(77)))));
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.White;
            this.btnVoltar.Location = new System.Drawing.Point(104, 557);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(0);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(103, 38);
            this.btnVoltar.TabIndex = 41;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // frmPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(154)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(1001, 625);
            this.Controls.Add(this.btnProsseguir);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.cbxCPF);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtTroco);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRecebido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1017, 664);
            this.MinimumSize = new System.Drawing.Size(1017, 664);
            this.Name = "frmPagamento";
            this.Text = "Pagamento";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPagamento_FormClosed);
            this.Load += new System.EventHandler(this.frmPagamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTroco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRecebido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox cbxCPF;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Button btnProsseguir;
        private System.Windows.Forms.Button btnVoltar;
    }
}