using System;
using System.Net;
using System.Net.Mail;

namespace GUI
{
    public class SendEmail
    {
        SmtpClient client;
        NetworkCredential credential;

        public SendEmail()
        {
            client = new SmtpClient();
            client.UseDefaultCredentials = false;
            credential = new NetworkCredential("huynhnhusee26@gmail.com", "(nhu)0312");
            client.Credentials = credential;
            client.Host = "smtp.gmail.com";
            client.Port = 587;
            client.EnableSsl = true;
        }

        public void SendMail(string subject, string content)
        {
            if (client == null)
            {
                throw new InvalidOperationException("SmtpClient is not initialized properly.");
            }

            var message = new MailMessage();
            message.From = new MailAddress("hethongquanlygiophucvucongdong@gmail.com");
            message.To.Add(new MailAddress("huynhnhusee26@gmail.com"));
            message.Subject = subject;
            message.Body = content;
            message.BodyEncoding = System.Text.Encoding.UTF8;
            message.IsBodyHtml = true;

            try
            {
                client.Send(message);
                Console.WriteLine("Email sent successfully!");
            }
            catch (SmtpException ex)
            {
                Console.WriteLine("Failed to send email: "+ex.StatusCode);
                Console.WriteLine("SmtpException Message: "+ex.Message);
                // Handle SmtpException - it contains specific SMTP status codes
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to send email: " + ex.Message);
                // Handle other exceptions that might occur during the sending process
            }
            finally
            {
                message.Dispose();
            }
        }
    }
}
