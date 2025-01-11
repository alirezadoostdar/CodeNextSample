using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class GridFilterTitleTbl
{
    public int SysCode { get; set; }

    public int LayoutId { get; set; }

    public string DisplayText { get; set; } = null!;

    public virtual ICollection<GridLayOutFilterTbl> GridLayOutFilterTbls { get; set; } = new List<GridLayOutFilterTbl>();
}
