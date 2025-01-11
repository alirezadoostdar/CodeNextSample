using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class GoodsGroup2PersonAccountTbl
{
    public int Syscode { get; set; }

    public int? AccountSysCode { get; set; }

    public int? GoodGroup2Code { get; set; }

    public virtual PersonTbl? AccountSysCodeNavigation { get; set; }
}
