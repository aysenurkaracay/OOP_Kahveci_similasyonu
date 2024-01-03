using Kaan_Binici_OOP_Sinavi.Abstract;
using Kaan_Binici_OOP_Sinavi.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaan_Binici_OOP_Sinavi.Concrete
{
    public class Urun : Iurun
    {
        public List<IMalzeme> Icindekiler { get; set; }
        public string Adi { get; set; }
        public int UretimSuresi { get; set; }
        public int BegenilmeOrani { get; set; }
        public decimal Fiyati { get; set; }
        public override string ToString()
        {
            return $"Ürün: {Adi}, Süre: {UretimSuresi}, Fiyat: {Fiyati}";
        }
    }
}
