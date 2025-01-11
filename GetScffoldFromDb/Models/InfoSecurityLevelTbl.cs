using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class InfoSecurityLevelTbl
{
    public int Value { get; set; }

    public string? Caption { get; set; }

    public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();

    public virtual ICollection<CodeMngdwntbl> CodeMngdwntbls { get; set; } = new List<CodeMngdwntbl>();
}
