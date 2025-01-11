using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class StockGroup1Tbl
{
    public int GroupId { get; set; }

    public string GroupName { get; set; } = null!;

    public virtual ICollection<StockTbl> StockTbls { get; set; } = new List<StockTbl>();
}
