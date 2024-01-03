using Kaan_Binici_OOP_Sinavi.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaan_Binici_OOP_Sinavi.Concrete
{
    public class Musteri : IMusteri
    {
        public event Haberci UrunlerimiSectim; // ürünleri seçince müşteri event ile gönderecek.
        private string _Ad;

        public string Ad   // kapsülleme yaptım adını alırken.
        {
            get { return _Ad; }
            set { _Ad = value; }
        }
        public Siparis HazirlananSiparisim { get; set; } // siparişi hazır olduğunda alacak prop.
        public Menu SecilenMenu { get; set; }

        public void SiparisOlustur(Object sender)  // gelen sender menü tipinde menü
        {

            if (KahveDukkani.Mesai) // kahve dükkanı açık mı kapalı mı kontrol .
            {
                if (sender != null)
                {
                    SecilenMenu = sender as Menu;  // gelen menuyu menuye attım.
                    UrunlerimiSectim(this);  // müşteriyi event aracılığı ile kasaya gönderiyorum.
                }
                else
                {
                    throw new Exception("Menü oluşturulmadığı için seçim yapılamadı Menü oluşturun.");
                }

            }
            else
            {
                throw new Exception("Kahve Dükkanı henüz açılmadı.");
            }

        }
        public void HazirlananSiparisimiAliyorum(Object sender)
        {
            HazirlananSiparisim = (Siparis)sender;
        }
    }
}
