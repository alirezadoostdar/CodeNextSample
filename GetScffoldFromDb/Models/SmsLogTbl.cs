using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("SmsLogTBL")]
public partial class SmsLogTbl
{
    [Key]
    public int SysCode { get; set; }

    public int? AccountSysCode { get; set; }

    [StringLength(20)]
    public string? Mobile { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Date { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ShamsiDate { get; set; }

    public string? Message { get; set; }

    public bool? IsSuccessfull { get; set; }

    [StringLength(1000)]
    public string? Msg { get; set; }

    [Column("PanelID")]
    [StringLength(500)]
    public string? PanelId { get; set; }

    [StringLength(1000)]
    public string? BatchKey { get; set; }
}
