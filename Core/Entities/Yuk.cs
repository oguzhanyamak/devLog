using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Yuk : BaseEntity
    {
        public virtual Tir? Tir { get; set; }
        public virtual Dorse? Dorse { get; set; }
        public string Nereden { get; set; }
        public string Nereye { get; set; }
        public string YukTuru { get; set; }
        public string Agirlik { get; set; }
        public uint Mesafe { get; set; }
        public uint Ucret { get; set; }
        public string YukDetayAciklama { get; set; }
        public bool Durum { get; set; } // false devam ediyor,true bitti
    }
}
