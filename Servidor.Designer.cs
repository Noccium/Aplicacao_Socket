namespace SERVIDOR_APP
{
    partial class Servidor
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
            this.Iniciar = new System.Windows.Forms.Button();
            this.TextoConsole = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Iniciar
            // 
            this.Iniciar.Location = new System.Drawing.Point(26, 21);
            this.Iniciar.Name = "Iniciar";
            this.Iniciar.Size = new System.Drawing.Size(102, 30);
            this.Iniciar.TabIndex = 0;
            this.Iniciar.Text = "Iniciar";
            this.Iniciar.UseVisualStyleBackColor = true;
            this.Iniciar.Click += new System.EventHandler(this.button1_Click);
            // 
            // TextoConsole
            // 
            this.TextoConsole.Location = new System.Drawing.Point(26, 75);
            this.TextoConsole.Name = "TextoConsole";
            this.TextoConsole.Size = new System.Drawing.Size(736, 157);
            this.TextoConsole.TabIndex = 1;
            this.TextoConsole.Text = "";
            // 
            // Servidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 268);
            this.Controls.Add(this.TextoConsole);
            this.Controls.Add(this.Iniciar);
            this.Name = "Servidor";
            this.Text = "Servidor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Iniciar;
        private System.Windows.Forms.RichTextBox TextoConsole;
    }
}

