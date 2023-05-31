using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace EntityLayer
{
    public class AlbumBilgisi : BaseClass
    {
        public string AlbumAdi { get; set; }
        public string SanatciveyaGrup { get; set; }
        public DateTime CikisTarihi { get; set; }
        public decimal Fiyat { get; set; }
        public int? IndirimOrani { get; set; }
        public bool SatisiVarMi { get; set; }
    }
}
