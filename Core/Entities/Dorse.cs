using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Dorse : BaseEntity
    {
        public virtual ICollection<BakimBilgisi>? BakimBilgileri { get; set; }
        public virtual ICollection<Yuk>? Yukler { get; set; }
        public string Plaka { get; set; }
        public string Marka { get; set; }
        public string Uzunluk { get; set; }
        public string UretimTarihi { get; set; }
        public string Turu { get; set; }
        public bool Durum { get; set; } //true çalışıyor,false boşta
        public string DorseTemsiliResim { get; set; }
    }
}
