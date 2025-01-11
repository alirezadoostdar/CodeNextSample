using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

public partial class TelType
{
    [StringLength(50)]
    public string TelTypes { get; set; } = null!;

    [Key]
    [Column("FK")]
    public int Fk { get; set; }
}
