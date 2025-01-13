using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class VwPersonList
{
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

    public decimal? VisitorBaseAmmount { get; set; }

    public decimal? VisitorIncreaseAmmount { get; set; }

    public float? VisitorIncreasePer { get; set; }

    public bool VisitorAutoDoc { get; set; }

    public short VisitorGoodActiveStat { get; set; }

    public bool VisitorPerActiveStat { get; set; }

    public int? VisitorGoodGroupCode { get; set; }

    public int? FkIdkind { get; set; }

    public bool? OutSidePerson { get; set; }

    public float? VisitorPerChanging { get; set; }

    public string? ShopName { get; set; }

    public string? Cardno { get; set; }

    public string? CardId1 { get; set; }

    public string? CardId2 { get; set; }

    public string? BirthDayDate { get; set; }

    public string? Pass { get; set; }
}
