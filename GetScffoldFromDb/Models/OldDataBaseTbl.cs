using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("OldDataBaseTbl")]
public partial class OldDataBaseTbl
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("DBName")]
    [StringLength(50)]
    public string? Dbname { get; set; }

    [StringLength(50)]
    public string? Title { get; set; }
}
