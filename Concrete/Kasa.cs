using Kaan_Binici_OOP_Sinavi.Abstract;
using Kaan_Binici_OOP_Sinavi.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaan_Binici_OOP_Sinavi.Concrete
{
    public class Kasa : IKasa
    {
        public event Haberci SiparisAtadim;
        ISiparis Siparis;
        IMusteri Musteri;
        public void BostaDuranCalisanaSiparisGonder()
        {
            SiparisAtadim(Siparis);                        // bu metotla siparişi atadım eventine siparişi veriyorum.
        }

        public void MusteridenAdiniVeSectigiMenuyuAlSiparisiOlustur(object sender)
        {

            if (BostaDuranCalisan.BosDuranCalisanlar.Count > 0) // listeyi kontrol ediyorum boşta çalışan varsa senderden gelen siparişi siparişe atıyorum. Yoksa siparişi almıyorum hata fırlatıyorum.
            {
                Musteri = sender as Musteri;                  // gelen sender müşteri adını ve menüsünü taşıyordu .
                Siparis siparis = new Siparis();
                siparis.SiparisVereninAdi = Musteri.Ad;
                siparis.Menu = Musteri.SecilenMenu;
                Siparis = siparis;
                KahveDukkani.GunlukRaporListesi.Add(Siparis); // her oluşan siparişi günlük rapor listesin ekledim.
            }
            else
            {

                throw new Exception("Boşta Çalışanımız yok.");
            }

        }
        public decimal Hesapla()  // Kasa siparişin toplam tutarını hesaplıyor.
        {
            Siparis.ToplamTutar = 0;

            Siparis.ToplamTutar += Siparis.SiparisUrun.Fiyati;
            switch (Siparis.Boyut)
            {
                case Boyut.Orta:
                    Siparis.ToplamTutar += Siparis.ToplamTutar * 0.10m;
                    break;
                case Boyut.Büyük:
                    Siparis.ToplamTutar += Siparis.ToplamTutar * 0.25m;
                    break;
            }
            Siparis.ToplamTutar += Siparis.ToplamTutar * Siparis.UrunSayisi;
            return Siparis.ToplamTutar;
        }
        public int SiparisSuresiHesapla() // Kasa siparişin süresini hesaplıyor.
        {
            Siparis.ToplamSiparisSuresi = Siparis.UrunSayisi * Siparis.SiparisUrun.UretimSuresi - Siparis.SiparisUrun.Icindekiler.Count;
            Siparis.ToplamSiparisSuresi = Siparis.ToplamSiparisSuresi * 60;
            return Siparis.ToplamSiparisSuresi;
        }
    }
}
