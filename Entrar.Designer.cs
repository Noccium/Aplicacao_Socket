namespace CLIENTE_APP
{
    partial class Entrar
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Numero_da_conta = new System.Windows.Forms.TextBox();
            this.PIN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.MensagemDeErro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Numero_da_conta
            // 
            this.Numero_da_conta.Location = new System.Drawing.Point(103, 153);
            this.Numero_da_conta.Name = "Numero_da_conta";
            this.Numero_da_conta.Size = new System.Drawing.Size(100, 20);
            this.Numero_da_conta.TabIndex = 0;
            // 
            // PIN
            // 
            this.PIN.Location = new System.Drawing.Point(103, 223);
            this.PIN.Name = "PIN";
            this.PIN.Size = new System.Drawing.Size(100, 20);
            this.PIN.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Número da conta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "PIN";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(106, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Entrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(48, 326);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(220, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Não tem uma conta? Cadastre agora mesmo!";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // MensagemDeErro
            // 
            this.MensagemDeErro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MensagemDeErro.AutoSize = true;
            this.MensagemDeErro.ForeColor = System.Drawing.Color.Red;
            this.MensagemDeErro.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MensagemDeErro.Location = new System.Drawing.Point(12, 428);
            this.MensagemDeErro.Name = "MensagemDeErro";
            this.MensagemDeErro.Size = new System.Drawing.Size(92, 13);
            this.MensagemDeErro.TabIndex = 6;
            this.MensagemDeErro.Text = "MensagemDeErro";
            this.MensagemDeErro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MensagemDeErro.UseMnemonic = false;
            this.MensagemDeErro.UseWaitCursor = true;
            this.MensagemDeErro.Visible = false;
            // 
            // Entrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 462);
            this.Controls.Add(this.MensagemDeErro);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PIN);
            this.Controls.Add(this.Numero_da_conta);
            this.Name = "Entrar";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Entrar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Numero_da_conta;
        private System.Windows.Forms.TextBox PIN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label MensagemDeErro;
    }
}

