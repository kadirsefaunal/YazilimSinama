namespace MayınKontrol
{
    partial class Form1
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
            this.btnOlustur = new System.Windows.Forms.Button();
            this.btnBasla = new System.Windows.Forms.Button();
            this.lblEn = new System.Windows.Forms.Label();
            this.lblBoy = new System.Windows.Forms.Label();
            this.txtEn = new System.Windows.Forms.TextBox();
            this.txtBoy = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOlustur
            // 
            this.btnOlustur.Location = new System.Drawing.Point(210, 12);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(75, 23);
            this.btnOlustur.TabIndex = 0;
            this.btnOlustur.Text = "Oluştur";
            this.btnOlustur.UseVisualStyleBackColor = true;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // btnBasla
            // 
            this.btnBasla.Location = new System.Drawing.Point(291, 12);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(75, 23);
            this.btnBasla.TabIndex = 1;
            this.btnBasla.Text = "Başla";
            this.btnBasla.UseVisualStyleBackColor = true;
            // 
            // lblEn
            // 
            this.lblEn.AutoSize = true;
            this.lblEn.Location = new System.Drawing.Point(15, 17);
            this.lblEn.Name = "lblEn";
            this.lblEn.Size = new System.Drawing.Size(26, 13);
            this.lblEn.TabIndex = 2;
            this.lblEn.Text = "En: ";
            // 
            // lblBoy
            // 
            this.lblBoy.AutoSize = true;
            this.lblBoy.Location = new System.Drawing.Point(113, 17);
            this.lblBoy.Name = "lblBoy";
            this.lblBoy.Size = new System.Drawing.Size(31, 13);
            this.lblBoy.TabIndex = 3;
            this.lblBoy.Text = "Boy: ";
            // 
            // txtEn
            // 
            this.txtEn.Location = new System.Drawing.Point(47, 14);
            this.txtEn.Name = "txtEn";
            this.txtEn.Size = new System.Drawing.Size(42, 20);
            this.txtEn.TabIndex = 4;
            // 
            // txtBoy
            // 
            this.txtBoy.Location = new System.Drawing.Point(150, 14);
            this.txtBoy.Name = "txtBoy";
            this.txtBoy.Size = new System.Drawing.Size(42, 20);
            this.txtBoy.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 420);
            this.Controls.Add(this.txtBoy);
            this.Controls.Add(this.txtEn);
            this.Controls.Add(this.lblBoy);
            this.Controls.Add(this.lblEn);
            this.Controls.Add(this.btnBasla);
            this.Controls.Add(this.btnOlustur);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOlustur;
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Label lblEn;
        private System.Windows.Forms.Label lblBoy;
        private System.Windows.Forms.TextBox txtEn;
        private System.Windows.Forms.TextBox txtBoy;
    }
}

