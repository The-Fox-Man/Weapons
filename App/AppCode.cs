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

    /*
      try
        {
    ... Тута любая вещь с путём файла, которая не работает...
        }
      catch(Exception){}
     */
    public partial class AppCode : Form
    {
    
        public AppCode(int a)
        {
            InitializeComponent();
            a = 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Black;
            button1.BackColor = Color.Red;
            MessageBox.Show("НИЧЕГО НЕТ"); 
        }
        private void button2_Click(object sender, EventArgs e)
        {

            Button da = (Button)sender;
            da.ForeColor = Color.Red;
            da.BackColor = Color.Black;
            Foque f = new Foque();
            f.ShowDialog();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            button3.ForeColor = Color.Red;
            button3.BackColor = Color.Black;
            MessageBox.Show("НИЧЕГО НЕТ"); 
        }
        private void button4_Click(object sender, EventArgs e)
        {
            filter filt = new filter();
            filt.ShowDialog();
           /* for (int i = 0; i < 3; i++)
            {
                btn[i].Visible = false;
            }*/
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Favourite hi = new Favourite();
            hi.ShowDialog();
        }

        private void AppCode_Load(object sender, EventArgs e)
        {
            string[] line = File.ReadAllLines("base_of_stuff.txt");

            foreach (string stroke in line)
            {
                string[] quarter = stroke.Split(new string[] {", "}, StringSplitOptions.None);
                Guns gune = new Guns(quarter[0], Convert.ToInt32(quarter[1]), quarter[2], quarter[3]);
                filter.gun_list.Add(gune);
            }

            /*filter.gun_list[0] = new Guns("INSAS", 7, "1987", "Автомат");
            filter.gun_list[1] = new Guns("ads", 5, "2007", "Автомат");
            filter.gun_list[2] = new Guns("Zastava", 7, "2004", "Автомат");
            filter.gun_list[3] = new Guns("ak47", 5, "1966", "Автомат");
            filter.gun_list[4] = new Guns("HK416", 7, "xz", "Автомат");
            filter.gun_list[5] = new Guns("FAMAS", 7, "1990", "Автомат");
            filter.gun_list[6] = new Guns("scar", 5, "2004", "Автомат");
            filter.gun_list[7] = new Guns("M-16", 5, "xz", "Автомат");*/;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
       /* private void button3_Click(object sender, EventArgs e)
        {
            //button3.ForeColor = Color.Black;
            //button3.BackColor = Color.Red; 
            MessageBox.Show("НЕ ВЕРЬ"); 
        }*/
     }