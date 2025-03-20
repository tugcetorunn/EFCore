using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_4.Models
{
    internal class Kitap
    {
        public int KitapId { get; set; }
        public string KitapAdi { get; set; }
        public double Fiyat { get; set; }
        public string ISBN { get; set; }
        public short? SayfaSayisi { get; set; }
        public DateTime BasimTarihi { get; set; }
        public short BaskiSayisi { get; set; }
        public string? Ozet { get; set; }
        public string? KapakResmi { get; set; }
        // sonradan eklenen prop
        public string KagitCinsi { get; set; }
        // sonradan eklenen np
        public Yayinevi? Yayinevi { get; set; }
        public ICollection<KitapYazar>? Yazarlar { get; set; }
        public Kategori? Kategori { get; set; }
        // nullable yapmamak ileride veri girerken hata alırız ve bu hatayı vs söylemiyor.
        public Kod? Kod { get; set; }
    }
}
