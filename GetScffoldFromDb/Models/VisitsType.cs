using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("VisitsType")]
public partial class VisitsType
{
    [Key]
    [Column("ID")]
    public byte Id { get; set; }

    [StringLength(200)]
    public string? Title { get; set; }

    [InverseProperty("VisitTypeNavigation")]
    public virtual ICollection<VisitsCategory> VisitsCategories { get; set; } = new List<VisitsCategory>();
}
