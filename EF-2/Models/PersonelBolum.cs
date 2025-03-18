using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_2.Models
{
    internal class PersonelBolum
    {
        public int Id { get; set; }
        public int PersonelId { get; set; }
        public int BolumId { get; set; }
        public Personel? Personel { get; set; }
        public Bolum? Bolum { get; set; }
    }
}
