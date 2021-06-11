using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLIENTE_APP
{
    public partial class Inicio : Form
    {
        private string _idCliente;

        public Inicio()
        {
            InitializeComponent();
        }

        public Inicio(string[] parametros)
        {
            InitializeComponent();
            PreenchaValores(parametros);
        }

        private void PreenchaValores(string[] parametros)
        {
            BemVindo.Text += " " + parametros[3];
            ValorSaldoAtual.Text = parametros[2];
            _idCliente = parametros[1];
            AtualizeHistoricosCobrancas();
        }

        private async void ConfirmarDeposito_Click(object sender, EventArgs e)
        {
            var pin = Interaction.InputBox("Digite o valor do PIN", "PIN", "");

            if (!string.IsNullOrEmpty(pin))
            {
                var comando = "DEPOSITO;" + _idCliente + ";" + pin + ";" + ValorDeposito.Text + ";";
                var resposta = await ClienteAssincrono.EnviarComando(comando);
                if (!string.IsNullOrEmpty(resposta))
                {
                    var parametros = resposta.Split(';');
                    if (parametros[0] == "OK")
                    {
                        MessageBox.Show("Depósito efetuado com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show(parametros[1]);
                    }
                }

                ClienteAssincrono.FinalizarConexaoComServidor();
                AtualizeSaldoAtual();
                ValorDeposito.Text = "";
            }
        }

        private async void AtualizeHistoricosCobrancas()
        {
            var comando = "CONSULTAR_COBRANCA;" + _idCliente;

            var resposta = await ClienteAssincrono.EnviarComando(comando);
            var parametros = resposta.Split(';');
            if (parametros[0] == "OK")
            {
                var evento = new StringBuilder();
                evento.AppendFormat("IDENTIFICADOR: {0}\n", parametros[1]);
                    
                evento.AppendFormat("VALOR: {0}", parametros.Length == 3 ? parametros[2] : "0");

                TabelaDeEventos.Text = evento.ToString();
            }
            ClienteAssincrono.FinalizarConexaoComServidor();
        }

        private async void AtualizeSaldoAtual()
        {
            var comando = "CONSULTAR_SALDO_ATUAL;" + _idCliente;
            var resposta = await ClienteAssincrono.EnviarComando(comando);
            var parametros = resposta.Split(';');
            ValorSaldoAtual.Text = parametros[0];
            ClienteAssincrono.FinalizarConexaoComServidor();
        }

        private void AtualizarTabelaEventos_Click(object sender, EventArgs e)
        {
            AtualizeHistoricosCobrancas();
        }

        private async void ConfirmarCobranca_Click(object sender, EventArgs e)
        {
            var pin = Interaction.InputBox("Digite o valor do PIN", "PIN", "");

            if (!string.IsNullOrEmpty(pin))
            {
                var comando = "COBRANCA;" + _idCliente + ";" + pin + ";" + NumeroContaCobranca.Text + ";" + ValorCobranca.Text;
                var resposta = await ClienteAssincrono.EnviarComando(comando);
                if (!string.IsNullOrEmpty(resposta))
                {
                    var parametros = resposta.Split(';');
                    if (parametros[0] == "OK")
                    {
                        MessageBox.Show("Cobrança efetuada com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show(parametros[1]);
                    }
                }

                ClienteAssincrono.FinalizarConexaoComServidor();
                AtualizeHistoricosCobrancas();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private async void Pagar_Click(object sender, EventArgs e)
        {
            var pin = Interaction.InputBox("Digite o valor do PIN", "PIN", "");

            if (!string.IsNullOrEmpty(pin))
            {
                var comando = "PAGAR_COBRANCA;" + _idCliente + ";" + pin + ";" + IdentificadorCobranca.Text;
                var resposta = await ClienteAssincrono.EnviarComando(comando);
                if (!string.IsNullOrEmpty(resposta))
                {
                    var parametros = resposta.Split(';');
                    if (parametros[0] == "OK")
                    {
                        MessageBox.Show("Pagamento efetuado com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show(parametros[1]);
                    }
                }

                ClienteAssincrono.FinalizarConexaoComServidor();
                AtualizeSaldoAtual();
                AtualizeHistoricosCobrancas();
            }
        }

        private void Atualizar_Click(object sender, EventArgs e)
        {
            AtualizeSaldoAtual();
        }
    }
}
