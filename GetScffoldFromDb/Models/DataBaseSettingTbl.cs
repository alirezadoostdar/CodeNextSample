using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("DataBaseSettingTBL")]
public partial class DataBaseSettingTbl
{
    [StringLength(1000)]
    public string KeyName { get; set; } = null!;

    [StringLength(4000)]
    public string? KeyValue { get; set; }

    [Column("UserID")]
    public int UserId { get; set; }

    [Key]
    [Column("syscode")]
    public int Syscode { get; set; }
}
