using DataAccessLayer;
using EntityLayer;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UILayer
{
    public partial class frmYoneticiModulu : Form
    {
        public frmYoneticiModulu()
        {
            InitializeComponent();
        }

        YoneticiModuluContext con;
        AlbumBilgisi secilenAlbum;
        int secilenAlbumId;

        void AlbumleriGoster()
        {
            var albumler = con.AlbumBilgileri.Select(x => new
            {
                x.Id,
                x.AlbumAdi,
                x.SanatciveyaGrup,
                x.CikisTarihi,
                x.Fiyat,
                x.IndirimOrani,
                x.SatisiVarMi
            }).ToList();

            dgvAlbumler.DataSource = albumler;
            dgvAlbumler.Columns["Id"].Visible = false;
        }

        private void frmYoneticiModulu_Load(object sender, EventArgs e)
        {
            con = new YoneticiModuluContext();
            AlbumleriGoster();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            AlbumBilgisi yeniAlbum = new AlbumBilgisi();
            decimal fiyat = 0;
            int indirimOrani = 0;
            bool flag = false;
            if (dtpCikisTarihi.Value <= DateTime.Now && decimal.TryParse(txtFiyat.Text, out fiyat) && int.TryParse(txtIndirimOrani.Text, out indirimOrani) && indirimOrani <= 100 && (rdbEvet.Checked || rdbHayir.Checked))
            {
                var albumler = con.AlbumBilgileri.Where(x => x.AlbumAdi == txtAlbumAdi.Text).ToList();

                foreach (var item in albumler)
                {
                    if (item.SanatciveyaGrup == txtSanatciGrup.Text)
                    {
                        flag = true;
                        break;
                    }
                }

                if (!flag)
                {
                    yeniAlbum.AlbumAdi = txtAlbumAdi.Text;
                    yeniAlbum.SanatciveyaGrup = txtSanatciGrup.Text;
                    yeniAlbum.CikisTarihi = dtpCikisTarihi.Value;
                    yeniAlbum.IndirimOrani = indirimOrani;
                    yeniAlbum.Fiyat = fiyat;
                    yeniAlbum.SatisiVarMi = rdbEvet.Checked;
                    yeniAlbum.CreatedDate = DateTime.Now;
                    try
                    {
                        con.AlbumBilgileri.Add(yeniAlbum);
                        con.SaveChanges();
                        MessageBox.Show("Yeni Albüm Başarıyla eklendi.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }

                }
                else
                {
                    MessageBox.Show("Girilen sanatçının aynı isme sahip bir albümü bulunmaktadır. Lütfen farklı bir albümü giriniz.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                if (dtpCikisTarihi.Value > DateTime.Now)
                {
                    MessageBox.Show("Girilen tarih bugünün tarihinden büyük olamaz.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!decimal.TryParse(txtFiyat.Text, out fiyat))
                {
                    MessageBox.Show("Fiyat olarak pozitif sayılar girmelisiniz.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!int.TryParse(txtIndirimOrani.Text, out indirimOrani))
                {
                    MessageBox.Show("Indirim oranı pozitif sayı olamalıdır. (%25 için 25 yazınız.) (Max 100 yazılabilir.)", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!(rdbEvet.Checked || rdbHayir.Checked))
                {
                    MessageBox.Show("Satış var mı seçeneği için evet veya hayır işaretlenmelidir.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Bütün alanları dikkatlice doldurunuz.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            AlbumleriGoster();



        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (secilenAlbum != null)
            {
               DialogResult answer = MessageBox.Show("Seçilen albumü silmek istediğinize emin misiniz?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    try
                    {
                        con.AlbumBilgileri.Remove(secilenAlbum);
                        con.SaveChanges();
                        MessageBox.Show("Albüm listeden silindi.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                    

                }
                else
                {
                    MessageBox.Show("Silme işlemi iptal edildi.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Lütfen öncelikle bir albüm seçiniz.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            secilenAlbum = null;
            secilenAlbumId = 0;
            AlbumleriGoster();
        }

        private void dgvAlbumler_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            secilenAlbum = con.AlbumBilgileri.Find((int)dgvAlbumler.CurrentRow.Cells["Id"].Value);

            secilenAlbumId = secilenAlbum.Id;

            txtAlbumAdi.Text = secilenAlbum.AlbumAdi;
            txtSanatciGrup.Text = secilenAlbum.SanatciveyaGrup;
            dtpCikisTarihi.Value = secilenAlbum.CikisTarihi;
            txtFiyat.Text = secilenAlbum.Fiyat.ToString();
            txtIndirimOrani.Text = secilenAlbum.IndirimOrani.ToString();
            if (secilenAlbum.SatisiVarMi)
                rdbEvet.Checked = true;
            else 
                rdbEvet.Checked = true;

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (secilenAlbum != null)
            {
                decimal fiyat = 0;
                int indirimOrani = 0;
                bool flag = false;
                if (dtpCikisTarihi.Value <= DateTime.Now && decimal.TryParse(txtFiyat.Text, out fiyat) && int.TryParse(txtIndirimOrani.Text, out indirimOrani) && indirimOrani <= 100 && (rdbEvet.Checked || rdbHayir.Checked))
                {

                    secilenAlbum.AlbumAdi = txtAlbumAdi.Text;
                    secilenAlbum.SanatciveyaGrup = txtSanatciGrup.Text;
                    secilenAlbum.CikisTarihi = dtpCikisTarihi.Value;
                    secilenAlbum.IndirimOrani = indirimOrani;
                    secilenAlbum.Fiyat = fiyat;
                    secilenAlbum.SatisiVarMi = rdbEvet.Checked;
                    try
                    {
                        con.AlbumBilgileri.Update(secilenAlbum);
                        con.SaveChanges();
                        MessageBox.Show("Yeni Albüm Başarıyla güncellendi.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }

                }
                else
                {
                    if (dtpCikisTarihi.Value > DateTime.Now)
                    {
                        MessageBox.Show("Girilen tarih bugünün tarihinden büyük olamaz.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (!decimal.TryParse(txtFiyat.Text, out fiyat))
                    {
                        MessageBox.Show("Fiyat olarak pozitif sayılar girmelisiniz.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (!int.TryParse(txtIndirimOrani.Text, out indirimOrani))
                    {
                        MessageBox.Show("Indirim oranı pozitif sayı olamalıdır. (%25 için 25 yazınız.) (Max 100 yazılabilir.)", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (!(rdbEvet.Checked || rdbHayir.Checked))
                    {
                        MessageBox.Show("Satış var mı seçeneği için evet veya hayır işaretlenmelidir.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Bütün alanları dikkatlice doldurunuz.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen öncelikle bir albüm seçiniz.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            secilenAlbum = null;
            AlbumleriGoster();
        }

        private void btnYeniKullaniciEkle_Click(object sender, EventArgs e)
        {
            frmYenikullaniciEkle frm = new frmYenikullaniciEkle();
            frm.ShowDialog();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            if (rdbTumAlbumler.Checked)
            {
                AlbumleriGoster();
            }
            else if (rdbSatisiDurmusAlbumler.Checked)
            {
                var albumler = con.AlbumBilgileri.Where(x=>x.SatisiVarMi == false).Select(x => new
                {
                    x.Id,
                    x.AlbumAdi,
                    x.SanatciveyaGrup,
                    x.CikisTarihi,
                    x.Fiyat,
                    x.IndirimOrani,
                    x.SatisiVarMi
                }).ToList();

                dgvAlbumler.DataSource = albumler;
                dgvAlbumler.Columns["Id"].Visible = false;
                dgvAlbumler.Columns["CikisTarihi"].Visible = false;
                dgvAlbumler.Columns["Fiyat"].Visible = false;
                dgvAlbumler.Columns["IndirimOrani"].Visible = false;
                dgvAlbumler.Columns["SatisiVarMi"].Visible = false;              
            }
            else if (rdbSatisiDevamEdenAlbumler.Checked)
            {
                var albumler = con.AlbumBilgileri.Where(x => x.SatisiVarMi == true).Select(x => new
                {
                    x.Id,
                    x.AlbumAdi,
                    x.SanatciveyaGrup,
                    x.CikisTarihi,
                    x.Fiyat,
                    x.IndirimOrani,
                    x.SatisiVarMi
                }).ToList();

                dgvAlbumler.DataSource = albumler;
                dgvAlbumler.Columns["Id"].Visible = false;
                dgvAlbumler.Columns["CikisTarihi"].Visible = false;
                dgvAlbumler.Columns["Fiyat"].Visible = false;
                dgvAlbumler.Columns["IndirimOrani"].Visible = false;
                dgvAlbumler.Columns["SatisiVarMi"].Visible = false;
            }
            else if (rdbEklenenOnAlbum.Checked)
            {
                var albumler = con.AlbumBilgileri.OrderByDescending(x=>x.CreatedDate).Select(x => new
                {
                    x.Id,
                    x.AlbumAdi,
                    x.SanatciveyaGrup,
                    x.CikisTarihi,
                    x.Fiyat,
                    x.IndirimOrani,
                    x.SatisiVarMi
                }).Take(10).ToList();

                dgvAlbumler.DataSource = albumler;
                dgvAlbumler.Columns["Id"].Visible = false;
                dgvAlbumler.Columns["CikisTarihi"].Visible = false;
                dgvAlbumler.Columns["Fiyat"].Visible = false;
                dgvAlbumler.Columns["IndirimOrani"].Visible = false;
                dgvAlbumler.Columns["SatisiVarMi"].Visible = false;
            }
            else if (rdbIndirimdekiAlbumler.Checked)
            {
                var albumler = con.AlbumBilgileri.Where(x => x.IndirimOrani > 0).Select(x => new
                {
                    x.Id,
                    x.AlbumAdi,
                    x.SanatciveyaGrup,
                    x.CikisTarihi,
                    x.Fiyat,
                    x.IndirimOrani,
                    x.SatisiVarMi
                }).ToList();

                dgvAlbumler.DataSource = albumler;
                dgvAlbumler.Columns["Id"].Visible = false;
                dgvAlbumler.Columns["CikisTarihi"].Visible = false;
                dgvAlbumler.Columns["Fiyat"].Visible = false;
                dgvAlbumler.Columns["IndirimOrani"].Visible = false;
                dgvAlbumler.Columns["SatisiVarMi"].Visible = false;
            }
            else
            {
                MessageBox.Show("Lütfen bir listeleme metodu seçiniz.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Çıkış yapmak istediğinize emin misiniz?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (answer == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
