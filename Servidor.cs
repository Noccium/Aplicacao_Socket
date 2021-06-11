using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SERVIDOR_APP
{
    public partial class Servidor : Form
    {
        public static ManualResetEvent allDone = new ManualResetEvent(false);
        private readonly string _connectionString = @"Server=.\sqlexpress;Database=SISTEMA_DE_PAGAMENTO_RPC;Trusted_Connection=True;";

        public Servidor()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await StartListening();
        }

        private void EscrevaNoConsole(string mensagem)
        {
            Iniciar.Enabled = false;
            TextoConsole.AppendText(mensagem + "\n");
        }

        public async Task StartListening()
        {
            try
            {
                IPAddress ipaddress = IPAddress.Parse("192.168.0.193");
                TcpListener listener = new TcpListener(ipaddress, 8000);
                listener.Start();
                EscrevaNoConsole("Server is Running on Port: 8000");
                EscrevaNoConsole("Local endpoint:" + listener.LocalEndpoint);

                while (true)
                {
                    EscrevaNoConsole("Waiting for Connections...");
                    var s = await listener.AcceptSocketAsync();
                    EscrevaNoConsole("Connection Accepted From:" + s.RemoteEndPoint);
                    byte[] b = new byte[100];
                    int k = s.Receive(b);
                    EscrevaNoConsole("Received..");
                    var recebido = new StringBuilder();
                    for (int i = 0; i < k; i++)
                    {
                        recebido.Append(Convert.ToChar(b[i]));
                    }

                    var retorno = ExecutaOperacao(recebido.ToString());
                    ASCIIEncoding asencd = new ASCIIEncoding();
                    s.Send(asencd.GetBytes(retorno));
                }
            }
            catch (Exception ex)
            {
                EscrevaNoConsole("Error.." + ex.StackTrace);
            }

            Iniciar.Enabled = true;
        }


        private string ExecutaOperacao(string requisicao)
        {
            var parametros = requisicao.Split(';');
            var operacao = parametros.First();
            EscrevaNoConsole(operacao);

            switch (operacao)
            {
                case "LOGIN": return Login(parametros);
                case "CADASTRO": return Cadastro(parametros);
                case "DEPOSITO": return Deposito(parametros);
                case "TRANSFERENCIA": return Transferencia(parametros);
                case "COBRANCA": return CadastreCobranca(parametros);
                case "PAGAR_COBRANCA": return PagarCobranca(parametros);
                case "CONSULTAR_COBRANCA": return ConsulteCobrancaPeloIdDoCliente(parametros);
                case "CONSULTAR_SALDO_ATUAL": return ConsulteSaldo(parametros[1]);
            }

            return "FALHA;OPERACAOO NAO ENCONTRADA;";
        }

        private string CadastreCobranca(string[] parametros)
        {
            var idRemetente = parametros[1];
            var pin = parametros[2];
            var numeroContaCobrada = parametros[3];
            var valorCobrado = parametros[4];

            var idDestinatario = ConsultaIdClientePeloNumeroDaConta(numeroContaCobrada);
            return idDestinatario.Split(';').First() == "FALHA" ? idDestinatario : CadastreTransferencia(idRemetente, idDestinatario, valorCobrado, "N");
        }

        private string Transferencia(string[] parametros)
        {
            var id = parametros[1];
            var numeroDaConta = parametros[2];
            var valor = parametros[3];
            var idTransacao = parametros[4];

            var saldoAtual = ConsulteSaldo(id);
            if (!(saldoAtual.Split(';').First() == "FALHA"))
            {
                var resultado = float.Parse(saldoAtual) - float.Parse(valor);
                if (resultado < 0)
                {
                    return "FALHA;Voce não possui saldo suficiente para realizar esta operação";
                }

                var idDestinatario = ConsultaIdClientePeloNumeroDaConta(numeroDaConta);

                return idDestinatario.Split(';').First() == "FALHA" ? idDestinatario : CadastreTransferencia(id, idDestinatario, valor, "S");
            }

            return saldoAtual;
        }

        private string PagarCobranca(string[] parametros)
        {
            var idDoCobrado = parametros[1];
            var idDaCobranca = parametros[3];

            var saldoAtual = ConsulteSaldo(idDoCobrado);
            if (!(saldoAtual.Split(';').First() == "FALHA"))
            {
                var valorDaCobranca = ConsulteValorDaCobranca(idDaCobranca);

                if (valorDaCobranca.Split(';').First() != "FALHA")
                {
                    var resultado = float.Parse(saldoAtual) - float.Parse(valorDaCobranca);
                    if (resultado < 0)
                    {
                        return "FALHA;Voce não possui saldo suficiente para realizar esta operação";
                    }

                    AtualizeSaldo(idDoCobrado, resultado.ToString());
                    var idDoCobrador = ConsultaIdCobradorPeloIdentificador(idDaCobranca);
                    AtualizeSaldo(idDoCobrador, (float.Parse(valorDaCobranca) + float.Parse(ConsulteSaldo(idDoCobrador))).ToString());
                    AtualizeStatusCobranca(idDaCobranca);
                }

                return valorDaCobranca;
            }

            return saldoAtual;
        }

        private string AtualizeStatusCobranca(string idDaCobranca)
        {
            string sql = "UPDATE TRANSFERENCIA SET EFETUADA = 'S' WHERE ID =" + idDaCobranca;

            var con = CrieConexaoComBancoDeDados();
            var cmd = CrieComandoSql(con, sql);

            con.Open();
            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    return "OK;O status da cobranca foi alterado com sucesso.";
                }
                else
                    return "FALHA";
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO;" + ex.ToString());
            }
            finally
            {
                con.Close();
            }

            return "OK;";
        }

        private string ConsulteValorDaCobranca(string idDaCobranca)
        {
            var sql = "SELECT VALOR FROM TRANSFERENCIA WHERE ID = " + idDaCobranca;
            var con = CrieConexaoComBancoDeDados();
            var cmd = CrieComandoSql(con, sql);

            con.Open();
            try
            {
                var leitor = cmd.ExecuteReader();
                if (leitor.HasRows)
                {
                    while (leitor.Read())
                    {
                        var valor = leitor["VALOR"] as string;
                        return valor;
                    }
                }
                else
                {
                    return "FALHA;Nao foi encontrado a cobranca vinculada ao identificador informado.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("FALHA;" + ex.ToString());
            }
            finally
            {
                con.Close();
            }


            return "OK;";
        }

        private string ConsulteCobrancaPeloIdDoCliente(string[] parametros)
        {
            var idDoCliente = parametros[1];
            var sql = "SELECT TOP(1) *FROM TRANSFERENCIA WHERE ID_DESTINATARIO = " + idDoCliente + " AND EFETUADA = 'N'";
            var con = CrieConexaoComBancoDeDados();
            var cmd = CrieComandoSql(con, sql);

            con.Open();
            try
            {
                var leitor = cmd.ExecuteReader();
                if (leitor.HasRows)
                {
                    while (leitor.Read())
                    {
                        var id = leitor["ID"] as int?;
                        var valor = leitor["VALOR"] as string;
                        return "OK;" + id.GetValueOrDefault().ToString() + ";" + valor;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("FALHA;" + ex.ToString());
            }
            finally
            {
                con.Close();
            }


            return "OK;";
        }

        private string ConsultaIdClientePeloNumeroDaConta(string numeroDaConta)
        {
            var sql = "SELECT TOP(1) ID FROM CLIENTE WHERE NUM_CONTA = '" + numeroDaConta + "'";
            var con = CrieConexaoComBancoDeDados();
            var cmd = CrieComandoSql(con, sql);

            con.Open();
            try
            {
                var leitor = cmd.ExecuteReader();
                if (leitor.HasRows)
                {
                    while (leitor.Read())
                    {
                        var id = leitor["ID"] as int?;
                        return id.GetValueOrDefault().ToString();
                    }
                }
                else
                {
                    return "FALHA;Nao foi encontrado o usuario vinculado a conta informada.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("FALHA;" + ex.ToString());
            }
            finally
            {
                con.Close();
            }


            return "OK;";
        }

        private string ConsultaIdCobradorPeloIdentificador(string identificador)
        {
            var sql = "SELECT TOP(1) ID_REMETENTE FROM TRANSFERENCIA WHERE ID = '" + identificador + "'";
            var con = CrieConexaoComBancoDeDados();
            var cmd = CrieComandoSql(con, sql);

            con.Open();
            try
            {
                var leitor = cmd.ExecuteReader();
                if (leitor.HasRows)
                {
                    while (leitor.Read())
                    {
                        var id = leitor["ID_REMETENTE"] as int?;
                        return id.GetValueOrDefault().ToString();
                    }
                }
                else
                {
                    return "FALHA;Nao foi encontrado o cobrador vinculado a cobranca informada.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("FALHA;" + ex.ToString());
            }
            finally
            {
                con.Close();
            }


            return "OK;";
        }

        private string Deposito(string[] parametros)
        {
            var id = parametros[1];
            var pin = parametros[2];
            var deposito = parametros[3]; 
            float novoSaldo = 0;

            var sql = "SELECT TOP(1) *FROM CLIENTE WHERE PIN = '" + pin +
                "' AND ID = '" + id + "'";

            var con = CrieConexaoComBancoDeDados();
            var cmd = CrieComandoSql(con, sql);

            con.Open();
            try
            {
                var leitor = cmd.ExecuteReader();
                if (leitor.HasRows)
                {
                    while (leitor.Read())
                    {
                        var saldoAtual = leitor["SALDO"] as string;
                        novoSaldo = float.Parse(saldoAtual) + float.Parse(deposito);
                    }

                    AtualizeSaldo(id, novoSaldo.ToString());
                    return CadastreTransferencia(id, id, novoSaldo.ToString(), "S");
                }
                else
                {
                    return "FALHA;O PIN informado é inválido.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("FALHA;" + ex.ToString());
            }
            finally
            {
                con.Close();
            }


            return "OK;" + id + ";" + novoSaldo; ;
        }

        private string Cadastro(string[] parametros)
        {
            var nome = parametros[1];
            var numeroDaConta = parametros[3];

            if (!UsuarioCadastrado(nome, numeroDaConta))
            {
                var banco = parametros[2];   
                var numeroCartaoDeCredito = parametros[4];
                var pin = parametros[5];

                string sql = "INSERT INTO CLIENTE (NOME, BANCO, NUM_CONTA, NUM_CARTAO_CREDITO, PIN, SALDO) "
                + "VALUES ('" + nome + "', '" + banco + "', '"
                + numeroDaConta + "', '" + numeroCartaoDeCredito
                + "', '" + pin + "', '0')";

                var con = CrieConexaoComBancoDeDados();
                var cmd = CrieComandoSql(con, sql);

                con.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        return "OK";
                    else
                        return "FALHA";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.ToString());
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                return "FALHA;Já existe um cadastro para este nome de usuário e conta bancária!";
            }

            return "";
        }

        private bool UsuarioCadastrado(string nome, string numeroDaConta)
        {
            string sql = "SELECT *FROM CLIENTE WHERE NOME = '" + nome +
                "' AND NUM_CONTA = '" + numeroDaConta + "'";

            var con = CrieConexaoComBancoDeDados();
            var cmd = CrieComandoSql(con, sql);

            con.Open();
            try
            {
                if (cmd.ExecuteReader().HasRows)
                    return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO;" + "Usuário não cadastrado;");
            }
            finally
            {
                con.Close();
            }

            return false;
        }

        private string Login(string[] parametros)
        {
            var numeroDaConta = parametros[1];
            var pin = parametros[2];

            var sql = "SELECT *FROM CLIENTE WHERE PIN = '" + pin +
                "' AND NUM_CONTA = '" + numeroDaConta + "'";

            var con = CrieConexaoComBancoDeDados();
            var cmd = CrieComandoSql(con, sql);

            con.Open();
            try
            {
                var leitor = cmd.ExecuteReader();
                if (leitor.HasRows)
                {
                    while (leitor.Read())
                    {
                        var idCliente = leitor["ID"] as int?;
                        var saldo = leitor["SALDO"] as string;
                        var nome = leitor["NOME"] as string;
                        return "OK;" + idCliente.GetValueOrDefault().ToString() + ";" + saldo + ";" + nome;
                    }
                }
                else
                {
                    return "ERRO";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }

            return "";
        }

        private string AtualizeSaldo(string id, string novoSaldo)
        {
            string sql = "UPDATE CLIENTE SET SALDO = '" + novoSaldo + "' WHERE ID = '" + id + "'";

            var con = CrieConexaoComBancoDeDados();
            var cmd = CrieComandoSql(con, sql);

            con.Open();
            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    return "OK";
                else
                    return "FALHA";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }

            return "OK";
        }

        private string ConsulteSaldo(string id)
        {
            string sql = "SELECT SALDO FROM CLIENTE WHERE ID = " + id;

            var con = CrieConexaoComBancoDeDados();
            var cmd = CrieComandoSql(con, sql);

            con.Open();
            try
            {
                var leitor = cmd.ExecuteReader();
                if (leitor.HasRows)
                {
                    while (leitor.Read())
                    {
                        return leitor["SALDO"] as string;
                    }
                }
                else
                {
                    return "FALHA;Saldo não encontrado ID: " + id;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }

            return "OK";
        }

        private string CadastreTransferencia(string idRemetente, string idDestinatario, string valor, string efetuada)
        {
            string sql = "INSERT INTO TRANSFERENCIA (ID_REMETENTE, ID_DESTINATARIO, VALOR, EFETUADA) "
            + "VALUES (" + idRemetente + ", " + idDestinatario + ", '"+ valor + "', '" + efetuada + "')";

            var con = CrieConexaoComBancoDeDados();
            var cmd = CrieComandoSql(con, sql);

            con.Open();
            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    return "OK;";
                }
                else
                    return "FALHA";
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO;" + ex.ToString());
            }
            finally
            {
                con.Close();
            }

            return "";  
        }

        private int ObtenhaProximoID(string nomeDaTabela)
        {
            var sql = "SELECT MAX(ID) FROM " + nomeDaTabela;
            var con = CrieConexaoComBancoDeDados();
            var cmd = CrieComandoSql(con, sql);
            
            con.Open();
            try
            {
                var leitor = cmd.ExecuteReader();
                while (leitor.Read())
                {
                    return leitor.GetInt32(0) + 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO;" + ex.ToString());
            }
            finally
            {
                con.Close();
            }

            return 0;
        }

        private SqlConnection CrieConexaoComBancoDeDados()
        {
            SqlConnection con = new SqlConnection(_connectionString);
            return con;
        }

        private SqlCommand CrieComandoSql(SqlConnection con, string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, con)
            {
                CommandType = CommandType.Text
            };

            return cmd;
        }
    }
}
