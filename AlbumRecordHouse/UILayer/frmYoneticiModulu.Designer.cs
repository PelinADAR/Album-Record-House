namespace UILayer
{
    partial class frmYoneticiModulu
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnYeniKullaniciEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.rdbHayir = new System.Windows.Forms.RadioButton();
            this.rdbEvet = new System.Windows.Forms.RadioButton();
            this.lblSatisVarMi = new System.Windows.Forms.Label();
            this.dtpCikisTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblCikisTarihi = new System.Windows.Forms.Label();
            this.txtAlbumAdi = new System.Windows.Forms.TextBox();
            this.txtIndirimOrani = new System.Windows.Forms.TextBox();
            this.lblIndirimOrani = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.txtSanatciGrup = new System.Windows.Forms.TextBox();
            this.lblAlbumAdi = new System.Windows.Forms.Label();
            this.lblSanatciGrup = new System.Windows.Forms.Label();
            this.lblAlbumBilgileri = new System.Windows.Forms.Label();
            this.dgvAlbumler = new System.Windows.Forms.DataGridView();
            this.rdbIndirimdekiAlbumler = new System.Windows.Forms.RadioButton();
            this.rdbEklenenOnAlbum = new System.Windows.Forms.RadioButton();
            this.rdbSatisiDevamEdenAlbumler = new System.Windows.Forms.RadioButton();
            this.rdbSatisiDurmusAlbumler = new System.Windows.Forms.RadioButton();
            this.rdbTumAlbumler = new System.Windows.Forms.RadioButton();
            this.btnCikisYap = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbumler)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.groupBox2.Controls.Add(this.btnListele);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.btnCikisYap);
            this.groupBox2.Controls.Add(this.dgvAlbumler);
            this.groupBox2.Controls.Add(this.rdbIndirimdekiAlbumler);
            this.groupBox2.Controls.Add(this.rdbEklenenOnAlbum);
            this.groupBox2.Controls.Add(this.rdbSatisiDevamEdenAlbumler);
            this.groupBox2.Controls.Add(this.rdbSatisiDurmusAlbumler);
            this.groupBox2.Controls.Add(this.rdbTumAlbumler);
            this.groupBox2.Location = new System.Drawing.Point(24, 20);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1558, 638);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.btnListele.Location = new System.Drawing.Point(642, 86);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(237, 39);
            this.btnListele.TabIndex = 8;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.btnYeniKullaniciEkle);
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.rdbHayir);
            this.groupBox1.Controls.Add(this.rdbEvet);
            this.groupBox1.Controls.Add(this.lblSatisVarMi);
            this.groupBox1.Controls.Add(this.dtpCikisTarihi);
            this.groupBox1.Controls.Add(this.lblCikisTarihi);
            this.groupBox1.Controls.Add(this.txtAlbumAdi);
            this.groupBox1.Controls.Add(this.txtIndirimOrani);
            this.groupBox1.Controls.Add(this.lblIndirimOrani);
            this.groupBox1.Controls.Add(this.txtFiyat);
            this.groupBox1.Controls.Add(this.lblFiyat);
            this.groupBox1.Controls.Add(this.txtSanatciGrup);
            this.groupBox1.Controls.Add(this.lblAlbumAdi);
            this.groupBox1.Controls.Add(this.lblSanatciGrup);
            this.groupBox1.Controls.Add(this.lblAlbumBilgileri);
            this.groupBox1.Location = new System.Drawing.Point(1045, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 558);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.btnEkle.Location = new System.Drawing.Point(165, 366);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(323, 39);
            this.btnEkle.TabIndex = 8;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.btnSil.Location = new System.Drawing.Point(165, 411);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(323, 39);
            this.btnSil.TabIndex = 9;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnYeniKullaniciEkle
            // 
            this.btnYeniKullaniciEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.btnYeniKullaniciEkle.Location = new System.Drawing.Point(165, 501);
            this.btnYeniKullaniciEkle.Name = "btnYeniKullaniciEkle";
            this.btnYeniKullaniciEkle.Size = new System.Drawing.Size(323, 39);
            this.btnYeniKullaniciEkle.TabIndex = 11;
            this.btnYeniKullaniciEkle.Text = "Yeni Kullanıcı Ekle";
            this.btnYeniKullaniciEkle.UseVisualStyleBackColor = false;
            this.btnYeniKullaniciEkle.Click += new System.EventHandler(this.btnYeniKullaniciEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.btnGuncelle.Location = new System.Drawing.Point(165, 456);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(323, 39);
            this.btnGuncelle.TabIndex = 10;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // rdbHayir
            // 
            this.rdbHayir.AutoSize = true;
            this.rdbHayir.Location = new System.Drawing.Point(388, 317);
            this.rdbHayir.Name = "rdbHayir";
            this.rdbHayir.Size = new System.Drawing.Size(85, 34);
            this.rdbHayir.TabIndex = 7;
            this.rdbHayir.TabStop = true;
            this.rdbHayir.Text = "Hayır";
            this.rdbHayir.UseVisualStyleBackColor = true;
            // 
            // rdbEvet
            // 
            this.rdbEvet.AutoSize = true;
            this.rdbEvet.Location = new System.Drawing.Point(210, 317);
            this.rdbEvet.Name = "rdbEvet";
            this.rdbEvet.Size = new System.Drawing.Size(75, 34);
            this.rdbEvet.TabIndex = 6;
            this.rdbEvet.Text = "Evet";
            this.rdbEvet.UseVisualStyleBackColor = true;
            // 
            // lblSatisVarMi
            // 
            this.lblSatisVarMi.AutoSize = true;
            this.lblSatisVarMi.Location = new System.Drawing.Point(55, 319);
            this.lblSatisVarMi.Name = "lblSatisVarMi";
            this.lblSatisVarMi.Size = new System.Drawing.Size(111, 30);
            this.lblSatisVarMi.TabIndex = 18;
            this.lblSatisVarMi.Text = "Satışta Mı:";
            // 
            // dtpCikisTarihi
            // 
            this.dtpCikisTarihi.CalendarFont = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpCikisTarihi.CustomFormat = "dd  MMMM yyyy dddd";
            this.dtpCikisTarihi.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpCikisTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCikisTarihi.Location = new System.Drawing.Point(165, 177);
            this.dtpCikisTarihi.Name = "dtpCikisTarihi";
            this.dtpCikisTarihi.Size = new System.Drawing.Size(323, 38);
            this.dtpCikisTarihi.TabIndex = 3;
            // 
            // lblCikisTarihi
            // 
            this.lblCikisTarihi.AutoSize = true;
            this.lblCikisTarihi.Location = new System.Drawing.Point(47, 177);
            this.lblCikisTarihi.Name = "lblCikisTarihi";
            this.lblCikisTarihi.Size = new System.Drawing.Size(119, 30);
            this.lblCikisTarihi.TabIndex = 6;
            this.lblCikisTarihi.Text = "Çıkış Tarihi:";
            // 
            // txtAlbumAdi
            // 
            this.txtAlbumAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.txtAlbumAdi.Location = new System.Drawing.Point(165, 72);
            this.txtAlbumAdi.Name = "txtAlbumAdi";
            this.txtAlbumAdi.Size = new System.Drawing.Size(323, 36);
            this.txtAlbumAdi.TabIndex = 1;
            // 
            // txtIndirimOrani
            // 
            this.txtIndirimOrani.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.txtIndirimOrani.Location = new System.Drawing.Point(165, 275);
            this.txtIndirimOrani.Name = "txtIndirimOrani";
            this.txtIndirimOrani.Size = new System.Drawing.Size(323, 36);
            this.txtIndirimOrani.TabIndex = 5;
            // 
            // lblIndirimOrani
            // 
            this.lblIndirimOrani.AutoSize = true;
            this.lblIndirimOrani.Location = new System.Drawing.Point(21, 278);
            this.lblIndirimOrani.Name = "lblIndirimOrani";
            this.lblIndirimOrani.Size = new System.Drawing.Size(145, 30);
            this.lblIndirimOrani.TabIndex = 7;
            this.lblIndirimOrani.Text = "İndirim Oranı:";
            // 
            // txtFiyat
            // 
            this.txtFiyat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.txtFiyat.Location = new System.Drawing.Point(165, 226);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(323, 36);
            this.txtFiyat.TabIndex = 4;
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(103, 229);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(63, 30);
            this.lblFiyat.TabIndex = 7;
            this.lblFiyat.Text = "Fiyat:";
            // 
            // txtSanatciGrup
            // 
            this.txtSanatciGrup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.txtSanatciGrup.Location = new System.Drawing.Point(165, 123);
            this.txtSanatciGrup.Name = "txtSanatciGrup";
            this.txtSanatciGrup.Size = new System.Drawing.Size(323, 36);
            this.txtSanatciGrup.TabIndex = 2;
            // 
            // lblAlbumAdi
            // 
            this.lblAlbumAdi.AutoSize = true;
            this.lblAlbumAdi.Location = new System.Drawing.Point(47, 75);
            this.lblAlbumAdi.Name = "lblAlbumAdi";
            this.lblAlbumAdi.Size = new System.Drawing.Size(119, 30);
            this.lblAlbumAdi.TabIndex = 8;
            this.lblAlbumAdi.Text = "Albüm Adı:";
            // 
            // lblSanatciGrup
            // 
            this.lblSanatciGrup.AutoSize = true;
            this.lblSanatciGrup.Location = new System.Drawing.Point(28, 126);
            this.lblSanatciGrup.Name = "lblSanatciGrup";
            this.lblSanatciGrup.Size = new System.Drawing.Size(138, 30);
            this.lblSanatciGrup.TabIndex = 9;
            this.lblSanatciGrup.Text = "Sanatçı/Grup";
            // 
            // lblAlbumBilgileri
            // 
            this.lblAlbumBilgileri.AutoSize = true;
            this.lblAlbumBilgileri.Location = new System.Drawing.Point(165, 18);
            this.lblAlbumBilgileri.Name = "lblAlbumBilgileri";
            this.lblAlbumBilgileri.Size = new System.Drawing.Size(153, 30);
            this.lblAlbumBilgileri.TabIndex = 10;
            this.lblAlbumBilgileri.Text = "Albüm Bilgileri";
            // 
            // dgvAlbumler
            // 
            this.dgvAlbumler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAlbumler.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(175)))), ((int)(((byte)(192)))));
            this.dgvAlbumler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlbumler.Location = new System.Drawing.Point(20, 138);
            this.dgvAlbumler.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAlbumler.MultiSelect = false;
            this.dgvAlbumler.Name = "dgvAlbumler";
            this.dgvAlbumler.RowHeadersWidth = 51;
            this.dgvAlbumler.RowTemplate.Height = 29;
            this.dgvAlbumler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlbumler.Size = new System.Drawing.Size(1018, 435);
            this.dgvAlbumler.TabIndex = 1;
            this.dgvAlbumler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlbumler_CellClick);
            // 
            // rdbIndirimdekiAlbumler
            // 
            this.rdbIndirimdekiAlbumler.AutoSize = true;
            this.rdbIndirimdekiAlbumler.Location = new System.Drawing.Point(642, 36);
            this.rdbIndirimdekiAlbumler.Name = "rdbIndirimdekiAlbumler";
            this.rdbIndirimdekiAlbumler.Size = new System.Drawing.Size(237, 34);
            this.rdbIndirimdekiAlbumler.TabIndex = 6;
            this.rdbIndirimdekiAlbumler.Text = "İndirimdeki Albümler";
            this.rdbIndirimdekiAlbumler.UseVisualStyleBackColor = true;
            // 
            // rdbEklenenOnAlbum
            // 
            this.rdbEklenenOnAlbum.AutoSize = true;
            this.rdbEklenenOnAlbum.Location = new System.Drawing.Point(319, 36);
            this.rdbEklenenOnAlbum.Name = "rdbEklenenOnAlbum";
            this.rdbEklenenOnAlbum.Size = new System.Drawing.Size(251, 34);
            this.rdbEklenenOnAlbum.TabIndex = 6;
            this.rdbEklenenOnAlbum.Text = "Son Eklenen 10 Albüm";
            this.rdbEklenenOnAlbum.UseVisualStyleBackColor = true;
            // 
            // rdbSatisiDevamEdenAlbumler
            // 
            this.rdbSatisiDevamEdenAlbumler.AutoSize = true;
            this.rdbSatisiDevamEdenAlbumler.Location = new System.Drawing.Point(319, 86);
            this.rdbSatisiDevamEdenAlbumler.Name = "rdbSatisiDevamEdenAlbumler";
            this.rdbSatisiDevamEdenAlbumler.Size = new System.Drawing.Size(305, 34);
            this.rdbSatisiDevamEdenAlbumler.TabIndex = 6;
            this.rdbSatisiDevamEdenAlbumler.Text = "Satışı Devam Eden Albümler";
            this.rdbSatisiDevamEdenAlbumler.UseVisualStyleBackColor = true;
            // 
            // rdbSatisiDurmusAlbumler
            // 
            this.rdbSatisiDurmusAlbumler.AutoSize = true;
            this.rdbSatisiDurmusAlbumler.Location = new System.Drawing.Point(44, 86);
            this.rdbSatisiDurmusAlbumler.Name = "rdbSatisiDurmusAlbumler";
            this.rdbSatisiDurmusAlbumler.Size = new System.Drawing.Size(258, 34);
            this.rdbSatisiDurmusAlbumler.TabIndex = 6;
            this.rdbSatisiDurmusAlbumler.Text = "Satışı Durmuş Albümler";
            this.rdbSatisiDurmusAlbumler.UseVisualStyleBackColor = true;
            // 
            // rdbTumAlbumler
            // 
            this.rdbTumAlbumler.AutoSize = true;
            this.rdbTumAlbumler.Location = new System.Drawing.Point(44, 36);
            this.rdbTumAlbumler.Name = "rdbTumAlbumler";
            this.rdbTumAlbumler.Size = new System.Drawing.Size(171, 34);
            this.rdbTumAlbumler.TabIndex = 6;
            this.rdbTumAlbumler.Text = "Tüm Albümler";
            this.rdbTumAlbumler.UseVisualStyleBackColor = true;
            // 
            // btnCikisYap
            // 
            this.btnCikisYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.btnCikisYap.Location = new System.Drawing.Point(1210, 592);
            this.btnCikisYap.Name = "btnCikisYap";
            this.btnCikisYap.Size = new System.Drawing.Size(323, 39);
            this.btnCikisYap.TabIndex = 11;
            this.btnCikisYap.Text = "Çıkış Yap";
            this.btnCikisYap.UseVisualStyleBackColor = false;
            this.btnCikisYap.Click += new System.EventHandler(this.btnCikisYap_Click);
            // 
            // frmYoneticiModulu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(175)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1595, 665);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "frmYoneticiModulu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YÖNETİCİ MODÜLÜ";
            this.Load += new System.EventHandler(this.frmYoneticiModulu_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbumler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox groupBox2;
        private DataGridView dgvAlbumler;
        private GroupBox groupBox1;
        private Label lblCikisTarihi;
        private TextBox txtAlbumAdi;
        private TextBox txtFiyat;
        private Label lblFiyat;
        private TextBox txtSanatciGrup;
        private Label lblAlbumAdi;
        private Label lblSanatciGrup;
        private DateTimePicker dtpCikisTarihi;
        private Button btnEkle;
        private Button btnSil;
        private Button btnYeniKullaniciEkle;
        private Button btnGuncelle;
        private RadioButton rdbHayir;
        private RadioButton rdbEvet;
        private Label lblSatisVarMi;
        private TextBox txtIndirimOrani;
        private Label lblIndirimOrani;
        private Label lblAlbumBilgileri;
        private Button btnListele;
        private RadioButton rdbIndirimdekiAlbumler;
        private RadioButton rdbEklenenOnAlbum;
        private RadioButton rdbSatisiDevamEdenAlbumler;
        private RadioButton rdbSatisiDurmusAlbumler;
        private RadioButton rdbTumAlbumler;
        private Button btnCikisYap;
    }
}