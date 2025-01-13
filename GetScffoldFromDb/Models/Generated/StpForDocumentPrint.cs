using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class StpForDocumentPrint
{
    public string StpName { get; set; } = null!;

    public int Syscode { get; set; }

    public string TableName { get; set; } = null!;
}
