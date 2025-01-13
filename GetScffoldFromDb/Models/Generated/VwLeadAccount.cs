using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class VwLeadAccount
{
    public int AccountId { get; set; }

    public int? ParentAccountRef { get; set; }

    public int Type { get; set; }

    public string Code { get; set; } = null!;

    public string Title { get; set; } = null!;

    public bool IsActive { get; set; }

    public bool Lock { get; set; }

    public decimal? Balance { get; set; }

    public int SecurLevel { get; set; }

    public bool HasMngdwn { get; set; }

    public string? TypeTitle { get; set; }

    public int? FkAccoutnSysCode { get; set; }

    public int? FkAccoutnSysCode0 { get; set; }

    public string? SecurLevelTitle { get; set; }

    public bool IsTemp { get; set; }
}
