using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class VwCompleteInventory
{
    public int InventorySerial { get; set; }

    public int InventoryNo { get; set; }

    public int UserNo { get; set; }

    public int Sign { get; set; }

    public int Type { get; set; }

    public string ShamsiDate { get; set; } = null!;

    public DateTime Date { get; set; }

    public string ShamsiSysDate { get; set; } = null!;

    public DateTime SysDate { get; set; }

    public string? Comment { get; set; }

    public bool IsTemp { get; set; }

    public int? FkInvoiceSerial { get; set; }

    public int? FkTransferSerial { get; set; }

    public int? FkDriversSysCode { get; set; }

    public int? FkDistributorSysCode { get; set; }

    public string? Field1 { get; set; }

    public string? Field2 { get; set; }

    public string? Field3 { get; set; }

    public string? Field4 { get; set; }

    public string? Field5 { get; set; }

    public string TypeTitle { get; set; } = null!;

    public int? Driver { get; set; }

    public int? Distributor { get; set; }

    public string Uname { get; set; } = null!;

    public int SysCode { get; set; }

    public int GoodSysCode { get; set; }

    public string? GoodsComment { get; set; }

    public double? Quantity { get; set; }

    public string Unit { get; set; } = null!;

    public double? UnitRate { get; set; }

    public string? SerialNo { get; set; }

    public string? DateExpire { get; set; }

    public int? Size { get; set; }

    public int? Color { get; set; }

    public int? WareHouse { get; set; }

    public int FkInventorySysCode { get; set; }

    public string? DetailField1 { get; set; }

    public string? DetailField2 { get; set; }

    public int? RowNo { get; set; }

    public double? NetQuantity { get; set; }

    public string? WareHouseName { get; set; }

    public string? ColorName { get; set; }

    public string? SizeName { get; set; }
}
