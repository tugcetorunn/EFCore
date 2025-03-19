using System;
using System.Collections.Generic;

namespace EF_3.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public int? SupplierId { get; set; }

    public int? CategoryId { get; set; }

    public string? QuantityPerUnit { get; set; }

    public decimal? UnitPrice { get; set; }

    public short? UnitsInStock { get; set; }

    public short? UnitsOnOrder { get; set; }

    public short? ReorderLevel { get; set; }

    public bool Discontinued { get; set; }

    public virtual Category? Category { get; set; } // virtual olması lazy loading old anlamına gelmez(eskiden öyleydi) ef core dan sonra üç koşul lazım virtual, gerekli kütüphane(proxy), gerekli ayar

    public virtual Supplier? Supplier { get; set; } // ef core dan önce virtual ile lazy loading sıkıntılıydı microsoft kaldırdı. daha sonra koşullarla beraber tekrar getirdi. önceki versiyonda serileştirme hatası oluyor, sonsuz döngüye giriyor. serileştirmede veri getirir
}
