using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("CheckInCreditStatusTBL")]
public partial class CheckInCreditStatusTbl
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(50)]
    public string Title { get; set; } = null!;

    [StringLength(1000)]
    public string? Comment { get; set; }

    public int? Color { get; set; }

    [InverseProperty("FkSayadiInquiryStatusNavigation")]
    public virtual ICollection<CheckInTbl> CheckInTbls { get; set; } = new List<CheckInTbl>();
}
