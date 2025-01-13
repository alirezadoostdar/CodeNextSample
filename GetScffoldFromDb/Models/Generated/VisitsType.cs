using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class VisitsType
{
    public byte Id { get; set; }

    public string? Title { get; set; }

    public virtual ICollection<VisitsCategory> VisitsCategories { get; set; } = new List<VisitsCategory>();
}
