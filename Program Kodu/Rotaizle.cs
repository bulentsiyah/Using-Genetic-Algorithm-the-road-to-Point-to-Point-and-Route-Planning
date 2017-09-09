using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace YolBulma
{
    class Rotaizle
    {
        int[,] ilkToplum = new int[101, 21];
        int[,] ToplumPozisyonu = new int[101, 21];
        int[] ToplumBireyUzunlugu = new int[101];
        int[] ToplumBireyUygunlugu = new int[101];
        int[] DonenDeger = new int[21];
      
        Hashtable hassecilen = new Hashtable();

        int[] Secilenler = new int[101];
        int EnKucuk = 10000;
        int EnKucukindex = 0;
        
        int[,] YeniToplum = new int[101, 21];
        int[,] YeniToplumPozisyonu = new int[101, 21];
        int[] YeniToplumBireyUygunlugu = new int[101];
        int[] YeniToplumBireyUzunlugu = new int[101];
        Random Sayi = new Random();
        int[,] NoktaKoordinatlari = new int[25, 2];
        int[,] SonucRota = new int[1, 22];
        int[] RastgeleSecilenler = new int[101];
        int[] eniyiler = new int[5];
        int[] Deney2 = new int[101];
        int[] Deney232 = new int[101];
        public int[,] RotaGonder(int gNesilSayisi, int gilkNokta, int gSonNokta)
        {
            NoktaKoordinatlariYerlestir();
            ToplumOlustur(gNesilSayisi);//100 bıreylı her bırey 20 kromozomlu
            ToplumUygunluk(gilkNokta, gSonNokta); //her bıreyın uygunlugu hesaplanıyor.
            ToplumSeckincilik();//en ıyı 4 tane secersecer ve yenı toplum ekler
            ToplumCaprazlama();//seckincilikle eklenenler dısında en uygunları caprazlayarak yenı topluma ekler.
            // ToplumCaprazlamaRastgele();
            ToplumMutasyon();
            YeniToplumUygunluk(gilkNokta, gSonNokta);
            ToplumDegistir();
            return SonucRota;
        }
        public int[] Deney()
        {
            return Deney2;
        }
        public int[] Deney23()
        {
            return Deney232;
        }

        public void ToplumOlustur(int gNesilSayisi)
        {
            if (gNesilSayisi == 100)//ilk nesıl oldugunu anlarım
            {
                for (int i = 1; i <= 100; i++)
                {
                    for (int j = 1; j <= 20; j++)
                    {

                        ilkToplum[i, j] = Sayi.Next(0, 4);
                    }
                }
                SonucRota[0, 21] = 25;
            }
            else
            {

            }
        }
        public void ToplumDegistir()
        {
            //for (int ic = 1; ic < 5; ic++)
            //{
            //    for (int hh = 1; hh < 21; hh++)
            //    {
            //        //Deney232[ic, hh] = ilkToplum[ic, hh];
            //        ilkToplum[ic, hh] = YeniToplum[eniyiler[ic], hh];
            //        //Deney2[ic, hh] = YeniToplum[ic, hh];
            //    }
            //}
            for (int i = 1; i < 101; i++)
            {
                for (int h = 1; h < 21; h++)
                {
                    //Deney232[i, h] = ilkToplum[i, h];
                    ilkToplum[i, h] = YeniToplum[i, h];
                    //Deney2[i, h] = YeniToplum[i, h];
                }
            }
            Deney232 = ToplumBireyUygunlugu;
            Deney2 = YeniToplumBireyUygunlugu;
        }

        public void ToplumUygunluk(int gilkNokta, int gSonNokta)
        {
            int ilk = gilkNokta;
            int Son = gSonNokta;

            for (int i = 1; i <= 100; i++)
            {
                ilk = gilkNokta;
                Son = gSonNokta;
                ToplumBireyUzunlugu[i] = 0;
                for (int j = 1; j <= 20; j++)
                {
                    DonenDeger[j] = ToplumUygunlukNoktasi(ilk, ilkToplum[i, j], Son, j);
                    ToplumBireyUzunlugu[i] = ToplumBireyUzunlugu[i] + ToplumUygunlukNoktaMesafesi(ilk, DonenDeger[j]);
                    ToplumPozisyonu[i, j] = DonenDeger[j];
                    ilk = DonenDeger[j];
                    if (j == 20)
                    {
                        ToplumBireyUygunlugu[i] = ToplumUygunlukNoktaMesafesi(DonenDeger[j], gSonNokta);
                        ToplumBireyUygunlugu[i] = ToplumBireyUygunlugu[i] + ToplumBireyUzunlugu[i] / 2;
                    }
                }
            }
        }
        public int ToplumUygunlukNoktasi(int gilkNokta, int gYon, int gSonNokta, int Sj)
        {
            int sonuc;
            if (gilkNokta == gSonNokta)
            {
                sonuc = gSonNokta;
            }
            else
            {
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
            }
            for (int j = 1; j <= Sj; j++)
            {
                if (sonuc == DonenDeger[j])
                {
                    sonuc = gilkNokta;
                }
            }
            return sonuc;

        }
        public int ToplumUygunlukNoktaMesafesi(int gilkNokta, int gDonenNokta)
        {
            double islem = Math.Pow(NoktaKoordinatlari[gilkNokta, 0] - NoktaKoordinatlari[gDonenNokta, 0], 2) + Math.Pow(NoktaKoordinatlari[gilkNokta, 1] - NoktaKoordinatlari[gDonenNokta, 1], 2);
            islem = Convert.ToInt32(Math.Sqrt(islem));
            return (int)islem;
        }
        public void NoktaKoordinatlariYerlestir()
        {
            NoktaKoordinatlari[1, 0] = 50;
            NoktaKoordinatlari[1, 1] = 50;
            NoktaKoordinatlari[2, 0] = 50;
            NoktaKoordinatlari[2, 1] = 150;
            NoktaKoordinatlari[3, 0] = 50;
            NoktaKoordinatlari[3, 1] = 300;
            NoktaKoordinatlari[4, 0] = 50;
            NoktaKoordinatlari[4, 1] = 400;
            NoktaKoordinatlari[5, 0] = 150;
            NoktaKoordinatlari[5, 1] = 10;
            NoktaKoordinatlari[6, 0] = 100;
            NoktaKoordinatlari[6, 1] = 100;
            NoktaKoordinatlari[7, 0] = 130;
            NoktaKoordinatlari[7, 1] = 225;
            NoktaKoordinatlari[8, 0] = 130;
            NoktaKoordinatlari[8, 1] = 400;
            NoktaKoordinatlari[9, 0] = 220;
            NoktaKoordinatlari[9, 1] = 75;
            NoktaKoordinatlari[10, 0] = 235;
            NoktaKoordinatlari[10, 1] = 160;
            NoktaKoordinatlari[11, 0] = 200;
            NoktaKoordinatlari[11, 1] = 300;
            NoktaKoordinatlari[12, 0] = 190;
            NoktaKoordinatlari[12, 1] = 400;
            NoktaKoordinatlari[13, 0] = 350;
            NoktaKoordinatlari[13, 1] = 75;
            NoktaKoordinatlari[14, 0] = 375;
            NoktaKoordinatlari[14, 1] = 160;
            NoktaKoordinatlari[15, 0] = 450;
            NoktaKoordinatlari[15, 1] = 310;
            NoktaKoordinatlari[16, 0] = 475;
            NoktaKoordinatlari[16, 1] = 400;
            NoktaKoordinatlari[17, 0] = 450;
            NoktaKoordinatlari[17, 1] = 75;
            NoktaKoordinatlari[18, 0] = 500;
            NoktaKoordinatlari[18, 1] = 165;
            NoktaKoordinatlari[19, 0] = 510;
            NoktaKoordinatlari[19, 1] = 210;
            NoktaKoordinatlari[20, 0] = 500;
            NoktaKoordinatlari[20, 1] = 350;
            NoktaKoordinatlari[21, 0] = 600;
            NoktaKoordinatlari[21, 1] = 100;
            NoktaKoordinatlari[22, 0] = 600;
            NoktaKoordinatlari[22, 1] = 190;
            NoktaKoordinatlari[23, 0] = 600;
            NoktaKoordinatlari[23, 1] = 300;
            NoktaKoordinatlari[24, 0] = 600;
            NoktaKoordinatlari[24, 1] = 400;
        }
        public void ToplumSeckincilik()
        {

            //SortedDictionary<int, int> siralayici = new SortedDictionary<int, int>();
            //for(int i=1; i<101; i++)
            //    siralayici.Add(ToplumBireyUygunlugu[i],i);

            //for (int i = 1; i < 101; i++)
            //    for (int j = 1; j < 21; j++)
            //        YeniToplum[i, j] = ilkToplum[siralayici.ElementAt(i-1).Value,j];

            for (int a = 1; a < 101; a++)
            {
                EnKucuk = 10000;
                EnKucukindex = 0;
                int gecici = 0, gecici2 = 0;
                for (int b = a; b < 101; b++)
                {
                    if (ToplumBireyUygunlugu[b] < (EnKucuk))
                    {
                        EnKucuk = ToplumBireyUygunlugu[b];
                        EnKucukindex = b;
                    }
                }

                for (int b = 1; b < 21; b++)
                {
                    gecici = ToplumBireyUygunlugu[a];
                    gecici2 = ilkToplum[a, b];
                    ToplumBireyUygunlugu[a] = ToplumBireyUygunlugu[EnKucukindex];
                    ilkToplum[a, b] = ilkToplum[EnKucukindex, b];
                    ToplumBireyUygunlugu[EnKucukindex] = gecici;
                    ilkToplum[a, b] = gecici2;
                }
            }
            for (int index = 1; index < 101; index++)
            {
                for (int bb = 1; bb < 21; bb++)
                {
                    YeniToplum[index, bb] = ilkToplum[index, bb];
                }
            }



        }
        public void ToplumCaprazlama()
        {
            int geciciDeger = 0;
            for (int s = 5; s < 100; s++)
            {
                for (int b = 11; b < 21; b++)
                {
                    geciciDeger = YeniToplum[s, b];
                    YeniToplum[s, b] = YeniToplum[s + 1, b];
                    YeniToplum[s + 1, b] = geciciDeger;
                }

            }
        }
        //public void ToplumCaprazlamaRastgele()
        //{
        //    Secilen = 1;
        //    int rastgele, rastgele2;
        //    int geciciDeger;


        //    while (Secilen < 101)
        //    {
        //        rastgele = Sayi.Next(1, 101);
        //        rastgele2 = Sayi.Next(1, 101);
        //        for (int a = 1; a < Secilen; a++)
        //        {
        //            if ((Secilenler[a] == rastgele) || (Secilenler[a] == rastgele2))
        //            {
        //                AyniindexVar = true;
        //            }
        //        }

        //        if (!(AyniindexVar))
        //        {
        //            for (int b = 11; b < 21; b++)
        //            {
        //                geciciDeger = YeniToplum[rastgele, b];
        //                YeniToplum[rastgele, b] = YeniToplum[rastgele2, b];
        //                YeniToplum[rastgele2, b] = geciciDeger;
        //            }
        //            RastgeleSecilenler[Secilen] = rastgele;
        //            Secilen++;
        //            RastgeleSecilenler[Secilen] = rastgele2;
        //            Secilen++;

        //        }

        //        AyniindexVar = false;

        //    }

        //}
        public void ToplumMutasyon()
        {
            int MutasyonaUgracakindex = Sayi.Next(1, 100);
            int MutasyonaUgracakgen = Sayi.Next(1, 20);
            int MutasyonYeniDeger = Sayi.Next(0, 4);
            if (YeniToplum[MutasyonaUgracakindex, MutasyonaUgracakgen] == 0 && !(MutasyonYeniDeger == 0))
            {
                YeniToplum[MutasyonaUgracakindex, MutasyonaUgracakgen] = MutasyonYeniDeger;
            }
            else if (YeniToplum[MutasyonaUgracakindex, MutasyonaUgracakgen] == 1 && !(MutasyonYeniDeger == 1))
            {
                YeniToplum[MutasyonaUgracakindex, MutasyonaUgracakgen] = MutasyonYeniDeger;
            }
            else if (YeniToplum[MutasyonaUgracakindex, MutasyonaUgracakgen] == 2 && !(MutasyonYeniDeger == 2))
            {
                YeniToplum[MutasyonaUgracakindex, MutasyonaUgracakgen] = MutasyonYeniDeger;
            }
            else
            {
                YeniToplum[MutasyonaUgracakindex, MutasyonaUgracakgen] = MutasyonYeniDeger;
            }
        }

        public void YeniToplumUygunluk(int gilkNokta, int gSonNokta)
        {
            int ilk = gilkNokta;
            int Son = gSonNokta;
            //int durdur = 1;
            //while (durdur <= 4)
            //{
            EnKucuk = 10000;
            EnKucukindex = 0;
            for (int i = 1; i < 101; i++)
            {
                ilk = gilkNokta;
                Son = gSonNokta;
                YeniToplumBireyUzunlugu[i] = 0;
                for (int j = 1; j <= 20; j++)
                {
                    DonenDeger[j] = ToplumUygunlukNoktasi(ilk, YeniToplum[i, j], Son, j);
                    YeniToplumPozisyonu[i, j] = DonenDeger[j];
                    YeniToplumBireyUzunlugu[i] = YeniToplumBireyUzunlugu[i] + ToplumUygunlukNoktaMesafesi(ilk, DonenDeger[j]);
                    ilk = DonenDeger[j];
                    if (j == 20)
                    {
                        YeniToplumBireyUygunlugu[i] = ToplumUygunlukNoktaMesafesi(DonenDeger[j], gSonNokta);
                        YeniToplumBireyUygunlugu[i] = YeniToplumBireyUygunlugu[i] + YeniToplumBireyUzunlugu[i] / 2;
                    }
                }
            }
            for (int i = 1; i <= 100; i++)
            {
                if (YeniToplumBireyUygunlugu[i] < EnKucuk)
                {
                    EnKucuk = YeniToplumBireyUygunlugu[i];
                    EnKucukindex = i;
                }
            }

            //if (durdur == 1)
            //{
            for (int b = 1; b < 21; b++)
            {
                SonucRota[0, b] = YeniToplumPozisyonu[EnKucukindex, b];
            }
            SonucRota[0, 21] = YeniToplumBireyUygunlugu[EnKucukindex];
            //}


            //eniyiler[durdur] = EnKucukindex;
            //durdur++;
            //}

        }

    }
}
