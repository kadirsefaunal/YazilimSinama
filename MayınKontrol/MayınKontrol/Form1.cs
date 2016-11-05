using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MayınKontrol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Button[,] butonlar;
        int en, boy;
        private void btnOlustur_Click(object sender, EventArgs e)
        {
            en = Convert.ToInt32(txtEn.Text);
            boy = Convert.ToInt32(txtBoy.Text);
            butonlar = new Button[en, boy];
            Button btn;

            for (int i = 0; i < en; i++)
            {
                for (int j = 0; j < boy; j++)
                {
                    btn = new Button();
                    btn.Name = "btn" + i + "_" + j;
                    btn.Width = 30;
                    btn.Height = 30;
                    btn.Top = 50 + (i * 30);
                    btn.Left = 10 + (j * 30);
                    btn.FlatStyle = FlatStyle.Flat;

                    if (i == 0 || j == 0 || i == (en - 1) || j == (boy - 1))
                    {
                        btn.BackColor = Color.Gray;
                        btn.Tag = 999;
                    }
                    else
                    {
                        btn.BackColor = Color.Red;
                        btn.Click += Btn_Click;
                        btn.Tag = 0;
                    }
                    butonlar[i, j] = btn;
                }
            }

            foreach (var item in butonlar)
            {
                Controls.Add(item);
            }
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            if (btnBasla.Text == "Başla")
            {
                butonlar[1, 1].BackColor = Color.White;
                butonlar[1, 1].Tag = Convert.ToInt32(butonlar[1, 1].Tag) + 1;
                timer.Start();
                btnBasla.Text = "Dur";
            }
            else
            {
                timer.Stop();
                btnBasla.Text = "Başla";
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            if (btn.BackColor == Color.Red)
            {
                btn.BackColor = Color.Gray;
                btn.Tag = 999;
            }
            else
            {
                btn.BackColor = Color.Red;
                btn.Tag = 0;
            }
        }

        int i = 1, j = 1;
        private void timer_Tick(object sender, EventArgs e)
        {
            butonlar[i, j].BackColor = Color.LightGreen;
            int yon = YonBul(i, j);
            switch (yon)
            {
                case 0:
                    j--;
                    butonlar[i, j].Tag = Convert.ToInt32(butonlar[i, j].Tag) + 1;
                    butonlar[i, j].BackColor = Color.White;
                    break;
                case 1:
                    i--;
                    butonlar[i, j].Tag = Convert.ToInt32(butonlar[i, j].Tag) + 1;
                    butonlar[i, j].BackColor = Color.White;
                    break;
                case 2:
                    i++;
                    butonlar[i, j].Tag = Convert.ToInt32(butonlar[i, j].Tag) + 1;
                    butonlar[i, j].BackColor = Color.White;
                    break;
                case 3:
                    j++;
                    butonlar[i, j].Tag = Convert.ToInt32(butonlar[i, j].Tag) + 1;
                    butonlar[i, j].BackColor = Color.White;
                    break;
                default:
                    timer.Stop();
                    break;
            }
            
        }

        //0 = sol
        //1 = ust
        //2 = alt
        //3 = sag
        bool[] yon;
        private int YonBul(int x, int y)
        {
            yon = new bool[4]{ false, false, false, false };
            int sol = Convert.ToInt32(butonlar[x, y - 1].Tag);
            int ust = Convert.ToInt32(butonlar[x - 1, y].Tag);
            int alt = Convert.ToInt32(butonlar[x + 1, y].Tag);
            int sag = Convert.ToInt32(butonlar[x, y + 1].Tag);

            if (sol != 999)
                yon[0] = true;
            if (ust != 999)
                yon[1] = true;
            if (alt != 999)
                yon[2] = true;
            if (sag != 999)
                yon[3] = true;

            if (yon[0] && sol <= sag && sol <= ust && sol <= alt)
                return 0;
            else if (yon[1] && ust <= alt && ust <= sag && ust <= sol)
                return 1;
            else if (yon[2] && alt <= ust && alt <= sol && alt <= sag)
                return 2;
            else if (yon[3] && sag <= sol && sag <= ust && sag <= alt)
                return 3;
            else
                return -1;
            
        }
    }
}
