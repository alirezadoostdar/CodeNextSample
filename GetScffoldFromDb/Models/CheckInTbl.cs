using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("CheckInTBL")]
public partial class CheckInTbl
{
    public long SerialNo { get; set; }

    [StringLength(1000)]
    public string Comment { get; set; } = null!;

    [Column("ACCNo")]
    [StringLength(1000)]
    public string Accno { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? CheckDate { get; set; }

    [StringLength(1000)]
    public string BankName { get; set; } = null!;

    [Key]
    [Column("FK_DocSysCode")]
    public int FkDocSysCode { get; set; }

    public int? BankAccountCode { get; set; }

    public int? Belongto { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? BeHesabDate { get; set; }

    [Column("SMSsent")]
    public bool? Smssent { get; set; }

    public bool? IsReject { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CheckMiladiDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? BeHesabMiladiDate { get; set; }

    [StringLength(20)]
    public string? SayadiCode { get; set; }

    public bool IsTransferred { get; set; }

    [Column("FK_SayadiInquiryStatus")]
    public int? FkSayadiInquiryStatus { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? RejectDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RejectMiladiDate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PassDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PassMiladiDate { get; set; }

    public int? LastDocDetail { get; set; }

    [Column("StatusID")]
    public int? StatusId { get; set; }

    public int? ToAccountSysCode { get; set; }

    public int? LastDocCode { get; set; }

    public int? BehesabDocCode { get; set; }

    [ForeignKey("BankAccountCode")]
    [InverseProperty("CheckInTbls")]
    public virtual BanksTbl? BankAccountCodeNavigation { get; set; }

    [ForeignKey("BehesabDocCode")]
    [InverseProperty("CheckInTbls")]
    public virtual DocTbl? BehesabDocCodeNavigation { get; set; }

    [ForeignKey("Belongto")]
    [InverseProperty("CheckInTbls")]
    public virtual CodeMngdwntbl? BelongtoNavigation { get; set; }

    [ForeignKey("FkDocSysCode")]
    [InverseProperty("CheckInTbl")]
    public virtual DocDetailTbl FkDocSysCodeNavigation { get; set; } = null!;

    [ForeignKey("FkSayadiInquiryStatus")]
    [InverseProperty("CheckInTbls")]
    public virtual CheckInCreditStatusTbl? FkSayadiInquiryStatusNavigation { get; set; }
}
