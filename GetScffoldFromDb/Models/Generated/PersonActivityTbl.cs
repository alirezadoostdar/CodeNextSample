using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class PersonActivityTbl
{
    public int FkAccountSysCode { get; set; }

    public int FkPersonActivity { get; set; }

    public float ActivityPer { get; set; }

    public bool Isactive { get; set; }

    public virtual CodeMngdwntbl FkAccountSysCodeNavigation { get; set; } = null!;

    public virtual PersonActivityTbl1 FkPersonActivityNavigation { get; set; } = null!;
}
