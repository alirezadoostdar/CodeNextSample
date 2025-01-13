using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class InventoryTypeTbl
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string TitleEn { get; set; } = null!;
}
