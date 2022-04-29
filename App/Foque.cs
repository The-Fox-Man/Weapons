using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class Foque : Form
    {
        //public static Guns[] gun_list = new Guns[8];
        //public static List<Guns> gun_list = new List<Guns>();
        int a = 0;
        public Foque()
        {
            InitializeComponent();
        }
        //сделааааааааааааааааааать массив, который сделает рабочей данную страницу!!!
        private void pic_Click(object sender, EventArgs e)
        {

            filter.okey(sender, e);
        }
        private void button4_Click(object sender, EventArgs e)
        {
         //     Foque kok = new Foque();
           //   kok.Close();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
     //       guns c = new guns("M-16");
      //      c.ShowDialog();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
       //     guns c = new guns("HK416");
     //       c.ShowDialog();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
        //   guns c = new guns("scar");
         //   c.ShowDialog();
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
         //   guns c = new guns("FAMAS");
         //   c.ShowDialog();
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
         //   guns c = new guns("Zastava");
          //  c.ShowDialog();
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
        //    guns c = new guns("INSAS");
          //  c.ShowDialog();
        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
         //   guns c = new guns("ads");
          //  c.ShowDialog();
        }

    }
}
