using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace YolBulma
{
    public partial class Form1 : Form
    {
        static int NesilSayisi;
        int NesilSayisiTespiti;
        int BireySayisi;
        int ElitSayisi;
        int MutasyonSayisi;
        int MutasyonOranı;
        int GenSayisi;
        int ilkNokta, SonNokta;
        int EnKucuk;
        int EnKucukindex;
        int BulunanFarkliCozumSayisi;
        Random Sayi = new Random();
        //int CizilecekResim, CizilecekResim1, CizilecekResim2;
        Bitmap bitmap;
        int eskix, eskiy;
        int[,] NoktaKoordinatlari = new int[25, 2];
        int[,] NoktalariCiz;
        int[,] ilkToplum;
        int[,] ilkToplumPozisyonu;
        int[] ilkToplumBireyUygunlugu;
        int[,] YeniToplum;
        int[,] YeniToplumPozisyonu;
        int[] YeniToplumBireyUygunlugu;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox2.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
        }
     
        //private void btnBilgi_Click(object sender, EventArgs e)
        //{
        //    if (btnBilgi.Text == "Kampüsteki Yerler Hakkında Bilgi ->>")
        //    {
        //        btnBilgi.Text = " Yer Bilgilerini Gizle <<-";
        //        this.Width = 1113;
        //    }
        //    else
        //    {
        //        btnBilgi.Text = "Kampüsteki Yerler Hakkında Bilgi ->>";
        //        this.Width = 909;
        //    }
        //}
        private void button1_Click(object sender, EventArgs e)
        {
            if (btnGA.Text == "Program Hakkında Bilgi ve Parametreler")
            {
                btnGA.Text = " Bilgi ve Parametreleri Gizle ";

                this.Height =  661;
            }
            else
            {
                btnGA.Text = "Program Hakkında Bilgi ve Parametreler";

                this.Height = 514;
            }
        }
        private void BtnBasla_Click(object sender, EventArgs e)
        {
            KrokiKampus.Image = new Bitmap(KrokiKampus.Width, KrokiKampus.Height);
            if (comboBox2.SelectedIndex == 0 || comboBox4.SelectedIndex == 0)
            {
                MessageBox.Show("Bulunduğunuz veya Gitmek istenilen Yer Seçilmedi.");
            }
            else if (comboBox4.SelectedIndex == comboBox2.SelectedIndex && comboBox2.SelectedIndex != 0)
            {
                MessageBox.Show("Bulunduğunuz ve Gitmek istenilen Yer Aynı Olamaz.");
            }
            else
            {

                try
                {
                    NesilSayisi = Convert.ToInt32(txtNesil.Text);
                    BireySayisi = Convert.ToInt32(txtBirey.Text);
                }
                catch
                {
                    MessageBox.Show("Girilen Değerler Geçerli Değil.Rakam Giriniz.");
                    return;
                }

                if (NesilSayisi <= 1 || BireySayisi <= 1)
                {
                    MessageBox.Show("Girilen Değerler Geçerli Değil.Değer '1' dan Büyük Olmalıdır.");
                    return;
                }
                //BAZI DEGERLER BURADA SABITLENIP YONETILEBILIR..
                MutasyonSayisi = 1; //mutasyon oranını buradan duzenlenebılır..
                MutasyonOranı = 1;//burada mutasyona ugrayacak gen sayısı belırlenebılır..
                ElitSayisi = (BireySayisi / 10);//en iyiler secılırken gerıye kalanlar ÇAPRAZLAMA ORANINI OLDUGU ICIN BU PARAMETREDE ONEMLI
                GenSayisi = 20; //gen sayısnı sabıtlendı..
                NesilSayisiTespiti = NesilSayisi;//ılk nesıl olup olmadıgını anlamızı saglayacak degerdır.
                ilkNokta = comboBox2.SelectedIndex;
                SonNokta = comboBox4.SelectedIndex;
                EnKucuk = 100000;
                EnKucukindex = 0;
                BulunanFarkliCozumSayisi = 1;
                eskix = -1;
                eskiy = -1;
                ilkToplum = new int[BireySayisi + 1, GenSayisi + 1];
                ilkToplumPozisyonu = new int[BireySayisi + 1, GenSayisi + 1];
                ilkToplumBireyUygunlugu = new int[BireySayisi + 1];
                YeniToplum = new int[BireySayisi + 1, GenSayisi + 1];
                YeniToplumPozisyonu = new int[BireySayisi + 1, GenSayisi + 1];
                YeniToplumBireyUygunlugu = new int[BireySayisi + 1];
                NoktalariCiz = new int[100, GenSayisi + 1];
                lblb.Visible = true;
                lwb.Visible = true;
                btnResimCiz.Visible = true;
                AyniKatRotaBul();

            }

        }

        public void AyniKatRotaBul()
        {
            lwb.Items.Clear();
            String rotaEski = "";
            BulunanFarkliCozumSayisi = 1;
            while (NesilSayisi != 0)
            {
                String rotayaz = ilkNokta.ToString();
                RotaGonder();
                YeniToplumPozisyonu[1, 0] = ilkNokta;
                    for (int b = 1; b <= GenSayisi; b++)
                    {

                        if (YeniToplumPozisyonu[1, b] != YeniToplumPozisyonu[1, b - 1])
                        {
                            rotayaz = rotayaz + "-" + YeniToplumPozisyonu[1, b].ToString();
                        }
                    }
                    if (!rotaEski.Equals(rotayaz))
                    {
                        for (int a = 1; a <= GenSayisi; a++)
                        {
                            NoktalariCiz[BulunanFarkliCozumSayisi, 0] = ilkNokta;
                            NoktalariCiz[BulunanFarkliCozumSayisi, a] = YeniToplumPozisyonu[1, a];
                        }
                        lwb.Items.Add(BulunanFarkliCozumSayisi + "-) " + YeniToplumBireyUygunlugu[1]);
                        lwb.Items[BulunanFarkliCozumSayisi - 1].SubItems.Add(rotayaz);
                        BulunanFarkliCozumSayisi++;
                    }
                    rotaEski = rotayaz;
                NesilSayisi--;
            }

            CizilecekRotayiBelirle(BulunanFarkliCozumSayisi-1);// en ıyı sonucu yazdırması ıcın..

        }
        public void CizilecekRotayiBelirle(int SecilenRota)
        {
            KrokiKampus.Image = new Bitmap(KrokiKampus.Width, KrokiKampus.Height);
            eskix = -1;
            eskiy = -1;
            for (int b = 0; b <= GenSayisi; b++)
            {
                ResimCizdir(NoktaKoordinatlari[NoktalariCiz[SecilenRota, b], 0], NoktaKoordinatlari[NoktalariCiz[SecilenRota, b], 1]);//secılen rotanın ılk noktasının x ve y sını cızdırmek ıcın baska fonksıyoa gonderıyoruz..
            }

        }
        private void btnResimCiz_Click(object sender, EventArgs e)
        {
            try
            {
                int Seciliindex;
                ListViewItem Secilen = lwb.SelectedItems[0];
                Seciliindex = Secilen.Index;
                CizilecekRotayiBelirle(Seciliindex + 1);
                //  MessageBox.Show("secili index: " + Seciliindex);

            }
            catch
            {
                MessageBox.Show("Mesafe Seçili Değil Listedeki Mesafelerden Birini Seçip Tıklayın");
            }

        }
        public void RotaGonder()
        {
            NoktaKoordinatlariYerlestir();
            ToplumOlustur();
            ToplumUygunluk();
            ToplumSeckincilik();
            ToplumCaprazlama();
            ToplumMutasyon();
            YeniToplumUygunluk();

        }
        public void ToplumOlustur()
        {
            if (NesilSayisi == NesilSayisiTespiti)//ilk nesıl oldugunu anlarım
            {
                for (int i = 1; i <= BireySayisi; i++)
                {
                    for (int j = 1; j <= GenSayisi; j++)
                    {

                        ilkToplum[i, j] = Sayi.Next(0, 4);
                    }
                }
            }
        }
        public void ToplumUygunluk()
        {
            int Degisenilk, SonPozisyon;
            for (int i = 1; i <= BireySayisi; i++)
            {
                ilkToplumBireyUygunlugu[i] = 0;
                Degisenilk = ilkNokta;
                for (int j = 1; j <= GenSayisi; j++)
                {
                    if (Degisenilk == SonNokta)
                    {
                        ilkToplumPozisyonu[i, j] = SonNokta;
                    }
                    else
                    {
                        ilkToplumPozisyonu[i, j] = BireyinBirSonrakiNoktasi(Degisenilk, ilkToplum[i, j]);
                    }
                    //for (int jk = 1; jk < j; jk++)
                    //{
                    //    if ((ilkToplumPozisyonu[i, j] == ilkToplumPozisyonu[i, jk]))
                    //    {
                    //        ilkToplumPozisyonu[i, j] = Degisenilk;
                    //    }
                    //}

                    ilkToplumBireyUygunlugu[i] = ilkToplumBireyUygunlugu[i] + BireyinNoktadanNoktayaMesafesi(Degisenilk, ilkToplumPozisyonu[i, j]);
                    Degisenilk = ilkToplumPozisyonu[i, j];
                    if (j == GenSayisi)
                    {
                        SonPozisyon = BireyinNoktadanNoktayaMesafesi(ilkToplumPozisyonu[i, j], SonNokta);
                        ilkToplumBireyUygunlugu[i] = 5 * SonPozisyon + ilkToplumBireyUygunlugu[i];
                    }
                }
            }
        }
        public int BireyinBirSonrakiNoktasi(int gilkNokta, int gYon)
        {
            int sonuc;

            if (gYon == 0 && !(gilkNokta == 1 || gilkNokta == 2 || gilkNokta == 3 || gilkNokta == 4))
            {
                sonuc = gilkNokta - 4;
            }
            else if (gYon == 1 && !(gilkNokta == 1 || gilkNokta == 5 || gilkNokta == 9 || gilkNokta == 13 || gilkNokta == 17 || gilkNokta == 21))
            {
                sonuc = gilkNokta - 1;
            }
            else if (gYon == 2 && !(gilkNokta == 21 || gilkNokta == 22 || gilkNokta == 23 || gilkNokta == 24))
            {
                sonuc = gilkNokta + 4;
            }
            else if (gYon == 3 && !(gilkNokta == 4 || gilkNokta == 8 || gilkNokta == 12 || gilkNokta == 16 || gilkNokta == 20 || gilkNokta == 24))
            {
                sonuc = gilkNokta + 1;
            }
            else
            {
                sonuc = gilkNokta;
            }

            return sonuc;

        }
        public int BireyinNoktadanNoktayaMesafesi(int gilkNokta, int gikinciNokta)
        {
            double islem;
            if (gilkNokta != gikinciNokta)
            {
                islem = Math.Pow(NoktaKoordinatlari[gilkNokta, 0] - NoktaKoordinatlari[gikinciNokta, 0], 2) + Math.Pow(NoktaKoordinatlari[gilkNokta, 1] - NoktaKoordinatlari[gikinciNokta, 1], 2);
                islem = Convert.ToInt32(Math.Sqrt(islem));
            }
            else
            {
                islem = 0;
            }
            return (int)islem;
        }

        public void ToplumSeckincilik()
        {
            for (int a = 1; a <= BireySayisi; a++)
            {
                EnKucuk = 100000;
                EnKucukindex = 0;
                int gecici = 0, gecici2 = 0;
                for (int b = a; b <= BireySayisi; b++)
                {
                    if (ilkToplumBireyUygunlugu[b] < (EnKucuk))
                    {
                        EnKucuk = ilkToplumBireyUygunlugu[b];
                        EnKucukindex = b;
                    }
                }
                gecici = ilkToplumBireyUygunlugu[a];
                ilkToplumBireyUygunlugu[a] = ilkToplumBireyUygunlugu[EnKucukindex];
                ilkToplumBireyUygunlugu[EnKucukindex] = gecici;
                for (int c = 1; c <= GenSayisi; c++)
                {
                    gecici2 = ilkToplum[a, c];
                    ilkToplum[a, c] = ilkToplum[EnKucukindex, c];
                    ilkToplum[EnKucukindex, c] = gecici2;
                }
            }
            for (int index = 1; index <= ElitSayisi; index++)
            {
                for (int bb = 1; bb <= GenSayisi; bb++)
                {
                    YeniToplum[index, bb] = ilkToplum[index, bb];
                }
            }

        }
        public void ToplumCaprazlama()
        {

            //int geciciDeger = 0;
            //for (int s = 3; s < BireySayisi; s = s + 2)
            //{
            //    for (int b = 11; b < 21; b++)
            //    {
            //        geciciDeger = YeniToplum[s, b];
            //        YeniToplum[s, b] = YeniToplum[s + 1, b];
            //        YeniToplum[s + 1, b] = geciciDeger;
            //    }

            //}
            int WhileDongusu = ElitSayisi + 1;
            int rastgeleBirey, rastgeleBirey2, rastgeleBirey3, rastgeleBirey4, lopus;
            while (WhileDongusu <= BireySayisi)
            {
                if (WhileDongusu == BireySayisi)
                {
                    WhileDongusu--;
                }
                rastgeleBirey = Sayi.Next(1, BireySayisi);
                rastgeleBirey2 = Sayi.Next(1, BireySayisi);
                rastgeleBirey3 = Sayi.Next(1, BireySayisi);
                rastgeleBirey4 = Sayi.Next(1, BireySayisi);
                lopus = Sayi.Next(2, GenSayisi - 1);
                if (rastgeleBirey < rastgeleBirey2)
                {

                    if (rastgeleBirey3 < rastgeleBirey4)
                    {
                        for (int b = 1; b < lopus; b++)
                        {
                            YeniToplum[WhileDongusu, b] = ilkToplum[rastgeleBirey, b];
                            YeniToplum[WhileDongusu + 1, b] = ilkToplum[rastgeleBirey3, b];
                        }
                        for (int b = (lopus); b <= GenSayisi; b++)
                        {
                            YeniToplum[WhileDongusu, b] = ilkToplum[rastgeleBirey3, b];
                            YeniToplum[WhileDongusu + 1, b] = ilkToplum[rastgeleBirey, b];
                        }

                    }
                    else
                    {
                        for (int b = 1; b < lopus; b++)
                        {
                            YeniToplum[WhileDongusu, b] = ilkToplum[rastgeleBirey, b];
                            YeniToplum[WhileDongusu + 1, b] = ilkToplum[rastgeleBirey4, b];
                        }
                        for (int b = (lopus); b <= GenSayisi; b++)
                        {
                            YeniToplum[WhileDongusu, b] = ilkToplum[rastgeleBirey4, b];
                            YeniToplum[WhileDongusu + 1, b] = ilkToplum[rastgeleBirey, b];
                        }

                    }

                }
                else
                {
                    if (rastgeleBirey3 < rastgeleBirey4)
                    {
                        for (int b = 1; b < lopus; b++)
                        {
                            YeniToplum[WhileDongusu, b] = ilkToplum[rastgeleBirey2, b];
                            YeniToplum[WhileDongusu + 1, b] = ilkToplum[rastgeleBirey3, b];
                        }
                        for (int b = (lopus); b <= GenSayisi; b++)
                        {
                            YeniToplum[WhileDongusu, b] = ilkToplum[rastgeleBirey3, b];
                            YeniToplum[WhileDongusu + 1, b] = ilkToplum[rastgeleBirey2, b];
                        }
                    }
                    else
                    {
                        for (int b = 1; b < lopus; b++)
                        {
                            YeniToplum[WhileDongusu, b] = ilkToplum[rastgeleBirey2, b];
                            YeniToplum[WhileDongusu + 1, b] = ilkToplum[rastgeleBirey4, b];
                        }
                        for (int b = (lopus); b <= GenSayisi; b++)
                        {
                            YeniToplum[WhileDongusu, b] = ilkToplum[rastgeleBirey4, b];
                            YeniToplum[WhileDongusu + 1, b] = ilkToplum[rastgeleBirey2, b];
                        }
                    }
                }

                WhileDongusu = WhileDongusu + 2;
            }

        }

        public void ToplumMutasyon()
        {
            while (MutasyonSayisi != 0)
            {
                int MutasyonaUgracakindex;
                if (BireySayisi < 3)
                {
                    MutasyonaUgracakindex = 1;
                }
                else
                {
                    MutasyonaUgracakindex = Sayi.Next(ElitSayisi + 1, BireySayisi);
                }
                while (MutasyonOranı != 0)
                {
                    int MutasyonaUgracakgen = Sayi.Next(1, GenSayisi);
                    int MutasyonYeniDeger = Sayi.Next(0, 4);
                    while (YeniToplum[MutasyonaUgracakindex, MutasyonaUgracakgen] == MutasyonYeniDeger)
                    {
                        MutasyonYeniDeger = Sayi.Next(0, 4);
                    }
                    YeniToplum[MutasyonaUgracakindex, MutasyonaUgracakgen] = MutasyonYeniDeger;
                    MutasyonOranı--;
                }
                MutasyonSayisi--;
            }
        }

        public void YeniToplumUygunluk()
        {
            int Degisenilk, SonPozisyon;
            for (int i = 1; i <= BireySayisi; i++)
            {
                YeniToplumBireyUygunlugu[i] = 0;
                Degisenilk = ilkNokta;
                for (int j = 1; j <= GenSayisi; j++)
                {
                    if (Degisenilk == SonNokta)
                    {
                        YeniToplumPozisyonu[i, j] = SonNokta;
                    }
                    else
                    {
                        YeniToplumPozisyonu[i, j] = BireyinBirSonrakiNoktasi(Degisenilk, YeniToplum[i, j]);
                    }
                    //for (int jk = 1; jk < j; jk++)
                    //{
                    //    if (YeniToplumPozisyonu[i, j] == YeniToplumPozisyonu[i, jk])
                    //    {
                    //        YeniToplumPozisyonu[i, j] = Degisenilk;
                    //    }
                    //}
                    YeniToplumBireyUygunlugu[i] = YeniToplumBireyUygunlugu[i] + BireyinNoktadanNoktayaMesafesi(Degisenilk, YeniToplumPozisyonu[i, j]);
                    Degisenilk = YeniToplumPozisyonu[i, j];
                    if (j == GenSayisi)
                    {
                        SonPozisyon = BireyinNoktadanNoktayaMesafesi(YeniToplumPozisyonu[i, j], SonNokta);
                        YeniToplumBireyUygunlugu[i] = 5 * SonPozisyon + YeniToplumBireyUygunlugu[i];
                    }
                }
            }
            for (int a = 1; a <= BireySayisi; a++)
            {
                EnKucuk = 100000;
                EnKucukindex = 0;
                int gecici = 0, gecici2 = 0, gecici3 = 0;
                for (int b = a; b <= BireySayisi; b++)
                {
                    if (YeniToplumBireyUygunlugu[b] < (EnKucuk))
                    {
                        EnKucuk = YeniToplumBireyUygunlugu[b];
                        EnKucukindex = b;
                    }
                }
                gecici = YeniToplumBireyUygunlugu[a];
                YeniToplumBireyUygunlugu[a] = YeniToplumBireyUygunlugu[EnKucukindex];
                YeniToplumBireyUygunlugu[EnKucukindex] = gecici;


                for (int c = 1; c <= GenSayisi; c++)
                {
                    gecici2 = YeniToplum[a, c];
                    YeniToplum[a, c] = YeniToplum[EnKucukindex, c];
                    YeniToplum[EnKucukindex, c] = gecici2;
                    gecici3 = YeniToplumPozisyonu[a, c];
                    YeniToplumPozisyonu[a, c] = YeniToplumPozisyonu[EnKucukindex, c];
                    YeniToplumPozisyonu[EnKucukindex, c] = gecici3;
                }
            }


            for (int i = 1; i <= BireySayisi; i++)
            {

                for (int h = 1; h <= GenSayisi; h++)
                {
                    ilkToplum[i, h] = YeniToplum[i, h];

                }

            }

        }
        public void ResimCizdir(int x, int y)
        {
            bitmap = (Bitmap)KrokiKampus.Image;
            Graphics g = Graphics.FromImage(bitmap);
            g.FillEllipse(new SolidBrush(Color.DarkRed), x - 5, y - 5, 10, 10);
              //g.DrawString(">>", new Font("Arial", 7), new SolidBrush(Color.White), x - 10, y - 10);
            if (eskix != -1)
            {
                g.DrawLine(new Pen(Color.Red), (float)eskix, (float)eskiy, (float)x, (float)y);
            }
            eskix = x;
            eskiy = y;
            KrokiKampus.Image = bitmap;
        }
        public void NoktaKoordinatlariYerlestir()
        {
            NoktaKoordinatlari[1, 0] = 16;
            NoktaKoordinatlari[1, 1] = 56;
            NoktaKoordinatlari[2, 0] = 58;
            NoktaKoordinatlari[2, 1] = 156;
            NoktaKoordinatlari[3, 0] = 21;
            NoktaKoordinatlari[3, 1] = 232;
            NoktaKoordinatlari[4, 0] = 44;
            NoktaKoordinatlari[4, 1] = 356;
            NoktaKoordinatlari[5, 0] = 137;
            NoktaKoordinatlari[5, 1] = 13;
            NoktaKoordinatlari[6, 0] = 108;
            NoktaKoordinatlari[6, 1] = 100;
            NoktaKoordinatlari[7, 0] = 120;
            NoktaKoordinatlari[7, 1] = 238;
            NoktaKoordinatlari[8, 0] = 127;
            NoktaKoordinatlari[8, 1] = 400;
            NoktaKoordinatlari[9, 0] = 222;
            NoktaKoordinatlari[9, 1] = 76;
            NoktaKoordinatlari[10, 0] = 241;
            NoktaKoordinatlari[10, 1] = 171;
            NoktaKoordinatlari[11, 0] = 215;
            NoktaKoordinatlari[11, 1] = 294;
            NoktaKoordinatlari[12, 0] = 265;
            NoktaKoordinatlari[12, 1] = 437;
            NoktaKoordinatlari[13, 0] = 358;
            NoktaKoordinatlari[13, 1] = 34;
            NoktaKoordinatlari[14, 0] = 380;
            NoktaKoordinatlari[14, 1] = 144;
            NoktaKoordinatlari[15, 0] = 348;
            NoktaKoordinatlari[15, 1] = 232;
            NoktaKoordinatlari[16, 0] = 365;
            NoktaKoordinatlari[16, 1] = 355;
            NoktaKoordinatlari[17, 0] = 460;
            NoktaKoordinatlari[17, 1] = 81;
            NoktaKoordinatlari[18, 0] = 536;
            NoktaKoordinatlari[18, 1] = 135;
            NoktaKoordinatlari[19, 0] = 473;
            NoktaKoordinatlari[19, 1] = 206;
            NoktaKoordinatlari[20, 0] = 505;
            NoktaKoordinatlari[20, 1] = 341;
            NoktaKoordinatlari[21, 0] = 573;
            NoktaKoordinatlari[21, 1] = 41;
            NoktaKoordinatlari[22, 0] = 626;
            NoktaKoordinatlari[22, 1] = 150;
            NoktaKoordinatlari[23, 0] = 581;
            NoktaKoordinatlari[23, 1] = 265;
            NoktaKoordinatlari[24, 0] = 627;
            NoktaKoordinatlari[24, 1] = 432;
        }




    }
}