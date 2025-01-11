using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("BanksTbl")]
public partial class BanksTbl
{
    [Key]
    [Column("Fk_AccountSyscode")]
    public int FkAccountSyscode { get; set; }

    public string AccountNo { get; set; } = null!;

    public string Manager { get; set; } = null!;

    [Column("ContactID")]
    public int ContactId { get; set; }

    public string Comment { get; set; } = null!;

    [StringLength(20)]
    public string? CardNo { get; set; }

    [StringLength(50)]
    public string? Iban { get; set; }

    [StringLength(20)]
    public string? PaySwitchNo { get; set; }

    [StringLength(30)]
    public string? ShoppingNo { get; set; }

    [StringLength(20)]
    public string? TerminalNo { get; set; }

    [InverseProperty("BankAccountCodeNavigation")]
    public virtual ICollection<CheckInTbl> CheckInTbls { get; set; } = new List<CheckInTbl>();

    [InverseProperty("FkBankAccountNavigation")]
    public virtual ICollection<CheckOuttbl> CheckOuttbls { get; set; } = new List<CheckOuttbl>();

    [ForeignKey("FkAccountSyscode")]
    [InverseProperty("BanksTbl")]
    public virtual CodeMngdwntbl FkAccountSyscodeNavigation { get; set; } = null!;
}
