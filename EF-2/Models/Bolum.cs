using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_2.Models
{
    internal class Bolum
    {
        public int BolumId { get; set; }
        public string Ad { get; set; }
        // public Personel Personel { get; set; }
        public ICollection<PersonelBolum>? Personeller { get; set; }
    }
}
