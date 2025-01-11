using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class CheckInTbl
{
    public long SerialNo { get; set; }

    public string Comment { get; set; } = null!;

    public string Accno { get; set; } = null!;

    public string? CheckDate { get; set; }

    public string BankName { get; set; } = null!;

    public int FkDocSysCode { get; set; }

    public int? BankAccountCode { get; set; }

    public int? Belongto { get; set; }

    public string? BeHesabDate { get; set; }

    public bool? Smssent { get; set; }

    public bool? IsReject { get; set; }

    public DateTime? CheckMiladiDate { get; set; }

    public DateTime? BeHesabMiladiDate { get; set; }

    public string? SayadiCode { get; set; }

    public bool IsTransferred { get; set; }

    public int? FkSayadiInquiryStatus { get; set; }

    public string? RejectDate { get; set; }

    public DateTime? RejectMiladiDate { get; set; }

    public string? PassDate { get; set; }

    public DateTime? PassMiladiDate { get; set; }

    public int? LastDocDetail { get; set; }

    public int? StatusId { get; set; }

    public int? ToAccountSysCode { get; set; }

    public int? LastDocCode { get; set; }

    public int? BehesabDocCode { get; set; }

    public virtual BanksTbl? BankAccountCodeNavigation { get; set; }

    public virtual DocTbl? BehesabDocCodeNavigation { get; set; }

    public virtual CodeMngdwntbl? BelongtoNavigation { get; set; }

    public virtual DocDetailTbl FkDocSysCodeNavigation { get; set; } = null!;

    public virtual CheckInCreditStatusTbl? FkSayadiInquiryStatusNavigation { get; set; }
}
