namespace CLIENTE_APP
{
    partial class Inicio
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
            this.BemVindo = new System.Windows.Forms.Label();
            this.ValorSaldoAtual = new System.Windows.Forms.TextBox();
            this.SaldoAtual = new System.Windows.Forms.Label();
            this.ConfirmarDeposito = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Atualizar = new System.Windows.Forms.Button();
            this.ValorDeposito = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.IdentificadorCobranca = new System.Windows.Forms.TextBox();
            this.Pagar = new System.Windows.Forms.Button();
            this.ConfirmarCobranca = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.NumeroContaCobranca = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ValorCobranca = new System.Windows.Forms.TextBox();
            this.ValorTransferencia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NumeroDaContaTransferencia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ConfirmarTransferencia = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Cobranca = new System.Windows.Forms.GroupBox();
            this.TabelaDeEventos = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AtualizarTabelaEventos = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Cobranca.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BemVindo
            // 
            this.BemVindo.AutoSize = true;
            this.BemVindo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BemVindo.Location = new System.Drawing.Point(26, 9);
            this.BemVindo.Name = "BemVindo";
            this.BemVindo.Size = new System.Drawing.Size(76, 18);
            this.BemVindo.TabIndex = 0;
            this.BemVindo.Text = "BemVindo";
            // 
            // ValorSaldoAtual
            // 
            this.ValorSaldoAtual.Enabled = false;
            this.ValorSaldoAtual.HideSelection = false;
            this.ValorSaldoAtual.Location = new System.Drawing.Point(14, 36);
            this.ValorSaldoAtual.Name = "ValorSaldoAtual";
            this.ValorSaldoAtual.ReadOnly = true;
            this.ValorSaldoAtual.Size = new System.Drawing.Size(100, 20);
            this.ValorSaldoAtual.TabIndex = 1;
            // 
            // SaldoAtual
            // 
            this.SaldoAtual.AutoSize = true;
            this.SaldoAtual.Location = new System.Drawing.Point(11, 20);
            this.SaldoAtual.Name = "SaldoAtual";
            this.SaldoAtual.Size = new System.Drawing.Size(60, 13);
            this.SaldoAtual.TabIndex = 2;
            this.SaldoAtual.Text = "Saldo atual";
            // 
            // ConfirmarDeposito
            // 
            this.ConfirmarDeposito.Location = new System.Drawing.Point(131, 88);
            this.ConfirmarDeposito.Name = "ConfirmarDeposito";
            this.ConfirmarDeposito.Size = new System.Drawing.Size(68, 20);
            this.ConfirmarDeposito.TabIndex = 5;
            this.ConfirmarDeposito.Text = "Confirmar";
            this.ConfirmarDeposito.UseVisualStyleBackColor = true;
            this.ConfirmarDeposito.Click += new System.EventHandler(this.ConfirmarDeposito_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Atualizar);
            this.panel2.Controls.Add(this.ConfirmarDeposito);
            this.panel2.Controls.Add(this.ValorDeposito);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.SaldoAtual);
            this.panel2.Controls.Add(this.ValorSaldoAtual);
            this.panel2.Location = new System.Drawing.Point(29, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(214, 130);
            this.panel2.TabIndex = 7;
            // 
            // Atualizar
            // 
            this.Atualizar.Location = new System.Drawing.Point(131, 36);
            this.Atualizar.Name = "Atualizar";
            this.Atualizar.Size = new System.Drawing.Size(68, 20);
            this.Atualizar.TabIndex = 6;
            this.Atualizar.Text = "Atualizar";
            this.Atualizar.UseVisualStyleBackColor = true;
            this.Atualizar.Click += new System.EventHandler(this.Atualizar_Click);
            // 
            // ValorDeposito
            // 
            this.ValorDeposito.Location = new System.Drawing.Point(14, 88);
            this.ValorDeposito.Name = "ValorDeposito";
            this.ValorDeposito.Size = new System.Drawing.Size(100, 20);
            this.ValorDeposito.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Depositar";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Controls.Add(this.ConfirmarCobranca);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.NumeroContaCobranca);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.ValorCobranca);
            this.panel3.Location = new System.Drawing.Point(14, 17);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(214, 156);
            this.panel3.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.IdentificadorCobranca);
            this.groupBox3.Controls.Add(this.Pagar);
            this.groupBox3.Location = new System.Drawing.Point(104, 61);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(109, 94);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pagamento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Identificador";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // IdentificadorCobranca
            // 
            this.IdentificadorCobranca.Location = new System.Drawing.Point(17, 36);
            this.IdentificadorCobranca.Name = "IdentificadorCobranca";
            this.IdentificadorCobranca.Size = new System.Drawing.Size(75, 20);
            this.IdentificadorCobranca.TabIndex = 8;
            // 
            // Pagar
            // 
            this.Pagar.Location = new System.Drawing.Point(17, 62);
            this.Pagar.Name = "Pagar";
            this.Pagar.Size = new System.Drawing.Size(75, 23);
            this.Pagar.TabIndex = 7;
            this.Pagar.Text = "Pagar";
            this.Pagar.UseVisualStyleBackColor = true;
            this.Pagar.Click += new System.EventHandler(this.Pagar_Click);
            // 
            // ConfirmarCobranca
            // 
            this.ConfirmarCobranca.Location = new System.Drawing.Point(15, 116);
            this.ConfirmarCobranca.Name = "ConfirmarCobranca";
            this.ConfirmarCobranca.Size = new System.Drawing.Size(68, 20);
            this.ConfirmarCobranca.TabIndex = 6;
            this.ConfirmarCobranca.Text = "Cobrar";
            this.ConfirmarCobranca.UseVisualStyleBackColor = true;
            this.ConfirmarCobranca.Click += new System.EventHandler(this.ConfirmarCobranca_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Número da conta do devedor";
            // 
            // NumeroContaCobranca
            // 
            this.NumeroContaCobranca.Location = new System.Drawing.Point(15, 28);
            this.NumeroContaCobranca.Name = "NumeroContaCobranca";
            this.NumeroContaCobranca.Size = new System.Drawing.Size(181, 20);
            this.NumeroContaCobranca.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Valor";
            // 
            // ValorCobranca
            // 
            this.ValorCobranca.Location = new System.Drawing.Point(15, 77);
            this.ValorCobranca.Name = "ValorCobranca";
            this.ValorCobranca.Size = new System.Drawing.Size(68, 20);
            this.ValorCobranca.TabIndex = 0;
            // 
            // ValorTransferencia
            // 
            this.ValorTransferencia.Location = new System.Drawing.Point(15, 77);
            this.ValorTransferencia.Name = "ValorTransferencia";
            this.ValorTransferencia.Size = new System.Drawing.Size(100, 20);
            this.ValorTransferencia.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor";
            // 
            // NumeroDaContaTransferencia
            // 
            this.NumeroDaContaTransferencia.Location = new System.Drawing.Point(15, 28);
            this.NumeroDaContaTransferencia.Name = "NumeroDaContaTransferencia";
            this.NumeroDaContaTransferencia.Size = new System.Drawing.Size(158, 20);
            this.NumeroDaContaTransferencia.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Número da conta do destinatário";
            // 
            // ConfirmarTransferencia
            // 
            this.ConfirmarTransferencia.Location = new System.Drawing.Point(15, 116);
            this.ConfirmarTransferencia.Name = "ConfirmarTransferencia";
            this.ConfirmarTransferencia.Size = new System.Drawing.Size(68, 20);
            this.ConfirmarTransferencia.TabIndex = 6;
            this.ConfirmarTransferencia.Text = "Confirmar";
            this.ConfirmarTransferencia.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ConfirmarTransferencia);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.NumeroDaContaTransferencia);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ValorTransferencia);
            this.panel1.Location = new System.Drawing.Point(14, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 156);
            this.panel1.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Location = new System.Drawing.Point(15, 215);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 189);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transferência";
            // 
            // Cobranca
            // 
            this.Cobranca.Controls.Add(this.panel3);
            this.Cobranca.Location = new System.Drawing.Point(277, 215);
            this.Cobranca.Name = "Cobranca";
            this.Cobranca.Size = new System.Drawing.Size(243, 188);
            this.Cobranca.TabIndex = 13;
            this.Cobranca.TabStop = false;
            this.Cobranca.Text = "Cobrança";
            // 
            // TabelaDeEventos
            // 
            this.TabelaDeEventos.Location = new System.Drawing.Point(14, 26);
            this.TabelaDeEventos.Name = "TabelaDeEventos";
            this.TabelaDeEventos.Size = new System.Drawing.Size(215, 108);
            this.TabelaDeEventos.TabIndex = 14;
            this.TabelaDeEventos.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AtualizarTabelaEventos);
            this.groupBox1.Controls.Add(this.TabelaDeEventos);
            this.groupBox1.Location = new System.Drawing.Point(277, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 169);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Histórico de transações";
            // 
            // AtualizarTabelaEventos
            // 
            this.AtualizarTabelaEventos.Location = new System.Drawing.Point(14, 140);
            this.AtualizarTabelaEventos.Name = "AtualizarTabelaEventos";
            this.AtualizarTabelaEventos.Size = new System.Drawing.Size(75, 23);
            this.AtualizarTabelaEventos.TabIndex = 15;
            this.AtualizarTabelaEventos.Text = "Atualizar";
            this.AtualizarTabelaEventos.UseVisualStyleBackColor = true;
            this.AtualizarTabelaEventos.Click += new System.EventHandler(this.AtualizarTabelaEventos_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 413);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Cobranca);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BemVindo);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.Cobranca.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BemVindo;
        private System.Windows.Forms.TextBox ValorSaldoAtual;
        private System.Windows.Forms.Label SaldoAtual;
        private System.Windows.Forms.Button ConfirmarDeposito;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button ConfirmarCobranca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NumeroContaCobranca;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ValorCobranca;
        private System.Windows.Forms.TextBox ValorDeposito;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ValorTransferencia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NumeroDaContaTransferencia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ConfirmarTransferencia;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox Cobranca;
        private System.Windows.Forms.RichTextBox TabelaDeEventos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AtualizarTabelaEventos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox IdentificadorCobranca;
        private System.Windows.Forms.Button Pagar;
        private System.Windows.Forms.Button Atualizar;
    }
}