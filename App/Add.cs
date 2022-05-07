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
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }
      
        private void save_Click(object sender, EventArgs e)
        {
            File.AppendAllText("base_of_stuff.txt", Environment.NewLine 
                + name.Text + ", " 
                + calibr.Text + ", "
                + yearB.Text + ", " 
                + var.Text);
            if (fileName != "")
            {
                File.Copy(fileName, "../../../images/" + name.Text + ".jpg");
                File.AppendAllText("../../../Text/" + name.Text + ".txt", describe.Text);    
            }
         
        }
 
        string fileName = "";
        private void img_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog1.FileName;
                pictureBox1.Load(fileName);

            }

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void describe_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
