using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("ZoneTBL")]
public partial class ZoneTbl
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(1000)]
    public string Zone { get; set; } = null!;

    public string? PolygonStr { get; set; }

    [InverseProperty("FkZone")]
    public virtual ICollection<VisitScaduleTbl> VisitScaduleTbls { get; set; } = new List<VisitScaduleTbl>();
}
