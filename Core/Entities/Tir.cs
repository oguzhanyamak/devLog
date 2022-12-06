using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Tir : BaseEntity
    {
        
        public virtual Kullanici? Kullanici { get; set; }
        public virtual ICollection<BakimBilgisi>? BakimBilgileri { get; set; }
        public virtual ICollection<Yuk>? Yukler { get; set; }
        public string Marka { get; set; }
        public string Seri { get; set; }
        public string Model { get; set; }
        public string Plaka { get; set; }
        public uint KM { get; set; }
        public ushort UretimYili { get; set; }
        public ushort BeygirGucu { get; set; }
        public bool VitesTuru { get; set; } //0 Manuel , 1 Otomatik
        public bool YakıtTuru { get; set; } //0 Fosil , 1 Elektrik
    }
}
