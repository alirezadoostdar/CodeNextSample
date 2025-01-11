using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("OstanTbl")]
public partial class OstanTbl
{
    [Key]
    public int OstanCode { get; set; }

    [StringLength(200)]
    public string Name { get; set; } = null!;

    [InverseProperty("FkOstanNavigation")]
    public virtual ICollection<CityTbl> CityTbls { get; set; } = new List<CityTbl>();

    [InverseProperty("FkIdostanNavigation")]
    public virtual ICollection<TelBook> TelBooks { get; set; } = new List<TelBook>();
}
