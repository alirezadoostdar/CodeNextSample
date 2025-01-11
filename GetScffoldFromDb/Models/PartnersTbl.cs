using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("PartnersTBL")]
public partial class PartnersTbl
{
    [Key]
    [Column("ID")]
    public byte Id { get; set; }

    public int? AccountSysCode { get; set; }

    public double StockPer { get; set; }

    [ForeignKey("AccountSysCode")]
    [InverseProperty("PartnersTbls")]
    public virtual CodeMngdwntbl? AccountSysCodeNavigation { get; set; }
}
