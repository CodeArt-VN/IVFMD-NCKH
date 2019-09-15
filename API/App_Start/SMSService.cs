using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Net;
using System.IO;
using System.Collections.Concurrent;
using System.Text.RegularExpressions;
using System.Text;

namespace API
{
    public class SmsService : IIdentityMessageService
    {
        
        public async Task SendAsync(IdentityMessage message)
        {
            var client = GetOrCreateWebClient();
            try
            {
                int type = 3;
                string sender = "MAT_HAI_YEN";
                string campaign_name = "member card";
                String url = rootURL + "/sms/send";
                
                NetworkCredential myCreds = new NetworkCredential(accessToken, ":x");
                client.Credentials = myCreds;
                client.Headers[HttpRequestHeader.ContentType] = "application/json";

                string builder = "{\"to\":[\"" 
                    + message.Destination 
                    + "\"], \"content\": \"" + message.Body 
                    + "\", \"type\":" + type 
                    + ", \"sender\": \"" + sender 
                    + "\", \"campaign_name\": \"" + campaign_name + "\"}";
                String json = builder.ToString();
                getUserInfo();
                await client.UploadStringTaskAsync(new Uri(url), json);
            }
            finally
            {
                _clients.Enqueue(client);
            }
        }
        public void Send(IdentityMessage message)
        {
            var client = GetOrCreateWebClient();
            try
            {
                int type = 3;
                string sender = "MAT_HAI_YEN";
                string campaign_name = "member card";
                String url = rootURL + "/sms/send";

                NetworkCredential myCreds = new NetworkCredential(accessToken, ":x");
                client.Credentials = myCreds;
                client.Headers[HttpRequestHeader.ContentType] = "application/json";

                string builder = "{\"to\":[\""
                    + message.Destination
                    + "\"], \"content\": \"" + RemoveVietnameseMark(message.Body.Replace("\r\n",""))
                    + "\", \"type\":" + type
                    + ", \"sender\": \"" + sender
                    + "\", \"campaign_name\": \"" + campaign_name + "\"}";
                String json = builder.ToString();
                
                string result = client.UploadString(url, json);
            }
            finally
            {
                _clients.Enqueue(client);
            }
        }
        public String getUserInfo()
        {
            String url = rootURL + "/user/info";
            NetworkCredential myCreds = new NetworkCredential(accessToken, ":x");
            WebClient client = new WebClient();
            client.Credentials = myCreds;
            Stream data = client.OpenRead(url);
            StreamReader reader = new StreamReader(data);
            return reader.ReadToEnd();
        }

        public string RemoveVietnameseMark(string accented)
        {
            if (string.IsNullOrEmpty(accented))
            {
                return "";
            }
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string input = accented.Normalize(NormalizationForm.FormD);
            return regex.Replace(input, string.Empty).Replace(Convert.ToChar(273), 'd').Replace(Convert.ToChar(272), 'D');
        }

        private string EncodeNonAsciiCharacters(string value)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            foreach (char c in value)
            {
                if (c > 127)
                {
                    // This character is too big for ASCII
                    string encodedValue = "\\u" + ((int)c).ToString("x4");
                    sb.Append(encodedValue);
                }
                else
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }
        const String rootURL = "http://api.speedsms.vn/index.php";
        private String accessToken = "BxPXL41QTmwWu6iSwLFxBxmuXNPqUgOl";
        
        readonly ConcurrentQueue<WebClient> _clients = new ConcurrentQueue<WebClient>();

        private WebClient GetOrCreateWebClient()
        {
            WebClient client = null;
            if (_clients.TryDequeue(out client))
            {
                return client;
            }

            client = new WebClient();
            return client;
        }
    }


    


}