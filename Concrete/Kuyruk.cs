using Kaan_Binici_OOP_Sinavi.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaan_Binici_OOP_Sinavi.Concrete
{
    public class Kuyruk : IKuyruk
    {
        static public List<IKuyruk> MusteriKuyrugu { get; set; }
    }
}
