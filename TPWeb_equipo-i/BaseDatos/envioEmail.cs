using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using BaseDatos;
using Dominio;

namespace servicios
{
    public class envioEmail
    {
        private MailMessage email;
        private SmtpClient server;

        public envioEmail()
        {
            server = new SmtpClient();
            server.Credentials = new NetworkCredential("rogerbrunoprueba@gmail.com.ar", "dtdj styv ueav qbnk");
            server.EnableSsl = true;
            server.Port = 587;
            server.Host = "smtp-mail.gmail.com";
        }
        public void armarCorreo (string emailDestino, string asunto,string cuerpo)
        {
            email = new MailMessage();
            email.From = new MailAddress("promociones@tpweb.com");
            email.To.Add(emailDestino);
            email.Subject = asunto;
            email.IsBodyHtml = true;
            email.Body = "<h1>¡Ha participado exitosamente!</h1>\r\n       <h2>¡Aumente sus chanches de ganar!</h2>\r\n    <h2>Siga participando con la compra de más artículos.</h2>";
        }
        public void enviarEmail()
        {
            try
            {
                server.Send(email);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
