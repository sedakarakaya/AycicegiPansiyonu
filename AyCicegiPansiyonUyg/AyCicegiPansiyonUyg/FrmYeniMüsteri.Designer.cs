namespace AyCicegiPansiyonUyg
{
    partial class FrmYeniMüsteri
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.MskTxtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.DtpCikisTarihi = new System.Windows.Forms.DateTimePicker();
            this.DtpGirisTarihi = new System.Windows.Forms.DateTimePicker();
            this.TxtUcret = new System.Windows.Forms.TextBox();
            this.TxtOdaNo = new System.Windows.Forms.TextBox();
            this.TxtTcKimlikNo = new System.Windows.Forms.TextBox();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.TxtSoyadi = new System.Windows.Forms.TextBox();
            this.TxtAdi = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnOda107 = new System.Windows.Forms.Button();
            this.BtnOda108 = new System.Windows.Forms.Button();
            this.BtnOda109 = new System.Windows.Forms.Button();
            this.BtnOda104 = new System.Windows.Forms.Button();
            this.BtnOda105 = new System.Windows.Forms.Button();
            this.BtnOda106 = new System.Windows.Forms.Button();
            this.BtnOda103 = new System.Windows.Forms.Button();
            this.BtnOda102 = new System.Windows.Forms.Button();
            this.BtnOda101 = new System.Windows.Forms.Button();
            this.BtnDoluOda = new System.Windows.Forms.Button();
            this.BtnBosOda = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.BtnKaydet);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.MskTxtTelefon);
            this.groupBox1.Controls.Add(this.DtpCikisTarihi);
            this.groupBox1.Controls.Add(this.DtpGirisTarihi);
            this.groupBox1.Controls.Add(this.TxtUcret);
            this.groupBox1.Controls.Add(this.TxtOdaNo);
            this.groupBox1.Controls.Add(this.TxtTcKimlikNo);
            this.groupBox1.Controls.Add(this.TxtMail);
            this.groupBox1.Controls.Add(this.TxtSoyadi);
            this.groupBox1.Controls.Add(this.TxtAdi);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(533, 596);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Bilgileri";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(482, 456);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 20);
            this.label11.TabIndex = 22;
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKaydet.Location = new System.Drawing.Point(275, 529);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(145, 39);
            this.BtnKaydet.TabIndex = 21;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Bayan",
            "Bay"});
            this.comboBox1.Location = new System.Drawing.Point(227, 158);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(234, 30);
            this.comboBox1.TabIndex = 20;
            // 
            // MskTxtTelefon
            // 
            this.MskTxtTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskTxtTelefon.Location = new System.Drawing.Point(227, 204);
            this.MskTxtTelefon.Mask = "(999) 000-0000";
            this.MskTxtTelefon.Name = "MskTxtTelefon";
            this.MskTxtTelefon.Size = new System.Drawing.Size(234, 28);
            this.MskTxtTelefon.TabIndex = 19;
            // 
            // DtpCikisTarihi
            // 
            this.DtpCikisTarihi.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DtpCikisTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DtpCikisTarihi.Location = new System.Drawing.Point(227, 476);
            this.DtpCikisTarihi.Name = "DtpCikisTarihi";
            this.DtpCikisTarihi.Size = new System.Drawing.Size(234, 28);
            this.DtpCikisTarihi.TabIndex = 18;
            this.DtpCikisTarihi.ValueChanged += new System.EventHandler(this.DtpCikisTarihi_ValueChanged);
            // 
            // DtpGirisTarihi
            // 
            this.DtpGirisTarihi.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DtpGirisTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DtpGirisTarihi.Location = new System.Drawing.Point(227, 429);
            this.DtpGirisTarihi.Name = "DtpGirisTarihi";
            this.DtpGirisTarihi.Size = new System.Drawing.Size(234, 28);
            this.DtpGirisTarihi.TabIndex = 17;
            // 
            // TxtUcret
            // 
            this.TxtUcret.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtUcret.Location = new System.Drawing.Point(227, 376);
            this.TxtUcret.Name = "TxtUcret";
            this.TxtUcret.Size = new System.Drawing.Size(234, 28);
            this.TxtUcret.TabIndex = 16;
            // 
            // TxtOdaNo
            // 
            this.TxtOdaNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtOdaNo.Location = new System.Drawing.Point(227, 331);
            this.TxtOdaNo.Name = "TxtOdaNo";
            this.TxtOdaNo.Size = new System.Drawing.Size(234, 28);
            this.TxtOdaNo.TabIndex = 15;
            // 
            // TxtTcKimlikNo
            // 
            this.TxtTcKimlikNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtTcKimlikNo.Location = new System.Drawing.Point(227, 284);
            this.TxtTcKimlikNo.MaxLength = 11;
            this.TxtTcKimlikNo.Name = "TxtTcKimlikNo";
            this.TxtTcKimlikNo.Size = new System.Drawing.Size(234, 28);
            this.TxtTcKimlikNo.TabIndex = 14;
            // 
            // TxtMail
            // 
            this.TxtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtMail.Location = new System.Drawing.Point(227, 244);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(234, 28);
            this.TxtMail.TabIndex = 13;
            // 
            // TxtSoyadi
            // 
            this.TxtSoyadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSoyadi.Location = new System.Drawing.Point(227, 112);
            this.TxtSoyadi.Name = "TxtSoyadi";
            this.TxtSoyadi.Size = new System.Drawing.Size(234, 28);
            this.TxtSoyadi.TabIndex = 11;
            // 
            // TxtAdi
            // 
            this.TxtAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAdi.Location = new System.Drawing.Point(227, 66);
            this.TxtAdi.Name = "TxtAdi";
            this.TxtAdi.Size = new System.Drawing.Size(234, 28);
            this.TxtAdi.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(56, 470);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 29);
            this.label10.TabIndex = 9;
            this.label10.Text = "Çıkış Tarihi :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(63, 428);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 29);
            this.label9.TabIndex = 8;
            this.label9.Text = "Giriş Tarihi :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(120, 376);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 29);
            this.label8.TabIndex = 7;
            this.label8.Text = "Ücret :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(26, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = "Oda Numarası :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(26, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "T.C. Kimlik No :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(132, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mail :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(98, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefon :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(96, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cinsiyet :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(103, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyadı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(142, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnOda107);
            this.groupBox2.Controls.Add(this.BtnOda108);
            this.groupBox2.Controls.Add(this.BtnOda109);
            this.groupBox2.Controls.Add(this.BtnOda104);
            this.groupBox2.Controls.Add(this.BtnOda105);
            this.groupBox2.Controls.Add(this.BtnOda106);
            this.groupBox2.Controls.Add(this.BtnOda103);
            this.groupBox2.Controls.Add(this.BtnOda102);
            this.groupBox2.Controls.Add(this.BtnOda101);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(591, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(481, 457);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Odalar";
            // 
            // BtnOda107
            // 
            this.BtnOda107.BackColor = System.Drawing.Color.Green;
            this.BtnOda107.Location = new System.Drawing.Point(57, 309);
            this.BtnOda107.Name = "BtnOda107";
            this.BtnOda107.Size = new System.Drawing.Size(103, 69);
            this.BtnOda107.TabIndex = 8;
            this.BtnOda107.Text = "107";
            this.BtnOda107.UseVisualStyleBackColor = false;
            this.BtnOda107.Click += new System.EventHandler(this.BtnOda107_Click);
            // 
            // BtnOda108
            // 
            this.BtnOda108.BackColor = System.Drawing.Color.Green;
            this.BtnOda108.Location = new System.Drawing.Point(214, 309);
            this.BtnOda108.Name = "BtnOda108";
            this.BtnOda108.Size = new System.Drawing.Size(103, 69);
            this.BtnOda108.TabIndex = 7;
            this.BtnOda108.Text = "108";
            this.BtnOda108.UseVisualStyleBackColor = false;
            this.BtnOda108.Click += new System.EventHandler(this.BtnOda108_Click);
            // 
            // BtnOda109
            // 
            this.BtnOda109.BackColor = System.Drawing.Color.Green;
            this.BtnOda109.Location = new System.Drawing.Point(352, 309);
            this.BtnOda109.Name = "BtnOda109";
            this.BtnOda109.Size = new System.Drawing.Size(103, 69);
            this.BtnOda109.TabIndex = 6;
            this.BtnOda109.Text = "109";
            this.BtnOda109.UseVisualStyleBackColor = false;
            this.BtnOda109.Click += new System.EventHandler(this.BtnOda109_Click);
            // 
            // BtnOda104
            // 
            this.BtnOda104.BackColor = System.Drawing.Color.Green;
            this.BtnOda104.Location = new System.Drawing.Point(57, 182);
            this.BtnOda104.Name = "BtnOda104";
            this.BtnOda104.Size = new System.Drawing.Size(103, 69);
            this.BtnOda104.TabIndex = 5;
            this.BtnOda104.Text = "104";
            this.BtnOda104.UseVisualStyleBackColor = false;
            this.BtnOda104.Click += new System.EventHandler(this.BtnOda104_Click);
            // 
            // BtnOda105
            // 
            this.BtnOda105.BackColor = System.Drawing.Color.Green;
            this.BtnOda105.Location = new System.Drawing.Point(214, 176);
            this.BtnOda105.Name = "BtnOda105";
            this.BtnOda105.Size = new System.Drawing.Size(103, 69);
            this.BtnOda105.TabIndex = 4;
            this.BtnOda105.Text = "105";
            this.BtnOda105.UseVisualStyleBackColor = false;
            this.BtnOda105.Click += new System.EventHandler(this.BtnOda105_Click);
            // 
            // BtnOda106
            // 
            this.BtnOda106.BackColor = System.Drawing.Color.Green;
            this.BtnOda106.Location = new System.Drawing.Point(352, 182);
            this.BtnOda106.Name = "BtnOda106";
            this.BtnOda106.Size = new System.Drawing.Size(103, 69);
            this.BtnOda106.TabIndex = 3;
            this.BtnOda106.Text = "106";
            this.BtnOda106.UseVisualStyleBackColor = false;
            this.BtnOda106.Click += new System.EventHandler(this.BtnOda106_Click);
            // 
            // BtnOda103
            // 
            this.BtnOda103.BackColor = System.Drawing.Color.Green;
            this.BtnOda103.Location = new System.Drawing.Point(352, 72);
            this.BtnOda103.Name = "BtnOda103";
            this.BtnOda103.Size = new System.Drawing.Size(103, 69);
            this.BtnOda103.TabIndex = 2;
            this.BtnOda103.Text = "103";
            this.BtnOda103.UseVisualStyleBackColor = false;
            this.BtnOda103.Click += new System.EventHandler(this.BtnOda103_Click);
            // 
            // BtnOda102
            // 
            this.BtnOda102.BackColor = System.Drawing.Color.Green;
            this.BtnOda102.Location = new System.Drawing.Point(214, 72);
            this.BtnOda102.Name = "BtnOda102";
            this.BtnOda102.Size = new System.Drawing.Size(103, 69);
            this.BtnOda102.TabIndex = 1;
            this.BtnOda102.Text = "102";
            this.BtnOda102.UseVisualStyleBackColor = false;
            this.BtnOda102.Click += new System.EventHandler(this.BtnOda102_Click);
            // 
            // BtnOda101
            // 
            this.BtnOda101.BackColor = System.Drawing.Color.Green;
            this.BtnOda101.Location = new System.Drawing.Point(57, 72);
            this.BtnOda101.Name = "BtnOda101";
            this.BtnOda101.Size = new System.Drawing.Size(103, 69);
            this.BtnOda101.TabIndex = 0;
            this.BtnOda101.Text = "101";
            this.BtnOda101.UseVisualStyleBackColor = false;
            this.BtnOda101.Click += new System.EventHandler(this.BtnOda101_Click);
            // 
            // BtnDoluOda
            // 
            this.BtnDoluOda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnDoluOda.Location = new System.Drawing.Point(943, 509);
            this.BtnDoluOda.Name = "BtnDoluOda";
            this.BtnDoluOda.Size = new System.Drawing.Size(103, 65);
            this.BtnDoluOda.TabIndex = 3;
            this.BtnDoluOda.Text = "DOLU";
            this.BtnDoluOda.UseVisualStyleBackColor = false;
            this.BtnDoluOda.Click += new System.EventHandler(this.BtnDoluOda_Click);
            // 
            // BtnBosOda
            // 
            this.BtnBosOda.BackColor = System.Drawing.Color.Green;
            this.BtnBosOda.Location = new System.Drawing.Point(943, 580);
            this.BtnBosOda.Name = "BtnBosOda";
            this.BtnBosOda.Size = new System.Drawing.Size(103, 65);
            this.BtnBosOda.TabIndex = 4;
            this.BtnBosOda.Text = "BOŞ";
            this.BtnBosOda.UseVisualStyleBackColor = false;
            this.BtnBosOda.Click += new System.EventHandler(this.BtnBosOda_Click);
            // 
            // FrmYeniMüsteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(1130, 699);
            this.Controls.Add(this.BtnBosOda);
            this.Controls.Add(this.BtnDoluOda);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmYeniMüsteri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Müşteri Ekle";
            this.Load += new System.EventHandler(this.FrmYeniMüsteri_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MaskedTextBox MskTxtTelefon;
        private System.Windows.Forms.DateTimePicker DtpCikisTarihi;
        private System.Windows.Forms.DateTimePicker DtpGirisTarihi;
        private System.Windows.Forms.TextBox TxtUcret;
        private System.Windows.Forms.TextBox TxtOdaNo;
        private System.Windows.Forms.TextBox TxtTcKimlikNo;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.TextBox TxtSoyadi;
        private System.Windows.Forms.TextBox TxtAdi;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnOda107;
        private System.Windows.Forms.Button BtnOda108;
        private System.Windows.Forms.Button BtnOda109;
        private System.Windows.Forms.Button BtnOda104;
        private System.Windows.Forms.Button BtnOda105;
        private System.Windows.Forms.Button BtnOda106;
        private System.Windows.Forms.Button BtnOda103;
        private System.Windows.Forms.Button BtnOda102;
        private System.Windows.Forms.Button BtnOda101;
        private System.Windows.Forms.Button BtnDoluOda;
        private System.Windows.Forms.Button BtnBosOda;
        private System.Windows.Forms.Label label11;
    }
}

