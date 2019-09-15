using Microsoft.AspNet.Identity;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace API
{
    public class EmailService : IIdentityMessageService
    {
        readonly ConcurrentQueue<SmtpClient> _clients = new ConcurrentQueue<SmtpClient>();
        
        public async Task SendAsync(IdentityMessage message)
        {
            var client = GetOrCreateSmtpClient();
            try
            {
                MailMessage mailMessage = new MailMessage();

                mailMessage.To.Add(new MailAddress(message.Destination));
                mailMessage.Subject = message.Subject;
                mailMessage.Body = message.Body;

                mailMessage.BodyEncoding = Encoding.UTF8;
                mailMessage.SubjectEncoding = Encoding.UTF8;
                mailMessage.IsBodyHtml = true;

                // there can only ever be one-1 concurrent call to SendMailAsync
                await client.SendMailAsync(mailMessage);
            }
            finally
            {
                _clients.Enqueue(client);
            }
        }
        public void Send(IdentityMessage message)
        {
            var client = GetOrCreateSmtpClient();
            try
            {
                MailMessage mailMessage = new MailMessage();

                mailMessage.To.Add(new MailAddress(message.Destination));
                mailMessage.Subject = message.Subject;
                mailMessage.Body = message.Body;

                mailMessage.BodyEncoding = Encoding.UTF8;
                mailMessage.SubjectEncoding = Encoding.UTF8;
                mailMessage.IsBodyHtml = true;

                // there can only ever be one-1 concurrent call to SendMailAsync
                
                Thread t1 = new Thread(delegate ()
                {
                    try
                    {
                        client.Send(mailMessage);
                    }
                    catch (Exception)
                    {
                        
                        //throw;
                    }
                    
                });

                t1.Start();

            }
            finally
            {
                _clients.Enqueue(client);
            }
        }
        public void SendSync(IdentityMessage message)
        {
            var client = GetOrCreateSmtpClient();
            try
            {
                MailMessage mailMessage = new MailMessage();

                mailMessage.To.Add(new MailAddress(message.Destination));
                mailMessage.Subject = message.Subject;
                mailMessage.Body = message.Body;

                mailMessage.BodyEncoding = Encoding.UTF8;
                mailMessage.SubjectEncoding = Encoding.UTF8;
                mailMessage.IsBodyHtml = true;
                
                client.Send(mailMessage);
            }
            finally
            {
                _clients.Enqueue(client);
            }
        }
        private SmtpClient GetOrCreateSmtpClient()
        {
            SmtpClient client = null;
            if (_clients.TryDequeue(out client))
            {
                return client;
            }

            client = new SmtpClient();
            return client;
        }



       

        

    }
}