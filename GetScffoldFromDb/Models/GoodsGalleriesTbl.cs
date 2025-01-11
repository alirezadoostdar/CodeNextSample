using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Keyless]
[Table("GoodsGalleriesTbl")]
public partial class GoodsGalleriesTbl
{
    public int SysCode { get; set; }

    [Column("FK_GoodSysCode")]
    public int FkGoodSysCode { get; set; }

    [StringLength(300)]
    public string ImageName { get; set; } = null!;
}
