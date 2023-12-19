using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Net.Mail;
using WafSistemas.GerenciadorCliente.Util.Arquivo;

namespace WafSistemas.GerenciadorCliente.Util.Email
{
    public class SendEmail
    {
        private string _remetente = "wolneyaf@gmail.com";
        private string _server = "smtp.gmail.com";
        private string _porta = "587";
        private string _login = "wolneyaf@gmail.com";
        private string _senha = "WoLnEy_waf_1q2w3e4r5t6y";

        public SendEmail()
        {
            //_remetente = ConfigurationManager.AppSettings["EmailRemetente"];
            //_server = ConfigurationManager.AppSettings["ServidorEmail"];
            //_porta = ConfigurationManager.AppSettings[""];
            //_login = ConfigurationManager.AppSettings["EmailRemetente"];
            //_senha = ConfigurationManager.AppSettings["SenhaRemetente"];
        }

        public SendEmail(string remetente, string server, string porta, string login, string senha)
        {
            _remetente = remetente;
            _server = server;
            _porta = porta;
            _login = login;
            _senha = senha;
        }

        public string Send(Dictionary<string,string> destinos=null, Dictionary<string, string> copys = null, string body="", string assunto="")
        {
            string Response = "";
            System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient();
            client.Host = _server;
            client.Port = Convert.ToInt32(_porta);
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
            client.Credentials = new System.Net.NetworkCredential(_login, _senha);
            MailMessage mail = new MailMessage();
            //mail.Sender = new System.Net.Mail.MailAddress("email que vai enviar", "ENVIADOR");
            
            //REMETENTE
            mail.From = new MailAddress(_remetente);

            //DESTINO
            if(destinos!=null)
                foreach(var email in destinos)
                    mail.To.Add(new MailAddress(email.Key, email.Value));

            //EMAIL COPIA
            if(copys!=null)
                foreach (var copy in copys)
                    mail.CC.Add(copy.Key);

            mail.Subject = assunto;
            mail.Body = body;
            mail.IsBodyHtml = true;
            mail.Priority = MailPriority.High;
            try
            {
                client.Send(mail);
                Response = "{ 'isSucesso': 'true'}";
            }
            catch (System.Exception ex) { 

                Response = "{ 'isSucesso': 'false'," +
                    "'msg': 'Erro inesperado consulte suporte.'," +
                    "'msgException':'" + ex.Message + "'," +
                    "'StackTrace': '" + ex.StackTrace + "}";

                mail = null;
                
                return Response;
            }
            finally
            {
                mail = null;
            }

            return Response;
        }


        public string GetModelo(Enums.ModeloEmail modelo)
        {
            string texto = "";
            string Diretorio= Directory.GetCurrentDirectory() + "/Modelo/";

            switch (modelo)
            { 
                case Enums.ModeloEmail.ConfirmarCadastro:
                    texto = Arquivo.Arquivo.CarregarArquivo(Diretorio + modelo.ToString()+".html");
                    break;
            }

            return texto;
        }

    }
}
