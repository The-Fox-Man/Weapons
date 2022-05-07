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
            pistols g = new pistols();
            g.ShowDialog();
            g.ForeColor = Color.Red;
        }
        private void button2_Click(object sender, EventArgs e)
        {

            Button da = (Button)sender;
           // da.ForeColor = Color.Red;
            Foque f = new Foque();
            f.ShowDialog();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            button3.ForeColor = Color.Red;
            MessageBox.Show("НИЧЕГО НЕТ"); 

        }
        private void button4_Click(object sender, EventArgs e)
        {
            filter filt = new filter();
            filt.ShowDialog();
            filt.ForeColor = Color.Red;
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
            hi.ForeColor = Color.Red;
        }

        private void AppCode_Load(object sender, EventArgs e)
        {
            filter.gun_list.Clear();
            Foque.gun_list.Clear();
            pistols.gun_list.Clear();

            string[] line = File.ReadAllLines("base_of_stuff.txt");

            foreach (string stroke in line)
            {
                string[] quarter = stroke.Split(new string[] {", "}, StringSplitOptions.None);
                Guns gune = new Guns(quarter[0], (quarter[1]), quarter[2], quarter[3]);//quarter[4]);
                filter.gun_list.Add(gune);
                Foque.gun_list.Add(gune);
                pistols.gun_list.Add(gune);

            }

            /*filter.gun_list[0] = new Guns("INSAS", 7, "1987", "Автомат", vhere ssilka na site);
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

        

        private void button6_Click(object sender, EventArgs e)
        {
             Add weap = new Add();
             weap.ForeColor = Color.Red;
             weap.ShowDialog();
             AppCode_Load(sender, e);
             
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }


        //      

        /*  private void menu_Click(object sender, EventArgs e)
          {
              Add weap = new Add();
              weap.ShowDialog();
          }*/
    }
       /* private void button3_Click(object sender, EventArgs e)
        {
            //button3.ForeColor = Color.Black;
            //button3.BackColor = Color.Red; 
            MessageBox.Show("НЕ ВЕРЬ"); 
        }*/
     }