using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("MoreBarCodeTBL")]
public partial class MoreBarCodeTbl
{
    [Key]
    public int SysCode { get; set; }

    [Column("FK_GoodSysCode")]
    public int FkGoodSysCode { get; set; }

    [StringLength(100)]
    public string BarCode { get; set; } = null!;
}
