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
        Guns gun;
        public guns(Guns _gun)
        {
            InitializeComponent();
            gun = _gun;
            Text = gun.name;

            pic.Load("../../../images/" + gun.name + ".jpg");
            txt.Text = File.ReadAllText("../../../Text/" + gun.name + ".txt");
            Text = gun.name;
            txt1.Text = gun.name;
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

        private void button1_Click(object sender, EventArgs e)
        {
            // Favourite.selectedGuns.Add(gun);
            if (Favourite.selectedGuns.ContainsKey(gun))
            {
                Favourite.selectedGuns[gun]++;
            }
            else
                Favourite.selectedGuns.Add(gun, 1);
        }

        private void back_Click(object sender, EventArgs e)
        {
            Close();
        }

        //  System.Diagnostics.Process.Start(guns.web); web добавить в структуру стринг и в массиве ссылку а также сделать кнопку "ссылка на веб сите" и на ёё клик в ней эту строкуЫ
    }
}
