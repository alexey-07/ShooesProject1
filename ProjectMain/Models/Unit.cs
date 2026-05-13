using System;
using System.Collections.Generic;

namespace ProjectMain.Models;

public partial class Unit
{
    public int Id { get; set; }

    public string UnitName { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
