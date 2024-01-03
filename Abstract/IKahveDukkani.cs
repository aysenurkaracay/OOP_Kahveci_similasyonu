using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _OOP_Sinavi.Abstract
{
    public interface IKahveDukkani
    {
        public IMusteri Musteri { get; set; }
        List<IKasa> Kasalar { get; set; }
        List<ICalisan> Calisanlar { get; set; }

        void MesaiBaslat(int kasaSayisi, int calisanSayisi);
        void MesaiBitir();
    }
}
