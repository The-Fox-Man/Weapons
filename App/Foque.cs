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
        public static List<Guns> gun_list = new List<Guns>();



        int a = 0;
        public Foque()
        {
            InitializeComponent();
            Controls.Clear();
            int x = 0;
            int y = 30;
            PictureBox back = new PictureBox();
            back.Location = new Point(930, + 5);
            back.SizeMode = PictureBoxSizeMode.Zoom;
            back.Load("../../../images/back.png");
            back.Size = new Size(49, 47);
            back.BackColor = Color.Transparent;
            back.Click += new EventHandler(back_Click);
            Controls.Add(back);
            for (int i = 0; i < gun_list.Count; i++)
            {
                if (gun_list[i].kind == "Автомат")
                {
                    gun_list[i].lbl.Location = new Point(x + 100, y);
                    gun_list[i].lbl.Size = new Size(130, 39);
                    gun_list[i].lbl.BackColor = Color.Transparent;
                    Controls.Add(gun_list[i].lbl);

                    gun_list[i].pic.Location = new Point(x, y + 50);
                    gun_list[i].pic.Size = new Size(310, 165);
                    gun_list[i].pic.BackColor = Color.Transparent;
                    gun_list[i].pic.Click += new EventHandler(oke);
                    Controls.Add(gun_list[i].pic);
                    x = x + 310;

                    if (x + 150 > Width)
                    {
                        y = y + 230;
                        x = 10;
                    }
                }
            }
        }
        public static void oke(object sender, EventArgs e)
        {
            for (int i = 0; i < gun_list.Count; i++)
            {
                if (((PictureBox)sender).Name == gun_list[i].name || ((PictureBox)sender).Tag == gun_list[i].name)
                {
                    guns gun = new guns(gun_list[i]);
                    gun.ShowDialog();
                }
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Foque_Load(object sender, EventArgs e)
        {

        }
        //сделааааааааааааааааааать массив, который сделает рабочей данную страницу!!!
        /*  private void pic_Click(object sender, EventArgs e)
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
          }*/

    }
}
