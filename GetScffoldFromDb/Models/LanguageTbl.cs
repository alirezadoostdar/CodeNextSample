using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("LanguageTBL")]
public partial class LanguageTbl
{
    [Key]
    [StringLength(50)]
    public string Symbol { get; set; } = null!;

    [StringLength(50)]
    public string Language { get; set; } = null!;
}
