using _OOP_Sinavi.Concrete;
using _OOP_Sinavi.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _OOP_Sinavi.Abstract
{
    public interface IMenu
    {
        public List<Urun> Urunler { get; set; }
        public List<Malzeme> Malzemeler { get; set; }

        public Sicaklik Sicaklik { get; set; }

        public decimal Fiyatı { get; set; }
        public int MenuHazirlanmaSuresi { get; set; }
    }
}
