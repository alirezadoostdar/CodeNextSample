using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

public partial class Visit
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("Fk_AccountSysCode")]
    public int FkAccountSysCode { get; set; }

    [Column("Fk_VisitorSysCode")]
    public int FkVisitorSysCode { get; set; }

    [Column("Fk_InvoiceSerialNo")]
    public int? FkInvoiceSerialNo { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string ShamsiDate { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime MiladiDate { get; set; }

    [Column("Visits_Comment")]
    [StringLength(500)]
    public string? VisitsComment { get; set; }

    [Column("Visits_Status")]
    public bool VisitsStatus { get; set; }

    [Column("Visits_Long")]
    [StringLength(50)]
    public string VisitsLong { get; set; } = null!;

    [Column("Visits_Lat")]
    [StringLength(50)]
    public string VisitsLat { get; set; } = null!;

    public byte? CategoryId { get; set; }

    [ForeignKey("CategoryId")]
    [InverseProperty("Visits")]
    public virtual VisitsCategory? Category { get; set; }

    [ForeignKey("FkAccountSysCode")]
    [InverseProperty("VisitFkAccountSysCodeNavigations")]
    public virtual CodeMngdwntbl FkAccountSysCodeNavigation { get; set; } = null!;

    [ForeignKey("FkInvoiceSerialNo")]
    [InverseProperty("Visits")]
    public virtual InvoiceTbl? FkInvoiceSerialNoNavigation { get; set; }

    [ForeignKey("FkVisitorSysCode")]
    [InverseProperty("VisitFkVisitorSysCodeNavigations")]
    public virtual CodeMngdwntbl FkVisitorSysCodeNavigation { get; set; } = null!;
}
