using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("TransferWareHoseTbl")]
public partial class TransferWareHoseTbl
{
    [StringLength(300)]
    public string Comment { get; set; } = null!;

    [Key]
    public int TransferSerialNo { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? TransferDate { get; set; }

    public int UserNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime SysDate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? SysShamsiDate { get; set; }

    public int? TransferNo { get; set; }

    [Column("ISMovaghat")]
    public bool Ismovaghat { get; set; }

    [Column("Fk_YearId")]
    public byte FkYearId { get; set; }

    [ForeignKey("FkYearId")]
    [InverseProperty("TransferWareHoseTbls")]
    public virtual FinancialYear FkYear { get; set; } = null!;

    [InverseProperty("FkTransferSerialNavigation")]
    public virtual ICollection<InventoryTbl> InventoryTbls { get; set; } = new List<InventoryTbl>();

    [InverseProperty("FkTransferSysCodeNavigation")]
    public virtual ICollection<TransferWareHoseDetailTbl> TransferWareHoseDetailTbls { get; set; } = new List<TransferWareHoseDetailTbl>();

    [ForeignKey("UserNo")]
    [InverseProperty("TransferWareHoseTbls")]
    public virtual User UserNoNavigation { get; set; } = null!;
}
