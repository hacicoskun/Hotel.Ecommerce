using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Ecommerce.Helper
{
    public class Smtp
    {



        public static string SmtpExSend(string ExMessage, string ExPage)
        {

            MailMessage mesaj = new MailMessage();
            mesaj.From = new MailAddress("info@becomingtur.com", "Becoming Tur");
            mesaj.To.Add("ercument@becomingtur.com");

            mesaj.Subject = "SİTE HATA RAPORU";
            mesaj.Body = "HATA SAYFASI=" + ExPage + "<br/>" + "<br/>" + ExMessage.ToString();
            mesaj.IsBodyHtml = true;
            SmtpClient client = new SmtpClient("smtp.yandex.ru", 587);
            client.Credentials = new NetworkCredential("info@becomingtur.com", "5hqyb64h");
            client.EnableSsl = true;
            client.Send(mesaj);
            return null;




        }
        public static string MailGonder(string MailMsg)
        {


            MailMessage mesaj = new MailMessage();
            SmtpClient istemci = new SmtpClient();
            istemci.Credentials = new System.Net.NetworkCredential("mail@becomingtur.com", "He9s5BkA");
            istemci.Port = 587;
            istemci.Host = "smtp.becomingtur.com";
            istemci.EnableSsl = false;
            mesaj.To.Add("gunayozcan06@gmail.com");//kime gönderilecek
            mesaj.From = new MailAddress("mail@becomingtur.com", "Arama Talebi");
            mesaj.Subject = "İletişim İsteği";
            mesaj.Body = MailMsg;
            mesaj.IsBodyHtml = true;
            ServicePointManager.ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };
            istemci.Send(mesaj);




            return "";



        }






    }
}
