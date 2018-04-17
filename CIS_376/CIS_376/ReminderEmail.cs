using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Net.Mail;

namespace CIS_376
{
    public partial class ReminderEmail : Form
    {
        private string reminderText = "Grocery list: ";
        private MailAddress emailID;

        public ReminderEmail()
        {
            InitializeComponent();
            this.CenterToScreen();
            fillComboBox();
        }

        public void sendEmail()
        {
            //http://csharp.net-informations.com/communications/csharp-smtp-mail.htm
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("facadefridge@gmail.com");
                mail.To.Add(emailID);
                mail.Subject = "Grocery reminder";
                mail.Body = reminderText + "Thanks for using the email reminder!";

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("facadefridge", "UMD12345");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("Reminder Sent!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            //https://stackoverflow.com/questions/3036829/how-do-i-create-a-message-box-with-yes-no-choices-and-a-dialogresult
            DialogResult dialogResult = MessageBox.Show($"The email will display:\n{reminderText}", "Email about to send!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                sendEmail();
            }
            else if (dialogResult == DialogResult.No)
            {}
        }

        private void fillComboBox()
        {
            FoodBox.DataSource = null;
            FoodBox.Items.Clear();

            var foods = ManagerHome.mainDatabaseReference.Foods.ToList().Select(p => new {p.Food_ID, p.Food_Name }).ToList();
            FoodBox.DataSource = foods.ToList();
            FoodBox.ValueMember = "Food_ID";
            FoodBox.DisplayMember = "Food_Name";
        }

        private void VerifyEmail_Click(object sender, EventArgs e)
        {
            bool idFound = false;
            try
            {
                emailID = new MailAddress(EmailAddressBox.Text);
                idFound = true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Email! Please use a valid email.");
            }
            
            if (idFound)
            {
                Food_Label.Visible = true;
                FoodBox.Visible = true;
                Add_button.Visible = true;
                listView1.Visible = true;
                TestButton.Visible = true;
            }
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(FoodBox.Text);
            reminderText = reminderText + $"{FoodBox.Text}\n";
            listView1.Items.Add(item);
            FoodBox.Text = "";
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }
    }
}