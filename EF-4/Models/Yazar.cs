using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_4.Models
{
    internal class Yazar
    {
        public int YazarId { get; set; }
        // aop - attribute oriented programming (hepsi bir class tır aslında)
        // default parameters / named parameters
        [StringLength(20), Column(TypeName = "varchar")]
        public string YazarAdi { get; set; }
        [StringLength(20)]
        [Column(TypeName = "varchar")]
        public string YazarSoyadi { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public ICollection<KitapYazar>? Kitaplar { get; set; }

    }
}
