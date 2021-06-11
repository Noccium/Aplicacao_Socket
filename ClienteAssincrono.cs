using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace CLIENTE_APP
{
    public static class ClienteAssincrono
    {
        private static TcpClient _conexao;

        public static void CrieConexaoComServidor()
        {
            try
            {
                _conexao = new TcpClient();
                //Console.WriteLine("Connecting..");
                _conexao.Connect("192.168.0.193", 8000);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error" + e.StackTrace);
            }
        }

        public static async Task<string> EnviarComando(string comando)
        {
            CrieConexaoComServidor();
            Stream stm = _conexao.GetStream();
            ASCIIEncoding ascnd = new ASCIIEncoding();
            byte[] ba = ascnd.GetBytes(comando);

            ///Console.WriteLine("Sending..");
            await stm.WriteAsync(ba, 0, ba.Length);
            byte[] bb = new byte[100];
            int k = await stm.ReadAsync(bb, 0, 100);

            var resposta = new StringBuilder();
            for (int i = 0; i < k; i++)
            {
                resposta.Append(Convert.ToChar(bb[i]));
            }

            return resposta.ToString();
        }

        public static void FinalizarConexaoComServidor()
        {
            if (_conexao == null || !_conexao.Connected)
            {
                _conexao.Close();
            }
        }
    }
}
