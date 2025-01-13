using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class InvoiceInfoPrint
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string ShopName { get; set; } = null!;

    public string? ShopComment { get; set; }

    public string Tel1 { get; set; } = null!;

    public string Tel2 { get; set; } = null!;

    public string? Mobile1 { get; set; }

    public string? Mobile2 { get; set; }

    public string? Address1 { get; set; }

    public string? ZipCode { get; set; }

    public string? EconomicCode { get; set; }

    public string? IdNumberCompony { get; set; }

    public string? IdNumberPerson { get; set; }

    public string? AccountNumber1 { get; set; }

    public string? AccountNumber2 { get; set; }

    public string? Term1 { get; set; }

    public string? Term2 { get; set; }

    public string? Comment { get; set; }

    public string? Feild1 { get; set; }

    public string? Feild2 { get; set; }

    public string? Feild3 { get; set; }

    public string? Feild4 { get; set; }

    public string? Feild5 { get; set; }

    public byte[]? Logo { get; set; }

    public virtual ICollection<DefaultPrintInfoLay> DefaultPrintInfoLays { get; set; } = new List<DefaultPrintInfoLay>();
}
