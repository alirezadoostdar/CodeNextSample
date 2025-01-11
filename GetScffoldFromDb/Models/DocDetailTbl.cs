using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("DocDetailTbl")]
public partial class DocDetailTbl
{
    [Key]
    public int Syscode { get; set; }

    [Column("Fk_docSysCode")]
    public int FkDocSysCode { get; set; }

    [Column("Fk_AccountSyscode")]
    public int FkAccountSyscode { get; set; }

    [Column("AmmountIN", TypeName = "money")]
    public decimal AmmountIn { get; set; }

    [Column("AmmountOUT", TypeName = "money")]
    public decimal AmmountOut { get; set; }

    public int UserRowNo { get; set; }

    [StringLength(1000)]
    public string ArchiveName { get; set; } = null!;

    [Column("SndFk_AccountSyscode")]
    public int SndFkAccountSyscode { get; set; }

    [StringLength(1000)]
    public string Comment { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? Cur1Amount { get; set; }

    [Column(TypeName = "money")]
    public decimal? Cur2Amount { get; set; }

    [Column(TypeName = "money")]
    public decimal? Cur3Amount { get; set; }

    public bool? Chek { get; set; }

    [Column("FK_VisitorSysCode")]
    public int FkVisitorSysCode { get; set; }

    public bool? IsVisitorAutoDoc { get; set; }

    public bool? IsUpdate { get; set; }

    [Column("Fk_AccountId")]
    public int FkAccountId { get; set; }

    public bool IsMoeinRow { get; set; }

    public byte? MoreType { get; set; }

    [InverseProperty("FkDocDetailsyscodeNavigation")]
    public virtual BankDetailTbl? BankDetailTbl { get; set; }

    [InverseProperty("FkDocSysCodeNavigation")]
    public virtual CheckInTbl? CheckInTbl { get; set; }

    [InverseProperty("FkDocSysCodeNavigation")]
    public virtual CheckOuttbl? CheckOuttbl { get; set; }

    [InverseProperty("FkFstDocDetailNavigation")]
    public virtual DocLinkSndTbl? DocLinkSndTblFkFstDocDetailNavigation { get; set; }

    [InverseProperty("FkMainDocDetailNavigation")]
    public virtual ICollection<DocLinkSndTbl> DocLinkSndTblFkMainDocDetailNavigations { get; set; } = new List<DocLinkSndTbl>();

    [InverseProperty("FkSndDocDetailNavigation")]
    public virtual ICollection<DocLinkSndTbl> DocLinkSndTblFkSndDocDetailNavigations { get; set; } = new List<DocLinkSndTbl>();

    [InverseProperty("FkFstDocDetailNavigation")]
    public virtual DocLinkTbl? DocLinkTblFkFstDocDetailNavigation { get; set; }

    [InverseProperty("FkSndDocDetailNavigation")]
    public virtual ICollection<DocLinkTbl> DocLinkTblFkSndDocDetailNavigations { get; set; } = new List<DocLinkTbl>();

    [ForeignKey("FkAccountId")]
    [InverseProperty("DocDetailTbls")]
    public virtual Account FkAccount { get; set; } = null!;

    [ForeignKey("FkAccountSyscode")]
    [InverseProperty("DocDetailTbls")]
    public virtual CodeMngdwntbl FkAccountSyscodeNavigation { get; set; } = null!;

    [ForeignKey("FkDocSysCode")]
    [InverseProperty("DocDetailTbls")]
    public virtual DocTbl FkDocSysCodeNavigation { get; set; } = null!;

    [InverseProperty("FkDocSysCodeNavigation")]
    public virtual GhestInTbl? GhestInTbl { get; set; }

    [InverseProperty("FkDocDetailSysCodeNavigation")]
    public virtual ICollection<InvoicePaymentTbl> InvoicePaymentTbls { get; set; } = new List<InvoicePaymentTbl>();

    [InverseProperty("FkDocsysCodeNavigation")]
    public virtual ICollection<InvoiceTbl> InvoiceTbls { get; set; } = new List<InvoiceTbl>();
}
