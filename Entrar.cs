using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLIENTE_APP
{
    public partial class Entrar : Form
    {
        public Entrar()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var cadastro = new Cadastro(this);
            Hide();
            cadastro.Show();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await Login();
        }

        private void Entrar_Load(object sender, EventArgs e)
        {
            MensagemDeErro.Hide();
        }

        private async Task Login()
        {
            var comando = "LOGIN;" + Numero_da_conta.Text + ";" + PIN.Text;
            var resposta = await ClienteAssincrono.EnviarComando(comando);
            if (!string.IsNullOrEmpty(resposta))
            {
                var parametros = resposta.Split(';');
                if (parametros[0] == "OK")
                {
                    var inicio = new Inicio(parametros);
                    Hide();
                    inicio.Show();
                } 
                else
                {
                    MensagemDeErro.Text = parametros[1];
                }
            }
        }
    }
}
