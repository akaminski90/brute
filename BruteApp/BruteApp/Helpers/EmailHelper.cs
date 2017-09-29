using System.Configuration;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Web;

namespace BruteApp.Helpers
{
    public class EmailHelper
    {

        public static void SendEmail(string email, string mailBody, string mailSubject, HttpPostedFileBase file = null, string emailFrom = null, string emailNameFrom = null)
        {
            var mailAddressFrom = new MailAddress(!string.IsNullOrWhiteSpace(emailFrom) ? emailFrom : ConfigurationManager.AppSettings["defaultEmailFrom"],
                !string.IsNullOrWhiteSpace(emailNameFrom) ? emailNameFrom : ConfigurationManager.AppSettings["defaultEmailNameFrom"]);

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(ConfigurationManager.AppSettings["smtpEmail"],
                    ConfigurationManager.AppSettings["smtpPassword"])
            };
            using (var message = new MailMessage(mailAddressFrom, new MailAddress(email))
            {
                Subject = mailSubject,
                SubjectEncoding = Encoding.UTF8,
                Body = mailBody,
                BodyEncoding = Encoding.UTF8,
                IsBodyHtml = true
            })
            {
                if (file != null)
                {
                    message.Attachments.Add(new Attachment(file.InputStream, file.FileName) { ContentType = new ContentType(file.ContentType) });
                }
                smtp.Send(message);
            }
        }

    }
}