﻿
namespace HastaneRandevuOtomasyonProjesi
{
    partial class FrmSekreterDoktor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSekreterDoktor));
            this.PctKayıt = new System.Windows.Forms.PictureBox();
            this.PctTemizle = new System.Windows.Forms.PictureBox();
            this.LblCinsiyet = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.CmbBranş = new System.Windows.Forms.ComboBox();
            this.CmbHastane = new System.Windows.Forms.ComboBox();
            this.CmbIlce = new System.Windows.Forms.ComboBox();
            this.CmbIl = new System.Windows.Forms.ComboBox();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.MskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.MslTc = new System.Windows.Forms.MaskedTextBox();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PctKayıt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctTemizle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PctKayıt
            // 
            this.PctKayıt.BackColor = System.Drawing.Color.Red;
            this.PctKayıt.Image = ((System.Drawing.Image)(resources.GetObject("PctKayıt.Image")));
            this.PctKayıt.Location = new System.Drawing.Point(764, 2);
            this.PctKayıt.Name = "PctKayıt";
            this.PctKayıt.Size = new System.Drawing.Size(65, 48);
            this.PctKayıt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctKayıt.TabIndex = 53;
            this.PctKayıt.TabStop = false;
            this.PctKayıt.Click += new System.EventHandler(this.PctKayıt_Click);
            // 
            // PctTemizle
            // 
            this.PctTemizle.BackColor = System.Drawing.Color.Lime;
            this.PctTemizle.Image = ((System.Drawing.Image)(resources.GetObject("PctTemizle.Image")));
            this.PctTemizle.Location = new System.Drawing.Point(693, 2);
            this.PctTemizle.Name = "PctTemizle";
            this.PctTemizle.Size = new System.Drawing.Size(65, 48);
            this.PctTemizle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctTemizle.TabIndex = 52;
            this.PctTemizle.TabStop = false;
            this.PctTemizle.Click += new System.EventHandler(this.PctTemizle_Click);
            // 
            // LblCinsiyet
            // 
            this.LblCinsiyet.AutoSize = true;
            this.LblCinsiyet.Location = new System.Drawing.Point(467, 27);
            this.LblCinsiyet.Name = "LblCinsiyet";
            this.LblCinsiyet.Size = new System.Drawing.Size(41, 23);
            this.LblCinsiyet.TabIndex = 51;
            this.LblCinsiyet.Text = "Null";
            this.LblCinsiyet.Visible = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(691, 273);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(83, 27);
            this.radioButton2.TabIndex = 50;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "ERKEK";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(567, 273);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(83, 27);
            this.radioButton1.TabIndex = 49;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "KADIN";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(567, 308);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(292, 31);
            this.TxtSifre.TabIndex = 48;
            // 
            // CmbBranş
            // 
            this.CmbBranş.FormattingEnabled = true;
            this.CmbBranş.Location = new System.Drawing.Point(567, 234);
            this.CmbBranş.Name = "CmbBranş";
            this.CmbBranş.Size = new System.Drawing.Size(292, 31);
            this.CmbBranş.TabIndex = 47;
            // 
            // CmbHastane
            // 
            this.CmbHastane.FormattingEnabled = true;
            this.CmbHastane.Location = new System.Drawing.Point(567, 195);
            this.CmbHastane.Name = "CmbHastane";
            this.CmbHastane.Size = new System.Drawing.Size(292, 31);
            this.CmbHastane.TabIndex = 46;
            // 
            // CmbIlce
            // 
            this.CmbIlce.FormattingEnabled = true;
            this.CmbIlce.Location = new System.Drawing.Point(567, 156);
            this.CmbIlce.Name = "CmbIlce";
            this.CmbIlce.Size = new System.Drawing.Size(292, 31);
            this.CmbIlce.TabIndex = 45;
            this.CmbIlce.SelectedIndexChanged += new System.EventHandler(this.CmbIlce_SelectedIndexChanged);
            // 
            // CmbIl
            // 
            this.CmbIl.FormattingEnabled = true;
            this.CmbIl.Location = new System.Drawing.Point(567, 117);
            this.CmbIl.Name = "CmbIl";
            this.CmbIl.Size = new System.Drawing.Size(292, 31);
            this.CmbIl.TabIndex = 44;
            this.CmbIl.SelectedIndexChanged += new System.EventHandler(this.CmbIl_SelectedIndexChanged);
            // 
            // TxtMail
            // 
            this.TxtMail.Location = new System.Drawing.Point(158, 293);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(235, 31);
            this.TxtMail.TabIndex = 43;
            // 
            // MskTelefon
            // 
            this.MskTelefon.Location = new System.Drawing.Point(158, 250);
            this.MskTelefon.Mask = "(999) 000-0000";
            this.MskTelefon.Name = "MskTelefon";
            this.MskTelefon.Size = new System.Drawing.Size(235, 31);
            this.MskTelefon.TabIndex = 42;
            // 
            // MslTc
            // 
            this.MslTc.Location = new System.Drawing.Point(158, 207);
            this.MslTc.Mask = "00000000000";
            this.MslTc.Name = "MslTc";
            this.MslTc.Size = new System.Drawing.Size(235, 31);
            this.MslTc.TabIndex = 41;
            this.MslTc.ValidatingType = typeof(int);
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(158, 164);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(235, 31);
            this.TxtSoyad.TabIndex = 40;
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(158, 121);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(235, 31);
            this.TxtAd.TabIndex = 39;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(463, 312);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 23);
            this.label11.TabIndex = 38;
            this.label11.Text = "Şifre:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 297);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 23);
            this.label9.TabIndex = 37;
            this.label9.Text = "E Posta :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(463, 275);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 23);
            this.label10.TabIndex = 36;
            this.label10.Text = "Cinsiyet:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(463, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 23);
            this.label7.TabIndex = 35;
            this.label7.Text = "Branş:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(463, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 23);
            this.label8.TabIndex = 34;
            this.label8.Text = "Hastane:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(463, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 23);
            this.label5.TabIndex = 33;
            this.label5.Text = "İlce:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(463, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 23);
            this.label6.TabIndex = 32;
            this.label6.Text = "İl:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 23);
            this.label3.TabIndex = 31;
            this.label3.Text = "Telefon :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 23);
            this.label4.TabIndex = 30;
            this.label4.Text = "TC Kimlik No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 23);
            this.label2.TabIndex = 29;
            this.label2.Text = "SOYAD:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 23);
            this.label1.TabIndex = 28;
            this.label1.Text = "AD:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Corbel", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(89, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(341, 39);
            this.label12.TabIndex = 54;
            this.label12.Text = "DOKTOR KAYIT PANELİ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Red;
            this.pictureBox1.Image = global::HastaneRandevuOtomasyonProjesi.Properties.Resources.çıkış;
            this.pictureBox1.Location = new System.Drawing.Point(835, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmSekreterDoktor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 407);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.PctKayıt);
            this.Controls.Add(this.PctTemizle);
            this.Controls.Add(this.LblCinsiyet);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.CmbBranş);
            this.Controls.Add(this.CmbHastane);
            this.Controls.Add(this.CmbIlce);
            this.Controls.Add(this.CmbIl);
            this.Controls.Add(this.TxtMail);
            this.Controls.Add(this.MskTelefon);
            this.Controls.Add(this.MslTc);
            this.Controls.Add(this.TxtSoyad);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmSekreterDoktor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSekreterDoktor";
            this.Load += new System.EventHandler(this.FrmSekreterDoktor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PctKayıt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctTemizle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox PctKayıt;
        private System.Windows.Forms.PictureBox PctTemizle;
        private System.Windows.Forms.Label LblCinsiyet;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.ComboBox CmbBranş;
        private System.Windows.Forms.ComboBox CmbHastane;
        private System.Windows.Forms.ComboBox CmbIlce;
        private System.Windows.Forms.ComboBox CmbIl;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.MaskedTextBox MskTelefon;
        private System.Windows.Forms.MaskedTextBox MslTc;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}