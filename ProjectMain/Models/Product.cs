using System;
using System.Collections.Generic;

namespace ProjectMain.Models;

public partial class Product
{
    public int Id { get; set; }

    public string Article { get; set; } = null!;

    public string ProductName { get; set; } = null!;

    public int IdUnit { get; set; }

    public decimal Price { get; set; }

    public int IdSupplier { get; set; }

    public int IdManufacture { get; set; }

    public int IdCategory { get; set; }

    public int Discount { get; set; }

    public int QuantityInStock { get; set; }

    public string Description { get; set; } = null!;

    public string Image { get; set; } = null!;

    public virtual Category IdCategoryNavigation { get; set; } = null!;

    public virtual Manufacturer IdManufactureNavigation { get; set; } = null!;

    public virtual Supplier IdSupplierNavigation { get; set; } = null!;

    public virtual Unit IdUnitNavigation { get; set; } = null!;
}
