using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class ContactImagesTbl
{
    public int Id { get; set; }

    public string ImageName { get; set; } = null!;

    public byte[] Images { get; set; } = null!;

    public int FkTelBookId { get; set; }

    public virtual TelBook FkTelBook { get; set; } = null!;
}
