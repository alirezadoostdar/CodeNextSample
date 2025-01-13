using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class TelBook
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string Comment { get; set; } = null!;

    public int OwnerUserId { get; set; }

    public int? FkIdcity { get; set; }

    public int? FkIdostan { get; set; }

    public int? FkZone { get; set; }

    public string? Company { get; set; }

    public string? TelegramId { get; set; }

    public string? TelegramMobileNo { get; set; }

    public decimal? Latitude { get; set; }

    public decimal? Longitude { get; set; }

    public virtual ICollection<BranchTbl> BranchTbls { get; set; } = new List<BranchTbl>();

    public virtual ICollection<ContactImagesTbl> ContactImagesTbls { get; set; } = new List<ContactImagesTbl>();

    public virtual CityTbl? FkIdcityNavigation { get; set; }

    public virtual OstanTbl? FkIdostanNavigation { get; set; }

    public virtual ICollection<PersonTbl> PersonTbls { get; set; } = new List<PersonTbl>();

    public virtual ICollection<TelNumber> TelNumbers { get; set; } = new List<TelNumber>();
}
