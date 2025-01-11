using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("DiscountModelsTBL")]
public partial class DiscountModelsTbl
{
    [Key]
    public int SysCode { get; set; }

    public string? Title { get; set; }

    [Column(TypeName = "money")]
    public decimal? GetAmmount { get; set; }

    [Column(TypeName = "money")]
    public decimal? SharjAmmount { get; set; }

    public double? DisPer { get; set; }
}
