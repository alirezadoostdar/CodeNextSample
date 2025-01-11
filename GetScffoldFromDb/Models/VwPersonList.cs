using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Keyless]
public partial class VwPersonList
{
    [Column("FK_AccountSysCode")]
    public int FkAccountSysCode { get; set; }

    public int? GroupId1 { get; set; }

    public int? GroupId2 { get; set; }

    public float VisitorPer { get; set; }

    public string Comment { get; set; } = null!;

    public string Introducer { get; set; } = null!;

    public long? Code { get; set; }

    public int SalePriceNo { get; set; }

    public int? ContactId { get; set; }

    public int? VisitorCostAcc { get; set; }

    [Column(TypeName = "money")]
    public decimal? VisitorBaseAmmount { get; set; }

    [Column(TypeName = "money")]
    public decimal? VisitorIncreaseAmmount { get; set; }

    public float? VisitorIncreasePer { get; set; }

    public bool VisitorAutoDoc { get; set; }

    public short VisitorGoodActiveStat { get; set; }

    public bool VisitorPerActiveStat { get; set; }

    public int? VisitorGoodGroupCode { get; set; }

    [Column("FK_IDKind")]
    public int? FkIdkind { get; set; }

    public bool? OutSidePerson { get; set; }

    public float? VisitorPerChanging { get; set; }

    public string? ShopName { get; set; }

    public string? Cardno { get; set; }

    [Column("CardID1")]
    public string? CardId1 { get; set; }

    [Column("CardID2")]
    public string? CardId2 { get; set; }

    [Column("birthDayDate")]
    [StringLength(10)]
    public string? BirthDayDate { get; set; }

    public string? Pass { get; set; }
}
