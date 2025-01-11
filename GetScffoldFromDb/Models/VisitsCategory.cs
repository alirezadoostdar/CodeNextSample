using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("VisitsCategory")]
public partial class VisitsCategory
{
    [Key]
    public byte CategoryId { get; set; }

    [StringLength(200)]
    public string Title { get; set; } = null!;

    public byte VisitType { get; set; }

    [ForeignKey("VisitType")]
    [InverseProperty("VisitsCategories")]
    public virtual VisitsType VisitTypeNavigation { get; set; } = null!;

    [InverseProperty("Category")]
    public virtual ICollection<Visit> Visits { get; set; } = new List<Visit>();
}
