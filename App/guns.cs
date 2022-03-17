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
    public partial class guns : Form
    {
        public guns(string c)
        {
            InitializeComponent();
            Text = c;
            if (c == "ak47")
            {
                pic.Load("../../../images/" + c + ".jpg");
                txt.Text = File.ReadAllText("../../../Text/" + c + ".txt");
                Text = "AK-47";
                txt1.Text = "AK-47";
            }
           if (c == "M-16")
            {
                pic.Load("../../../images/" + c + ".jpg");
                txt.Text = File.ReadAllText("../../../Text/" + c + ".txt");
                Text = "M16";
                txt1.Text = "M16";
            }
           if (c == "HK416")
            {
                pic.Load("../../../images/" + c + ".jpg");
                txt.Text = File.ReadAllText("../../../Text/" + c + ".txt");
                Text = "HK416";
                txt1.Text = "HK416";
            }
          if (c == "scar")
            {
                pic.Load("../../../images/" + c + ".jpg");
                txt.Text = File.ReadAllText("../../../Text/" + c + ".txt");
                Text = "Scar";
                txt1.Text = "Scar";
            }
          if (c == "FAMAS")
            {
                pic.Load("../../../images/" + c + ".jpg");
                txt.Text = File.ReadAllText("../../../Text/" + c + ".txt");
                Text = "FAMAS";
                txt1.Text = "FAMAS";
            }
         if (c == "Zastava")
            {
                pic.Load("../../../images/" + c + ".jpg");
                txt.Text = File.ReadAllText("../../../Text/" + c + ".txt");
                Text = "Застава M21";
                txt1.Text = "Застава M21";
            }
         if (c == "INSAS")
            {
                pic.Load("../../../images/" + c + ".jpg");
                txt.Text = File.ReadAllText("../../../Text/" + c + ".txt");
                Text = "INSAS";
                txt1.Text = "INSAS";
            }
         if (c == "ads")
            {
                pic.Load("../../../images/" + c + ".jpg");
                txt.Text = File.ReadAllText("../../../Text/" + c + ".txt");
                Text = "АДС";
                txt1.Text = "АДС";
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
