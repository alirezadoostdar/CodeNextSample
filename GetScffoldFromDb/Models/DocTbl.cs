using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class DocTbl
{
    public int SysCode { get; set; }

    public string? DocDate { get; set; }

    public DateTime SysDate { get; set; }

    public int? UserIdno { get; set; }

    public string? Comment { get; set; }

    public string? ArchiveName { get; set; }

    public bool? Lock { get; set; }

    public string? SysShamsiDate { get; set; }

    public string? StrCode { get; set; }

    public long? NumCode { get; set; }

    public decimal CurBaseRate1 { get; set; }

    public decimal CurBaseRate2 { get; set; }

    public decimal CurBaseRate3 { get; set; }

    public decimal CurRate1Part2 { get; set; }

    public decimal CurRate2Part2 { get; set; }

    public decimal CurRate3Part2 { get; set; }

    public DateTime? DocMiladiDate { get; set; }

    public int? FkProjectId { get; set; }

    public byte FkTypeId { get; set; }

    public bool IsTemp { get; set; }

    public int? OpeningMoeinCode { get; set; }

    public byte FkYearId { get; set; }

    public int? Code { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<CheckInTbl> CheckInTbls { get; set; } = new List<CheckInTbl>();

    public virtual ICollection<DocDetailTbl> DocDetailTbls { get; set; } = new List<DocDetailTbl>();

    public virtual ProjectTbl? FkProject { get; set; }

    public virtual DocTypeTbl FkType { get; set; } = null!;

    public virtual FinancialYear FkYear { get; set; } = null!;

    public virtual User? UserIdnoNavigation { get; set; }
}
