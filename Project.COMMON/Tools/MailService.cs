using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Project.COMMON.Tools
{
    public static class MailService
    {
        public static void Send(string receiver, string password = "oktczfjzfohickzn", string body = "Test mesajıdır", string subject = "Email testi", string sender = "yzlm3170@gmail.com")
        {
            MailAddress senderEmail = new(sender);
            MailAddress receiverEmail = new(receiver);

            // Bizim Email İşlemlerim SMTP'ye Göre Yapılır.
            // Kullandığımız gmail hesabımızın başka uygulamalar tarafından mesaj gönderme sistemini açmamız gerekiyor.

            SmtpClient smtp = new()
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(senderEmail.Address, password)

            };


            using (MailMessage message = new MailMessage(senderEmail, receiverEmail)
            {
                Subject = subject,
                Body = body,
            })
            {
                smtp.Send(message);
            }

            //    MailMessage message = new(senderEmail, receiverEmail)
            //    {
            //        Subject = subject,
            //        Body = body,
            //    };

            //smtp.Send(message);

            #region DefaultParameters
            /*
             
                            - Default Parameters -

                -> Bir metod parametresine default bir değer alırsa cağırılırken argüman almayabilir böylece o default değer parametreye girmiş olur... Ancak yine de eğer argüman verirseniz verdiğiniz argüman defualt değeri ezerek gönderilir.

                -> Eğer Parametreleriniz defult bir değer almaya başladıysa onları takip eden parametreler değer alamdan Syntax hatası verirler.. Defult değer almaaycak parametelrinizi değer alanlardan önce yazmalısınız.

                        -> Params Keyword'ü <-

                -> Bir metodun kaç tane argüman alabileceğini öngöremediğimiz durumlarda parametre keyword'u tanımlamasını params ile yaparız böylece metot çağırıldığında isterse hiç argüman almayabilir veya istediğimiz o ilgili tipte argüman alabilirler.

                -> Param keyword'u ile Kullanılan bir parametreden sonra başka bir parametre tanımlaması yapamazsınız 

                ------ Örnek Kullanım -----
                public static void Deneme(int b , params char[] a)
                {
                }

             */
            #endregion

        }
    }
}
