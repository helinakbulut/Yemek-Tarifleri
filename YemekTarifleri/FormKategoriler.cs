using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YemekTarifleri
{
    public partial class FormKategoriler : Form
    {
        public FormKategoriler()
        {
            InitializeComponent();
        }

        private void btnCorbalar_Click(object sender, EventArgs e)
        {
            FormYemekListesi liste = new FormYemekListesi();
            liste.GelenKategori = "Çorbalar";
            liste.Show();
            this.Hide();
        }

        private void btnAnaYemekler_Click(object sender, EventArgs e)
        {
            FormYemekListesi liste = new FormYemekListesi();
            liste.GelenKategori = "Ana Yemekler";
            liste.Show();
            this.Hide();
        }

        private void btnMezeler_Click(object sender, EventArgs e)
        {
            FormYemekListesi liste = new FormYemekListesi();
            liste.GelenKategori = "Mezeler";
            liste.Show();
            this.Hide();
        }

        private void btnSalatalar_Click(object sender, EventArgs e)
        {
            FormYemekListesi liste = new FormYemekListesi();
            liste.GelenKategori = "Salatalar";
            liste.Show();
            this.Hide();
        }

        private void btnTatlilar_Click(object sender, EventArgs e)
        {
            FormYemekListesi liste = new FormYemekListesi();
            liste.GelenKategori = "Tatlılar";
            liste.Show();
            this.Hide();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            // 1. Giriş ekranını (FormGiris) yeniden oluşturuyoruz
            FormGiris girisEkrani = new FormGiris();

            // 2. Giriş ekranını kullanıcıya gösteriyoruz
            girisEkrani.Show();

            // 3. Şu an açık olan Kategoriler ekranını kapatıyoruz
            this.Close();
        }
    }
}
