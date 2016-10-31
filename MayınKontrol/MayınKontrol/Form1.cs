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
                        btn.BackColor = Color.Gray;
                    else
                        btn.Click += Btn_Click;
                    butonlar[i, j] = btn;
                }
            }

            foreach (var item in butonlar)
            {
                Controls.Add(item);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            MessageBox.Show("Test");
        }
    }
}
