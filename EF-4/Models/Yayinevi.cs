using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_4.Models
{
    internal class Yayinevi
    {
        public int YayineviId { get; set; }
        public string YayineviAdi { get; set; }
        public ICollection<Kitap>? Kitaplar { get; set; }
    }
}
