using DataAccessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UILayer
{
    public partial class frmYenikullaniciEkle : Form
    {
        public frmYenikullaniciEkle()
        {
            InitializeComponent();
        }

        YoneticiModuluContext con;
        private void frmYenikullaniciEkle_Load(object sender, EventArgs e)
        {
            con = new YoneticiModuluContext();
            lblUyari.Visible = false;

        }

        private void btnYeniYoneticiOlustur_Click(object sender, EventArgs e)
        {
            YoneticiGirisBilgisi? yeniYonetici = con.YoneticiGirisBilgileri.Where(x => x.KullaniciAdi == txtKullaniciAdi.Text).FirstOrDefault();
            if (yeniYonetici == null)
            {
                if (txtKullaniciAdi.Text.Length <= 64)
                {
                    bool sifreUygunMu = SifreKontrol(txtSifre.Text);
                    if (sifreUygunMu)
                    {
                        if (txtSifre.Text == txtSifreTekrar.Text)
                        {
                            yeniYonetici = new YoneticiGirisBilgisi();
                            yeniYonetici.KullaniciAdi = txtKullaniciAdi.Text;
                            yeniYonetici.Sifre = sha256_hash(txtSifre.Text);
                            yeniYonetici.CreatedDate = DateTime.Now;
                            try
                            {
                                con.YoneticiGirisBilgileri.Add(yeniYonetici);
                                con.SaveChanges();
                                MessageBox.Show("Yeni yönetici başarıyla oluşturuldu.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }

                        }
                        else
                        {
                            MessageBox.Show("Şifreler birbiriyle uyuşmamaktadır.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Kullanıcı adı 64 karakterden uzun olamaz.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Mevcut kullanıcı adına sahip bir yönetici vardır. Lütfen yeni bir kullanıcı adı ile tekrar deneyiniz.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public bool SifreKontrol(string sifre)
        {
            Regex buyukHarfKontrolu = new Regex(@".*[A-Z].*[A-Z].*");
            Regex kucukharfKontrolu = new Regex(@".*[a-z].*[a-z].*[a-z].*");
            Regex sembolKontrolu = new Regex(@".*[!:+*]+.*[!:+*]+.*");
            bool sonuc;

            if (sifre.Length >= 8)
            {
                if (buyukHarfKontrolu.IsMatch(sifre))
                {
                    if (kucukharfKontrolu.IsMatch(sifre))
                    {
                        if (sembolKontrolu.IsMatch(sifre))
                        {
                            sonuc = true;
                        }

                        else
                        {
                            sonuc = false;
                            MessageBox.Show("Şifre içinde ! (ünlem), : (iki nokta üst üste), + (artı), * (yıldız) karakterlerinden en az 2 tanesi olmalıdır.\n(Aynı karakterden birden fazla olabilir)");
                        }
                    }

                    else
                    {
                        sonuc = false;
                        MessageBox.Show("Şifre içinde en az 3 küçük harf olmalıdır.");
                    }
                }

                else
                {
                    MessageBox.Show("En az 2 büyük harf içermelidir.");
                    sonuc = false;
                }
            }

            else
            {
                MessageBox.Show("Şifre en az 8 karakterli olmalıdır.");
                sonuc = false;
            }

            return sonuc;
        }


        private void txtSifreTekrar_TextChanged(object sender, EventArgs e)
        {
            if (txtSifre.Text != txtSifreTekrar.Text)
            {
                lblUyari.Visible = true;
            }
            else
            {
                lblUyari.Visible = false;
            }
        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
            //if (!ParolaUygunMu())
            //{
            //    lblParolaUyari.Visible = true;
            //}
            //else
            //{
            //    lblParolaUyari.Visible = false;
            //}
        }

        private string sha256_hash(string sifre)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(l => l.ToString("X2")));
            }
        }
    }
}
