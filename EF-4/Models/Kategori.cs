using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_4.Models
{
    internal class Kategori
    {
        public int KategoriId { get; set; }
        public string KategoriAdi { get; set; }
        public ICollection<Kitap>? Kitaplar { get; set; }

        // yardımcı tablo -> foreign keyi olmayan tablo (diagram da)
    }
}
