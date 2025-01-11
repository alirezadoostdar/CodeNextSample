using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("invoiceDetailTbl")]
public partial class InvoiceDetailTbl
{
    public int GoodSysCode { get; set; }

    [StringLength(300)]
    public string? Comment { get; set; }

    public double? Quantity { get; set; }

    [Column(TypeName = "money")]
    public decimal Fee { get; set; }

    [StringLength(100)]
    public string Unit { get; set; } = null!;

    public double? UnitRate { get; set; }

    [Column(TypeName = "money")]
    public decimal? UserPrice { get; set; }

    [StringLength(100)]
    public string? SerialNo { get; set; }

    public int? Size { get; set; }

    public int? Color { get; set; }

    public int? WareHouse { get; set; }

    [Column("FK_InvoiceSysCode")]
    public int FkInvoiceSysCode { get; set; }

    public double? DiscountPercent { get; set; }

    [Key]
    public int SysCode { get; set; }

    [StringLength(1000)]
    public string? Term { get; set; }

    public int? RowNo { get; set; }

    public double? DiscountPercent2 { get; set; }

    public double MaliatArzeshAfzoodeh { get; set; }

    public double Avarez { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? DateExpire { get; set; }

    [Column(TypeName = "money")]
    public decimal? CurFee { get; set; }

    [Column(TypeName = "money")]
    public decimal DiscountFee { get; set; }

    public int? VisitorSysCode { get; set; }

    [Column(TypeName = "money")]
    public decimal Cost { get; set; }

    [Column(TypeName = "money")]
    public decimal VisitorFee { get; set; }

    public float? VisitorPer { get; set; }

    public double? WeightCar { get; set; }

    public double? WeighCarwithBar { get; set; }

    [Column(TypeName = "money")]
    public decimal BenefitCost { get; set; }

    public int? PromotionGoodSysCode { get; set; }

    [ForeignKey("Color")]
    [InverseProperty("InvoiceDetailTbls")]
    public virtual GoodColorTbl? ColorNavigation { get; set; }

    [ForeignKey("FkInvoiceSysCode")]
    [InverseProperty("InvoiceDetailTbls")]
    public virtual InvoiceTbl FkInvoiceSysCodeNavigation { get; set; } = null!;

    [ForeignKey("GoodSysCode")]
    [InverseProperty("InvoiceDetailTblGoodSysCodeNavigations")]
    public virtual StockTbl GoodSysCodeNavigation { get; set; } = null!;

    [ForeignKey("PromotionGoodSysCode")]
    [InverseProperty("InvoiceDetailTblPromotionGoodSysCodeNavigations")]
    public virtual StockTbl? PromotionGoodSysCodeNavigation { get; set; }

    [ForeignKey("Size")]
    [InverseProperty("InvoiceDetailTbls")]
    public virtual GoodSizeTbl? SizeNavigation { get; set; }

    [ForeignKey("WareHouse")]
    [InverseProperty("InvoiceDetailTbls")]
    public virtual WareHouseTbl? WareHouseNavigation { get; set; }
}
