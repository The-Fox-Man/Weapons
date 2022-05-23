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
    public partial class mail : Form
    {
        public mail()
        {
            InitializeComponent();
            textBox1.Text = login1.gmail;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            MailAddress fromMailAddress = new MailAddress("testoffyuo@gmail.com", "Weapons");
            MailAddress toAdress = new MailAddress(textBox1.Text, "User");
            using (MailMessage msg = new MailMessage(fromMailAddress, toAdress))
            using (SmtpClient smtpClient = new SmtpClient())
            {
                msg.Subject = "da";
                msg.Body = "hello my nigg " + Environment.NewLine;
                msg.IsBodyHtml = true; //artem.lisenkoff@gmail.com

                System.IO.File.WriteAllText("yes.csv", "Название, Цена, Количество, Стоимость всего оружия");

                foreach (KeyValuePair<Guns, int> selected_guns in Favourite.selectedGuns)
                {
                    Guns gun = selected_guns.Key;
                    System.IO.File.AppendAllText("yes.csv", Environment.NewLine + gun.name + ","
                                                 + gun.price + "," + selected_guns.Value + ","
                                                 + selected_guns.Value * gun.price);
                }

                System.IO.File.AppendAllText("yes.csv", Environment.NewLine + "Цена вашей корзины : " + Favourite.finalprs);

                msg.Attachments.Add(new Attachment("yes.csv"));

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

        private void mail_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
