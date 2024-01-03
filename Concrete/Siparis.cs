using Kaan_Binici_OOP_Sinavi.Abstract;
using Kaan_Binici_OOP_Sinavi.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaan_Binici_OOP_Sinavi.Concrete
{
    public class Siparis : ISiparis    //Sipariş nesnesinin içinde olması gereken proplar girildi.
    {
        private string _siparisVereninAdi; 

        public string SiparisVereninAdi   //kapsülleme
        {
            get { return _siparisVereninAdi; }
            set { _siparisVereninAdi = value; }
        }

        public Menu Menu { get; set; }
        public Boyut Boyut { get; set; }
        public SekerMiktari SekerMiktari { get; set; }
        public OdemeTipi OdemeTipi { get; set; }
        public int UrunSayisi { get; set; }
        public Urun SiparisUrun { get; set; }
        public Malzeme Malzeme { get; set; }
        public int UrunSuresi { get; set; }
        public int ToplamSiparisSuresi { get; set; }
        public decimal ToplamTutar { get; set; }


    }

}

