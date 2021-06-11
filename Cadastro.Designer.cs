namespace CLIENTE_APP
{
    partial class Cadastro
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
            this.Nome = new System.Windows.Forms.TextBox();
            this.Banco = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Numero_da_conta = new System.Windows.Forms.TextBox();
            this.Numero_do_cartao_de_credito = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PIN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Voltar = new System.Windows.Forms.Button();
            this.MensagemDeErro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Nome
            // 
            this.Nome.Location = new System.Drawing.Point(12, 37);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(258, 20);
            this.Nome.TabIndex = 0;
            // 
            // Banco
            // 
            this.Banco.Location = new System.Drawing.Point(12, 83);
            this.Banco.Name = "Banco";
            this.Banco.Size = new System.Drawing.Size(258, 20);
            this.Banco.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Banco";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Número da conta";
            // 
            // Numero_da_conta
            // 
            this.Numero_da_conta.Location = new System.Drawing.Point(12, 133);
            this.Numero_da_conta.Name = "Numero_da_conta";
            this.Numero_da_conta.Size = new System.Drawing.Size(142, 20);
            this.Numero_da_conta.TabIndex = 5;
            // 
            // Numero_do_cartao_de_credito
            // 
            this.Numero_do_cartao_de_credito.Location = new System.Drawing.Point(12, 182);
            this.Numero_do_cartao_de_credito.Name = "Numero_do_cartao_de_credito";
            this.Numero_do_cartao_de_credito.Size = new System.Drawing.Size(142, 20);
            this.Numero_do_cartao_de_credito.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Número do cartão de crédito";
            // 
            // PIN
            // 
            this.PIN.Location = new System.Drawing.Point(12, 235);
            this.PIN.Name = "PIN";
            this.PIN.Size = new System.Drawing.Size(62, 20);
            this.PIN.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "PIN";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(144, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Cadastro_Click);
            // 
            // Voltar
            // 
            this.Voltar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Voltar.Location = new System.Drawing.Point(230, 235);
            this.Voltar.Name = "Voltar";
            this.Voltar.Size = new System.Drawing.Size(50, 23);
            this.Voltar.TabIndex = 11;
            this.Voltar.Text = "Voltar";
            this.Voltar.UseVisualStyleBackColor = false;
            this.Voltar.Click += new System.EventHandler(this.Voltar_Click);
            // 
            // MensagemDeErro
            // 
            this.MensagemDeErro.AutoSize = true;
            this.MensagemDeErro.ForeColor = System.Drawing.Color.Red;
            this.MensagemDeErro.Location = new System.Drawing.Point(9, 8);
            this.MensagemDeErro.Name = "MensagemDeErro";
            this.MensagemDeErro.Size = new System.Drawing.Size(92, 13);
            this.MensagemDeErro.TabIndex = 12;
            this.MensagemDeErro.Text = "MensagemDeErro";
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(292, 270);
            this.Controls.Add(this.MensagemDeErro);
            this.Controls.Add(this.Voltar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PIN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Numero_do_cartao_de_credito);
            this.Controls.Add(this.Numero_da_conta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Banco);
            this.Controls.Add(this.Nome);
            this.Name = "Cadastro";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Cadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Nome;
        private System.Windows.Forms.TextBox Banco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Numero_da_conta;
        private System.Windows.Forms.TextBox Numero_do_cartao_de_credito;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PIN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Voltar;
        private System.Windows.Forms.Label MensagemDeErro;
    }
}