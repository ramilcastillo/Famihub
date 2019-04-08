using FamiHub.Common.Mail.Resource;
using System.Net.Mail;

namespace FamiHub.Common.Mail
{
    public class SendMailService
    {
        public void SendMail(MailProperties mailRequest, SMTPSettings smtp)
        {
            MailMessage objeto_mail = new MailMessage();
            SmtpClient client = new SmtpClient();
            client.Port = smtp.Port;
            client.Host = smtp.Host;
            client.Timeout = 10000;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential(smtp.Username, smtp.Password);
            objeto_mail.From = new MailAddress(smtp.DefaultFromAddress);
            objeto_mail.To.Add(new MailAddress(mailRequest.DestinationEmailAddress));
            objeto_mail.Subject = mailRequest.Subject;
            objeto_mail.Body = "<p>"+mailRequest.Body+"</p>";
            client.Send(objeto_mail);
        }      
    }
}
