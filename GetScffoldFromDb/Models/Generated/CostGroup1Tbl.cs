using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class CostGroup1Tbl
{
    public int GroupId { get; set; }

    public string GroupName { get; set; } = null!;

    public virtual ICollection<CostTbl> CostTbls { get; set; } = new List<CostTbl>();
}
