using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class VwLeadAccountsTreeList
{
    public int AccountId { get; set; }

    public int? ParentAccountRef { get; set; }

    public string Title { get; set; } = null!;

    public string Code { get; set; } = null!;

    public int Type { get; set; }

    public int SecurLevel { get; set; }

    public bool IsActive { get; set; }

    public bool Lock { get; set; }

    public int? FkAccoutnSysCode { get; set; }

    public int? FkAccoutnSysCode0 { get; set; }

    public bool HasMngdwn { get; set; }

    public decimal? Balance { get; set; }
}
