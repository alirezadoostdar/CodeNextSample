using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("VisitScaduleTBL")]
public partial class VisitScaduleTbl
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(500)]
    public string? Title { get; set; }

    public string? Comment { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ShamsiDate { get; set; }

    [Column("date", TypeName = "datetime")]
    public DateTime? Date { get; set; }

    [Column("FK_VisitorID")]
    public int? FkVisitorId { get; set; }

    [Column("FK_ZoneID")]
    public int? FkZoneId { get; set; }

    [ForeignKey("FkVisitorId")]
    [InverseProperty("VisitScaduleTbls")]
    public virtual CodeMngdwntbl? FkVisitor { get; set; }

    [ForeignKey("FkZoneId")]
    [InverseProperty("VisitScaduleTbls")]
    public virtual ZoneTbl? FkZone { get; set; }
}
