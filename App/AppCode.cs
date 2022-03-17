using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
       /* private void button3_Click(object sender, EventArgs e)
        {
            //button3.ForeColor = Color.Black;
            //button3.BackColor = Color.Red; 
            MessageBox.Show("НЕ ВЕРЬ"); 
        }*/
     }