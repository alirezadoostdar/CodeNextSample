using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class BranchTbl
{
    public int Id { get; set; }

    public int? FkTelBookId { get; set; }

    public int? FkAccountSysCode { get; set; }

    public string? BranchName { get; set; }

    public virtual CodeMngdwntbl? FkAccountSysCodeNavigation { get; set; }

    public virtual TelBook? FkTelBook { get; set; }
}
