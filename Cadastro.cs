using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLIENTE_APP
{
    public partial class Cadastro : Form
    {
        private readonly Entrar _instanciaEntrar;

        public Cadastro()
        {
            InitializeComponent();
        }

        public Cadastro(Entrar entrar)
        {
            _instanciaEntrar = entrar;
            Size = entrar.Size;
            StartPosition = entrar.StartPosition;
            InitializeComponent();
        }

        private async void Cadastro_Click(object sender, EventArgs e)
        {
            VerifiqueSeOsCamposForamInformados();

            var comando = "CADASTRO;" + Nome.Text + ";" + Banco.Text + ";"
                + Numero_da_conta.Text + ";" + Numero_do_cartao_de_credito.Text + ";" + PIN.Text;

            var resposta = await ClienteAssincrono.EnviarComando(comando);
            if (!string.IsNullOrEmpty(resposta))
            {
                var parametros = resposta.Split(';');
                if (parametros[0] == "OK")
                {
                    MessageBox.Show("Cadastrado com sucesso!");
                    Voltar_Pagina();
                }
                else
                {
                    MessageBox.Show(parametros[1]);
                }
            }

            ClienteAssincrono.FinalizarConexaoComServidor();
        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            Voltar_Pagina();
        }

        private void Voltar_Pagina()
        {
            Hide();
            _instanciaEntrar.Show();
        }

        private bool VerifiqueSeOsCamposForamInformados()
        {
            var mensagem = "O campo obrigatório não foi informado: ";
            return CampoFoiInformado(mensagem, Nome) &&
            CampoFoiInformado(mensagem, Banco) &&
            CampoFoiInformado(mensagem, Numero_da_conta) &&
            CampoFoiInformado(mensagem, Numero_do_cartao_de_credito) &&
            CampoFoiInformado(mensagem, PIN);
        }

        private bool CampoFoiInformado(string mensagem, TextBox textBox)
        {
            var naoFoiInformado = string.IsNullOrEmpty(textBox.Text);
            if (naoFoiInformado)
            {
                MessageBox.Show(mensagem + textBox.Name);
            }

            return !naoFoiInformado;
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {
            MensagemDeErro.Hide();
        }
    }
}
