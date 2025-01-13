using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class VwLeadAccountsWithParent
{
    public int Level3Id { get; set; }

    public int Level2Id { get; set; }

    public int Level1Id { get; set; }

    public int Level0Id { get; set; }

    public string Level3Title { get; set; } = null!;

    public string Level2Title { get; set; } = null!;

    public string Level1Title { get; set; } = null!;

    public string Level0Title { get; set; } = null!;

    public string Code0 { get; set; } = null!;

    public string Code1 { get; set; } = null!;

    public string Code2 { get; set; } = null!;

    public string Code3 { get; set; } = null!;

    public string Code { get; set; } = null!;
}
