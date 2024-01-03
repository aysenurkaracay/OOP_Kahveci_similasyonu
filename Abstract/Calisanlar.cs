using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _OOP_Sinavi.Abstract
{
    public abstract class Calisanlar  // abstract class ve metotlar oluşturuldu, Çalışanlarda ortak olan metotlar burada tanımlandı.
    {
        /// <summary>
        /// Molaya cik metodu siniflarda override yapilacak.
        /// </summary>
        /// <param name="value"></param>
        public abstract void MolayaCik(object value);
        /// <summary>
        /// Moladan dön metodu siniflarda override yapilacak.
        /// </summary>
        public abstract void MoladanDon();

    }

}


