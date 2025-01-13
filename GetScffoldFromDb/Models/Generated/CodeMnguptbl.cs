using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class CodeMnguptbl
{
    public int AccountSysCode0 { get; set; }

    public string Title { get; set; } = null!;

    public int Kind { get; set; }

    public bool? Private { get; set; }

    public bool IsTafsilGroup { get; set; }

    public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();

    public virtual ICollection<CodeMngdwntbl> CodeMngdwntbls { get; set; } = new List<CodeMngdwntbl>();

    public virtual InfoAccountKind KindNavigation { get; set; } = null!;
}
