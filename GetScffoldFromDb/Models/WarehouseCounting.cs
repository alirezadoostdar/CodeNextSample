using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("WarehouseCounting")]
public partial class WarehouseCounting
{
    [Key]
    public int Id { get; set; }

    public int Code { get; set; }

    [Column("Fk_DocSysCodeIn")]
    public int? FkDocSysCodeIn { get; set; }

    [Column("Fk_DocSysCodeOut")]
    public int? FkDocSysCodeOut { get; set; }

    [StringLength(500)]
    public string? Comment { get; set; }

    public bool IsTemp { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string ShamsiDate { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime MiladiDate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string RegShamsiDate { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime RegMiladiDate { get; set; }

    public int RegUserId { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? EditShamsiDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EditMiladiDate { get; set; }

    public int? EditUserId { get; set; }

    public int? LastInvoiceSerial { get; set; }

    public int? LastTransferSerial { get; set; }

    public int? LastInventorySerial { get; set; }

    [Column("Fk_YearId")]
    public byte FkYearId { get; set; }

    [Column("Fk_ProjectId")]
    public int? FkProjectId { get; set; }

    [ForeignKey("FkProjectId")]
    [InverseProperty("WarehouseCountings")]
    public virtual ProjectTbl? FkProject { get; set; }

    [ForeignKey("FkYearId")]
    [InverseProperty("WarehouseCountings")]
    public virtual FinancialYear FkYear { get; set; } = null!;

    [InverseProperty("FkWarehouseCounting")]
    public virtual ICollection<WarehouseCountingDetail> WarehouseCountingDetails { get; set; } = new List<WarehouseCountingDetail>();
}
