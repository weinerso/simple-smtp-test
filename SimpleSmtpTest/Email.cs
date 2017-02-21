using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSmtpTest
{
    public class Email
    {
        public string Host { get; set; }
        public int Port { get; set; }
        public int Timeout { get; set; }
        public bool Ssl { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public bool UseDefaultCredentials { get; set; }
        public string From { get; set; }
        public string To { get; set; }

        public Email()
        {
            Timeout = 20;
            UseDefaultCredentials = false;
        }

        public void SendMail()
        {
            using (SmtpClient client = new SmtpClient())
            {
                client.EnableSsl = Ssl;
                if (UseDefaultCredentials)
                {
                    client.UseDefaultCredentials = UseDefaultCredentials;
                }
                else
                {
                    if (string.IsNullOrEmpty(User) && string.IsNullOrEmpty(Password))
                    {
                        client.Credentials = null;
                    }
                    else
                    {
                        client.Credentials = new System.Net.NetworkCredential(User, Password);
                    }
                }
                client.Timeout = Timeout;
                client.Host = Host;
                client.Port = Port;
                client.Send(From, To, "Simple SMTP Test", "Success!");
            }
        }
    }
}
