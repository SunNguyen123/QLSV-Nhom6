using System;
using FluentEmail.Core;
using FluentEmail.Smtp;
using System.Net.Mail;

namespace BLL.QuanTriVien
{
    class Email_BLL
    {


public void SendEmail()
    {
        var email = Email
            .From("youremail@gmail.com")
            .To("recipientemail@gmail.com")
            .Subject("Test Email")
            .Body("This is a test email sent using FluentEmail library.");

        var sender = new SmtpSender(() => new SmtpClient("smtp.gmail.com")
        {
            EnableSsl = true,
            DeliveryMethod = SmtpDeliveryMethod.Network,
            Port = 587,
            UseDefaultCredentials = false,
            Credentials = new System.Net.NetworkCredential("youremail@gmail.com", "yourpassword")
        });

        //email.Send(sender);
    }

}
}
