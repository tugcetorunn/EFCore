using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_4.Models
{
    internal class Kod
    {
        // [ForeignKey("Kitap")] da yazılabilir.
        public int KodId { get; set; }
        public string? BarkodYolu { get; set; }
        public string? KarekodYolu { get; set; }
        [ForeignKey(nameof(KodId))] // yazmazsak hata verir. bire bir de hangi tabloya yazacağını bilemez.
        public Kitap? Kitap { get; set; }
    }
}
