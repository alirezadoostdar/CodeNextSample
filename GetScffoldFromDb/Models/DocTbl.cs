using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("DocTbl")]
public partial class DocTbl
{
    [Key]
    public int SysCode { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? DocDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime SysDate { get; set; }

    [Column("UserIDNO")]
    public int? UserIdno { get; set; }

    [StringLength(1000)]
    public string? Comment { get; set; }

    [StringLength(1000)]
    public string? ArchiveName { get; set; }

    public bool? Lock { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? SysShamsiDate { get; set; }

    [StringLength(13)]
    public string? StrCode { get; set; }

    public long? NumCode { get; set; }

    [Column(TypeName = "decimal(12, 6)")]
    public decimal CurBaseRate1 { get; set; }

    [Column(TypeName = "decimal(12, 6)")]
    public decimal CurBaseRate2 { get; set; }

    [Column(TypeName = "decimal(12, 6)")]
    public decimal CurBaseRate3 { get; set; }

    [Column(TypeName = "decimal(12, 6)")]
    public decimal CurRate1Part2 { get; set; }

    [Column(TypeName = "decimal(12, 6)")]
    public decimal CurRate2Part2 { get; set; }

    [Column(TypeName = "decimal(12, 6)")]
    public decimal CurRate3Part2 { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DocMiladiDate { get; set; }

    [Column("Fk_ProjectID")]
    public int? FkProjectId { get; set; }

    [Column("Fk_TypeID")]
    public byte FkTypeId { get; set; }

    public bool IsTemp { get; set; }

    public int? OpeningMoeinCode { get; set; }

    [Column("Fk_YearId")]
    public byte FkYearId { get; set; }

    [Column("code")]
    public int? Code { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDate { get; set; }

    [InverseProperty("BehesabDocCodeNavigation")]
    public virtual ICollection<CheckInTbl> CheckInTbls { get; set; } = new List<CheckInTbl>();

    [InverseProperty("FkDocSysCodeNavigation")]
    public virtual ICollection<DocDetailTbl> DocDetailTbls { get; set; } = new List<DocDetailTbl>();

    [ForeignKey("FkProjectId")]
    [InverseProperty("DocTbls")]
    public virtual ProjectTbl? FkProject { get; set; }

    [ForeignKey("FkTypeId")]
    [InverseProperty("DocTbls")]
    public virtual DocTypeTbl FkType { get; set; } = null!;

    [ForeignKey("FkYearId")]
    [InverseProperty("DocTbls")]
    public virtual FinancialYear FkYear { get; set; } = null!;

    [ForeignKey("UserIdno")]
    [InverseProperty("DocTbls")]
    public virtual User? UserIdnoNavigation { get; set; }
}
