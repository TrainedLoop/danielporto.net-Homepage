using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace Homepage.MVC.Models
{
    public class Email
    {
        private string SMTP = "CONFIGURAR";
        private string SendMail = "CONFIGURAR";
#warning senha
        private string PassWord = "CONFIGURAR";

        private string ReceiveMail = "CONFIGURARt";

        private string _Subject;
        private string Subject
        {
            get { return this._Subject; }
            set
            {
                if (value.Trim().Length < 3)
                    throw new Exception("Escreva um assunto com mais de 3 caracteres");
                if (value.Length > 30)
                    throw new Exception("Assunto com no maximo 30 caracteres");
                this._Subject = value;
            }
        }
        private string _ContactEmail;
        private string ContactEmail
        {
            get { return this._ContactEmail; }
            set
            {
                if (value.Trim().Length < 3)
                    throw new Exception("Email Invalido");
                if (value.Length > 30)
                    throw new Exception("Email Invalido");
                this._ContactEmail = value;
            }
        }
        private string _Message;
        private string Message
        {
            get { return this._Message; }
            set
            {
                if (value.Trim().Length < 10)
                    throw new Exception("A mensagem precisa ter mais de 10 caracteres");
                if (value.Length > 600)
                    throw new Exception("A mensagem com no maximo 600 caracteres");
                this._Message = value;
            }
        }




        public Email(string subject, string message, string email)
        {
            Subject = subject;
            Message = message;
            ContactEmail = email;
        }
        public void sendMail()
        {
            try
            {
                MailMessage mail = new MailMessage(SendMail, ReceiveMail);
                SmtpClient client = new SmtpClient();
                client.Port = 80;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.Credentials = new NetworkCredential(SendMail, PassWord);
                client.Host = SMTP;
                mail.Subject = Subject+"/n/n"+ContactEmail;
                mail.Body = Message;
                client.Send(mail);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}