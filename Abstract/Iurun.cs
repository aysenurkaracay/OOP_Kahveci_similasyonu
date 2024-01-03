using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _OOP_Sinavi.Abstract
{
    public interface Iurun
    {
        public List<IMalzeme> Icindekiler { get; set; }
        public string Adi { get; set; }
        public int UretimSuresi { get; set; }
        public int BegenilmeOrani { get; set; }
        public decimal Fiyati { get; set; }


    }
}
