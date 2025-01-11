using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class GoodsCategoryTbl
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public int Pid { get; set; }

    public byte[]? CatImage { get; set; }

    public string CatImageUrl { get; set; } = null!;

    public virtual ICollection<StockTbl> StockTbls { get; set; } = new List<StockTbl>();
}
