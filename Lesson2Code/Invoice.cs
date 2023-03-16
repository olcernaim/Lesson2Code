using Lesson2Code.Log.Concrete;
using Lesson2Code.Log.Interfaces;
using Lesson2Code.Mail;
using System;

namespace Lesson2Code
{
    //Send email
    //Invice İşlemleri
    //Log
    public class Invoice
    {
        public long InviceAmount { get; set; }
        public DateTime InviceDate { get; set; }

        private MailSender emailSender;

        private ILog logger;

        public Invoice() {
            logger = new LogRepo();
            emailSender = new MailSender();
        }    

        public void AddInvoice() {
            try
            {
                logger.Info("Email process start");
                emailSender.EmailFrom = "";
                emailSender.EmailTo = "";
                emailSender.EmailSubject = "";
                emailSender.EmailBody = "";
                emailSender.SendMail();
                logger.Info("Email process end");

            }
            catch (Exception ex)
            {
                logger.Error("Error occured while sending email", ex);
            }
        }
        public void DeleteInvoice() {
            try
            {
                //Delete
            }
            catch (Exception ex)
            {
                logger.Error("Error occured while deleting invoice", ex);
            }
        }
    }
}
