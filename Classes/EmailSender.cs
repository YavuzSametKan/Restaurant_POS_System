using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace POS_System.Classes
{
    internal class EmailSender
    {
        private readonly string _fromAddress;
        private readonly string _password;

        // Constructor to set the sender's email address and password
        public EmailSender(string fromAddress, string password)
        {
            _fromAddress = fromAddress;
            _password = password;
        }

        // Method to send an email
        public bool SendEmail(string fromName, string toAddress, string subject, string body)
        {
            try
            {
                // Create an SMTP client to send the email via Gmail's SMTP server
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new NetworkCredential(_fromAddress, _password),
                    EnableSsl = true
                };

                // Set sender and recipient email addresses
                MailAddress fromMailAddress = new MailAddress(_fromAddress, fromName);
                MailAddress toMailAddress = new MailAddress(toAddress);

                // Create the email message
                MailMessage mailMessage = new MailMessage(fromMailAddress, toMailAddress)
                {
                    Subject = subject,
                    Body = body,
                    IsBodyHtml = false // Set to true if you want to send HTML content
                };

                // Send the email
                smtpClient.Send(mailMessage);
                return true; // Successfully sent
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false; // Sending error
            }
        }
    }
}
