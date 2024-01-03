using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _OOP_Sinavi.Abstract
{
    public interface IMalzeme
    {
        public string MalzemeAdi { get; set; }
        public int MalzemeSuresi { get; set; }
        public decimal MalzemeFiyati { get; set; }
    }
}
