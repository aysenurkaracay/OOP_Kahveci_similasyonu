using _OOP_Sinavi.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _OOP_Sinavi.Abstract
{
    public interface IKasa
    {
        public event Haberci SiparisAtadim;

        void BostaDuranCalisanaSiparisGonder();
        void MusteridenAdiniVeSectigiMenuyuAlSiparisiOlustur(object sender);
    }
}
