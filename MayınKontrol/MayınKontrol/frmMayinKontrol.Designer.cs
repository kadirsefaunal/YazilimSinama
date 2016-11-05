namespace MayınKontrol
{
    partial class frmMayinKontrol
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnOlustur = new System.Windows.Forms.Button();
            this.btnBasla = new System.Windows.Forms.Button();
            this.lblEn = new System.Windows.Forms.Label();
            this.lblBoy = new System.Windows.Forms.Label();
            this.txtEn = new System.Windows.Forms.TextBox();
            this.txtBoy = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOlustur
            // 
            this.btnOlustur.Location = new System.Drawing.Point(207, 19);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(75, 23);
            this.btnOlustur.TabIndex = 0;
            this.btnOlustur.Text = "Oluştur";
            this.btnOlustur.UseVisualStyleBackColor = true;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // btnBasla
            // 
            this.btnBasla.Enabled = false;
            this.btnBasla.Location = new System.Drawing.Point(288, 19);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(75, 23);
            this.btnBasla.TabIndex = 1;
            this.btnBasla.Text = "Başla";
            this.btnBasla.UseVisualStyleBackColor = true;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // lblEn
            // 
            this.lblEn.AutoSize = true;
            this.lblEn.Location = new System.Drawing.Point(12, 24);
            this.lblEn.Name = "lblEn";
            this.lblEn.Size = new System.Drawing.Size(26, 13);
            this.lblEn.TabIndex = 2;
            this.lblEn.Text = "En: ";
            // 
            // lblBoy
            // 
            this.lblBoy.AutoSize = true;
            this.lblBoy.Location = new System.Drawing.Point(100, 24);
            this.lblBoy.Name = "lblBoy";
            this.lblBoy.Size = new System.Drawing.Size(31, 13);
            this.lblBoy.TabIndex = 3;
            this.lblBoy.Text = "Boy: ";
            // 
            // txtEn
            // 
            this.txtEn.Location = new System.Drawing.Point(44, 21);
            this.txtEn.Name = "txtEn";
            this.txtEn.Size = new System.Drawing.Size(42, 20);
            this.txtEn.TabIndex = 4;
            // 
            // txtBoy
            // 
            this.txtBoy.Location = new System.Drawing.Point(137, 22);
            this.txtBoy.Name = "txtBoy";
            this.txtBoy.Size = new System.Drawing.Size(42, 20);
            this.txtBoy.TabIndex = 5;
            // 
            // timer
            // 
            this.timer.Interval = 50;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOlustur);
            this.groupBox1.Controls.Add(this.txtBoy);
            this.groupBox1.Controls.Add(this.btnBasla);
            this.groupBox1.Controls.Add(this.txtEn);
            this.groupBox1.Controls.Add(this.lblEn);
            this.groupBox1.Controls.Add(this.lblBoy);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 54);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "En ve Boyu Girin";
            // 
            // frmMayinKontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 420);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmMayinKontrol";
            this.Text = "Mayın Kontrol";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOlustur;
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Label lblEn;
        private System.Windows.Forms.Label lblBoy;
        private System.Windows.Forms.TextBox txtEn;
        private System.Windows.Forms.TextBox txtBoy;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

