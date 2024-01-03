using Kaan_Binici_OOP_Sinavi.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaan_Binici_OOP_Sinavi.Concrete
{
    public delegate void Haberci(object sender);
    public class KahveDukkani : IKahveDukkani
    {
        public KahveDukkani()                          // kahve dükkanı nesnesi çalışınca oluşacak nesneler.
        {
            Kasalar = new List<IKasa>();
            Calisanlar = new List<ICalisan>();
            BostaDuranCalisan.BosDuranCalisanlar = new List<IBostaDuranCalisan>();
            Kuyruk.MusteriKuyrugu = new List<IKuyruk>();
            GunlukRaporListesi = new List<ISiparis>();
            Mesai = false;
        }
        public static bool Mesai { get; set; }         // Mesai İçerisinde olduğunu denetleyen bool. Mesai Başladığında true bitince false döner.
        public IMusteri Musteri { get; set; }          // müşteri  dükkan başladığında gelir.
        public List<IKasa> Kasalar { get; set; }       // dükkan açılınca kasalar açılır ve kasalar listesine atılır.
        public List<ICalisan> Calisanlar { get; set; } // dükkan açılınca çalışanlar işe başlar ve çalışanlar listesine atılır.

        static public List<ISiparis> GunlukRaporListesi;

        /// <summary>
        /// Mesai Başlatan metot Kasa sayısı ve Calisan sayısı girilerek işe başlanır.
        /// </summary>
        /// <param name="kasaSayisi"></param> Girilen kasa kasıyı kadar kasa oluşturulur.
        /// <param name="calisanSayisi"></param> Girilen çalışan sayısı kadar çalışan oluşturulur.
        /// <exception cref="Exception"></exception> 
        public void MesaiBaslat(int kasaSayisi, int calisanSayisi)
        {
            if (kasaSayisi > 3)
            {
                throw new Exception("Kasa sayısı üçten büyük olamaz");  // kasa sayısı max değeri aşarsa hata fırlatır.
            }
            else
            {
                for (int i = 0; i < calisanSayisi; i++)                 // mesai başlarsa çalışan sayısı kadar dönecek for döngüsü.
                {
                    ICalisan calisan = new Calisan();                   // her döngüde çalışan oluşturacak.
                    Calisanlar.Add(calisan);                            // çalışanı çalışan listesine atacak.
                    calisan.KasaBenMusaitim += Kasalar[i].MusteridenAdiniVeSectigiMenuyuAlSiparisiOlustur; // çalışan kasaya ben müsaitim diyecek event ile kasa müşteriden siparişi alacak.
                }
                for (int i = 0; i < kasaSayisi; i++)                    // mesai başlarsa kasa sayısı kadar dönecek for döngüsü.
                {
                    IKasa kasa = new Kasa();                            // her döngüde kasa açılır.
                    Kasalar.Add(kasa);                                  // kasalar listesine eklenir.
                    Musteri.UrunlerimiSectim += Kasalar[i].MusteridenAdiniVeSectigiMenuyuAlSiparisiOlustur; // müşteri menumu seçtim der(event ile). Kasa müşteriden seçtiği menüyü ve müşterinin adını alır kahvenin üzerine yazmak için.
                    kasa.BostaDuranCalisanaSiparisGonder();             // kasa boşta duran çalışana siparişi gönderir.
                    kasa.SiparisAtadim += Calisanlar[i].KasadanSiparisAl; // kasa siparişi atar boşta duran çalışan kasadan siparişi alır.
                    Calisanlar[i].MusteriSiparisiniHazirladim += Musteri.HazirlananSiparisimiAliyorum;

                }
            }
            Mesai = true;            // mesai başladı ve mesai bool true döndü.    
        }
        /// <summary>
        /// bu metot mesai bitirmek içindir Mesai false döner ve dükkan kapanır.
        /// </summary>
        public void MesaiBitir()
        {
            Mesai = false;
        }
    }
}

