using System;
using System.IO;

namespace WafSistemas.GerenciadorCliente.Util.Arquivo
{
    public static class Arquivo
    {
        public static string CarregarArquivo(string file)
        {
            string response = "";
            try
            {                
                var data = File.ReadAllText(file);
                response = "{ 'isSucesso': 'true', " +
                         " 'file': '" + data + "', " +
                         "}";                
            }
            catch(Exception ex)
            {
                response= "{ 'isSucesso': 'false'," +
                    "'msg': 'Erro inesperado consulte suporte.'," +
                    "'msgException':'" + ex.Message + "'," +
                    "'StackTrace': '" + ex.StackTrace + "}";
            }

            return response;
        }
    }
}
