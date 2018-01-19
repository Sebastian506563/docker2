using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.magic;

namespace WebApplication1.Controllers
{
    [Route("api/mail")]
    public class ValuesController : Controller
    {

        [HttpPost]
        public void Post([FromBody]Mail mailP)
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

            mail.From = new MailAddress("kontoszkoleniowedocker@gmail.com");
            mail.To.Add(mailP.Email);
            mail.Subject = mailP.Topic;
            mail.Body = mailP.Message;

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("kontoszkoleniowedocker", "testoweHaslo");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);

        }

    }
}
