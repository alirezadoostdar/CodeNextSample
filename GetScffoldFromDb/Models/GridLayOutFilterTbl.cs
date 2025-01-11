using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class GridLayOutFilterTbl
{
    public string Field { get; set; } = null!;

    public string FilterText { get; set; } = null!;

    public int SysCode { get; set; }

    public int? FkFilterId { get; set; }

    public virtual GridFilterTitleTbl? FkFilter { get; set; }
}
