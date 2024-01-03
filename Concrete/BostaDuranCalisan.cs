using Kaan_Binici_OOP_Sinavi.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaan_Binici_OOP_Sinavi.Concrete
{

    public class BostaDuranCalisan : IBostaDuranCalisan
    {
        public static List<IBostaDuranCalisan> BosDuranCalisanlar { get; set; } // boş çalışan listesi static.

    }
}
