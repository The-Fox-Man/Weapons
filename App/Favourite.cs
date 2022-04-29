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
        //public static List<Guns> selectedGuns = new List<Guns>();
        public static Dictionary<Guns, int> selectedGuns = new Dictionary<Guns, int>();
        public Favourite()
        {
            InitializeComponent();
            draw();
        }

        void draw()
        {
            Controls.Clear();
            int x = 0;
            int y = 30;
            // foreach (Guns gun in selectedGuns)
            foreach (KeyValuePair<Guns, int> choose_gun in selectedGuns)
            {
                Guns gun = choose_gun.Key;

                #region столб намбер ван
                Label pip = new Label();
                pip.ForeColor = Color.White;
                pip.BackColor = Color.Transparent;
                pip.Location = new Point(x + 100, y);
                pip.Font = new Font("Calibri", 24);
                pip.Size = new Size(130, 39);
                pip.Text = gun.name;
                Controls.Add(pip);

                #endregion
                PictureBox lilpip = new PictureBox();
                lilpip.Location = new Point(x, y + 50);
                lilpip.Size = new Size(310, 165);
                lilpip.SizeMode = PictureBoxSizeMode.Zoom;
                lilpip.Image = gun.pic.Image;
                Controls.Add(lilpip);

                Label op = new Label();
                op.Location = new Point(x + 500, y);
                op.Size = new Size(270, 39);
                op.ForeColor = Color.White;
                op.BackColor = Color.Transparent;
                op.Font = new Font("Calibri", 24);
                op.Text = "Год выпуска:" + gun.year;
                Controls.Add(op);

                Label ui = new Label();
                ui.Location = new Point(x + 500, y + 50);
                ui.ForeColor = Color.White;
                ui.BackColor = Color.Transparent;
                ui.Size = new Size(270, 39);
                ui.Font = new Font("Calibri", 24);
                ui.Text = "Калибр:" + gun.cal;
                Controls.Add(ui);

                Label uh = new Label();
                uh.Location = new Point(x + 500, y + 100);
                uh.ForeColor = Color.White;
                uh.BackColor = Color.Transparent;
                uh.Size = new Size(270, 39);
                uh.Font = new Font("Calibri", 24);
                uh.Text = "Вид:" + gun.kind;
                Controls.Add(uh);

                Label ua = new Label();
                ua.Location = new Point(x + 500, y + 150);
                ua.ForeColor = Color.White;
                ua.BackColor = Color.Transparent;
                ua.Size = new Size(270, 39);
                ua.Font = new Font("Calibri", 24);
                ua.Text = "Количество:" + choose_gun.Value.ToString();
                Controls.Add(ua);

             
                NumericUpDown sus = new NumericUpDown();
                sus.Location = new Point(x + 510, y + 200);
                sus.Size = new Size(100, 5);
                sus.Font = new Font("Calibri", 24);
                sus.Value = choose_gun.Value;
                sus.Click += new EventHandler(num);
                Controls.Add(sus);
                //общую цену в скобках умножение а потом перевод в стринги

                Button jojo = new Button();
                jojo.Location = new Point(x + 800, y);
                jojo.Size = new Size(110, 50);
                jojo.Font = new Font("Comic Sans MS", 15, FontStyle.Bold);
                jojo.Text = "Удалить";
                jojo.Click += new EventHandler(del);
                Controls.Add(jojo);

                y = y + 230;
            }

        }
        void del(object sender, EventArgs e)
        {

            int i = 0; 
            Button ass = new Button();
            ass = (Button)sender;
           // List<Guns> selectedGuns1 = new List<Guns>();
           Dictionary<Guns, int> selectedGuns1 = new Dictionary<Guns, int>();

            // foreach (Guns gun in selectedGuns)
            foreach (KeyValuePair<Guns, int> choose_gun in selectedGuns)
            {
                Guns gun = choose_gun.Key;
                if (ass.Location == new Point(800, 230 * i + 30 + AutoScrollPosition.Y))
                {

                }
                else
                {
                  // selectedGuns1.Add(gun);
                   selectedGuns1[choose_gun.Key] = choose_gun.Value;
                }
                i++;   
                    //  selectedGuns.Remove(gun);
            }
            selectedGuns = selectedGuns1;
          
           draw();
        }
        private void num(object sender, EventArgs e)
        {
            NumericUpDown na = (NumericUpDown)sender;

            for (int i = 0; i < selectedGuns.Count; i++)
            {
                int pris = 0;
                Image img = null;
              /*  Control pox = new Control();
                pox = Point.AutoScrollPosition();*/

                int y = 30;
                if(na.Location == new Point(510, 230 * i + 230 + AutoScrollPosition.Y))
                    {
                        foreach(Control ctr in Controls)
                            {
                                if (ctr is PictureBox && ctr.Location == new Point(0, 230 * i + 80 + AutoScrollPosition.Y))
                     {
                                    img = ((PictureBox)ctr).Image;
                                }     
                                                               
                            }
                        foreach(Guns gun in filter.gun_list)
                            {
                                if(gun.pic.Image == img)           
                                    {
                                      selectedGuns[gun] = (int)na.Value;
                                    }
                            }
                        foreach (Control ctr in Controls)
                            {
                            if (ctr is Label && ctr.Location == new Point(500, 230 * i + 180 + AutoScrollPosition.Y))
                                {
                                    ctr.Text = "Кол:" + na.Text;
                                    //pris = Convert.ToInt32(ctr.Text.Replace("Количество:", ""));
                                }

                            }
                    }
            }
        }
               /* foreach (Control ctr in Controls) танцы с бубнами для цены и общией цены
                {
                    if (ctr is Label && ctr.Location == new Point(510, 230))
                    {
                        ctr.Text = (col * na.Value).ToString();
                    }
                }*/
            
        
        private void Favourite_Load(object sender, EventArgs e)
        {

        }
    }
}
