using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace CIS_376
{
    public partial class ReminderEmail : Form
    {
        public ReminderEmail()
        {
            InitializeComponent();
        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            //http://csharp.net-informations.com/communications/csharp-smtp-mail.htm
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("facadefridge@gmail.com");
                mail.To.Add("akrayem@umich.edu");
                mail.Subject = "Test Mail";
                mail.Body = "This is for testing SMTP mail from GMAIL";

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("facadefridge", "UMD12345");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("mail Send");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //TODO: Custom reminder, adds item to database

        private void VerifyEmail_Click(object sender, EventArgs e)
        {
            bool idFound = false;
            try
            {
                MailAddress emailID = new MailAddress(EmailAddressBox.Text);
                idFound = true;

            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Email! Please use a valid email.");
            }
            
            if (idFound)
            {

            }
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
    }
}