using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("PricingTBL")]
public partial class PricingTbl
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    public int PricingNo { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string ShamsiDate { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime MiladiDate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? SysShamsiDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SysMiladiDate { get; set; }

    public int UserNo { get; set; }

    public int? AccountCode { get; set; }

    [StringLength(2000)]
    public string Comment { get; set; } = null!;

    [StringLength(1000)]
    public string Field1 { get; set; } = null!;

    [StringLength(1000)]
    public string Field2 { get; set; } = null!;

    [StringLength(1000)]
    public string Field3 { get; set; } = null!;

    public int TasviehDay { get; set; }

    [ForeignKey("AccountCode")]
    [InverseProperty("PricingTbls")]
    public virtual CodeMngdwntbl? AccountCodeNavigation { get; set; }

    [InverseProperty("FkPricing")]
    public virtual ICollection<PricingDetailTbl> PricingDetailTbls { get; set; } = new List<PricingDetailTbl>();

    [ForeignKey("UserNo")]
    [InverseProperty("PricingTbls")]
    public virtual User UserNoNavigation { get; set; } = null!;
}
