using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("PersonCreditTBL")]
public partial class PersonCreditTbl
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("FK_AccountsysCode")]
    public int? FkAccountsysCode { get; set; }

    [StringLength(200)]
    public string? Title { get; set; }

    [StringLength(1000)]
    public string? Comment { get; set; }

    [ForeignKey("FkAccountsysCode")]
    [InverseProperty("PersonCreditTbls")]
    public virtual CodeMngdwntbl? FkAccountsysCodeNavigation { get; set; }
}
