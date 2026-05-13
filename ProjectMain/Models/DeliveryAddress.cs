using System;
using System.Collections.Generic;

namespace ProjectMain.Models;

public partial class DeliveryAddress
{
    public int Id { get; set; }

    public string DeliveryName { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
