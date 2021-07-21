using MailKit.Net.Smtp;
using Microsoft.AspNet.Identity;
using MimeKit;
using System;
using System.Collections.Concurrent;
using System.Configuration;
using System.Net.Configuration;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace API
{
    public class EmailService : IIdentityMessageService
    {
        readonly ConcurrentQueue<SmtpClient> _clients = new ConcurrentQueue<SmtpClient>();
        public string from = "";
        public async Task SendAsync(IdentityMessage message)
        {
            //var client = GetOrCreateSmtpClient();
            try
            {
                var config = (SmtpSection)ConfigurationManager.GetSection("system.net/mailSettings/smtp");
                from = config.From;

                var email = new MimeMessage();
                email.From.Add(MailboxAddress.Parse(from));
                email.To.Add(MailboxAddress.Parse(message.Destination));
                email.Subject = message.Subject;
                email.Body = new TextPart(MimeKit.Text.TextFormat.Html) { Text = message.Body };

                //client.Send(email);

                using (var client = new SmtpClient())
                {
                    await client.ConnectAsync(config.Network.Host, config.Network.Port, config.Network.EnableSsl ? MailKit.Security.SecureSocketOptions.SslOnConnect : MailKit.Security.SecureSocketOptions.Auto);
                    await client.AuthenticateAsync(config.Network.UserName, config.Network.Password);
                    await client.SendAsync(email);
                    await client.DisconnectAsync(true);

                };

            }
            finally
            {
                //_clients.Enqueue(client);
            }
        }
        public void Send(IdentityMessage message)
        {
            var client = GetOrCreateSmtpClient();
            try
            {
                var email = new MimeMessage();
                email.From.Add(MailboxAddress.Parse(from));
                email.To.Add(MailboxAddress.Parse(message.Destination));
                email.Subject = message.Subject;
                email.Body = new TextPart(MimeKit.Text.TextFormat.Html) { Text = message.Body };

                // there can only ever be one-1 concurrent call to SendMailAsync

                Thread t1 = new Thread(delegate ()
                {
                    try
                    {
                        client.Send(email);
                    }
                    catch (Exception ex)
                    {

                        throw ex;
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
                var email = new MimeMessage();
                email.From.Add(MailboxAddress.Parse(from));
                email.To.Add(MailboxAddress.Parse(message.Destination));
                email.Subject = message.Subject;
                email.Body = new TextPart(MimeKit.Text.TextFormat.Html) { Text = message.Body };

                client.Send(email);
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

            var config = (SmtpSection)ConfigurationManager.GetSection("system.net/mailSettings/smtp");
            from = config.From;

            client = new SmtpClient();
            client.Connect(config.Network.Host, config.Network.Port, config.Network.EnableSsl ? MailKit.Security.SecureSocketOptions.SslOnConnect : MailKit.Security.SecureSocketOptions.Auto);
            client.Authenticate(config.Network.UserName, config.Network.Password);
            return client;
        }

    }
}