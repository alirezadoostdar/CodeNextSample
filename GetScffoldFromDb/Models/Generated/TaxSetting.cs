using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class TaxSetting
{
    public int Id { get; set; }

    public string TitleFilaName { get; set; } = null!;

    public string? MeliCode { get; set; }

    public string MemoryId { get; set; } = null!;

    public string EconomicCode { get; set; } = null!;

    public string? ZipCode { get; set; }

    public string? BaseUrl { get; set; }

    public string? PublickKey { get; set; }

    public string PrivateKey { get; set; } = null!;

    public string? CetificateCode { get; set; }

    public virtual ICollection<TaxInvoice> TaxInvoices { get; set; } = new List<TaxInvoice>();
}
