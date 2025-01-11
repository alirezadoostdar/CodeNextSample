using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

public partial class DefaultPrintInfoLay
{
    [Key]
    public int Id { get; set; }

    [Column("Fk_PrintLayoutId")]
    public int FkPrintLayoutId { get; set; }

    public int UserId { get; set; }

    public int PrintInfoId { get; set; }

    [ForeignKey("FkPrintLayoutId")]
    [InverseProperty("DefaultPrintInfoLays")]
    public virtual PrintLayout FkPrintLayout { get; set; } = null!;

    [ForeignKey("PrintInfoId")]
    [InverseProperty("DefaultPrintInfoLays")]
    public virtual InvoiceInfoPrint PrintInfo { get; set; } = null!;

    [ForeignKey("UserId")]
    [InverseProperty("DefaultPrintInfoLays")]
    public virtual User User { get; set; } = null!;
}
