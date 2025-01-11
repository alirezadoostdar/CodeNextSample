using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class VwinvoiceDetailComplete
{
    public int GoodSysCode { get; set; }

    public double? NetQuantity { get; set; }

    public double? Fee { get; set; }

    public string? SerialNo { get; set; }

    public int? Size { get; set; }

    public int? Color { get; set; }

    public int? WareHouse { get; set; }

    public bool? Amani { get; set; }

    public int Type { get; set; }

    public int? FkDocsysCode { get; set; }

    public string? InvoiceDate { get; set; }

    public string CustomerName { get; set; } = null!;

    public int InvoiceSerialNo { get; set; }

    public int? FkAccountSysCode { get; set; }

    public int SysCode { get; set; }

    public double? Quantity { get; set; }

    public decimal GrossFee { get; set; }

    public string Unit { get; set; } = null!;

    public double? DiscountPercent { get; set; }

    public string? Term { get; set; }

    public string? SysShamsiDate { get; set; }

    public DateTime SysDate { get; set; }

    public int InvoiceNo { get; set; }

    public string Comment { get; set; } = null!;

    public double? DiscountPercent2 { get; set; }

    public string? DateExpire { get; set; }

    public decimal DiscountFee { get; set; }

    public int? VisitorSysCodeRows { get; set; }

    public decimal Cost { get; set; }

    public decimal VisitorFee { get; set; }

    public float? VisitorPer { get; set; }

    public decimal BenefitCost { get; set; }

    public int? Visitor1SysCode { get; set; }

    public double? TotalFee { get; set; }

    public double? AvarezAmount { get; set; }

    public double? MaliatAmount { get; set; }

    public double? DiscountAmount2 { get; set; }

    public double? DiscountAmount { get; set; }

    public double? SubTotalFee { get; set; }

    public double? UnitFee { get; set; }

    public int? VisitorSysCode2 { get; set; }

    public double? FeeNoCost { get; set; }

    public int? GoodType { get; set; }

    public string? Field4 { get; set; }

    public string? Field3 { get; set; }

    public string? RecivedDate { get; set; }

    public string? DelivaredDate { get; set; }

    public string? PaymentDate { get; set; }

    public double? GoodsVisitorPer { get; set; }

    public int? GroupId1 { get; set; }

    public int? GroupId2 { get; set; }

    public int? GroupId3 { get; set; }

    public string? CommentRow { get; set; }

    public int? VisitorSyscode { get; set; }

    public double? TotalFeeNoMaliat { get; set; }

    public int Sign { get; set; }

    public double? UnitRate { get; set; }

    public int? RowNo { get; set; }

    public DateTime? InvoiceMiladiDate { get; set; }

    public string? Title { get; set; }

    public int? FkProjectId { get; set; }

    public byte FkYearId { get; set; }
}
