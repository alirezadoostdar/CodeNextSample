using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class DocDetailTbl
{
    public int Syscode { get; set; }

    public int FkDocSysCode { get; set; }

    public int FkAccountSyscode { get; set; }

    public decimal AmmountIn { get; set; }

    public decimal AmmountOut { get; set; }

    public int UserRowNo { get; set; }

    public string ArchiveName { get; set; } = null!;

    public int SndFkAccountSyscode { get; set; }

    public string Comment { get; set; } = null!;

    public decimal? Cur1Amount { get; set; }

    public decimal? Cur2Amount { get; set; }

    public decimal? Cur3Amount { get; set; }

    public bool? Chek { get; set; }

    public int FkVisitorSysCode { get; set; }

    public bool? IsVisitorAutoDoc { get; set; }

    public bool? IsUpdate { get; set; }

    public int FkAccountId { get; set; }

    public bool IsMoeinRow { get; set; }

    public byte? MoreType { get; set; }

    public virtual BankDetailTbl? BankDetailTbl { get; set; }

    public virtual CheckInTbl? CheckInTbl { get; set; }

    public virtual CheckOuttbl? CheckOuttbl { get; set; }

    public virtual DocLinkSndTbl? DocLinkSndTblFkFstDocDetailNavigation { get; set; }

    public virtual ICollection<DocLinkSndTbl> DocLinkSndTblFkMainDocDetailNavigations { get; set; } = new List<DocLinkSndTbl>();

    public virtual ICollection<DocLinkSndTbl> DocLinkSndTblFkSndDocDetailNavigations { get; set; } = new List<DocLinkSndTbl>();

    public virtual DocLinkTbl? DocLinkTblFkFstDocDetailNavigation { get; set; }

    public virtual ICollection<DocLinkTbl> DocLinkTblFkSndDocDetailNavigations { get; set; } = new List<DocLinkTbl>();

    public virtual Account FkAccount { get; set; } = null!;

    public virtual CodeMngdwntbl FkAccountSyscodeNavigation { get; set; } = null!;

    public virtual DocTbl FkDocSysCodeNavigation { get; set; } = null!;

    public virtual GhestInTbl? GhestInTbl { get; set; }

    public virtual ICollection<InvoicePaymentTbl> InvoicePaymentTbls { get; set; } = new List<InvoicePaymentTbl>();

    public virtual ICollection<InvoiceTbl> InvoiceTbls { get; set; } = new List<InvoiceTbl>();
}
