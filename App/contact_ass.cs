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
using System.Net;

namespace App
{
    public partial class contact_ass : Form
    {
        public contact_ass()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MailAddress fromMailAddress = new MailAddress("testoffyuo@gmail.com", "Weapons");
            MailAddress toAdress = new MailAddress("testoffyuo@gmail.com", "User");
            using (MailMessage msg = new MailMessage(fromMailAddress, toAdress))
            using (SmtpClient smtpClient = new SmtpClient())
            {
                msg.Subject = comboBox1.Text;
                msg.Body = "hello my nigg, " + Environment.NewLine + richTextBox1.Text
                           + Environment.NewLine + Environment.NewLine + "С уважением, ваш пользователь";
                msg.IsBodyHtml = true;

                smtpClient.Host = "smtp.gmail.com";
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(fromMailAddress.Address, "a2000lol");

                smtpClient.Send(msg);

            }
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void contact_ass_Load(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
