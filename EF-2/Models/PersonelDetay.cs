using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_2.Models
{
    internal class PersonelDetay
    {
        public int Id { get; set; }
        public string SicilNotu { get; set; }
        [ForeignKey(nameof(Id))]
        public Personel? Personel { get; set; } // one to one ilişki - burada baskın olan personelId. bu yüzden primary key personelId olursa ilişki tablosu doğru oluşur. iki tabloya da attribute süz np leri tanımladığımızda hata alırız. program hangisini oluşturacağını bilemez. bu yüzden attribute atıyoruz.
    }
}
