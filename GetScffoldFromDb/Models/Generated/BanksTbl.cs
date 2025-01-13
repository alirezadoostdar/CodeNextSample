using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class BanksTbl
{
    public int FkAccountSyscode { get; set; }

    public string AccountNo { get; set; } = null!;

    public string Manager { get; set; } = null!;

    public int ContactId { get; set; }

    public string Comment { get; set; } = null!;

    public string? CardNo { get; set; }

    public string? Iban { get; set; }

    public string? PaySwitchNo { get; set; }

    public string? ShoppingNo { get; set; }

    public string? TerminalNo { get; set; }

    public virtual ICollection<CheckInTbl> CheckInTbls { get; set; } = new List<CheckInTbl>();

    public virtual ICollection<CheckOuttbl> CheckOuttbls { get; set; } = new List<CheckOuttbl>();

    public virtual CodeMngdwntbl FkAccountSyscodeNavigation { get; set; } = null!;
}
