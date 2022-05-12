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
            if (fileName != "" && name.Text != "" && calibr.Text != "" && yearB.Text != "" &&
                var.Text != "" && prsvar.Text != "" && describe.Text != "" && pi != null)
            {
            File.AppendAllText("base_of_stuff.txt", Environment.NewLine 
                + name.Text + ", " 
                + calibr.Text + ", "
                + yearB.Text + ", " 
                + var.Text + ", "
                + prsvar.Text);
            
                File.Copy(fileName, "../../../images/" + name.Text + ".jpg");
                File.AppendAllText("../../../Text/" + name.Text + ".txt", describe.Text);
                MessageBox.Show("Ваше оружие успешно добавлено.");
            }
            else { MessageBox.Show("Заполните все поля и вложите изображение! Не будте глупым.", "Программа"); }
         
        }
 
        string fileName = "";
        private void img_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog1.FileName;
                pi.Load(fileName);

            }

        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void describe_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void prsvar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
