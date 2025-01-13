using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class DisCountCardTbl
{
    public string SerialNo { get; set; } = null!;

    public string ExpDateShamsi { get; set; } = null!;

    public DateTime ExpDate { get; set; }

    public decimal Amount { get; set; }

    public decimal BuyAmount { get; set; }

    public int FkAccountSysCode { get; set; }

    public int? FkInvoiceSrialNo { get; set; }
}
