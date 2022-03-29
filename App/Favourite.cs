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
    public partial class Favourite : Form
    {
        public static List<Guns> selectedGuns = new List<Guns>();

        public Favourite()
        {
            InitializeComponent();

            int x = 0;
            int y = 30;
            foreach (Guns gun in selectedGuns)
            {
                gun.lbl.Location = new Point(x + 100, y);
                gun.lbl.Size = new Size(130, 39);
                Controls.Add(gun.lbl);

                gun.pic.Location = new Point(x, y + 50);
                gun.pic.Size = new Size(310, 165);
                Controls.Add(gun.pic);
                x = x + 310;

                if (x + 150 > Width)
                {
                    y = y + 230;
                    x = 10;
                }
            }
        }

        private void Favourite_Load(object sender, EventArgs e)
        {

        }
    }
}
