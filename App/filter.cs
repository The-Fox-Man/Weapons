using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;

namespace App
{
    public struct Guns
    {
        public string name;
        public double cal;
        public string year;
        public Label lbl;
        public PictureBox pic;
        public string kind;

        public Guns(string _name, double _cal, string _year, string _kind)
        {
            name = _name;
            cal = _cal;
            year = _year;
            lbl = new Label();
            pic = new PictureBox();
            kind = _kind;

            lbl.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));
            lbl.Text = name;
            pic.Tag = name;

            lbl.ForeColor = Color.White;

            pic.SizeMode = PictureBoxSizeMode.Zoom;
            pic.Load("../../../images/" + name + ".jpg");
        }
    }

    public partial class filter : Form
    {
      
       // public static Guns[] gun_list = new Guns[8];
        public static List<Guns> gun_list = new List<Guns>();
        public filter()
        {
            InitializeComponent();
            int x = 0;
            int y = 30;
            for (int i = 0; i < gun_list.Count; i++)
            {   
                gun_list[i].lbl.Location = new Point(x + 100, y);
                gun_list[i].lbl.Size = new Size(130, 39);
                pan.Controls.Add(gun_list[i].lbl);

                gun_list[i].pic.Location = new Point(x, y + 50); 
                gun_list[i].pic.Size = new Size(310, 165);
                gun_list[i].pic.Click += new EventHandler(okey);
                pan.Controls.Add(gun_list[i].pic);
                x = x + 310;

                if (x + 150 > Width)
                {
                    y = y + 230;
                    x = 10;
                }
             /*   if (gun_list[i].pic.Visible == false)
                {
                    x = x - 310;                              
                    y = y - 230;
                }*/
            }
        }
        private void filter_Load(object sender, EventArgs e)
        {

        }


        private void filtr_Click(object sender, EventArgs e)
        {
            int x = 0;
            int y = 30;
            for (int i = 0; i < gun_list.Count; i++)
            {

                gun_list[i].lbl.Visible = true;
                gun_list[i].pic.Visible = true;
                if (choice.Text != "" && choice.Text != "nothing" && gun_list[i].name != choice.Text)
                {
                     gun_list[i].lbl.Visible = false; 
                     gun_list[i].pic.Visible = false;
                }
                if (choiceCal.Text != "" && choiceCal.Text != "nothing" && gun_list[i].cal != Convert.ToInt32(choiceCal.Text))
                {
                    gun_list[i].lbl.Visible = false;
                    gun_list[i].pic.Visible = false;
                }
                if (choiceYear.Text != "" && choiceYear.Text != "nothing" && gun_list[i].year != choiceYear.Text)
                {
                    gun_list[i].lbl.Visible = false;
                    gun_list[i].pic.Visible = false;
                }
                if (gun_list[i].lbl.Visible)
                {
                    gun_list[i].lbl.Location = new System.Drawing.Point(x + 100, y);
                    gun_list[i].pic.Location = new System.Drawing.Point(x, y + 50);
                    x = x + 310;
                    if (x + 150 > Width)
                    {
                        y = y + 230;
                        x = 10;
                    }
                }
            }
        }
        public static void okey(object sender, EventArgs e)
        {
            /* PictureBox y = (PictureBox)sender;
             guns c = new guns((string)y.Tag);
             c.ShowDialog();
            */
            for (int i = 0; i < gun_list.Count; i++)
            {
                if (((PictureBox)sender).Name == gun_list[i].name || ((PictureBox)sender).Tag == gun_list[i].name)
                {
                    guns gun = new guns(gun_list[i]);
                    gun.ShowDialog();
                }
            }
        }
        private void choiceYear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}