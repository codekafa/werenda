using Business.Abstract;
using CommonUI.Constants;
using Models.UIModel;
using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace Business.ConCreate
{
    public class MailManager : IMailService
    {
        public bool SendMail(SendMailModel mail)
        {
            try
            {
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp-mail.outlook.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.Credentials = new System.Net.NetworkCredential(MailKeyConstants.Mail, MailKeyConstants.Password);
                MailMessage email = new MailMessage();
                email.From = new MailAddress(MailKeyConstants.Mail);

                foreach (var item in mail.To)
                {
                    email.To.Add(item);
                }

                foreach (var bbc in mail.Bbc)
                {
                    email.Bcc.Add(bbc);
                }
                foreach (var cc in mail.Cc)
                {
                    email.CC.Add(cc);
                }
                email.Subject = mail.Subject;
                email.IsBodyHtml = mail.IsHtml;
                email.Body = "";
                foreach (string att in mail.Attactments)
                {
                    email.Attachments.Add(new Attachment(att));
                }
                smtp.Send(email);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }         
        }
    }
}
