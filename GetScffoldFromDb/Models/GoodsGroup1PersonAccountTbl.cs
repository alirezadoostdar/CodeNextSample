using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class GoodsGroup1PersonAccountTbl
{
    public int Syscode { get; set; }

    public int? AccountSysCode { get; set; }

    public int? GoodGroup1Code { get; set; }

    public virtual PersonTbl? AccountSysCodeNavigation { get; set; }
}
