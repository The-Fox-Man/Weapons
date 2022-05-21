using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace App
{
    public partial class login1 : Form
    {
        public login1()
        {
            InitializeComponent();
        }
        public static string login = "";
        public static string sur = "";
        public static string post = "";

        public static string nameUS = "";
        public static string surnm = "";
        public static string gmail = "";
        public static string psd = "";

    
        private void button1_Click(object sender, EventArgs e)
        {
            //log = textBox1.Text;
            string[] li = File.ReadAllLines("users.txt");
            foreach(string objects in li)
            {
                string[] word = objects.Split(new string[] { ", " }, StringSplitOptions.None);
                nameUS = word[0];
                surnm = word[1];
                gmail = word[2];
                psd = word[3];

                if(log.Text == nameUS && pswdBox.Text == psd)
                {
                    login = nameUS;
                    sur = surnm;
                    post = gmail;
                    MessageBox.Show("ВЫ успешно вошли!", "Программа");
                }
                else { MessageBox.Show("Неверный адрес почты или пароль. Или поля вообще пустые. Внимательно посмотрите, не содержат ли поля лишних пробелов или символов. Либо ВЫ просто не зарегестрированы.", "Программа"); }
               

            }

            Close();
        }
    }
}
