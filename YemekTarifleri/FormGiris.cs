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
    public partial class FormGiris : Form
    {
        public FormGiris()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            // FormKategoriler sayfasından bir tane oluşturuyoruz
            FormKategoriler kategoriEkrani = new FormKategoriler();

            // Oluşturduğumuz sayfayı ekranda gösteriyoruz
            kategoriEkrani.Show();

            // Şu anki giriş ekranını gizliyoruz
            this.Hide();
        }
    }
}
