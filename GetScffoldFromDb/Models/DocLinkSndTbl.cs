using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class DocLinkSndTbl
{
    public int FkFstDocDetail { get; set; }

    public int FkSndDocDetail { get; set; }

    public int FkMainDocDetail { get; set; }

    public virtual DocDetailTbl FkFstDocDetailNavigation { get; set; } = null!;

    public virtual DocDetailTbl FkMainDocDetailNavigation { get; set; } = null!;

    public virtual DocDetailTbl FkSndDocDetailNavigation { get; set; } = null!;
}
