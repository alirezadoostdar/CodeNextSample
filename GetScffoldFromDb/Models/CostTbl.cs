using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class CostTbl
{
    public int FkAccountSyscode { get; set; }

    public int? GroupId1 { get; set; }

    public int? GroupId2 { get; set; }

    public string Comment { get; set; } = null!;

    public virtual CodeMngdwntbl FkAccountSyscodeNavigation { get; set; } = null!;

    public virtual CostGroup1Tbl? GroupId1Navigation { get; set; }

    public virtual CostGroup2Tbl? GroupId2Navigation { get; set; }
}
