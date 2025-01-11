using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("CostTbl")]
public partial class CostTbl
{
    [Key]
    [Column("Fk_AccountSyscode")]
    public int FkAccountSyscode { get; set; }

    [Column("GroupID1")]
    public int? GroupId1 { get; set; }

    [Column("GroupID2")]
    public int? GroupId2 { get; set; }

    public string Comment { get; set; } = null!;

    [ForeignKey("FkAccountSyscode")]
    [InverseProperty("CostTbl")]
    public virtual CodeMngdwntbl FkAccountSyscodeNavigation { get; set; } = null!;

    [ForeignKey("GroupId1")]
    [InverseProperty("CostTbls")]
    public virtual CostGroup1Tbl? GroupId1Navigation { get; set; }

    [ForeignKey("GroupId2")]
    [InverseProperty("CostTbls")]
    public virtual CostGroup2Tbl? GroupId2Navigation { get; set; }
}
