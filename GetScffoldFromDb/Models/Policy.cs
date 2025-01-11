using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

public partial class Policy
{
    [Column("PName")]
    [StringLength(1000)]
    public string Pname { get; set; } = null!;

    [Column("PLevel")]
    public int? Plevel { get; set; }

    [Key]
    [Column("PID")]
    public int Pid { get; set; }
}
