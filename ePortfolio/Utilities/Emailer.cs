using System.Configuration;
using System.Net;
using System.Net.Mail;

namespace ePortfolio.Utilities
{
    public class Emailer
    {
        public static bool Send(string mailto, string subject, string body)
        {
            string mailfrom = ConfigurationManager.AppSettings["mail.1"];
            string password = ConfigurationManager.AppSettings["maildaemon.Key"];
            MailMessage mail = new MailMessage(mailfrom, mailto);
            SmtpClient client = new SmtpClient
            {
                Port = 80,
                Timeout = 10000,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtpout.secureserver.net",
                Credentials = new NetworkCredential(mailfrom, password)
            };
            mail.Subject = subject;
            mail.Body = body;
            client.Send(mail);
            return true;
        }
    }
}