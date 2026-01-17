namespace YemekTarifleri
{
    partial class FormYemekListesi
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
            this.btnGeri = new System.Windows.Forms.Button();
            this.cmbYemekler = new System.Windows.Forms.ComboBox();
            this.lblKategoriBaslik = new System.Windows.Forms.Label();
            this.rtbMalzemeler = new System.Windows.Forms.RichTextBox();
            this.rtbTarif = new System.Windows.Forms.RichTextBox();
            this.pbYemekResmi = new System.Windows.Forms.PictureBox();
            this.btnVideoAc = new System.Windows.Forms.Button();
            this.btnFavoriEkle = new System.Windows.Forms.Button();
            this.btnFavorileriGor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbYemekResmi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.Bisque;
            this.btnGeri.Font = new System.Drawing.Font("Microsoft YaHei", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnGeri.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGeri.Location = new System.Drawing.Point(27, 27);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(135, 41);
            this.btnGeri.TabIndex = 7;
            this.btnGeri.Text = "GERİ DÖN";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // cmbYemekler
            // 
            this.cmbYemekler.FormattingEnabled = true;
            this.cmbYemekler.Location = new System.Drawing.Point(101, 164);
            this.cmbYemekler.Name = "cmbYemekler";
            this.cmbYemekler.Size = new System.Drawing.Size(333, 33);
            this.cmbYemekler.TabIndex = 8;
            this.cmbYemekler.SelectedIndexChanged += new System.EventHandler(this.cmbYemekler_SelectedIndexChanged);
            // 
            // lblKategoriBaslik
            // 
            this.lblKategoriBaslik.AutoSize = true;
            this.lblKategoriBaslik.Location = new System.Drawing.Point(172, 120);
            this.lblKategoriBaslik.Name = "lblKategoriBaslik";
            this.lblKategoriBaslik.Size = new System.Drawing.Size(160, 25);
            this.lblKategoriBaslik.TabIndex = 9;
            this.lblKategoriBaslik.Text = "KATEGORİLER";
            // 
            // rtbMalzemeler
            // 
            this.rtbMalzemeler.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.rtbMalzemeler.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.85F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rtbMalzemeler.Location = new System.Drawing.Point(101, 431);
            this.rtbMalzemeler.Name = "rtbMalzemeler";
            this.rtbMalzemeler.Size = new System.Drawing.Size(333, 335);
            this.rtbMalzemeler.TabIndex = 10;
            this.rtbMalzemeler.Text = "MALZEMELER";
            // 
            // rtbTarif
            // 
            this.rtbTarif.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbTarif.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.rtbTarif.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.85F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rtbTarif.Location = new System.Drawing.Point(589, 295);
            this.rtbTarif.Name = "rtbTarif";
            this.rtbTarif.Size = new System.Drawing.Size(534, 471);
            this.rtbTarif.TabIndex = 12;
            this.rtbTarif.Text = "TARİF";
            // 
            // pbYemekResmi
            // 
            this.pbYemekResmi.Location = new System.Drawing.Point(101, 239);
            this.pbYemekResmi.Name = "pbYemekResmi";
            this.pbYemekResmi.Size = new System.Drawing.Size(333, 173);
            this.pbYemekResmi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbYemekResmi.TabIndex = 14;
            this.pbYemekResmi.TabStop = false;
            // 
            // btnVideoAc
            // 
            this.btnVideoAc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnVideoAc.Location = new System.Drawing.Point(589, 81);
            this.btnVideoAc.Name = "btnVideoAc";
            this.btnVideoAc.Size = new System.Drawing.Size(324, 144);
            this.btnVideoAc.TabIndex = 15;
            this.btnVideoAc.Text = "Tarif Videosu İzle";
            this.btnVideoAc.UseVisualStyleBackColor = false;
            this.btnVideoAc.Click += new System.EventHandler(this.btnVideoAc_Click);
            // 
            // btnFavoriEkle
            // 
            this.btnFavoriEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnFavoriEkle.Location = new System.Drawing.Point(931, 81);
            this.btnFavoriEkle.Name = "btnFavoriEkle";
            this.btnFavoriEkle.Size = new System.Drawing.Size(192, 54);
            this.btnFavoriEkle.TabIndex = 16;
            this.btnFavoriEkle.Text = "Favorilere Ekle";
            this.btnFavoriEkle.UseVisualStyleBackColor = false;
            this.btnFavoriEkle.Click += new System.EventHandler(this.btnFavoriEkle_Click);
            // 
            // btnFavorileriGor
            // 
            this.btnFavorileriGor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnFavorileriGor.Location = new System.Drawing.Point(931, 177);
            this.btnFavorileriGor.Name = "btnFavorileriGor";
            this.btnFavorileriGor.Size = new System.Drawing.Size(192, 48);
            this.btnFavorileriGor.TabIndex = 17;
            this.btnFavorileriGor.Text = "Favorilerim";
            this.btnFavorileriGor.UseVisualStyleBackColor = false;
            this.btnFavorileriGor.Click += new System.EventHandler(this.btnFavorileriGor_Click);
            // 
            // FormYemekListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1227, 821);
            this.Controls.Add(this.btnFavorileriGor);
            this.Controls.Add(this.btnFavoriEkle);
            this.Controls.Add(this.btnVideoAc);
            this.Controls.Add(this.pbYemekResmi);
            this.Controls.Add(this.rtbTarif);
            this.Controls.Add(this.rtbMalzemeler);
            this.Controls.Add(this.lblKategoriBaslik);
            this.Controls.Add(this.cmbYemekler);
            this.Controls.Add(this.btnGeri);
            this.Name = "FormYemekListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormYemekListesi";
            this.Load += new System.EventHandler(this.FormYemekListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbYemekResmi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.ComboBox cmbYemekler;
        private System.Windows.Forms.Label lblKategoriBaslik;
        private System.Windows.Forms.RichTextBox rtbMalzemeler;
        private System.Windows.Forms.RichTextBox rtbTarif;
        private System.Windows.Forms.PictureBox pbYemekResmi;
        private System.Windows.Forms.Button btnVideoAc;
        private System.Windows.Forms.Button btnFavoriEkle;
        private System.Windows.Forms.Button btnFavorileriGor;
    }
}