using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class Account
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

    public int? FkAccoutnSysCode { get; set; }

    public int? FkAccoutnSysCode0 { get; set; }

    public bool IsTemp { get; set; }

    public virtual ICollection<DocDetailTbl> DocDetailTbls { get; set; } = new List<DocDetailTbl>();

    public virtual CodeMnguptbl? FkAccoutnSysCode0Navigation { get; set; }

    public virtual CodeMngdwntbl? FkAccoutnSysCodeNavigation { get; set; }

    public virtual ICollection<Account> InverseParentAccountRefNavigation { get; set; } = new List<Account>();

    public virtual Account? ParentAccountRefNavigation { get; set; }

    public virtual InfoSecurityLevelTbl SecurLevelNavigation { get; set; } = null!;
}
