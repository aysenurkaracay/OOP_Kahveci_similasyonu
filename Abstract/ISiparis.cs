using _OOP_Sinavi.Concrete;
using _OOP_Sinavi.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _OOP_Sinavi.Abstract
{
    public interface ISiparis   ////Sipariş nesnesinin içinde olması gereken proplar girildi interface oluşturuldu.
    {

        public string SiparisVereninAdi { get; set; }
        public Menu Menu { get; set; }
        public Boyut Boyut { get; set; }
        public SekerMiktari SekerMiktari { get; set; }
        public OdemeTipi OdemeTipi { get; set; }
        public int UrunSayisi { get; set; }
        public Urun SiparisUrun { get; set; }
        public int UrunSuresi { get; set; }
        public int ToplamSiparisSuresi { get; set; }
        public decimal ToplamTutar { get; set; }

    }
}
