using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("PersonCreditDetailTBL")]
public partial class PersonCreditDetailTbl
{
    [Key]
    public int SysCode { get; set; }

    [Column("Fk_AccountSysCode")]
    public int? FkAccountSysCode { get; set; }

    [Column("UserID")]
    public int? UserId { get; set; }

    [StringLength(1000)]
    public string? Comment { get; set; }

    [Column(TypeName = "money")]
    public decimal? Price { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SysDate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ShamsiSysDate { get; set; }

    [Column(TypeName = "money")]
    public decimal? SndPrice { get; set; }

    [ForeignKey("FkAccountSysCode")]
    [InverseProperty("PersonCreditDetailTbls")]
    public virtual CodeMngdwntbl? FkAccountSysCodeNavigation { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("PersonCreditDetailTbls")]
    public virtual User? User { get; set; }
}
