using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Keyless]
[Table("Person_CostMountlyTBL")]
public partial class PersonCostMountlyTbl
{
    [Column("FK_AccountSysCode")]
    public int FkAccountSysCode { get; set; }

    [Column("FK_PersonCostMountLy")]
    public int FkPersonCostMountLy { get; set; }

    [Column("QTY")]
    public double Qty { get; set; }

    [Column(TypeName = "money")]
    public decimal Amount { get; set; }

    [Column("ISActive")]
    public bool Isactive { get; set; }

    [ForeignKey("FkAccountSysCode")]
    public virtual CodeMngdwntbl FkAccountSysCodeNavigation { get; set; } = null!;

    [ForeignKey("FkPersonCostMountLy")]
    public virtual PersonCostMountlyTbl1 FkPersonCostMountLyNavigation { get; set; } = null!;
}
