using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class VwdocumentDetailDocHeader
{
    public string? DocDate { get; set; }

    public DateTime SysDate { get; set; }

    public int DetailCode { get; set; }

    public int FkAccountSyscode { get; set; }

    public decimal AmmountIn { get; set; }

    public decimal AmmountOut { get; set; }

    public string ArchiveName { get; set; } = null!;

    public string Comment { get; set; } = null!;

    public int UserRowNo { get; set; }

    public int SndFkAccountSyscode { get; set; }

    public int FkDocSysCode { get; set; }

    public string? StrCode { get; set; }

    public long? NumCode { get; set; }

    public decimal? Cur1Amount { get; set; }

    public decimal? Cur2Amount { get; set; }

    public decimal? Cur3Amount { get; set; }

    public bool? Chek { get; set; }

    public int FkVisitorSysCode { get; set; }

    public bool? IsVisitorAutoDoc { get; set; }

    public DateTime? DocMiladiDate { get; set; }

    public bool? IsUpdate { get; set; }

    public int Level3Id { get; set; }

    public int Level2Id { get; set; }

    public int Level1Id { get; set; }

    public int Level0Id { get; set; }

    public string Code { get; set; } = null!;

    public string Level0Title { get; set; } = null!;

    public string Level1Title { get; set; } = null!;

    public string Level2Title { get; set; } = null!;

    public string Level3Title { get; set; } = null!;

    public int FkAccountId { get; set; }

    public bool IsMoeinRow { get; set; }

    public int? FkProjectId { get; set; }

    public byte FkTypeId { get; set; }

    public bool IsTemp { get; set; }

    public string? ProjectName { get; set; }

    public byte? MoreType { get; set; }

    public byte FkYearId { get; set; }

    public int? YearCode { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public int? OpeningMoeinCode { get; set; }

    public bool IsMoeinAccountTemp { get; set; }
}
