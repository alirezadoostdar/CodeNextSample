using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class ZoneTbl
{
    public int Id { get; set; }

    public string Zone { get; set; } = null!;

    public string? PolygonStr { get; set; }

    public virtual ICollection<VisitScaduleTbl> VisitScaduleTbls { get; set; } = new List<VisitScaduleTbl>();
}
