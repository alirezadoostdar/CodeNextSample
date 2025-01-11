using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

public partial class TelNumber
{
    [Column("TelBookID")]
    public int? TelBookId { get; set; }

    [StringLength(50)]
    public string? TelNo { get; set; }

    public byte? TelNoType { get; set; }

    [Key]
    public int SysCode { get; set; }

    [StringLength(50)]
    public string? Title { get; set; }

    [ForeignKey("TelBookId")]
    [InverseProperty("TelNumbers")]
    public virtual TelBook? TelBook { get; set; }
}
