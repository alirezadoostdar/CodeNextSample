using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("InternalSettingTbl")]
public partial class InternalSettingTbl
{
    [StringLength(1000)]
    public string? Key { get; set; }

    [StringLength(1000)]
    public string? Value { get; set; }

    [Key]
    public int Syscode { get; set; }
}
