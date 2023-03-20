using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Rehber
    {
        public Guid ID { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string TelefonNumarasiI { get; set; }
        public string TelefonNumarasiII { get; set; }
        public string TelefonNumarasiIII { get; set; }
        public string EmailAdres { get; set; }
        public string WebAdres { get; set; }
        public string Adres { get; set; }
        public string Aciklama { get; set; }

        public override string ToString() // bu kısmı yazmazsam entities.rehber olarak görünecek. isim ve soyisim i ezmem gerekti.
        {
            return string.Format("{0} {1}", Isim, Soyisim);
        }
    }
}
