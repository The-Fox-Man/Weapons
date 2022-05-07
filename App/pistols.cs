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
    public partial class pistols : Form
    {
        public static List<Guns> gun_list = new List<Guns>();

        public pistols()
        {
            InitializeComponent();
            Controls.Clear();
            int x = 0;
            int y = 30;
            for (int i = 0; i < gun_list.Count; i++)
            {
                if (gun_list[i].kind == "Пистолет")
                {
                    gun_list[i].lbl.Location = new Point(x + 80, y);
                    gun_list[i].lbl.Size = new Size(200, 39);
                    gun_list[i].lbl.BackColor = Color.Transparent;
                    Controls.Add(gun_list[i].lbl);

                    gun_list[i].pic.Location = new Point(x, y + 50);
                    gun_list[i].pic.Size = new Size(310, 165);
                    gun_list[i].pic.BackColor = Color.Transparent;
                    gun_list[i].pic.Click += new EventHandler(ok);
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
        public static void ok(object sender, EventArgs e)
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

        private void pistols_Load(object sender, EventArgs e)
        {

        }
    }
}
