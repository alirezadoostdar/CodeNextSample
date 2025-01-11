using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("GoodsGroup2PersonAccountTBL")]
public partial class GoodsGroup2PersonAccountTbl
{
    [Key]
    [Column("syscode")]
    public int Syscode { get; set; }

    public int? AccountSysCode { get; set; }

    public int? GoodGroup2Code { get; set; }

    [ForeignKey("AccountSysCode")]
    [InverseProperty("GoodsGroup2PersonAccountTbls")]
    public virtual PersonTbl? AccountSysCodeNavigation { get; set; }
}
