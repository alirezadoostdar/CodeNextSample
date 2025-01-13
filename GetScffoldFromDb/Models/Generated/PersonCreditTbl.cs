using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class PersonCreditTbl
{
    public int Id { get; set; }

    public int? FkAccountsysCode { get; set; }

    public string? Title { get; set; }

    public string? Comment { get; set; }

    public virtual CodeMngdwntbl? FkAccountsysCodeNavigation { get; set; }
}
