using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("InfoPersonPriceNoTbl")]
public partial class InfoPersonPriceNoTbl
{
    [Key]
    public int Value { get; set; }

    [StringLength(1000)]
    public string? Caption { get; set; }

    [InverseProperty("SalePriceNoNavigation")]
    public virtual ICollection<PersonTbl> PersonTbls { get; set; } = new List<PersonTbl>();
}
