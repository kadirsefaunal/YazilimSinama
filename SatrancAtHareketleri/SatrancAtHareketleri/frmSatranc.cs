using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SatrancAtHareketleri
{
    public partial class frmSatranc : Form
    {
        public frmSatranc()
        {
            InitializeComponent();
        }

        //Daha önce geçmediyse tag = 0
        //Daha önce geçtiyse tag = 1
        //Klavuz noktalar ise tag = 2
        Button[,] butonlar;
        int en, boy;
        private void btnOlustur_Click(object sender, EventArgs e)
        {
            en = Convert.ToInt32(txtEn.Text);
            boy = Convert.ToInt32(txtBoy.Text);

            butonlar = new Button[boy, en];
            Button btn;

            for (int i = 0; i < boy; i++)
            {
                for (int j = 0; j < en; j++)
                {
                    btn = new Button();
                    btn.Name = "btn" + i + "_" + j;
                    btn.Width = 30;
                    btn.Height = 30;
                    btn.Top = 70 + (i * 30);
                    btn.Left = 13 + (j * 30);
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.Tag = 0;
                    btn.Click += Btn_Click1;
                    butonlar[i, j] = btn;
                }
            }

            foreach (var item in butonlar)
            {
                Controls.Add(item);
            }
        }

        private void Btn_Click1(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            MessageBox.Show(btn.Name);
        }
    }
}
