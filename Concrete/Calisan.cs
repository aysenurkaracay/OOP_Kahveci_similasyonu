using Kaan_Binici_OOP_Sinavi.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aysenur_karacay_OOP_Sinavi.Concrete
{
    public class Calisan : Calisanlar, ICalisan // interface ve abstract kullanılarak kalıtım alındı.
    {
        public ISiparis IslemYapilanSiparis { get; set; } // Çalışanın o an aldığı siparişi atadığım prop.

        public event Haberci KasaBenMusaitim;  // Çalışan müsait olunca event aracılığıyla ben müsaitim diyecek.
        public event Haberci MusteriSiparisiniHazirladim; // Müşteri işim bitti diyince müşteriye siparişini verecek.

        public void Gorev() // çalışan siparişi hazırlayacak.
        {

            MusteriSiparisiniHazirladim(IslemYapilanSiparis);
            KasaBenMusaitim(this);
        }

        public void KasadanSiparisAl(object sender) // Kasadan oluşan sipariş gönderilecek.
        {
            Gorev();
        }
        public override void MolayaCik(object value)
        {
            if (Kuyruk.MusteriKuyrugu.Count > 1)
            {
                throw new Exception("Müşteri Varken Molaya Çıkamazsın.");
            }
            else
            {
                throw new Exception("Molaya çıkabilirsin.");
            }
        }
        public override void MoladanDon()
        {

        }


    }
}
