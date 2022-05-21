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
    public partial class delete : Form
    {
        public delete()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = comboBox1.Text;
        }

        private void delete_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < filter.gun_list.Count; i++)
            {
                comboBox1.Items.Add(filter.gun_list[i].name);
            }
        }

        private void button1_Click(object sender, EventArgs e)//delete
        {
            System.IO.File.Delete("base_of_stuff.txt");
            for(int i = 0; i < filter.gun_list.Count; i++)
            {
                if (textBox1.Text == filter.gun_list[i].name)
                {

                }
                else {
                    System.IO.File.AppendAllText("base_of_stuff.txt", filter.gun_list[i].name + ", " +
                    filter.gun_list[i].cal + ", " + filter.gun_list[i].year + ", " + filter.gun_list[i].kind + ", "
                    + filter.gun_list[i].price + Environment.NewLine);
                }
            }
            MessageBox.Show("gg");
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
