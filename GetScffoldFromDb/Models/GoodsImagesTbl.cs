using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class GoodsImagesTbl
{
    public int Id { get; set; }

    public string ImageName { get; set; } = null!;

    public byte[] Images { get; set; } = null!;

    public int FkGoodSysCode { get; set; }

    public virtual StockTbl FkGoodSysCodeNavigation { get; set; } = null!;
}
