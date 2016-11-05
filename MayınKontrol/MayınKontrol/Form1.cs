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
                        btn.Tag = -1;
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
                btn.Tag = -1;
            }
            else
            {
                btn.BackColor = Color.Red;
                btn.Tag = 0;
            }
            MessageBox.Show(btn.Tag.ToString());
        }

        int i = 1, j = 1;
        private void timer_Tick(object sender, EventArgs e)
        {
            if (Convert.ToInt32(butonlar[i, j - 1].Tag) != -1 && Convert.ToInt32(butonlar[i, j - 1].Tag) == 0)
            {
                j--;
                butonlar[i, j].Tag = 1;
                butonlar[i, j].BackColor = Color.White;
            }
            else if (Convert.ToInt32(butonlar[i - 1, j].Tag) != -1 && Convert.ToInt32(butonlar[i - 1, j].Tag) == 0)
            {
                i--;
                butonlar[i, j].Tag = 1;
                butonlar[i, j].BackColor = Color.White;
            }
            else if (Convert.ToInt32(butonlar[i + 1, j].Tag) != -1 && Convert.ToInt32(butonlar[i + 1, j].Tag) == 0)
            {
                i++;
                butonlar[i, j].Tag = 1;
                butonlar[i, j].BackColor = Color.White;
            }
            else if (Convert.ToInt32(butonlar[i, j + 1].Tag) != -1 && Convert.ToInt32(butonlar[i, j + 1].Tag) == 0)
            {
                j++;
                butonlar[i, j].Tag = 1;
                butonlar[i, j].BackColor = Color.White;
            }
        }

        private int YonBul(int x, int y)
        {
            bool sol = false, sag = false, alt = false, ust = false;
            if (Convert.ToInt32(butonlar[x - 1, y].Tag) == -1)
                sol = true;
            if (Convert.ToInt32(butonlar[x, y - 1].Tag) == -1)
                ust = true;
            if (Convert.ToInt32(butonlar[x + 1, y].Tag) == -1)
                alt = true;
            if (Convert.ToInt32(butonlar[x, y + 1].Tag) == -1)
                sag = true;

            if (!alt)
                return 0;
            else
                return 1;
        }
    }
}
