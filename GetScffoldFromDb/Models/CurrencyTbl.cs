using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("CurrencyTBL")]
public partial class CurrencyTbl
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(50)]
    public string Name { get; set; } = null!;

    [StringLength(50)]
    public string CultureName { get; set; } = null!;

    [StringLength(50)]
    public string? Title { get; set; }

    [Column(TypeName = "money")]
    public decimal? Price { get; set; }

    public double? Change { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdateTime { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ShamsiUpdateDate { get; set; }
}
