using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("InventoryTypeTBL")]
public partial class InventoryTypeTbl
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(100)]
    public string Title { get; set; } = null!;

    [Column("Title_En")]
    [StringLength(100)]
    public string TitleEn { get; set; } = null!;
}
