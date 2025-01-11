using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("CityTbl")]
public partial class CityTbl
{
    [Key]
    public int Code { get; set; }

    [StringLength(200)]
    public string Name { get; set; } = null!;

    [Column("FK_Ostan")]
    public int? FkOstan { get; set; }

    [ForeignKey("FkOstan")]
    [InverseProperty("CityTbls")]
    public virtual OstanTbl? FkOstanNavigation { get; set; }

    [InverseProperty("FkIdcityNavigation")]
    public virtual ICollection<TelBook> TelBooks { get; set; } = new List<TelBook>();
}
