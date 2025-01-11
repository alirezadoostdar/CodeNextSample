using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("DistributionTBL")]
public partial class DistributionTbl
{
    [Key]
    public int DistributionSerial { get; set; }

    [Column("FK_DriverSysCode")]
    public int? FkDriverSysCode { get; set; }

    [Column("FK_DistributorSysCode")]
    public int? FkDistributorSysCode { get; set; }

    [StringLength(1000)]
    public string Comment { get; set; } = null!;

    [StringLength(1000)]
    public string Field1 { get; set; } = null!;

    [StringLength(1000)]
    public string Field2 { get; set; } = null!;

    [StringLength(1000)]
    public string Field3 { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string DistributionDate { get; set; } = null!;

    public DateOnly DistributionMiladiDate { get; set; }

    public int UserNo { get; set; }

    public DateOnly SysMiladiDate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string SysShamsiDate { get; set; } = null!;

    public int DistributionNo { get; set; }

    [Column("FK_CarID")]
    public int? FkCarId { get; set; }

    [InverseProperty("FkDistributionSerialNavigation")]
    public virtual ICollection<DistributionDetailTbl> DistributionDetailTbls { get; set; } = new List<DistributionDetailTbl>();

    [ForeignKey("FkCarId")]
    [InverseProperty("DistributionTbls")]
    public virtual CarTbl? FkCar { get; set; }

    [ForeignKey("FkDistributorSysCode")]
    [InverseProperty("DistributionTblFkDistributorSysCodeNavigations")]
    public virtual CodeMngdwntbl? FkDistributorSysCodeNavigation { get; set; }

    [ForeignKey("FkDriverSysCode")]
    [InverseProperty("DistributionTblFkDriverSysCodeNavigations")]
    public virtual CodeMngdwntbl? FkDriverSysCodeNavigation { get; set; }

    [ForeignKey("UserNo")]
    [InverseProperty("DistributionTbls")]
    public virtual User UserNoNavigation { get; set; } = null!;
}
