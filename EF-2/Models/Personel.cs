using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_2.Models
{
    internal class Personel
    {
        // [Key]
        public int PersonelId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public decimal Maas { get; set; }
        public PersonelDetay? PersonelDetay { get; set; }
        public ICollection<PersonelBolum>? Bolumler { get; set; } // many to many de ef otomatik ara tablo oluşturuyor fakat biz bu tabloyu özelleştirmek istersek bu ara tabloyu değiştiremiyoruz. mesela bu tabloya identity kolonu eklemek, (film, oyuncu, rol adı örneği). bunun için kendi modelimizi oluşturmalıyız.
    }
}
