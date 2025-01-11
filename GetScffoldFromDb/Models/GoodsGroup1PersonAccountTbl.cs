using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("GoodsGroup1PersonAccountTBL")]
public partial class GoodsGroup1PersonAccountTbl
{
    [Key]
    [Column("syscode")]
    public int Syscode { get; set; }

    public int? AccountSysCode { get; set; }

    public int? GoodGroup1Code { get; set; }

    [ForeignKey("AccountSysCode")]
    [InverseProperty("GoodsGroup1PersonAccountTbls")]
    public virtual PersonTbl? AccountSysCodeNavigation { get; set; }
}
