using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class BakimBilgisi : BaseEntity
    {
        public virtual Tir? Tir { get; set; }
        public virtual Dorse? Dorse { get; set; }
        public string Plaka { get; set; }
        public string BakimAciklamasi { get; set; }
        public uint GuncelKMBilgisi { get; set; }
    }
}
