using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("GoodVisitorTBL")]
public partial class GoodVisitorTbl
{
    [Key]
    public int SysCode { get; set; }

    public int AccountSysCode { get; set; }

    public int GoodSysCode { get; set; }

    public float SalePer { get; set; }

    [Column(TypeName = "money")]
    public decimal SaleFee { get; set; }

    public float MarjoPer { get; set; }

    [Column(TypeName = "money")]
    public decimal MarjoFee { get; set; }

    [ForeignKey("AccountSysCode")]
    [InverseProperty("GoodVisitorTbls")]
    public virtual CodeMngdwntbl AccountSysCodeNavigation { get; set; } = null!;

    [ForeignKey("GoodSysCode")]
    [InverseProperty("GoodVisitorTbls")]
    public virtual StockTbl GoodSysCodeNavigation { get; set; } = null!;
}
