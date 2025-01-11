using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Keyless]
public partial class VwdocumentDetailDocHeader
{
    [StringLength(10)]
    [Unicode(false)]
    public string? DocDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime SysDate { get; set; }

    public int DetailCode { get; set; }

    [Column("Fk_AccountSyscode")]
    public int FkAccountSyscode { get; set; }

    [Column("AmmountIN", TypeName = "money")]
    public decimal AmmountIn { get; set; }

    [Column("AmmountOUT", TypeName = "money")]
    public decimal AmmountOut { get; set; }

    [StringLength(1000)]
    public string ArchiveName { get; set; } = null!;

    [StringLength(1000)]
    public string Comment { get; set; } = null!;

    public int UserRowNo { get; set; }

    [Column("SndFk_AccountSyscode")]
    public int SndFkAccountSyscode { get; set; }

    [Column("Fk_docSysCode")]
    public int FkDocSysCode { get; set; }

    [StringLength(13)]
    public string? StrCode { get; set; }

    public long? NumCode { get; set; }

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

    [Column(TypeName = "datetime")]
    public DateTime? DocMiladiDate { get; set; }

    public bool? IsUpdate { get; set; }

    [Column("level3ID")]
    public int Level3Id { get; set; }

    [Column("Level2ID")]
    public int Level2Id { get; set; }

    [Column("Level1ID")]
    public int Level1Id { get; set; }

    [Column("Level0ID")]
    public int Level0Id { get; set; }

    [StringLength(120)]
    [Unicode(false)]
    public string Code { get; set; } = null!;

    [StringLength(250)]
    public string Level0Title { get; set; } = null!;

    [StringLength(250)]
    public string Level1Title { get; set; } = null!;

    [StringLength(250)]
    public string Level2Title { get; set; } = null!;

    [StringLength(250)]
    public string Level3Title { get; set; } = null!;

    [Column("Fk_AccountId")]
    public int FkAccountId { get; set; }

    public bool IsMoeinRow { get; set; }

    [Column("Fk_ProjectID")]
    public int? FkProjectId { get; set; }

    [Column("Fk_TypeID")]
    public byte FkTypeId { get; set; }

    public bool IsTemp { get; set; }

    [StringLength(500)]
    public string? ProjectName { get; set; }

    public byte? MoreType { get; set; }

    [Column("Fk_YearId")]
    public byte FkYearId { get; set; }

    public int? YearCode { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDate { get; set; }

    public int? OpeningMoeinCode { get; set; }

    public bool IsMoeinAccountTemp { get; set; }
}
