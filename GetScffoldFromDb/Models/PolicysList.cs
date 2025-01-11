using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Keyless]
public partial class PolicysList
{
    [Column("PName")]
    public string Pname { get; set; } = null!;

    [Column("PLevel")]
    public int Plevel { get; set; }

    [Column("PID")]
    public int Pid { get; set; }
}
