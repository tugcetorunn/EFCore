using EF_3.Models;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("database first");

NorthwindContext context = new NorthwindContext();


var urunler = context.Products.ToList();

//foreach (var product in urunler)
//    Console.WriteLine(product.ProductId + " " + product.ProductName);

var urunKategoriAd = context.Products.Join(context.Categories, x => x.CategoryId, y => y.CategoryId, (x, y) => new
{
    x.ProductId,
    x.ProductName,
    y.CategoryName
});

// navigation property yoksa ilişkili tabloyu getirmek için join kullanmamız gerek.

//foreach (var product in urunKategoriAd)
//    Console.WriteLine(product.ProductId + " - " + product.ProductName + " - " + product.CategoryName);

// özel kullanım

var listele = context.Products.Select(x => x);

//foreach (var product in listele)
//    Console.WriteLine(product.ProductName + " - " + product.Category.CategoryName); // bu şekilde kullanabilmemiz için include metoduna np yi vermemiz gerek önce.

var productWithCategories = context.Products.Include(x => x.Category); // navigation prop ler ve include sayesinde uzun join sorguları yapmak zorunda kalmıyoruz.

foreach (var product in productWithCategories)
{
    Console.WriteLine(product.ProductName + " - " + product.Category.CategoryName);
}

// ef core yükleme mekanizmaları - lazy loading, eager loading, explicit loading

// primary key tutulmazsa index olmaz
// primary key yoksa foreign key yok fk yoksa ilişki yok ilişki yoksa - orphan records (öksüz yetim)

// clustered index lerde fiziksel olarak sıralama yapılması gerekiyor. metinsel primary keyler a dan z ye sıralanır. bu nedenle indexleme maliyeti yüksektir. çünkü bu sıralamayı yapmak için öteleme-kaydırma yapması gerekiyor.

// dbcc - id boşluklarını doldurma - tercih etmeyiz maliyetten dolayı id ileriye gitmeli, ikinci neden ilişkili tablolarda veri kaybı yaşatır.



