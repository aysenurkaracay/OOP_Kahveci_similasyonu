using Kaan_Binici_OOP_Sinavi.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaan_Binici_OOP_Sinavi.Concrete
{
    public class Malzeme : IMalzeme
    {
        public string MalzemeAdi { get; set; }
        public int MalzemeSuresi { get; set; }
        public decimal MalzemeFiyati { get; set; }
        public override string ToString()
        {
            return $"Ürün: {MalzemeAdi}, Ek Süre: {MalzemeSuresi}, Ek Ücret: {MalzemeFiyati}";
        }
    }
}
