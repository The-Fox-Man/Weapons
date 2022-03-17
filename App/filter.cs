using System;
using System.Windows.Forms;

namespace App
{
    public struct Guns
    {
        public string name;
        public double cal;
        public string year;
        public Label lbl;
        public PictureBox pic;

        public Guns(string _name, double _cal, string _year)
        {
            name = _name;
            cal = _cal;
            year = _year;
            lbl = new Label();
            pic = new PictureBox();

            lbl.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            lbl.Text = name;

            pic.SizeMode = PictureBoxSizeMode.Zoom;
            pic.Load("../../../images/" + name + ".jpg");
        }
    }

    public partial class filter : Form
    {

        Guns[] gun_list = new Guns[8];
        public filter()
        {
            InitializeComponent();

            gun_list[0] = new Guns("INSAS", 7, "1987");
            gun_list[1] = new Guns("ads", 5, "2007");
            gun_list[2] = new Guns("Zastava", 7, "2004");
            gun_list[3] = new Guns("ak47", 5, "1966");
            gun_list[4] = new Guns("HK416", 7, "xz");
            gun_list[5] = new Guns("FAMAS", 7, "1990");
            gun_list[6] = new Guns("scar", 5, "2004");
            gun_list[7] = new Guns("M-16", 5, "xz");

            int x = 0;
            int y = 30;
            for (int i = 0; i < gun_list.Length; i++)
            {   
                gun_list[i].lbl.Location = new System.Drawing.Point(x + 100, y);
                gun_list[i].lbl.Size = new System.Drawing.Size(130, 39);
                pan.Controls.Add(gun_list[i].lbl);

                gun_list[i].pic.Location = new System.Drawing.Point(x, y + 50); 
                gun_list[i].pic.Size = new System.Drawing.Size(310, 165);
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
            for (int i = 0; i < gun_list.Length; i++)
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
        private void okey(object sender, EventArgs e)
        {
                PictureBox y = (PictureBox)sender;
                guns c = new guns(y.Tag);
                c.ShowDialog();
        }
        private void choiceYear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}