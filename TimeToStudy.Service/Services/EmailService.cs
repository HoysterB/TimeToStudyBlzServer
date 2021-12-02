using System.Net;
using System.Net.Mail;

namespace TimeToStudy.Service.Services
{
    public static class EmailService
    {
        public static void EnviarEmail(string destinatario, string nomeUsuario)
        {
            try
            {
                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress("alexandretaumaturgo4@gmail.com");
                    mail.To.Add(destinatario);
                    mail.Subject = "TimeToStudy";
                    mail.Body = $"<h1>Parabéns {nomeUsuario}</h1>  <h2>Cadastro feito com sucesso</h2>";
                    mail.IsBodyHtml = true;

                    using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                    {
                        smtp.Credentials = new NetworkCredential("alexandretaumaturgo4@gmail.com", "C3branco");
                        smtp.EnableSsl = true;
                        smtp.Send(mail);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
