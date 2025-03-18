using EF_2.Data.Context;
using EF_2.Models;
using Microsoft.EntityFrameworkCore;

PersonelDbContext context = new PersonelDbContext();

//context.Database.EnsureDeleted(); // önce siler sonra
//context.Database.EnsureCreated(); // oluşturur

//context.Bolumler.Add(new Bolum { Ad = "Muhasebe" }); // savechanges olmadan db ye eklemez.
//context.Bolumler.Add(new Bolum { Ad = "Satış" });
//context.Bolumler.Add(new Bolum { Ad = "İK" });


//context.SaveChanges();

//var ik = context.Bolumler.Find(2); // id ye göre bulur, params tipli parametre alır çünkü composit key olan tablolarda arama yapabilmek için.

//ik.Ad = "İnsan Kaynakları";
//context.Update(ik);
//context.Entry<Bolum>(ik).State = EntityState.Modified;
//context.SaveChanges();

context.Bolumler.Remove(context.Bolumler.Find(3));
context.SaveChanges();

foreach (var bolum in context.Bolumler)
{
    Console.WriteLine($"{bolum.BolumId} {bolum.Ad}");
}