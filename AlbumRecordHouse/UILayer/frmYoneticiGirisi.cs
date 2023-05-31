using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using DataAccessLayer;
using System.Security.Cryptography;

namespace UILayer
{
    public partial class frmYoneticiGirisi : Form
    {
        public frmYoneticiGirisi()
        {
            InitializeComponent();
        }

        YoneticiModuluContext con;

        private void frmYoneticiGirisi_Load(object sender, EventArgs e)
        {
            con = new YoneticiModuluContext();
        }
        private void btnGiris_Click(object sender, EventArgs e)
        {
            YoneticiGirisBilgisi? user = con.YoneticiGirisBilgileri.Where(x => x.KullaniciAdi == txtKullaniciAdi.Text).FirstOrDefault();

            if(user != null)
            {
                if(user.Sifre == sha256_hash(txtSifre.Text))
                {
                    frmYoneticiModulu frm = new frmYoneticiModulu();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Girilen şifre yanlış. Lütfen tekrar deneyiniz.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Bu Kullanıcı adına sahip bir kullanıcı bulunmamaktadır.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
