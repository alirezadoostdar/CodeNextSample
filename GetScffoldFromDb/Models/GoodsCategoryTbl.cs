using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("GoodsCategoryTBL")]
public partial class GoodsCategoryTbl
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(200)]
    public string Title { get; set; } = null!;

    [Column("PID")]
    public int Pid { get; set; }

    [Column(TypeName = "image")]
    public byte[]? CatImage { get; set; }

    [Column("CatImageURL")]
    [StringLength(200)]
    public string CatImageUrl { get; set; } = null!;

    [InverseProperty("Category")]
    public virtual ICollection<StockTbl> StockTbls { get; set; } = new List<StockTbl>();
}
