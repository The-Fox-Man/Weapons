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
        public static int finalprs = 0;

        int m = 350;
        public static void calculating()
        {
            finalprs = 0;
            foreach(KeyValuePair<Guns, int> selected_Guns in selectedGuns)
            {
                finalprs += selected_Guns.Value * selected_Guns.Key.price;
            }
        }
        public Favourite()
        {
            InitializeComponent();
            draw();
        }

        void draw()
        {
            Controls.Clear();
            Controls.Add(lal);
            int x = 0;
            int y = 30;
            // foreach (Guns gun in selectedGuns)
            foreach (KeyValuePair<Guns, int> choose_gun in selectedGuns)
            {
                Guns gun = choose_gun.Key;
                #region splittteeeeeeeeeeeeeeeerrrrrrr!!!!
                Button s = new Button();
                s.Location = new Point(x + 0, y);
                s.Size = new Size(1000, 2);
                Controls.Add(s);
                #endregion

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
                #region 2
                PictureBox lilpip = new PictureBox();
                lilpip.Location = new Point(x, y + 50);
                lilpip.Size = new Size(310, 165);
                lilpip.BackColor = Color.Transparent;
                lilpip.SizeMode = PictureBoxSizeMode.Zoom;
                lilpip.Image = gun.pic.Image;
                Controls.Add(lilpip);
                #endregion
                #region 3
                Label op = new Label();
                op.Location = new Point(x + 500, y);
                op.Size = new Size(270, 39);
                op.ForeColor = Color.White;
                op.BackColor = Color.Transparent;
                op.Font = new Font("Calibri", 24);
                op.Text = "Год выпуска:" + gun.year;
                Controls.Add(op);
                #endregion
                #region 4
                Label ui = new Label();
                ui.Location = new Point(x + 500, y + 50);
                ui.ForeColor = Color.White;
                ui.BackColor = Color.Transparent;
                ui.Size = new Size(270, 39);
                ui.Font = new Font("Calibri", 24);
                ui.Text = "Калибр:" + gun.cal;
                Controls.Add(ui);
                #endregion
                #region 5
                Label uh = new Label();
                uh.Location = new Point(x + 500, y + 100);
                uh.ForeColor = Color.White;
                uh.BackColor = Color.Transparent;
                uh.Size = new Size(270, 39);
                uh.Font = new Font("Calibri", 24);
                uh.Text = "Вид:" + gun.kind;
                Controls.Add(uh);
                #endregion
                #region 6
                Label ua = new Label();
                ua.Location = new Point(x + 500, y + 150);
                ua.ForeColor = Color.White;
                ua.BackColor = Color.Transparent;
                ua.Size = new Size(270, 39);
                ua.Font = new Font("Calibri", 24);
                ua.Text = "Количество:" + choose_gun.Value.ToString();
                Controls.Add(ua);
                #endregion
                #region 7
                Label uhd = new Label();
                uhd.Location = new Point(x + 500, y + 250);
                uhd.ForeColor = Color.White;
                uhd.BackColor = Color.Transparent;
                uhd.Size = new Size(270, 39);
                uhd.Font = new Font("Calibri", 24);
                uhd.Text = "Цена:" + gun.price;
                Controls.Add(uhd);
                #endregion
                #region 8
                Label u = new Label();
                u.Location = new Point(x + 500, y + 300);
                u.ForeColor = Color.White;
                u.BackColor = Color.Transparent;
                u.Size = new Size(400, 39);
                u.Font = new Font("Calibri", 24);
                u.Text = "Итоговая цена:" + (gun.price * choose_gun.Value).ToString();
                Controls.Add(u);
                #endregion
                #region 9
                NumericUpDown sus = new NumericUpDown();
                sus.Location = new Point(x + 510, y + 200);
                sus.Size = new Size(100, 5);
                sus.Font = new Font("Calibri", 24);
                sus.Value = choose_gun.Value;
                sus.Click += new EventHandler(num);
                Controls.Add(sus);
                //общую цену в скобках умножение а потом перевод в стринги
                #endregion
                #region 10
                Button jojo = new Button();
                jojo.Location = new Point(x + 800, y);
                jojo.Size = new Size(110, 50);
                jojo.ForeColor = Color.White;
                jojo.Font = new Font("Comic Sans MS", 15, FontStyle.Bold);
                jojo.Text = "Удалить";
                jojo.BackgroundImage = new Bitmap("../../../images/bg.jpg");
                jojo.Click += new EventHandler(del);
                Controls.Add(jojo);
                #endregion

                y = y + m;
            }

            calculating();
            if (finalprs > 100000) { lal.Text = "Готовьтесь брать кредит, ваша итоговая цена избранного: " + finalprs.ToString(); }
            else { lal.Text = "Итоговая цена всего избраного: " + finalprs.ToString(); }
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
                if (ass.Location == new Point(800, 350 * i + 30 + AutoScrollPosition.Y))
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
                    Image img = null;
                /*  Control pox = new Control();
                  pox = Point.AutoScrollPosition();*/
                int pris = 0;
                int y = 30;
                if (na.Value == 10) { MessageBox.Show("Зачем Вам так много оружия? Вы хотите вооружить целую армию? Ладно, дело ваше.", "Программа"); }
                if (na.Location == new Point(510, m * i + 230 + AutoScrollPosition.Y))
                    {
                        foreach (Control ctr in Controls)
                        {
                            if (ctr is PictureBox && ctr.Location == new Point(0, m * i + 80 + AutoScrollPosition.Y))
                            {
                                img = ((PictureBox)ctr).Image;
                            }
                        }
                        foreach (Guns gun in filter.gun_list)
                        {
                            if (gun.pic.Image == img)
                            {

                            selectedGuns[gun] = (int)na.Value;
                            }
                        }
                        foreach (Control ctr in Controls)
                        {
                            if (ctr is Label && ctr.Location == new Point(500,  m * i + 180 + AutoScrollPosition.Y))
                            {
                                ctr.Text = "Количество:" + na.Text;
                            }
                        }
                        foreach (Control ctr in Controls)
                        {
                            if (ctr is Label && ctr.Location == new Point(500,  m * i + 280 + AutoScrollPosition.Y))
                            {
                                pris = Convert.ToInt32(ctr.Text.Replace("Цена:", ""));
                            }
                        }
                        foreach (Control ctr in Controls)
                        {
                            if (ctr is Label && ctr.Location == new Point(500, m * i + 330 + AutoScrollPosition.Y))
                            {
                                    ctr.Text = "Итоговая цена:" + (pris * na.Value).ToString();
                                    calculating();
                                    if (finalprs > 100000) { lal.Text = "Готовьтесь брать кредит, ваша итоговая цена избранного: "
                                        + finalprs.ToString();
                                    }
                                    else { lal.Text = "Итоговая цена всего избраного: " + finalprs.ToString(); }
                                //pris = Convert.ToInt32(ctr.Text.Replace("", ""));
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
