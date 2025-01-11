using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class DocLinkTbl
{
    public int FkFstDocDetail { get; set; }

    public int FkSndDocDetail { get; set; }

    public virtual DocDetailTbl FkFstDocDetailNavigation { get; set; } = null!;

    public virtual DocDetailTbl FkSndDocDetailNavigation { get; set; } = null!;
}
