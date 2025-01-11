using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("DisCountCardTBL")]
public partial class DisCountCardTbl
{
    [Key]
    [StringLength(200)]
    public string SerialNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string ExpDateShamsi { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ExpDate { get; set; }

    [Column(TypeName = "money")]
    public decimal Amount { get; set; }

    [Column(TypeName = "money")]
    public decimal BuyAmount { get; set; }

    [Column("FK_AccountSysCode")]
    public int FkAccountSysCode { get; set; }

    [Column("FK_InvoiceSrialNo")]
    public int? FkInvoiceSrialNo { get; set; }
}
