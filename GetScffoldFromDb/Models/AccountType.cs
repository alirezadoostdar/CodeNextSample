using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("AccountType")]
public partial class AccountType
{
    [Key]
    [Column("ID")]
    public byte Id { get; set; }

    [StringLength(50)]
    public string? Title { get; set; }
}
