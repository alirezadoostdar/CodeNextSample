using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("InfoConvCurToStringTBL")]
public partial class InfoConvCurToStringTbl
{
    [Key]
    public int Value { get; set; }

    [StringLength(50)]
    public string? Title { get; set; }
}
