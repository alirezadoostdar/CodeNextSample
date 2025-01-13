using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using PizzaShop.Models;

namespace PizzaShop.Data;

public partial class Mehr2180Context : DbContext
{
    public Mehr2180Context()
    {
    }

    public Mehr2180Context(DbContextOptions<Mehr2180Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Account> Accounts { get; set; }

    public virtual DbSet<AccountType> AccountTypes { get; set; }

    public virtual DbSet<AutoSync> AutoSyncs { get; set; }

    public virtual DbSet<AutoSyncLog> AutoSyncLogs { get; set; }

    public virtual DbSet<BackUpLogTbl> BackUpLogTbls { get; set; }

    public virtual DbSet<BankDetailTbl> BankDetailTbls { get; set; }

    public virtual DbSet<BanksTbl> BanksTbls { get; set; }

    public virtual DbSet<BarcodeTbl> BarcodeTbls { get; set; }

    public virtual DbSet<BlogViewLogTbl> BlogViewLogTbls { get; set; }

    public virtual DbSet<BranchTbl> BranchTbls { get; set; }

    public virtual DbSet<CarTbl> CarTbls { get; set; }

    public virtual DbSet<ChangeBankDetailTbl> ChangeBankDetailTbls { get; set; }

    public virtual DbSet<ChangeCheckInTbl> ChangeCheckInTbls { get; set; }

    public virtual DbSet<ChangeCheckOuttbl> ChangeCheckOuttbls { get; set; }

    public virtual DbSet<ChangeDocDetailTbl> ChangeDocDetailTbls { get; set; }

    public virtual DbSet<ChangeDocTbl> ChangeDocTbls { get; set; }

    public virtual DbSet<ChangeGhestInTbl> ChangeGhestInTbls { get; set; }

    public virtual DbSet<ChangeInventoryDetailTbl> ChangeInventoryDetailTbls { get; set; }

    public virtual DbSet<ChangeInventoryTbl> ChangeInventoryTbls { get; set; }

    public virtual DbSet<ChangeInvoiceCostDetailTbl> ChangeInvoiceCostDetailTbls { get; set; }

    public virtual DbSet<ChangeInvoiceTbl> ChangeInvoiceTbls { get; set; }

    public virtual DbSet<ChangeinvoiceDetailTbl> ChangeinvoiceDetailTbls { get; set; }

    public virtual DbSet<ChartLayoutTbl> ChartLayoutTbls { get; set; }

    public virtual DbSet<CheckInCreditStatusTbl> CheckInCreditStatusTbls { get; set; }

    public virtual DbSet<CheckInStatusTbl> CheckInStatusTbls { get; set; }

    public virtual DbSet<CheckInTbl> CheckInTbls { get; set; }

    public virtual DbSet<CheckInsForPrintTbl> CheckInsForPrintTbls { get; set; }

    public virtual DbSet<CheckOuttbl> CheckOuttbls { get; set; }

    public virtual DbSet<CityTbl> CityTbls { get; set; }

    public virtual DbSet<CodeMngdwntbl> CodeMngdwntbls { get; set; }

    public virtual DbSet<CodeMnguptbl> CodeMnguptbls { get; set; }

    public virtual DbSet<ConsumedGoodsTbl> ConsumedGoodsTbls { get; set; }

    public virtual DbSet<ContactImagesTbl> ContactImagesTbls { get; set; }

    public virtual DbSet<CostGroup1Tbl> CostGroup1Tbls { get; set; }

    public virtual DbSet<CostGroup2Tbl> CostGroup2Tbls { get; set; }

    public virtual DbSet<CostTbl> CostTbls { get; set; }

    public virtual DbSet<CurrencyTbl> CurrencyTbls { get; set; }

    public virtual DbSet<DashbordLayoutTbl> DashbordLayoutTbls { get; set; }

    public virtual DbSet<DataBaseSettingTbl> DataBaseSettingTbls { get; set; }

    public virtual DbSet<DataLog> DataLogs { get; set; }

    public virtual DbSet<DefaultPrintInfoLay> DefaultPrintInfoLays { get; set; }

    public virtual DbSet<DeletedCodeMngdwntbl> DeletedCodeMngdwntbls { get; set; }

    public virtual DbSet<DisCountCardTbl> DisCountCardTbls { get; set; }

    public virtual DbSet<DiscountCardTransactionTbl> DiscountCardTransactionTbls { get; set; }

    public virtual DbSet<DiscountModelsTbl> DiscountModelsTbls { get; set; }

    public virtual DbSet<DistributionDetailTbl> DistributionDetailTbls { get; set; }

    public virtual DbSet<DistributionTbl> DistributionTbls { get; set; }

    public virtual DbSet<DocDetailTbl> DocDetailTbls { get; set; }

    public virtual DbSet<DocLinkSndTbl> DocLinkSndTbls { get; set; }

    public virtual DbSet<DocLinkTbl> DocLinkTbls { get; set; }

    public virtual DbSet<DocTbl> DocTbls { get; set; }

    public virtual DbSet<DocTypeTbl> DocTypeTbls { get; set; }

    public virtual DbSet<FactorPrintLayoutPrinterTbl> FactorPrintLayoutPrinterTbls { get; set; }

    public virtual DbSet<FinancialYear> FinancialYears { get; set; }

    public virtual DbSet<FormLayoutTbl> FormLayoutTbls { get; set; }

    public virtual DbSet<GhestForPrint> GhestForPrints { get; set; }

    public virtual DbSet<GhestInTbl> GhestInTbls { get; set; }

    public virtual DbSet<GoodColorTbl> GoodColorTbls { get; set; }

    public virtual DbSet<GoodSizeTbl> GoodSizeTbls { get; set; }

    public virtual DbSet<GoodVisitorTbl> GoodVisitorTbls { get; set; }

    public virtual DbSet<GoodWarehouseTbl> GoodWarehouseTbls { get; set; }

    public virtual DbSet<GoodsCategoryTbl> GoodsCategoryTbls { get; set; }

    public virtual DbSet<GoodsGalleriesTbl> GoodsGalleriesTbls { get; set; }

    public virtual DbSet<GoodsGroup1PersonAccountTbl> GoodsGroup1PersonAccountTbls { get; set; }

    public virtual DbSet<GoodsGroup2PersonAccountTbl> GoodsGroup2PersonAccountTbls { get; set; }

    public virtual DbSet<GoodsImagesTbl> GoodsImagesTbls { get; set; }

    public virtual DbSet<GoodsOfStockForPrint> GoodsOfStockForPrints { get; set; }

    public virtual DbSet<GoodsQuotaTbl> GoodsQuotaTbls { get; set; }

    public virtual DbSet<GpstrackingTbl> GpstrackingTbls { get; set; }

    public virtual DbSet<GridFilterTitleTbl> GridFilterTitleTbls { get; set; }

    public virtual DbSet<GridLayOutFilterTbl> GridLayOutFilterTbls { get; set; }

    public virtual DbSet<GridLayout> GridLayouts { get; set; }

    public virtual DbSet<GridsInfo> GridsInfos { get; set; }

    public virtual DbSet<Group> Groups { get; set; }

    public virtual DbSet<GroupPolicy> GroupPolicys { get; set; }

    public virtual DbSet<InfoAccountKind> InfoAccountKinds { get; set; }

    public virtual DbSet<InfoBankListForCheckInTbl> InfoBankListForCheckInTbls { get; set; }

    public virtual DbSet<InfoConvCurToStringTbl> InfoConvCurToStringTbls { get; set; }

    public virtual DbSet<InfoDataLogAction> InfoDataLogActions { get; set; }

    public virtual DbSet<InfoGoodTypeTbl> InfoGoodTypeTbls { get; set; }

    public virtual DbSet<InfoInvoiceType> InfoInvoiceTypes { get; set; }

    public virtual DbSet<InfoParamDescribtion> InfoParamDescribtions { get; set; }

    public virtual DbSet<InfoPersonPriceNoTbl> InfoPersonPriceNoTbls { get; set; }

    public virtual DbSet<InfoSecurityLevelTbl> InfoSecurityLevelTbls { get; set; }

    public virtual DbSet<InfoSumOfDay> InfoSumOfDays { get; set; }

    public virtual DbSet<InternalSettingTbl> InternalSettingTbls { get; set; }

    public virtual DbSet<InventoryDetailTbl> InventoryDetailTbls { get; set; }

    public virtual DbSet<InventoryTbl> InventoryTbls { get; set; }

    public virtual DbSet<InventoryTypeTbl> InventoryTypeTbls { get; set; }

    public virtual DbSet<InvoiceCostDetailTbl> InvoiceCostDetailTbls { get; set; }

    public virtual DbSet<InvoiceCostTbl> InvoiceCostTbls { get; set; }

    public virtual DbSet<InvoiceDetailTbl> InvoiceDetailTbls { get; set; }

    public virtual DbSet<InvoiceInfoPrint> InvoiceInfoPrints { get; set; }

    public virtual DbSet<InvoicePaymentTbl> InvoicePaymentTbls { get; set; }

    public virtual DbSet<InvoiceReturnResonTbl> InvoiceReturnResonTbls { get; set; }

    public virtual DbSet<InvoiceSerialForHavaleh> InvoiceSerialForHavalehs { get; set; }

    public virtual DbSet<InvoiceServerType> InvoiceServerTypes { get; set; }

    public virtual DbSet<InvoiceStatusTbl> InvoiceStatusTbls { get; set; }

    public virtual DbSet<InvoiceTbl> InvoiceTbls { get; set; }

    public virtual DbSet<LanguageTbl> LanguageTbls { get; set; }

    public virtual DbSet<Log> Logs { get; set; }

    public virtual DbSet<MoreBarCodeTbl> MoreBarCodeTbls { get; set; }

    public virtual DbSet<OldDataBaseTbl> OldDataBaseTbls { get; set; }

    public virtual DbSet<OstanTbl> OstanTbls { get; set; }

    public virtual DbSet<PartnersTbl> PartnersTbls { get; set; }

    public virtual DbSet<PersonActivityTbl> PersonActivityTbls { get; set; }

    public virtual DbSet<PersonActivityTbl1> PersonActivityTbls1 { get; set; }

    public virtual DbSet<PersonCommercialTbl> PersonCommercialTbls { get; set; }

    public virtual DbSet<PersonCostMountlyTbl> PersonCostMountlyTbls { get; set; }

    public virtual DbSet<PersonCostMountlyTbl1> PersonCostMountlyTbls1 { get; set; }

    public virtual DbSet<PersonCreditDetailTbl> PersonCreditDetailTbls { get; set; }

    public virtual DbSet<PersonCreditTbl> PersonCreditTbls { get; set; }

    public virtual DbSet<PersonCustomerKindTbl> PersonCustomerKindTbls { get; set; }

    public virtual DbSet<PersonForPrint> PersonForPrints { get; set; }

    public virtual DbSet<PersonGroup1Tbl> PersonGroup1Tbls { get; set; }

    public virtual DbSet<PersonGroup2Tbl> PersonGroup2Tbls { get; set; }

    public virtual DbSet<PersonKind> PersonKinds { get; set; }

    public virtual DbSet<PersonTbl> PersonTbls { get; set; }

    public virtual DbSet<Policy> Policys { get; set; }

    public virtual DbSet<PolicysList> PolicysLists { get; set; }

    public virtual DbSet<PosTransactionTbl> PosTransactionTbls { get; set; }

    public virtual DbSet<PricingDetailTbl> PricingDetailTbls { get; set; }

    public virtual DbSet<PricingTbl> PricingTbls { get; set; }

    public virtual DbSet<PrintLayout> PrintLayouts { get; set; }

    public virtual DbSet<ProjectTbl> ProjectTbls { get; set; }

    public virtual DbSet<PromotionTbl> PromotionTbls { get; set; }

    public virtual DbSet<ScaduleCircuitTbl> ScaduleCircuitTbls { get; set; }

    public virtual DbSet<ScaduleTbl> ScaduleTbls { get; set; }

    public virtual DbSet<SmsLogTbl> SmsLogTbls { get; set; }

    public virtual DbSet<SqlErrMsg> SqlErrMsgs { get; set; }

    public virtual DbSet<StockDeletedTbl> StockDeletedTbls { get; set; }

    public virtual DbSet<StockGroup1Tbl> StockGroup1Tbls { get; set; }

    public virtual DbSet<StockGroup2Tbl> StockGroup2Tbls { get; set; }

    public virtual DbSet<StockGroup3Tbl> StockGroup3Tbls { get; set; }

    public virtual DbSet<StockTbl> StockTbls { get; set; }

    public virtual DbSet<StpForDistributionPrint> StpForDistributionPrints { get; set; }

    public virtual DbSet<StpForDocumentPrint> StpForDocumentPrints { get; set; }

    public virtual DbSet<StpForInventoryPrint> StpForInventoryPrints { get; set; }

    public virtual DbSet<StpForInvoicePrint> StpForInvoicePrints { get; set; }

    public virtual DbSet<StpForPricingPrint> StpForPricingPrints { get; set; }

    public virtual DbSet<StpForTransferWareHousePrint> StpForTransferWareHousePrints { get; set; }

    public virtual DbSet<StpForWarehouseCounting> StpForWarehouseCountings { get; set; }

    public virtual DbSet<SysObjVerTbl> SysObjVerTbls { get; set; }

    public virtual DbSet<TaxErrorType> TaxErrorTypes { get; set; }

    public virtual DbSet<TaxInvoice> TaxInvoices { get; set; }

    public virtual DbSet<TaxInvoiceIssue> TaxInvoiceIssues { get; set; }

    public virtual DbSet<TaxInvoicePattern> TaxInvoicePatterns { get; set; }

    public virtual DbSet<TaxInvoiceSettlement> TaxInvoiceSettlements { get; set; }

    public virtual DbSet<TaxInvoiceStatus> TaxInvoiceStatuses { get; set; }

    public virtual DbSet<TaxInvoiceType> TaxInvoiceTypes { get; set; }

    public virtual DbSet<TaxInvoicesError> TaxInvoicesErrors { get; set; }

    public virtual DbSet<TaxInvoicesLog> TaxInvoicesLogs { get; set; }

    public virtual DbSet<TaxPersonKind> TaxPersonKinds { get; set; }

    public virtual DbSet<TaxSetting> TaxSettings { get; set; }

    public virtual DbSet<TaxUnit> TaxUnits { get; set; }

    public virtual DbSet<TelBook> TelBooks { get; set; }

    public virtual DbSet<TelNumber> TelNumbers { get; set; }

    public virtual DbSet<TelType> TelTypes { get; set; }

    public virtual DbSet<TransferWareHoseDetailTbl> TransferWareHoseDetailTbls { get; set; }

    public virtual DbSet<TransferWareHoseTbl> TransferWareHoseTbls { get; set; }

    public virtual DbSet<TypeOfSettlementTbl> TypeOfSettlementTbls { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserDefaultGridLayoutTbl> UserDefaultGridLayoutTbls { get; set; }

    public virtual DbSet<UserDefaultPrintLayoutTbl> UserDefaultPrintLayoutTbls { get; set; }

    public virtual DbSet<VideoViewLogTbl> VideoViewLogTbls { get; set; }

    public virtual DbSet<Visit> Visits { get; set; }

    public virtual DbSet<VisitScaduleTbl> VisitScaduleTbls { get; set; }

    public virtual DbSet<VisitsCategory> VisitsCategories { get; set; }

    public virtual DbSet<VisitsType> VisitsTypes { get; set; }

    public virtual DbSet<VwAccountCheckInUnPassSum> VwAccountCheckInUnPassSums { get; set; }

    public virtual DbSet<VwAccountGhestInUnPassSum> VwAccountGhestInUnPassSums { get; set; }

    public virtual DbSet<VwAccountRemain> VwAccountRemains { get; set; }

    public virtual DbSet<VwAllBarcodeOfStockList> VwAllBarcodeOfStockLists { get; set; }

    public virtual DbSet<VwAndroidMehr> VwAndroidMehrs { get; set; }

    public virtual DbSet<VwCompleteInventory> VwCompleteInventories { get; set; }

    public virtual DbSet<VwCompleteInvoice> VwCompleteInvoices { get; set; }

    public virtual DbSet<VwCompleteRemainAnbarTransfer> VwCompleteRemainAnbarTransfers { get; set; }

    public virtual DbSet<VwCompleteRemainAnbarTransferByTitle> VwCompleteRemainAnbarTransferByTitles { get; set; }

    public virtual DbSet<VwCompleteVisit> VwCompleteVisits { get; set; }

    public virtual DbSet<VwContactIdContactSumary> VwContactIdContactSumaries { get; set; }

    public virtual DbSet<VwGoodCardex> VwGoodCardices { get; set; }

    public virtual DbSet<VwGoodOrderIn> VwGoodOrderIns { get; set; }

    public virtual DbSet<VwGoodOrderOut> VwGoodOrderOuts { get; set; }

    public virtual DbSet<VwInventoryGoodDetailRemain> VwInventoryGoodDetailRemains { get; set; }

    public virtual DbSet<VwInventoryGoodDetailRemainByTitle> VwInventoryGoodDetailRemainByTitles { get; set; }

    public virtual DbSet<VwInventoryGoodSimpleRemain> VwInventoryGoodSimpleRemains { get; set; }

    public virtual DbSet<VwInvoiceAndInventoryRemain> VwInvoiceAndInventoryRemains { get; set; }

    public virtual DbSet<VwInvoiceByInventory> VwInvoiceByInventories { get; set; }

    public virtual DbSet<VwInvoiceCostAmount> VwInvoiceCostAmounts { get; set; }

    public virtual DbSet<VwInvoiceDetailCostPersonDocDetail> VwInvoiceDetailCostPersonDocDetails { get; set; }

    public virtual DbSet<VwInvoiceListNotPaymentAndNoPaymentComplete> VwInvoiceListNotPaymentAndNoPaymentCompletes { get; set; }

    public virtual DbSet<VwInvoiceListPayment> VwInvoiceListPayments { get; set; }

    public virtual DbSet<VwInvoiceSumPayment> VwInvoiceSumPayments { get; set; }

    public virtual DbSet<VwInvoiceTasviehComplete> VwInvoiceTasviehCompletes { get; set; }

    public virtual DbSet<VwLastInvoiceOfPerson> VwLastInvoiceOfPeople { get; set; }

    public virtual DbSet<VwLeadAccount> VwLeadAccounts { get; set; }

    public virtual DbSet<VwLeadAccountsTreeList> VwLeadAccountsTreeLists { get; set; }

    public virtual DbSet<VwLeadAccountsWithParent> VwLeadAccountsWithParents { get; set; }

    public virtual DbSet<VwLinkToAccountTitle> VwLinkToAccountTitles { get; set; }

    public virtual DbSet<VwMaliatMokarar> VwMaliatMokarars { get; set; }

    public virtual DbSet<VwPersonList> VwPersonLists { get; set; }

    public virtual DbSet<VwPersonRemainCheckRemain> VwPersonRemainCheckRemains { get; set; }

    public virtual DbSet<VwPersonStateCityZone> VwPersonStateCityZones { get; set; }

    public virtual DbSet<VwPricingDetailComplete> VwPricingDetailCompletes { get; set; }

    public virtual DbSet<VwRemainGoodTolidi> VwRemainGoodTolidis { get; set; }

    public virtual DbSet<VwSysGoodRemainDetail> VwSysGoodRemainDetails { get; set; }

    public virtual DbSet<VwSysGoodRemainSimple> VwSysGoodRemainSimples { get; set; }

    public virtual DbSet<VwTaxErrorComplete> VwTaxErrorCompletes { get; set; }

    public virtual DbSet<VwTaxInvoiceAmount> VwTaxInvoiceAmounts { get; set; }

    public virtual DbSet<VwTaxInvoiceBody> VwTaxInvoiceBodies { get; set; }

    public virtual DbSet<VwTaxInvoiceComplete> VwTaxInvoiceCompletes { get; set; }

    public virtual DbSet<VwTaxInvoiceCompleteLastStatus> VwTaxInvoiceCompleteLastStatuses { get; set; }

    public virtual DbSet<VwTaxInvoiceLog> VwTaxInvoiceLogs { get; set; }

    public virtual DbSet<VwTaxPersonComplete> VwTaxPersonCompletes { get; set; }

    public virtual DbSet<VwTransferAndInventoryRemain> VwTransferAndInventoryRemains { get; set; }

    public virtual DbSet<VwVisitorDriverMovaze> VwVisitorDriverMovazes { get; set; }

    public virtual DbSet<VwWareHouseTransferComplete> VwWareHouseTransferCompletes { get; set; }

    public virtual DbSet<VwWarehouseCounting> VwWarehouseCountings { get; set; }

    public virtual DbSet<VwWarehouseCountingDetail> VwWarehouseCountingDetails { get; set; }

    public virtual DbSet<VwcompleteCode> VwcompleteCodes { get; set; }

    public virtual DbSet<VwcompleteGood> VwcompleteGoods { get; set; }

    public virtual DbSet<VwdocumentDetailDocHeader> VwdocumentDetailDocHeaders { get; set; }

    public virtual DbSet<VwdocumentDetailDocHeaderNotTemp> VwdocumentDetailDocHeaderNotTemps { get; set; }

    public virtual DbSet<VwgoodAvrageFee> VwgoodAvrageFees { get; set; }

    public virtual DbSet<VwgoodDetailRemain> VwgoodDetailRemains { get; set; }

    public virtual DbSet<VwgoodDetailRemainForPropertyInvoice> VwgoodDetailRemainForPropertyInvoices { get; set; }

    public virtual DbSet<VwgoodReport> VwgoodReports { get; set; }

    public virtual DbSet<VwgoodSimpleLastCurrencySummary> VwgoodSimpleLastCurrencySummaries { get; set; }

    public virtual DbSet<VwgoodSimpleLastSummary> VwgoodSimpleLastSummaries { get; set; }

    public virtual DbSet<VwgoodSimpleRemain> VwgoodSimpleRemains { get; set; }

    public virtual DbSet<VwinvoiceDetailComplete> VwinvoiceDetailCompletes { get; set; }

    public virtual DbSet<VwinvoiceDetailCompleteForAndroid> VwinvoiceDetailCompleteForAndroids { get; set; }

    public virtual DbSet<WareHouseTbl> WareHouseTbls { get; set; }

    public virtual DbSet<WarehouseCounting> WarehouseCountings { get; set; }

    public virtual DbSet<WarehouseCountingDetail> WarehouseCountingDetails { get; set; }

    public virtual DbSet<ZoneTbl> ZoneTbls { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-NPREDR7\\sql2019;Initial Catalog=mehr2180;User ID=sa;Password=bastan.net.sqlserver;MultipleActiveResultSets=true;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("SQL_Latin1_General_CP1_CI_AS");

        modelBuilder.Entity<Account>(entity =>
        {
            entity.HasKey(e => e.AccountId).HasName("PK_Account");

            entity.Property(e => e.AccountId).ValueGeneratedNever();
            entity.Property(e => e.Balance)
                .HasDefaultValue(0m)
                .HasColumnType("money");
            entity.Property(e => e.Code)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.FkAccoutnSysCode).HasColumnName("Fk_AccoutnSysCode");
            entity.Property(e => e.FkAccoutnSysCode0).HasColumnName("Fk_AccoutnSysCode0");
            entity.Property(e => e.HasMngdwn).HasColumnName("Has_MNGDWN");
            entity.Property(e => e.Title).HasMaxLength(250);

            entity.HasOne(d => d.FkAccoutnSysCodeNavigation).WithMany(p => p.Accounts)
                .HasForeignKey(d => d.FkAccoutnSysCode)
                .HasConstraintName("FK__Accounts__Fk_Acc__3FFC2C09");

            entity.HasOne(d => d.FkAccoutnSysCode0Navigation).WithMany(p => p.Accounts)
                .HasForeignKey(d => d.FkAccoutnSysCode0)
                .HasConstraintName("FK__Accounts__Fk_Acc__40F05042");

            entity.HasOne(d => d.ParentAccountRefNavigation).WithMany(p => p.InverseParentAccountRefNavigation)
                .HasForeignKey(d => d.ParentAccountRef)
                .HasConstraintName("FK_Account_ParentAccountRef");

            entity.HasOne(d => d.SecurLevelNavigation).WithMany(p => p.Accounts)
                .HasForeignKey(d => d.SecurLevel)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Accounts__SecurL__41E4747B");
        });

        modelBuilder.Entity<AccountType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AccountT__3214EC27ACD74B8F");

            entity.ToTable("AccountType");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Title).HasMaxLength(50);
        });

        modelBuilder.Entity<AutoSync>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AutoSync__3214EC07DC1D427D");

            entity.ToTable("AutoSync", tb => tb.HasTrigger("RGONDeleteAutoSync"));

            entity.Property(e => e.ActionTitle).HasMaxLength(10);
            entity.Property(e => e.EntityName).HasMaxLength(50);
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.SiteName).HasMaxLength(50);
        });

        modelBuilder.Entity<AutoSyncLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AutoSync__3214EC0774919555");

            entity.ToTable("AutoSyncLog");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.ActionTitle).HasMaxLength(10);
            entity.Property(e => e.EntityName).HasMaxLength(50);
            entity.Property(e => e.LogDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.SiteName).HasMaxLength(50);
        });

        modelBuilder.Entity<BackUpLogTbl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BackUpLogTBL");

            entity.Property(e => e.ComputerName).HasMaxLength(200);
            entity.Property(e => e.Ip)
                .HasMaxLength(50)
                .HasColumnName("IP");
            entity.Property(e => e.MiladiDate).HasColumnType("datetime");
            entity.Property(e => e.PathFile).HasMaxLength(1000);
            entity.Property(e => e.ShamsiDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.UserName).HasMaxLength(100);
        });

        modelBuilder.Entity<BankDetailTbl>(entity =>
        {
            entity.HasKey(e => e.FkDocDetailsyscode);

            entity.ToTable("BankDetailTbl", tb => tb.HasTrigger("TRGOnDeleteBankDetail"));

            entity.Property(e => e.FkDocDetailsyscode)
                .ValueGeneratedNever()
                .HasColumnName("Fk_DocDetailsyscode");
            entity.Property(e => e.Number).HasMaxLength(1000);

            entity.HasOne(d => d.FkDocDetailsyscodeNavigation).WithOne(p => p.BankDetailTbl)
                .HasForeignKey<BankDetailTbl>(d => d.FkDocDetailsyscode)
                .HasConstraintName("FK_BankDetailTbl_DocDetailTbl");
        });

        modelBuilder.Entity<BanksTbl>(entity =>
        {
            entity.HasKey(e => e.FkAccountSyscode);

            entity.ToTable("BanksTbl");

            entity.Property(e => e.FkAccountSyscode)
                .ValueGeneratedNever()
                .HasColumnName("Fk_AccountSyscode");
            entity.Property(e => e.CardNo).HasMaxLength(20);
            entity.Property(e => e.ContactId).HasColumnName("ContactID");
            entity.Property(e => e.Iban).HasMaxLength(50);
            entity.Property(e => e.PaySwitchNo).HasMaxLength(20);
            entity.Property(e => e.ShoppingNo).HasMaxLength(30);
            entity.Property(e => e.TerminalNo).HasMaxLength(20);

            entity.HasOne(d => d.FkAccountSyscodeNavigation).WithOne(p => p.BanksTbl)
                .HasForeignKey<BanksTbl>(d => d.FkAccountSyscode)
                .HasConstraintName("FK_BanksTbl_CodeMNGDWNTbl");
        });

        modelBuilder.Entity<BarcodeTbl>(entity =>
        {
            entity.HasKey(e => e.SysId);

            entity.ToTable("BarcodeTbl");

            entity.Property(e => e.Field1).HasMaxLength(1000);
            entity.Property(e => e.Field2).HasMaxLength(1000);

            entity.HasOne(d => d.GoodCodeNavigation).WithMany(p => p.BarcodeTbls)
                .HasForeignKey(d => d.GoodCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BarcodeTbl_StockTbl");
        });

        modelBuilder.Entity<BlogViewLogTbl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BlogViewLogTBL");

            entity.Property(e => e.FkBlogId).HasColumnName("FK_BlogID");
            entity.Property(e => e.FkUid).HasColumnName("FK_UID");
            entity.Property(e => e.ViewDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<BranchTbl>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BranchTBL__5D4BCC77");

            entity.ToTable("BranchTBL");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BranchName).HasMaxLength(200);
            entity.Property(e => e.FkAccountSysCode).HasColumnName("FK_AccountSysCode");
            entity.Property(e => e.FkTelBookId).HasColumnName("FK_TelBookID");

            entity.HasOne(d => d.FkAccountSysCodeNavigation).WithMany(p => p.BranchTbls)
                .HasForeignKey(d => d.FkAccountSysCode)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__BranchTBL__FK_Ac__5F3414E9");

            entity.HasOne(d => d.FkTelBook).WithMany(p => p.BranchTbls)
                .HasForeignKey(d => d.FkTelBookId)
                .HasConstraintName("FK__BranchTBL__FK_Te__5E3FF0B0");
        });

        modelBuilder.Entity<CarTbl>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CarTBL__3214EC2760F15D69");

            entity.ToTable("CarTBL");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CarOwner).HasMaxLength(200);
            entity.Property(e => e.CarTag).HasMaxLength(50);
            entity.Property(e => e.ChassisNo).HasMaxLength(200);
            entity.Property(e => e.Color).HasMaxLength(50);
            entity.Property(e => e.EngineCapacity).HasMaxLength(50);
            entity.Property(e => e.LoadLapacity).HasDefaultValue(0f);
            entity.Property(e => e.MobileOwner).HasMaxLength(20);
            entity.Property(e => e.MotorNo).HasMaxLength(200);
            entity.Property(e => e.Title).HasMaxLength(200);
        });

        modelBuilder.Entity<ChangeBankDetailTbl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ChangeBankDetailTbl");

            entity.Property(e => e.FkDocDetailsyscode).HasColumnName("Fk_DocDetailsyscode");
            entity.Property(e => e.Number).HasMaxLength(1000);
            entity.Property(e => e.OnChangeSysDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.OnChangeSysShamsiDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("([dbo].[funsundate](NULL))")
                .IsFixedLength();
            entity.Property(e => e.OnChangeUserId).HasDefaultValueSql("([dbo].[funuserid]())");
        });

        modelBuilder.Entity<ChangeCheckInTbl>(entity =>
        {
            entity.HasKey(e => e.RowNo).HasName("PK__ChangeCh__FFEE5BA250274E3C");

            entity.ToTable("ChangeCheckInTBL");

            entity.Property(e => e.Accno)
                .HasMaxLength(1000)
                .HasColumnName("ACCNo");
            entity.Property(e => e.BankName).HasMaxLength(1000);
            entity.Property(e => e.BeHesabDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.BeHesabMiladiDate).HasColumnType("datetime");
            entity.Property(e => e.CheckDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CheckMiladiDate).HasColumnType("datetime");
            entity.Property(e => e.Comment).HasMaxLength(1000);
            entity.Property(e => e.FkDocSysCode).HasColumnName("FK_DocSysCode");
            entity.Property(e => e.FkSayadiInquiryStatus).HasColumnName("FK_SayadiInquiryStatus");
            entity.Property(e => e.OnChangeSysDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.OnChangeSysShamsiDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("([dbo].[funsundate](NULL))")
                .IsFixedLength();
            entity.Property(e => e.OnChangeUserId).HasDefaultValueSql("([dbo].[funuserid]())");
            entity.Property(e => e.PassDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PassMiladiDate).HasColumnType("datetime");
            entity.Property(e => e.RejectDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RejectMiladiDate).HasColumnType("datetime");
            entity.Property(e => e.SayadiCode).HasMaxLength(20);
            entity.Property(e => e.Smssent).HasColumnName("SMSsent");
            entity.Property(e => e.StatusId).HasColumnName("StatusID");
        });

        modelBuilder.Entity<ChangeCheckOuttbl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ChangeCheckOUTTBL");

            entity.Property(e => e.CheckDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CheckMiladiDate).HasColumnType("datetime");
            entity.Property(e => e.Comment).HasMaxLength(1000);
            entity.Property(e => e.FkBankAccount).HasColumnName("FK_BankAccount");
            entity.Property(e => e.FkDocSysCode).HasColumnName("FK_DocSysCode");
            entity.Property(e => e.OnChangeSysDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.OnChangeSysShamsiDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("([dbo].[funsundate](NULL))")
                .IsFixedLength();
            entity.Property(e => e.OnChangeUserId).HasDefaultValueSql("([dbo].[funuserid]())");
        });

        modelBuilder.Entity<ChangeDocDetailTbl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ChangeDocDetailTbl");

            entity.Property(e => e.AmmountIn)
                .HasColumnType("money")
                .HasColumnName("AmmountIN");
            entity.Property(e => e.AmmountOut)
                .HasColumnType("money")
                .HasColumnName("AmmountOUT");
            entity.Property(e => e.ArchiveName).HasMaxLength(1000);
            entity.Property(e => e.Comment).HasMaxLength(1000);
            entity.Property(e => e.FkAccountSyscode).HasColumnName("Fk_AccountSyscode");
            entity.Property(e => e.FkDocSysCode).HasColumnName("Fk_docSysCode");
            entity.Property(e => e.IsDeleteOnServer).HasDefaultValue(false);
            entity.Property(e => e.OnChangeSysDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.OnChangeSysShamsiDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("([dbo].[funsundate](NULL))")
                .IsFixedLength();
            entity.Property(e => e.OnChangeUserId).HasDefaultValueSql("([dbo].[funuserid]())");
            entity.Property(e => e.SndFkAccountSyscode).HasColumnName("SndFk_AccountSyscode");
        });

        modelBuilder.Entity<ChangeDocTbl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ChangeDocTbl");

            entity.Property(e => e.ArchiveName).HasMaxLength(1000);
            entity.Property(e => e.Comment).HasMaxLength(1000);
            entity.Property(e => e.DocDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.OnChangeSysDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.OnChangeSysShamsiDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("([dbo].[funsundate](NULL))")
                .IsFixedLength();
            entity.Property(e => e.OnChangeUserId).HasDefaultValueSql("([dbo].[funuserid]())");
            entity.Property(e => e.SysDate).HasColumnType("datetime");
            entity.Property(e => e.UserIdno).HasColumnName("UserIDNO");
        });

        modelBuilder.Entity<ChangeGhestInTbl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ChangeGhestInTBL");

            entity.Property(e => e.Comment).HasMaxLength(1000);
            entity.Property(e => e.Date)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.FkDocSysCode).HasColumnName("FK_DocSysCode");
            entity.Property(e => e.OnChangeSysDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.OnChangeSysShamsiDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("([dbo].[funsundate](NULL))")
                .IsFixedLength();
            entity.Property(e => e.OnChangeUserId).HasDefaultValueSql("([dbo].[funuserid]())");
        });

        modelBuilder.Entity<ChangeInventoryDetailTbl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ChangeInventoryDetailTbl");

            entity.Property(e => e.Comment).HasMaxLength(300);
            entity.Property(e => e.DateExpire)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Field1).HasMaxLength(1000);
            entity.Property(e => e.Field2).HasMaxLength(1000);
            entity.Property(e => e.FkInventorySysCode).HasColumnName("FK_InventorySysCode");
            entity.Property(e => e.SerialNo).HasMaxLength(100);
            entity.Property(e => e.Unit).HasMaxLength(100);
        });

        modelBuilder.Entity<ChangeInventoryTbl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ChangeInventoryTBL");

            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.Field1).HasMaxLength(1000);
            entity.Property(e => e.Field2).HasMaxLength(1000);
            entity.Property(e => e.Field3).HasMaxLength(1000);
            entity.Property(e => e.Field4).HasMaxLength(1000);
            entity.Property(e => e.Field5).HasMaxLength(1000);
            entity.Property(e => e.FkDistributorSysCode).HasColumnName("Fk_DistributorSysCode");
            entity.Property(e => e.FkDriversSysCode).HasColumnName("Fk_DriversSysCode");
            entity.Property(e => e.FkInvoiceSerial).HasColumnName("Fk_InvoiceSerial");
            entity.Property(e => e.FkTransferSerial).HasColumnName("Fk_TransferSerial");
            entity.Property(e => e.OnChangeSysDate).HasColumnType("datetime");
            entity.Property(e => e.OnChangeSysShamsiDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.OnChangeUserId).HasColumnName("OnChangeUserID");
            entity.Property(e => e.ShamsiDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ShamsiSysDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.SysDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ChangeInvoiceCostDetailTbl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ChangeInvoiceCostDetailTbl");

            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.FkFactorSerialNo).HasColumnName("FK_FactorSerialNo");
            entity.Property(e => e.FkInvoiceCostSysCode).HasColumnName("FK_InvoiceCostSysCode");
            entity.Property(e => e.OnChangeSysDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.OnChangeSysShamsiDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("([dbo].[funsundate](NULL))")
                .IsFixedLength();
            entity.Property(e => e.OnChangeUserId).HasDefaultValueSql("([dbo].[funuserid]())");
        });

        modelBuilder.Entity<ChangeInvoiceTbl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ChangeInvoiceTbl");

            entity.Property(e => e.ArchiveName).HasMaxLength(100);
            entity.Property(e => e.Comment).HasMaxLength(300);
            entity.Property(e => e.CustomerName).HasMaxLength(300);
            entity.Property(e => e.DelivaredDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.FkAccountSysCode).HasColumnName("FK_AccountSysCode");
            entity.Property(e => e.FkDocsysCode).HasColumnName("FK_DocsysCode");
            entity.Property(e => e.InvoiceDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IsDeleteOnServer).HasDefaultValue(true);
            entity.Property(e => e.OnChangeSysDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.OnChangeSysShamsiDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("([dbo].[funsundate](NULL))")
                .IsFixedLength();
            entity.Property(e => e.OnChangeUserId).HasDefaultValueSql("([dbo].[funuserid]())");
            entity.Property(e => e.PaymentDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RecivedDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.SysDate).HasColumnType("datetime");
            entity.Property(e => e.VisitorAmount).HasColumnType("money");
        });

        modelBuilder.Entity<ChangeinvoiceDetailTbl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ChangeinvoiceDetailTbl");

            entity.Property(e => e.Comment).HasMaxLength(300);
            entity.Property(e => e.DateExpire)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Fee).HasColumnType("money");
            entity.Property(e => e.FkInvoiceSysCode).HasColumnName("FK_InvoiceSysCode");
            entity.Property(e => e.OnChangeSysDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.OnChangeSysShamsiDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("([dbo].[funsundate](NULL))")
                .IsFixedLength();
            entity.Property(e => e.OnChangeUserId).HasDefaultValueSql("([dbo].[funuserid]())");
            entity.Property(e => e.SerialNo).HasMaxLength(100);
            entity.Property(e => e.Term).HasMaxLength(1000);
            entity.Property(e => e.Unit).HasMaxLength(100);
            entity.Property(e => e.UserPrice).HasColumnType("money");
        });

        modelBuilder.Entity<ChartLayoutTbl>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ChartLay__3214EC2716E45895");

            entity.ToTable("ChartLayoutTBL");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ChartName).HasMaxLength(1000);
            entity.Property(e => e.FkUid).HasColumnName("FK_UID");
            entity.Property(e => e.Lang).HasMaxLength(10);
            entity.Property(e => e.Xmldata).HasColumnName("XMLdata");
        });

        modelBuilder.Entity<CheckInCreditStatusTbl>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CheckInC__3214EC2728A929D3");

            entity.ToTable("CheckInCreditStatusTBL");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Comment).HasMaxLength(1000);
            entity.Property(e => e.Title).HasMaxLength(50);
        });

        modelBuilder.Entity<CheckInStatusTbl>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CheckInS__3214EC273A5D3D2F");

            entity.ToTable("CheckInStatusTBL");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Title).HasMaxLength(50);
        });

        modelBuilder.Entity<CheckInTbl>(entity =>
        {
            entity.HasKey(e => e.FkDocSysCode);

            entity.ToTable("CheckInTBL", tb =>
                {
                    tb.HasTrigger("TRGOnDeleteCheckIn");
                    tb.HasTrigger("TRGOnInsertCheckIn");
                    tb.HasTrigger("TRGOnUpdateCheckIn");
                });

            entity.Property(e => e.FkDocSysCode)
                .ValueGeneratedNever()
                .HasColumnName("FK_DocSysCode");
            entity.Property(e => e.Accno)
                .HasMaxLength(1000)
                .HasColumnName("ACCNo");
            entity.Property(e => e.BankName).HasMaxLength(1000);
            entity.Property(e => e.BeHesabDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.BeHesabMiladiDate).HasColumnType("datetime");
            entity.Property(e => e.CheckDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CheckMiladiDate).HasColumnType("datetime");
            entity.Property(e => e.Comment).HasMaxLength(1000);
            entity.Property(e => e.FkSayadiInquiryStatus).HasColumnName("FK_SayadiInquiryStatus");
            entity.Property(e => e.IsReject).HasDefaultValue(false);
            entity.Property(e => e.PassDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PassMiladiDate).HasColumnType("datetime");
            entity.Property(e => e.RejectDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RejectMiladiDate).HasColumnType("datetime");
            entity.Property(e => e.SayadiCode).HasMaxLength(20);
            entity.Property(e => e.Smssent).HasColumnName("SMSsent");
            entity.Property(e => e.StatusId).HasColumnName("StatusID");

            entity.HasOne(d => d.BankAccountCodeNavigation).WithMany(p => p.CheckInTbls)
                .HasForeignKey(d => d.BankAccountCode)
                .HasConstraintName("FK_CheckInTBL_BanksTbl");

            entity.HasOne(d => d.BehesabDocCodeNavigation).WithMany(p => p.CheckInTbls)
                .HasForeignKey(d => d.BehesabDocCode)
                .HasConstraintName("FK__CheckInTB__Behes__54C23EC5");

            entity.HasOne(d => d.BelongtoNavigation).WithMany(p => p.CheckInTbls)
                .HasForeignKey(d => d.Belongto)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_CheckInTBL_Belongto");

            entity.HasOne(d => d.FkDocSysCodeNavigation).WithOne(p => p.CheckInTbl)
                .HasForeignKey<CheckInTbl>(d => d.FkDocSysCode)
                .HasConstraintName("FK_CheckInTBL_DocDetailTbl");

            entity.HasOne(d => d.FkSayadiInquiryStatusNavigation).WithMany(p => p.CheckInTbls)
                .HasForeignKey(d => d.FkSayadiInquiryStatus)
                .HasConstraintName("FK__CheckInTB__FK_Sa__749A117A");
        });

        modelBuilder.Entity<CheckInsForPrintTbl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CheckInsForPrintTBL");

            entity.Property(e => e.Accno)
                .HasMaxLength(1000)
                .HasColumnName("ACCNo");
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.BankName).HasMaxLength(1000);
            entity.Property(e => e.CheckDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<CheckOuttbl>(entity =>
        {
            entity.HasKey(e => e.FkDocSysCode);

            entity.ToTable("CheckOUTTBL", tb => tb.HasTrigger("TRGOnDeleteCheckOUT"));

            entity.Property(e => e.FkDocSysCode)
                .ValueGeneratedNever()
                .HasColumnName("FK_DocSysCode");
            entity.Property(e => e.CheckDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CheckMiladiDate).HasColumnType("datetime");
            entity.Property(e => e.Comment).HasMaxLength(1000);
            entity.Property(e => e.FkBankAccount).HasColumnName("FK_BankAccount");

            entity.HasOne(d => d.BelongtoNavigation).WithMany(p => p.CheckOuttbls)
                .HasForeignKey(d => d.Belongto)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_CheckOUTTBL_Belongto");

            entity.HasOne(d => d.FkBankAccountNavigation).WithMany(p => p.CheckOuttbls)
                .HasForeignKey(d => d.FkBankAccount)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CheckOUTTBL_Bank");

            entity.HasOne(d => d.FkDocSysCodeNavigation).WithOne(p => p.CheckOuttbl)
                .HasForeignKey<CheckOuttbl>(d => d.FkDocSysCode)
                .HasConstraintName("FK_CheckOUTTBL_detail");
        });

        modelBuilder.Entity<CityTbl>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PK__CityTbl__511AFFBC");

            entity.ToTable("CityTbl");

            entity.Property(e => e.Code).ValueGeneratedNever();
            entity.Property(e => e.FkOstan).HasColumnName("FK_Ostan");
            entity.Property(e => e.Name).HasMaxLength(200);

            entity.HasOne(d => d.FkOstanNavigation).WithMany(p => p.CityTbls)
                .HasForeignKey(d => d.FkOstan)
                .HasConstraintName("FK__CityTbl__FK_Osta__520F23F5");
        });

        modelBuilder.Entity<CodeMngdwntbl>(entity =>
        {
            entity.HasKey(e => e.AccountSysCode);

            entity.ToTable("CodeMNGDWNTbl", tb => tb.HasTrigger("TRGOnDeleteCodeMNGDWNTbl"));

            entity.Property(e => e.CreditLimit).HasColumnType("money");
            entity.Property(e => e.FkAccountSysCode0).HasColumnName("FK_AccountSysCode0");
            entity.Property(e => e.IsUpdate).HasDefaultValue(true);

            entity.HasOne(d => d.FkAccountSysCode0Navigation).WithMany(p => p.CodeMngdwntbls)
                .HasForeignKey(d => d.FkAccountSysCode0)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CodeMNGDWNTbl_CodeMNGUPTbl");

            entity.HasOne(d => d.SecurLevelNavigation).WithMany(p => p.CodeMngdwntbls)
                .HasForeignKey(d => d.SecurLevel)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CodeMNGDWNTbl_securlevel");
        });

        modelBuilder.Entity<CodeMnguptbl>(entity =>
        {
            entity.HasKey(e => e.AccountSysCode0);

            entity.ToTable("CodeMNGUPTbl");

            entity.Property(e => e.AccountSysCode0).ValueGeneratedNever();

            entity.HasOne(d => d.KindNavigation).WithMany(p => p.CodeMnguptbls)
                .HasForeignKey(d => d.Kind)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CodeMNGUPTbl_AccountType");
        });

        modelBuilder.Entity<ConsumedGoodsTbl>(entity =>
        {
            entity.HasKey(e => e.SysCode).HasName("PK__ConsumedGoodsTBL__26EFBBC6");

            entity.ToTable("ConsumedGoodsTBL");

            entity.Property(e => e.FkConsumedGoods).HasColumnName("FK_ConsumedGoods");
            entity.Property(e => e.Qty).HasColumnName("QTY");

            entity.HasOne(d => d.FkConsumedGoodsNavigation).WithMany(p => p.ConsumedGoodsTbls)
                .HasForeignKey(d => d.FkConsumedGoods)
                .HasConstraintName("FK__ConsumedG__FK_Co__27E3DFFF");
        });

        modelBuilder.Entity<ContactImagesTbl>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ContactI__3214EC27E7B2E5C9");

            entity.ToTable("ContactImagesTBL");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.FkTelBookId).HasColumnName("FK_TelBookID");
            entity.Property(e => e.ImageName).HasMaxLength(100);
            entity.Property(e => e.Images).HasColumnType("image");

            entity.HasOne(d => d.FkTelBook).WithMany(p => p.ContactImagesTbls)
                .HasForeignKey(d => d.FkTelBookId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ContactIm__FK_Te__6FF48C97");
        });

        modelBuilder.Entity<CostGroup1Tbl>(entity =>
        {
            entity.HasKey(e => e.GroupId);

            entity.ToTable("CostGroup1Tbl");

            entity.HasIndex(e => e.GroupName, "IX_CostGroup1Tbl").IsUnique();

            entity.Property(e => e.GroupName).HasMaxLength(100);
        });

        modelBuilder.Entity<CostGroup2Tbl>(entity =>
        {
            entity.HasKey(e => e.GroupId);

            entity.ToTable("CostGroup2Tbl");

            entity.Property(e => e.GroupName).HasMaxLength(100);
        });

        modelBuilder.Entity<CostTbl>(entity =>
        {
            entity.HasKey(e => e.FkAccountSyscode);

            entity.ToTable("CostTbl");

            entity.Property(e => e.FkAccountSyscode)
                .ValueGeneratedNever()
                .HasColumnName("Fk_AccountSyscode");
            entity.Property(e => e.GroupId1)
                .HasDefaultValue(1)
                .HasColumnName("GroupID1");
            entity.Property(e => e.GroupId2)
                .HasDefaultValue(1)
                .HasColumnName("GroupID2");

            entity.HasOne(d => d.FkAccountSyscodeNavigation).WithOne(p => p.CostTbl)
                .HasForeignKey<CostTbl>(d => d.FkAccountSyscode)
                .HasConstraintName("FK_CostTbl_CodeMNGDWNTbl");

            entity.HasOne(d => d.GroupId1Navigation).WithMany(p => p.CostTbls)
                .HasForeignKey(d => d.GroupId1)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_CostTbl_CostGroup1Tbl");

            entity.HasOne(d => d.GroupId2Navigation).WithMany(p => p.CostTbls)
                .HasForeignKey(d => d.GroupId2)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_CostTbl_CostGroup2Tbl");
        });

        modelBuilder.Entity<CurrencyTbl>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Currency__3214EC277740A8A4");

            entity.ToTable("CurrencyTBL");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CultureName).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Price).HasColumnType("money");
            entity.Property(e => e.ShamsiUpdateDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Title).HasMaxLength(50);
            entity.Property(e => e.UpdateTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<DashbordLayoutTbl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DashbordLayoutTBL");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Title).HasMaxLength(1000);
            entity.Property(e => e.UseCurrentDatabase).HasDefaultValue(true);
            entity.Property(e => e.Xmldata).HasColumnName("XMLdata");
        });

        modelBuilder.Entity<DataBaseSettingTbl>(entity =>
        {
            entity.HasKey(e => e.Syscode).HasName("PK_DataBaseSetting");

            entity.ToTable("DataBaseSettingTBL");

            entity.Property(e => e.Syscode).HasColumnName("syscode");
            entity.Property(e => e.KeyName).HasMaxLength(1000);
            entity.Property(e => e.KeyValue).HasMaxLength(4000);
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<DataLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DataLog");

            entity.Property(e => e.Comment).HasMaxLength(4000);
            entity.Property(e => e.Source).HasMaxLength(100);
            entity.Property(e => e.SysDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.SysShamsiDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("([dbo].[funsundate](NULL))")
                .IsFixedLength();
            entity.Property(e => e.UserId).HasDefaultValueSql("([dbo].[funuserid]())");

            entity.HasOne(d => d.ActionNavigation).WithMany()
                .HasForeignKey(d => d.Action)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DataLog_InfoType");
        });

        modelBuilder.Entity<DefaultPrintInfoLay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DefaultP__3214EC07E01E139F");

            entity.Property(e => e.FkPrintLayoutId).HasColumnName("Fk_PrintLayoutId");

            entity.HasOne(d => d.FkPrintLayout).WithMany(p => p.DefaultPrintInfoLays)
                .HasForeignKey(d => d.FkPrintLayoutId)
                .HasConstraintName("FK__DefaultPr__Fk_Pr__206E7217");

            entity.HasOne(d => d.PrintInfo).WithMany(p => p.DefaultPrintInfoLays)
                .HasForeignKey(d => d.PrintInfoId)
                .HasConstraintName("FK__DefaultPr__Print__2256BA89");

            entity.HasOne(d => d.User).WithMany(p => p.DefaultPrintInfoLays)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__DefaultPr__UserI__21629650");
        });

        modelBuilder.Entity<DeletedCodeMngdwntbl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DeletedCodeMNGDWNTbl");

            entity.Property(e => e.CreditLimit).HasColumnType("money");
            entity.Property(e => e.FkAccountSysCode0).HasColumnName("FK_AccountSysCode0");
        });

        modelBuilder.Entity<DisCountCardTbl>(entity =>
        {
            entity.HasKey(e => e.SerialNo).HasName("PK__DisCountCardTBL__23DE44F1");

            entity.ToTable("DisCountCardTBL");

            entity.Property(e => e.SerialNo).HasMaxLength(200);
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.BuyAmount).HasColumnType("money");
            entity.Property(e => e.ExpDate).HasColumnType("datetime");
            entity.Property(e => e.ExpDateShamsi)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.FkAccountSysCode).HasColumnName("FK_AccountSysCode");
            entity.Property(e => e.FkInvoiceSrialNo).HasColumnName("FK_InvoiceSrialNo");
        });

        modelBuilder.Entity<DiscountCardTransactionTbl>(entity =>
        {
            entity.HasKey(e => e.SysCode).HasName("PK__DiscountCardTran__26BAB19C");

            entity.ToTable("DiscountCardTransactionTbl");

            entity.Property(e => e.CardNo).HasMaxLength(16);
            entity.Property(e => e.Checked).HasColumnName("checked");
            entity.Property(e => e.Err).HasMaxLength(1000);
            entity.Property(e => e.FkSerialInvoiceNo).HasColumnName("FK_SerialInvoiceNo");
            entity.Property(e => e.InvoiceAmount).HasColumnType("money");
            entity.Property(e => e.SysDate).HasColumnType("datetime");
            entity.Property(e => e.SysShamsiDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TotalDedicatedCredit).HasColumnType("money");
            entity.Property(e => e.TransactionDedicatedCredit).HasColumnType("money");
        });

        modelBuilder.Entity<DiscountModelsTbl>(entity =>
        {
            entity.HasKey(e => e.SysCode).HasName("PK__DiscountModelsTB__4C214075");

            entity.ToTable("DiscountModelsTBL");

            entity.Property(e => e.GetAmmount).HasColumnType("money");
            entity.Property(e => e.SharjAmmount).HasColumnType("money");
        });

        modelBuilder.Entity<DistributionDetailTbl>(entity =>
        {
            entity.HasKey(e => e.SysCode).HasName("PK__Distribu__EE72712D152ADE2B");

            entity.ToTable("DistributionDetailTBL");

            entity.Property(e => e.Comment)
                .HasMaxLength(1000)
                .HasDefaultValue("");
            entity.Property(e => e.Field1)
                .HasMaxLength(1000)
                .HasDefaultValue("");
            entity.Property(e => e.Field2)
                .HasMaxLength(1000)
                .HasDefaultValue("");
            entity.Property(e => e.Field3)
                .HasMaxLength(1000)
                .HasDefaultValue("");
            entity.Property(e => e.FkDistributionSerial).HasColumnName("FK_DistributionSerial");
            entity.Property(e => e.FkInvoiceSerial).HasColumnName("FK_InvoiceSerial");

            entity.HasOne(d => d.FkDistributionSerialNavigation).WithMany(p => p.DistributionDetailTbls)
                .HasForeignKey(d => d.FkDistributionSerial)
                .HasConstraintName("FK__Distribut__FK_Di__11FF8BD8");

            entity.HasOne(d => d.FkInvoiceSerialNavigation).WithMany(p => p.DistributionDetailTbls)
                .HasForeignKey(d => d.FkInvoiceSerial)
                .HasConstraintName("FK__Distribut__FK_In__110B679F");
        });

        modelBuilder.Entity<DistributionTbl>(entity =>
        {
            entity.HasKey(e => e.DistributionSerial).HasName("PK__Distribu__F8C3E3A57BF82040");

            entity.ToTable("DistributionTBL");

            entity.Property(e => e.Comment)
                .HasMaxLength(1000)
                .HasDefaultValue("");
            entity.Property(e => e.DistributionDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Field1)
                .HasMaxLength(1000)
                .HasDefaultValue("");
            entity.Property(e => e.Field2)
                .HasMaxLength(1000)
                .HasDefaultValue("");
            entity.Property(e => e.Field3)
                .HasMaxLength(1000)
                .HasDefaultValue("");
            entity.Property(e => e.FkCarId).HasColumnName("FK_CarID");
            entity.Property(e => e.FkDistributorSysCode).HasColumnName("FK_DistributorSysCode");
            entity.Property(e => e.FkDriverSysCode).HasColumnName("FK_DriverSysCode");
            entity.Property(e => e.SysMiladiDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.SysShamsiDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("([dbo].[Funsundate](getdate()))")
                .IsFixedLength();

            entity.HasOne(d => d.FkCar).WithMany(p => p.DistributionTbls)
                .HasForeignKey(d => d.FkCarId)
                .HasConstraintName("FK__Distribut__FK_Ca__068DD92C");

            entity.HasOne(d => d.FkDistributorSysCodeNavigation).WithMany(p => p.DistributionTblFkDistributorSysCodeNavigations)
                .HasForeignKey(d => d.FkDistributorSysCode)
                .HasConstraintName("FK__Distribut__FK_Di__7EECB764");

            entity.HasOne(d => d.FkDriverSysCodeNavigation).WithMany(p => p.DistributionTblFkDriverSysCodeNavigations)
                .HasForeignKey(d => d.FkDriverSysCode)
                .HasConstraintName("FK__Distribut__FK_Dr__7DF8932B");

            entity.HasOne(d => d.UserNoNavigation).WithMany(p => p.DistributionTbls)
                .HasForeignKey(d => d.UserNo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Distribut__UserN__03B16C81");
        });

        modelBuilder.Entity<DocDetailTbl>(entity =>
        {
            entity.HasKey(e => e.Syscode);

            entity.ToTable("DocDetailTbl", tb =>
                {
                    tb.HasTrigger("TRGOnDeleteDocDetail");
                    tb.HasTrigger("TRGOnUpdateDocDetail");
                });

            entity.Property(e => e.AmmountIn)
                .HasColumnType("money")
                .HasColumnName("AmmountIN");
            entity.Property(e => e.AmmountOut)
                .HasColumnType("money")
                .HasColumnName("AmmountOUT");
            entity.Property(e => e.ArchiveName).HasMaxLength(1000);
            entity.Property(e => e.Comment).HasMaxLength(1000);
            entity.Property(e => e.Cur1Amount).HasColumnType("money");
            entity.Property(e => e.Cur2Amount).HasColumnType("money");
            entity.Property(e => e.Cur3Amount).HasColumnType("money");
            entity.Property(e => e.FkAccountId)
                .HasDefaultValue(173)
                .HasColumnName("Fk_AccountId");
            entity.Property(e => e.FkAccountSyscode).HasColumnName("Fk_AccountSyscode");
            entity.Property(e => e.FkDocSysCode).HasColumnName("Fk_docSysCode");
            entity.Property(e => e.FkVisitorSysCode).HasColumnName("FK_VisitorSysCode");
            entity.Property(e => e.IsUpdate).HasDefaultValue(true);
            entity.Property(e => e.SndFkAccountSyscode).HasColumnName("SndFk_AccountSyscode");

            entity.HasOne(d => d.FkAccount).WithMany(p => p.DocDetailTbls)
                .HasForeignKey(d => d.FkAccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DocDetail__Fk_Ac__096B112E");

            entity.HasOne(d => d.FkAccountSyscodeNavigation).WithMany(p => p.DocDetailTbls)
                .HasForeignKey(d => d.FkAccountSyscode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DocDetailTbl_CodeMNGDWNTbl");

            entity.HasOne(d => d.FkDocSysCodeNavigation).WithMany(p => p.DocDetailTbls)
                .HasForeignKey(d => d.FkDocSysCode)
                .HasConstraintName("FK_DocDetailTbl_DocTbl");
        });

        modelBuilder.Entity<DocLinkSndTbl>(entity =>
        {
            entity.HasKey(e => e.FkFstDocDetail).HasName("PK__DocLinkS__450EFCF1873D3D75");

            entity.ToTable("DocLinkSndTBL");

            entity.Property(e => e.FkFstDocDetail)
                .ValueGeneratedNever()
                .HasColumnName("FK_FstDocDetail");
            entity.Property(e => e.FkMainDocDetail).HasColumnName("FK_MainDocDetail");
            entity.Property(e => e.FkSndDocDetail).HasColumnName("FK_SndDocDetail");

            entity.HasOne(d => d.FkFstDocDetailNavigation).WithOne(p => p.DocLinkSndTblFkFstDocDetailNavigation)
                .HasForeignKey<DocLinkSndTbl>(d => d.FkFstDocDetail)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DocLinkSn__FK_Fs__0CE69C57");

            entity.HasOne(d => d.FkMainDocDetailNavigation).WithMany(p => p.DocLinkSndTblFkMainDocDetailNavigations)
                .HasForeignKey(d => d.FkMainDocDetail)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DocLinkSn__FK_Ma__0ECEE4C9");

            entity.HasOne(d => d.FkSndDocDetailNavigation).WithMany(p => p.DocLinkSndTblFkSndDocDetailNavigations)
                .HasForeignKey(d => d.FkSndDocDetail)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DocLinkSn__FK_Sn__0DDAC090");
        });

        modelBuilder.Entity<DocLinkTbl>(entity =>
        {
            entity.HasKey(e => e.FkFstDocDetail);

            entity.ToTable("DocLinkTBL", tb => tb.HasTrigger("TRGOnUpdateDocLink"));

            entity.Property(e => e.FkFstDocDetail)
                .ValueGeneratedNever()
                .HasColumnName("FK_FstDocDetail");
            entity.Property(e => e.FkSndDocDetail).HasColumnName("FK_SndDocDetail");

            entity.HasOne(d => d.FkFstDocDetailNavigation).WithOne(p => p.DocLinkTblFkFstDocDetailNavigation)
                .HasForeignKey<DocLinkTbl>(d => d.FkFstDocDetail)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DocLinkTBL_DocDetailTbl");

            entity.HasOne(d => d.FkSndDocDetailNavigation).WithMany(p => p.DocLinkTblFkSndDocDetailNavigations)
                .HasForeignKey(d => d.FkSndDocDetail)
                .HasConstraintName("FK_DocLinkTBL_DocDetailTbl1");
        });

        modelBuilder.Entity<DocTbl>(entity =>
        {
            entity.HasKey(e => e.SysCode);

            entity.ToTable("DocTbl", tb => tb.HasTrigger("TRGOnDeleteDoc"));

            entity.Property(e => e.ArchiveName).HasMaxLength(1000);
            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.Comment).HasMaxLength(1000);
            entity.Property(e => e.CurBaseRate1).HasColumnType("decimal(12, 6)");
            entity.Property(e => e.CurBaseRate2).HasColumnType("decimal(12, 6)");
            entity.Property(e => e.CurBaseRate3).HasColumnType("decimal(12, 6)");
            entity.Property(e => e.CurRate1Part2).HasColumnType("decimal(12, 6)");
            entity.Property(e => e.CurRate2Part2).HasColumnType("decimal(12, 6)");
            entity.Property(e => e.CurRate3Part2).HasColumnType("decimal(12, 6)");
            entity.Property(e => e.DocDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DocMiladiDate).HasColumnType("datetime");
            entity.Property(e => e.FkProjectId).HasColumnName("Fk_ProjectID");
            entity.Property(e => e.FkTypeId)
                .HasDefaultValue((byte)2)
                .HasColumnName("Fk_TypeID");
            entity.Property(e => e.FkYearId)
                .HasDefaultValue((byte)1)
                .HasColumnName("Fk_YearId");
            entity.Property(e => e.Lock).HasDefaultValue(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.StrCode).HasMaxLength(13);
            entity.Property(e => e.SysDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.SysShamsiDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("([dbo].[funsundate](NULL))")
                .IsFixedLength();
            entity.Property(e => e.UserIdno)
                .HasDefaultValueSql("([dbo].[FunUserId]())")
                .HasColumnName("UserIDNO");

            entity.HasOne(d => d.FkProject).WithMany(p => p.DocTbls)
                .HasForeignKey(d => d.FkProjectId)
                .HasConstraintName("FK__DocTbl__Fk_Proje__0FE30493");

            entity.HasOne(d => d.FkType).WithMany(p => p.DocTbls)
                .HasForeignKey(d => d.FkTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DocTbl__Fk_TypeI__10D728CC");

            entity.HasOne(d => d.FkYear).WithMany(p => p.DocTbls)
                .HasForeignKey(d => d.FkYearId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DocTbl__Fk_YearI__0758AB8A");

            entity.HasOne(d => d.UserIdnoNavigation).WithMany(p => p.DocTbls)
                .HasForeignKey(d => d.UserIdno)
                .HasConstraintName("FK_DocTbl_Users");
        });

        modelBuilder.Entity<DocTypeTbl>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DocTypeT__3214EC270CEEC06C");

            entity.ToTable("DocTypeTBL");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Title).HasMaxLength(100);
        });

        modelBuilder.Entity<FactorPrintLayoutPrinterTbl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FactorPrintLayout_PrinterTBL");

            entity.Property(e => e.PrinterName).HasMaxLength(1000);
        });

        modelBuilder.Entity<FinancialYear>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Financia__3214EC07F35BAF60");

            entity.ToTable("FinancialYear");

            entity.Property(e => e.EndDateMiladi).HasColumnType("datetime");
            entity.Property(e => e.EndDateShamsi)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RegisterDate).HasColumnType("datetime");
            entity.Property(e => e.StartDateMiladi).HasColumnType("datetime");
            entity.Property(e => e.StartDateShamsi)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Title).HasMaxLength(100);
        });

        modelBuilder.Entity<FormLayoutTbl>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__FormLayoutTBL__2E5BD364");

            entity.ToTable("FormLayoutTBL");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.FkUid).HasColumnName("FK_UID");
            entity.Property(e => e.FormName).HasMaxLength(1000);
            entity.Property(e => e.LanguageId).HasDefaultValue((byte)1);
            entity.Property(e => e.Xmldata).HasColumnName("XMLdata");
        });

        modelBuilder.Entity<GhestForPrint>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GhestForPrint");
        });

        modelBuilder.Entity<GhestInTbl>(entity =>
        {
            entity.HasKey(e => e.FkDocSysCode);

            entity.ToTable("GhestInTBL", tb => tb.HasTrigger("TRGOnDeleteGhestInTBL"));

            entity.Property(e => e.FkDocSysCode)
                .ValueGeneratedNever()
                .HasColumnName("FK_DocSysCode");
            entity.Property(e => e.Comment).HasMaxLength(1000);
            entity.Property(e => e.Date)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MiladiDate).HasColumnType("datetime");
            entity.Property(e => e.PassDate).HasMaxLength(10);
            entity.Property(e => e.PassMiladiDate).HasColumnType("datetime");
            entity.Property(e => e.Smssent).HasColumnName("SMSsent");
            entity.Property(e => e.SysCode).ValueGeneratedOnAdd();

            entity.HasOne(d => d.BelongtoNavigation).WithMany(p => p.GhestInTbls)
                .HasForeignKey(d => d.Belongto)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_GhestInTBL_Belongto");

            entity.HasOne(d => d.FkDocSysCodeNavigation).WithOne(p => p.GhestInTbl)
                .HasForeignKey<GhestInTbl>(d => d.FkDocSysCode)
                .HasConstraintName("FK_GhestInTBL_DocDetailTbl");
        });

        modelBuilder.Entity<GoodColorTbl>(entity =>
        {
            entity.HasKey(e => e.SysCode);

            entity.ToTable("GoodColorTbl");

            entity.Property(e => e.ColorName).HasMaxLength(1000);

            entity.HasOne(d => d.GoodSysCodeNavigation).WithMany(p => p.GoodColorTbls)
                .HasForeignKey(d => d.GoodSysCode)
                .HasConstraintName("FK_GoodColorTbl_Stock");
        });

        modelBuilder.Entity<GoodSizeTbl>(entity =>
        {
            entity.HasKey(e => e.SysCode);

            entity.ToTable("GoodSizeTbl");

            entity.Property(e => e.SizeName).HasMaxLength(1000);

            entity.HasOne(d => d.GoodSysCodeNavigation).WithMany(p => p.GoodSizeTbls)
                .HasForeignKey(d => d.GoodSysCode)
                .HasConstraintName("FK_GoodSizeTbl_stock");
        });

        modelBuilder.Entity<GoodVisitorTbl>(entity =>
        {
            entity.HasKey(e => e.SysCode).HasName("PK__GoodVisitorTBL__0682EC34");

            entity.ToTable("GoodVisitorTBL");

            entity.Property(e => e.MarjoFee).HasColumnType("money");
            entity.Property(e => e.SaleFee).HasColumnType("money");

            entity.HasOne(d => d.AccountSysCodeNavigation).WithMany(p => p.GoodVisitorTbls)
                .HasForeignKey(d => d.AccountSysCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__GoodVisit__Accou__0777106D");

            entity.HasOne(d => d.GoodSysCodeNavigation).WithMany(p => p.GoodVisitorTbls)
                .HasForeignKey(d => d.GoodSysCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__GoodVisit__GoodS__086B34A6");
        });

        modelBuilder.Entity<GoodWarehouseTbl>(entity =>
        {
            entity.HasKey(e => e.SysCode).HasName("PK__GoodWarehouseTBL__60E75331");

            entity.ToTable("GoodWarehouseTBL");

            entity.Property(e => e.MaxQty).HasColumnName("MaxQTY");

            entity.HasOne(d => d.GoodSysCodeNavigation).WithMany(p => p.GoodWarehouseTbls)
                .HasForeignKey(d => d.GoodSysCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__GoodWareh__GoodS__62CF9BA3");

            entity.HasOne(d => d.WareHouseSysCodeNavigation).WithMany(p => p.GoodWarehouseTbls)
                .HasForeignKey(d => d.WareHouseSysCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__GoodWareh__WareH__61DB776A");
        });

        modelBuilder.Entity<GoodsCategoryTbl>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__GoodsCat__3214EC27F4F7FD70");

            entity.ToTable("GoodsCategoryTBL", tb =>
                {
                    tb.HasTrigger("RGONDeleteGoodCategory");
                    tb.HasTrigger("RGONUpdateGoodCategory");
                });

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CatImage).HasColumnType("image");
            entity.Property(e => e.CatImageUrl)
                .HasMaxLength(200)
                .HasDefaultValue("")
                .HasColumnName("CatImageURL");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.Title).HasMaxLength(200);
        });

        modelBuilder.Entity<GoodsGalleriesTbl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GoodsGalleriesTbl");

            entity.Property(e => e.FkGoodSysCode).HasColumnName("FK_GoodSysCode");
            entity.Property(e => e.ImageName).HasMaxLength(300);
            entity.Property(e => e.SysCode).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<GoodsGroup1PersonAccountTbl>(entity =>
        {
            entity.HasKey(e => e.Syscode).HasName("PK__GoodsGroup1Perso__3BEAD8AC");

            entity.ToTable("GoodsGroup1PersonAccountTBL");

            entity.Property(e => e.Syscode).HasColumnName("syscode");

            entity.HasOne(d => d.AccountSysCodeNavigation).WithMany(p => p.GoodsGroup1PersonAccountTbls)
                .HasForeignKey(d => d.AccountSysCode)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__GoodsGrou__Accou__3CDEFCE5");
        });

        modelBuilder.Entity<GoodsGroup2PersonAccountTbl>(entity =>
        {
            entity.HasKey(e => e.Syscode).HasName("PK__GoodsGroup2Perso__3EC74557");

            entity.ToTable("GoodsGroup2PersonAccountTBL");

            entity.Property(e => e.Syscode).HasColumnName("syscode");

            entity.HasOne(d => d.AccountSysCodeNavigation).WithMany(p => p.GoodsGroup2PersonAccountTbls)
                .HasForeignKey(d => d.AccountSysCode)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__GoodsGrou__Accou__3FBB6990");
        });

        modelBuilder.Entity<GoodsImagesTbl>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__GoodsImagesTBL__00CA12DE");

            entity.ToTable("GoodsImagesTBL", tb => tb.HasTrigger("RGONUpdateGoodImage"));

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.FkGoodSysCode).HasColumnName("FK_GoodSysCode");
            entity.Property(e => e.ImageName).HasMaxLength(100);
            entity.Property(e => e.Images).HasColumnType("image");

            entity.HasOne(d => d.FkGoodSysCodeNavigation).WithMany(p => p.GoodsImagesTbls)
                .HasForeignKey(d => d.FkGoodSysCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__GoodsImag__FK_Go__01BE3717");
        });

        modelBuilder.Entity<GoodsOfStockForPrint>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GoodsOfStockForPrint");
        });

        modelBuilder.Entity<GoodsQuotaTbl>(entity =>
        {
            entity.HasKey(e => e.SysCode).HasName("PK__GoodsQuo__EE72712DB410CD61");

            entity.ToTable("GoodsQuotaTBL");

            entity.Property(e => e.EndDateMiladi).HasColumnType("datetime");
            entity.Property(e => e.EndDateShamsi)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.FkAccountSysCode).HasColumnName("FK_AccountSysCode");
            entity.Property(e => e.FkGoodSysCode).HasColumnName("FK_GoodSysCode");
            entity.Property(e => e.FkWareHouseId).HasColumnName("FK_WareHouseID");
            entity.Property(e => e.SartDateShamsi)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.StartDateMiladi).HasColumnType("datetime");

            entity.HasOne(d => d.FkAccountSysCodeNavigation).WithMany(p => p.GoodsQuotaTbls)
                .HasForeignKey(d => d.FkAccountSysCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__GoodsQuot__FK_Ac__2E11BAA1");

            entity.HasOne(d => d.FkGoodSysCodeNavigation).WithMany(p => p.GoodsQuotaTbls)
                .HasForeignKey(d => d.FkGoodSysCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__GoodsQuot__FK_Go__2C29722F");

            entity.HasOne(d => d.FkWareHouse).WithMany(p => p.GoodsQuotaTbls)
                .HasForeignKey(d => d.FkWareHouseId)
                .HasConstraintName("FK__GoodsQuot__FK_Wa__2D1D9668");
        });

        modelBuilder.Entity<GpstrackingTbl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GPSTrackingTBL");

            entity.Property(e => e.Dt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("DT");
            entity.Property(e => e.FkAccountSysCode).HasColumnName("Fk_AccountSysCode");
            entity.Property(e => e.Lat).HasMaxLength(15);
            entity.Property(e => e.Long).HasMaxLength(15);
            entity.Property(e => e.ShamsiDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TrackingId).ValueGeneratedOnAdd();

            entity.HasOne(d => d.FkAccountSysCodeNavigation).WithMany()
                .HasForeignKey(d => d.FkAccountSysCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__GPSTracki__Fk_Ac__48DABF76");
        });

        modelBuilder.Entity<GridFilterTitleTbl>(entity =>
        {
            entity.HasKey(e => e.SysCode);

            entity.ToTable("GridFilterTitleTbl");

            entity.Property(e => e.DisplayText).HasMaxLength(1000);
        });

        modelBuilder.Entity<GridLayOutFilterTbl>(entity =>
        {
            entity.HasKey(e => e.SysCode);

            entity.ToTable("GridLayOutFilterTbl");

            entity.Property(e => e.Field).HasMaxLength(1000);
            entity.Property(e => e.FilterText).HasMaxLength(1000);
            entity.Property(e => e.FkFilterId).HasColumnName("FK_FilterId");

            entity.HasOne(d => d.FkFilter).WithMany(p => p.GridLayOutFilterTbls)
                .HasForeignKey(d => d.FkFilterId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_GridLayOutFilterTbl_GridFilterTitleTbl");
        });

        modelBuilder.Entity<GridLayout>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Fkid).HasColumnName("FKID");
            entity.Property(e => e.LayoutName).HasMaxLength(200);
            entity.Property(e => e.Xmldata).HasColumnName("XMLdata");

            entity.HasOne(d => d.Fk).WithMany(p => p.GridLayouts)
                .HasForeignKey(d => d.Fkid)
                .HasConstraintName("FK_GridLayouts_GridsInfo");
        });

        modelBuilder.Entity<GridsInfo>(entity =>
        {
            entity.ToTable("GridsInfo");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.DeleteStp).HasMaxLength(100);
            entity.Property(e => e.DetailRef).HasMaxLength(100);
            entity.Property(e => e.DisplayName).HasMaxLength(1000);
            entity.Property(e => e.Field1name).HasMaxLength(1000);
            entity.Property(e => e.Field2name).HasMaxLength(1000);
            entity.Property(e => e.InsertStp).HasMaxLength(100);
            entity.Property(e => e.PolicyComment).HasMaxLength(1000);
            entity.Property(e => e.PrintStPname)
                .HasMaxLength(100)
                .HasColumnName("PrintStPName");
            entity.Property(e => e.RefrenceName).HasMaxLength(1000);
            entity.Property(e => e.RelationColumn).HasMaxLength(100);
            entity.Property(e => e.RemainField).HasMaxLength(1000);
            entity.Property(e => e.Stpname)
                .HasMaxLength(1000)
                .HasColumnName("STPname");
            entity.Property(e => e.Syscodefield).HasMaxLength(100);
            entity.Property(e => e.TableName).HasMaxLength(100);
            entity.Property(e => e.UpdateStp)
                .HasMaxLength(100)
                .HasColumnName("UpdateSTP");
        });

        modelBuilder.Entity<Group>(entity =>
        {
            entity.HasKey(e => e.Gid);

            entity.Property(e => e.Gid).HasColumnName("GID");
            entity.Property(e => e.Gname).HasMaxLength(1000);
        });

        modelBuilder.Entity<GroupPolicy>(entity =>
        {
            entity.HasKey(e => new { e.Gid, e.Pid });

            entity.Property(e => e.Gid).HasColumnName("GID");
            entity.Property(e => e.Pid).HasColumnName("PID");

            entity.HasOne(d => d.GidNavigation).WithMany(p => p.GroupPolicies)
                .HasForeignKey(d => d.Gid)
                .HasConstraintName("FK_GroupPolicys_Groups");
        });

        modelBuilder.Entity<InfoAccountKind>(entity =>
        {
            entity.HasKey(e => e.KindCode);

            entity.ToTable("InfoAccountKind");

            entity.Property(e => e.KindCode).ValueGeneratedNever();
            entity.Property(e => e.KindTxt).HasMaxLength(50);
        });

        modelBuilder.Entity<InfoBankListForCheckInTbl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("InfoBankListForCheckInTBL");

            entity.Property(e => e.BankName).HasMaxLength(50);
        });

        modelBuilder.Entity<InfoConvCurToStringTbl>(entity =>
        {
            entity.HasKey(e => e.Value);

            entity.ToTable("InfoConvCurToStringTBL");

            entity.Property(e => e.Value).ValueGeneratedNever();
            entity.Property(e => e.Title).HasMaxLength(50);
        });

        modelBuilder.Entity<InfoDataLogAction>(entity =>
        {
            entity.HasKey(e => e.Value);

            entity.ToTable("InfoDataLogAction");

            entity.Property(e => e.Value).ValueGeneratedNever();
            entity.Property(e => e.Description).HasMaxLength(50);
        });

        modelBuilder.Entity<InfoGoodTypeTbl>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PK_GoodTypeTbl");

            entity.ToTable("infoGoodTypeTbl");

            entity.Property(e => e.Code).ValueGeneratedNever();
            entity.Property(e => e.Title).HasMaxLength(1000);
        });

        modelBuilder.Entity<InfoInvoiceType>(entity =>
        {
            entity.HasKey(e => e.Value);

            entity.ToTable("InfoInvoiceType");

            entity.Property(e => e.Value).ValueGeneratedNever();
            entity.Property(e => e.Caption).HasMaxLength(200);
            entity.Property(e => e.Syscode)
                .ValueGeneratedOnAdd()
                .HasColumnName("syscode");
        });

        modelBuilder.Entity<InfoParamDescribtion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("InfoParamDescribtion");

            entity.Property(e => e.EditorType).HasMaxLength(100);
            entity.Property(e => e.ParamDescribtion).HasMaxLength(1000);
            entity.Property(e => e.ParamName).HasMaxLength(100);
            entity.Property(e => e.ParamValue).HasMaxLength(100);
        });

        modelBuilder.Entity<InfoPersonPriceNoTbl>(entity =>
        {
            entity.HasKey(e => e.Value);

            entity.ToTable("InfoPersonPriceNoTbl");

            entity.Property(e => e.Value).ValueGeneratedNever();
            entity.Property(e => e.Caption).HasMaxLength(1000);
        });

        modelBuilder.Entity<InfoSecurityLevelTbl>(entity =>
        {
            entity.HasKey(e => e.Value);

            entity.ToTable("InfoSecurityLevelTbl");

            entity.Property(e => e.Value).ValueGeneratedNever();
            entity.Property(e => e.Caption).HasMaxLength(1000);
        });

        modelBuilder.Entity<InfoSumOfDay>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Gday1).HasColumnName("GDay1");
            entity.Property(e => e.Gday2).HasColumnName("GDay2");
            entity.Property(e => e.Sday1).HasColumnName("SDay1");
            entity.Property(e => e.Sday2).HasColumnName("SDay2");
        });

        modelBuilder.Entity<InternalSettingTbl>(entity =>
        {
            entity.HasKey(e => e.Syscode);

            entity.ToTable("InternalSettingTbl");

            entity.Property(e => e.Key).HasMaxLength(1000);
            entity.Property(e => e.Value).HasMaxLength(1000);
        });

        modelBuilder.Entity<InventoryDetailTbl>(entity =>
        {
            entity.HasKey(e => e.SysCode).HasName("PK__InventoryDetailT__3D9E16F4");

            entity.ToTable("InventoryDetailTbl", tb => tb.HasTrigger("TRGOnDeleteInventoryDetailTbl"));

            entity.Property(e => e.Comment).HasMaxLength(300);
            entity.Property(e => e.DateExpire)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Field1).HasMaxLength(1000);
            entity.Property(e => e.Field2).HasMaxLength(1000);
            entity.Property(e => e.FkInventorySysCode).HasColumnName("FK_InventorySysCode");
            entity.Property(e => e.SerialNo).HasMaxLength(100);
            entity.Property(e => e.Unit).HasMaxLength(100);

            entity.HasOne(d => d.ColorNavigation).WithMany(p => p.InventoryDetailTbls)
                .HasForeignKey(d => d.Color)
                .HasConstraintName("FK__Inventory__Color__407A839F");

            entity.HasOne(d => d.FkInventorySysCodeNavigation).WithMany(p => p.InventoryDetailTbls)
                .HasForeignKey(d => d.FkInventorySysCode)
                .HasConstraintName("FK__Inventory__FK_In__4262CC11");

            entity.HasOne(d => d.GoodSysCodeNavigation).WithMany(p => p.InventoryDetailTbls)
                .HasForeignKey(d => d.GoodSysCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Inventory__GoodS__3E923B2D");

            entity.HasOne(d => d.SizeNavigation).WithMany(p => p.InventoryDetailTbls)
                .HasForeignKey(d => d.Size)
                .HasConstraintName("FK__InventoryD__Size__3F865F66");

            entity.HasOne(d => d.WareHouseNavigation).WithMany(p => p.InventoryDetailTbls)
                .HasForeignKey(d => d.WareHouse)
                .HasConstraintName("FK__Inventory__WareH__416EA7D8");
        });

        modelBuilder.Entity<InventoryTbl>(entity =>
        {
            entity.HasKey(e => e.InventorySerial).HasName("PK__InventoryTBL__3508D0F3");

            entity.ToTable("InventoryTBL", tb =>
                {
                    tb.HasTrigger("TRGOnDeleteInventory");
                    tb.HasTrigger("TRGOnUpdateInventory");
                });

            entity.Property(e => e.CustomerName).HasMaxLength(200);
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.Field1).HasMaxLength(1000);
            entity.Property(e => e.Field2).HasMaxLength(1000);
            entity.Property(e => e.Field3).HasMaxLength(1000);
            entity.Property(e => e.Field4).HasMaxLength(1000);
            entity.Property(e => e.Field5).HasMaxLength(1000);
            entity.Property(e => e.FkAccountSysCode).HasColumnName("FK_AccountSysCode");
            entity.Property(e => e.FkDistributorSysCode).HasColumnName("Fk_DistributorSysCode");
            entity.Property(e => e.FkDriversSysCode).HasColumnName("Fk_DriversSysCode");
            entity.Property(e => e.FkInvoiceSerial).HasColumnName("Fk_InvoiceSerial");
            entity.Property(e => e.FkTransferSerial).HasColumnName("Fk_TransferSerial");
            entity.Property(e => e.FkYearId)
                .HasDefaultValue((byte)1)
                .HasColumnName("Fk_YearId");
            entity.Property(e => e.ShamsiDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ShamsiSysDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.SysDate).HasColumnType("datetime");
            entity.Property(e => e.UserNo).HasDefaultValueSql("([dbo].[FunUserId]())");

            entity.HasOne(d => d.FkAccountSysCodeNavigation).WithMany(p => p.InventoryTbls)
                .HasForeignKey(d => d.FkAccountSysCode)
                .HasConstraintName("FK__Inventory__FK_Ac__0ADD8CFD");

            entity.HasOne(d => d.FkDistributorSysCodeNavigation).WithMany(p => p.InventoryTblFkDistributorSysCodeNavigations)
                .HasForeignKey(d => d.FkDistributorSysCode)
                .HasConstraintName("FK__Inventory__Fk_Di__3BB5CE82");

            entity.HasOne(d => d.FkDriversSysCodeNavigation).WithMany(p => p.InventoryTblFkDriversSysCodeNavigations)
                .HasForeignKey(d => d.FkDriversSysCode)
                .HasConstraintName("FK__Inventory__Fk_Dr__3AC1AA49");

            entity.HasOne(d => d.FkInvoiceSerialNavigation).WithMany(p => p.InventoryTbls)
                .HasForeignKey(d => d.FkInvoiceSerial)
                .HasConstraintName("FK__Inventory__Fk_In__38D961D7");

            entity.HasOne(d => d.FkTransferSerialNavigation).WithMany(p => p.InventoryTbls)
                .HasForeignKey(d => d.FkTransferSerial)
                .HasConstraintName("FK__Inventory__Fk_Tr__39CD8610");

            entity.HasOne(d => d.FkYear).WithMany(p => p.InventoryTbls)
                .HasForeignKey(d => d.FkYearId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Inventory__Fk_Ye__0B293C6E");

            entity.HasOne(d => d.UserNoNavigation).WithMany(p => p.InventoryTbls)
                .HasForeignKey(d => d.UserNo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Inventory__UserN__35FCF52C");
        });

        modelBuilder.Entity<InventoryTypeTbl>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__InventoryTypeTBL__33208881");

            entity.ToTable("InventoryTypeTBL");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Title).HasMaxLength(100);
            entity.Property(e => e.TitleEn)
                .HasMaxLength(100)
                .HasColumnName("Title_En");
        });

        modelBuilder.Entity<InvoiceCostDetailTbl>(entity =>
        {
            entity.HasKey(e => e.SysCode);

            entity.ToTable("InvoiceCostDetailTbl", tb => tb.HasTrigger("TRGOnDeleteInvoiceCostDetailTbl"));

            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.CurAmount).HasColumnType("money");
            entity.Property(e => e.FkFactorSerialNo).HasColumnName("FK_FactorSerialNo");
            entity.Property(e => e.FkInvoiceCostSysCode).HasColumnName("FK_InvoiceCostSysCode");

            entity.HasOne(d => d.FkFactorSerialNoNavigation).WithMany(p => p.InvoiceCostDetailTbls)
                .HasForeignKey(d => d.FkFactorSerialNo)
                .HasConstraintName("FK_InvoiceCostDetailTbl_InvoiceTbl");

            entity.HasOne(d => d.FkInvoiceCostSysCodeNavigation).WithMany(p => p.InvoiceCostDetailTbls)
                .HasForeignKey(d => d.FkInvoiceCostSysCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InvoiceCostDetailTbl_InvoiceCostTbl");
        });

        modelBuilder.Entity<InvoiceCostTbl>(entity =>
        {
            entity.HasKey(e => e.SysCode);

            entity.ToTable("InvoiceCostTbl");

            entity.Property(e => e.Title).HasMaxLength(100);
        });

        modelBuilder.Entity<InvoiceDetailTbl>(entity =>
        {
            entity.HasKey(e => e.SysCode);

            entity.ToTable("invoiceDetailTbl", tb =>
                {
                    tb.HasTrigger("RGONDeleteGoodInvoice_AutoSync");
                    tb.HasTrigger("RGONUpdateGoodInvoice_AutoSync");
                    tb.HasTrigger("TRGOnDeleteinvoiceDetailTbl");
                });

            entity.Property(e => e.BenefitCost).HasColumnType("money");
            entity.Property(e => e.Comment).HasMaxLength(300);
            entity.Property(e => e.Cost).HasColumnType("money");
            entity.Property(e => e.CurFee).HasColumnType("money");
            entity.Property(e => e.DateExpire)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DiscountFee).HasColumnType("money");
            entity.Property(e => e.Fee).HasColumnType("money");
            entity.Property(e => e.FkInvoiceSysCode).HasColumnName("FK_InvoiceSysCode");
            entity.Property(e => e.SerialNo).HasMaxLength(100);
            entity.Property(e => e.Term).HasMaxLength(1000);
            entity.Property(e => e.Unit).HasMaxLength(100);
            entity.Property(e => e.UserPrice).HasColumnType("money");
            entity.Property(e => e.VisitorFee).HasColumnType("money");
            entity.Property(e => e.WeighCarwithBar).HasDefaultValue(0.0);
            entity.Property(e => e.WeightCar).HasDefaultValue(0.0);

            entity.HasOne(d => d.ColorNavigation).WithMany(p => p.InvoiceDetailTbls)
                .HasForeignKey(d => d.Color)
                .HasConstraintName("FK_invoiceDetailTbl_Color");

            entity.HasOne(d => d.FkInvoiceSysCodeNavigation).WithMany(p => p.InvoiceDetailTbls)
                .HasForeignKey(d => d.FkInvoiceSysCode)
                .HasConstraintName("FK_invoiceDetailTbl_InvoiceTbl");

            entity.HasOne(d => d.GoodSysCodeNavigation).WithMany(p => p.InvoiceDetailTblGoodSysCodeNavigations)
                .HasForeignKey(d => d.GoodSysCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_invoiceDetailTbl_StockTbl");

            entity.HasOne(d => d.PromotionGoodSysCodeNavigation).WithMany(p => p.InvoiceDetailTblPromotionGoodSysCodeNavigations)
                .HasForeignKey(d => d.PromotionGoodSysCode)
                .HasConstraintName("FK__invoiceDe__Promo__1CB22475");

            entity.HasOne(d => d.SizeNavigation).WithMany(p => p.InvoiceDetailTbls)
                .HasForeignKey(d => d.Size)
                .HasConstraintName("FK_invoiceDetailTbl_size");

            entity.HasOne(d => d.WareHouseNavigation).WithMany(p => p.InvoiceDetailTbls)
                .HasForeignKey(d => d.WareHouse)
                .HasConstraintName("FK_invoiceDetailTbl_warehouse");
        });

        modelBuilder.Entity<InvoiceInfoPrint>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__InvoiceI__3214EC070B677F57");

            entity.ToTable("InvoiceInfoPrint");

            entity.Property(e => e.AccountNumber1).HasMaxLength(500);
            entity.Property(e => e.AccountNumber2).HasMaxLength(500);
            entity.Property(e => e.Address1).HasMaxLength(50);
            entity.Property(e => e.Comment).HasMaxLength(500);
            entity.Property(e => e.EconomicCode).HasMaxLength(50);
            entity.Property(e => e.Feild1).HasMaxLength(500);
            entity.Property(e => e.Feild2).HasMaxLength(500);
            entity.Property(e => e.Feild3).HasMaxLength(500);
            entity.Property(e => e.Feild4).HasMaxLength(500);
            entity.Property(e => e.Feild5).HasMaxLength(500);
            entity.Property(e => e.IdNumberCompony).HasMaxLength(50);
            entity.Property(e => e.IdNumberPerson).HasMaxLength(50);
            entity.Property(e => e.Logo).HasColumnType("image");
            entity.Property(e => e.Mobile1).HasMaxLength(50);
            entity.Property(e => e.Mobile2).HasMaxLength(50);
            entity.Property(e => e.ShopComment).HasMaxLength(1000);
            entity.Property(e => e.ShopName).HasMaxLength(300);
            entity.Property(e => e.Tel1).HasMaxLength(50);
            entity.Property(e => e.Tel2).HasMaxLength(50);
            entity.Property(e => e.Term1).HasMaxLength(500);
            entity.Property(e => e.Term2).HasMaxLength(500);
            entity.Property(e => e.Title).HasMaxLength(200);
            entity.Property(e => e.ZipCode).HasMaxLength(20);
        });

        modelBuilder.Entity<InvoicePaymentTbl>(entity =>
        {
            entity.HasKey(e => e.SysCode).HasName("PK__InvoicePaymentTb__1995C0A8");

            entity.ToTable("InvoicePaymentTbl");

            entity.Property(e => e.Fee).HasColumnType("money");
            entity.Property(e => e.FkDocDetailSysCode).HasColumnName("FK_DocDetailSysCode");
            entity.Property(e => e.FkInvoiceSerial).HasColumnName("FK_InvoiceSerial");

            entity.HasOne(d => d.FkDocDetailSysCodeNavigation).WithMany(p => p.InvoicePaymentTbls)
                .HasForeignKey(d => d.FkDocDetailSysCode)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__DocDetailSysCode_InvoicePayment");

            entity.HasOne(d => d.FkInvoiceSerialNavigation).WithMany(p => p.InvoicePaymentTbls)
                .HasForeignKey(d => d.FkInvoiceSerial)
                .HasConstraintName("FK__InvoicePa__FK_In__1A89E4E1");
        });

        modelBuilder.Entity<InvoiceReturnResonTbl>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__InvoiceR__3214EC27DDF4A6EF");

            entity.ToTable("InvoiceReturnResonTBL");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Title).HasMaxLength(200);
        });

        modelBuilder.Entity<InvoiceSerialForHavaleh>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("InvoiceSerialForHavaleh");
        });

        modelBuilder.Entity<InvoiceServerType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__InvoiceS__3214EC27D65A3061");

            entity.ToTable("InvoiceServerType");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.TypeTitle).HasMaxLength(50);
        });

        modelBuilder.Entity<InvoiceStatusTbl>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__InvoiceS__3214EC275E2FBE54");

            entity.ToTable("InvoiceStatusTBL");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.FormatString).HasMaxLength(500);
            entity.Property(e => e.HexaColor).HasMaxLength(15);
            entity.Property(e => e.Title).HasMaxLength(200);
        });

        modelBuilder.Entity<InvoiceTbl>(entity =>
        {
            entity.HasKey(e => e.InvoiceSerialNo);

            entity.ToTable("InvoiceTbl", tb =>
                {
                    tb.HasTrigger("TRGInvoiceUpdateSignField");
                    tb.HasTrigger("TRGOnDeleteInvoice");
                    tb.HasTrigger("TRGOnUpdateInvoice");
                });

            entity.HasIndex(e => new { e.FkAccountSysCode, e.FkDocsysCode, e.InvoiceNo }, "NonClusteredIndex-20241012-114640").HasFillFactor(90);

            entity.Property(e => e.Address).HasMaxLength(300);
            entity.Property(e => e.ArchiveName).HasMaxLength(100);
            entity.Property(e => e.BaseRate)
                .HasDefaultValue(1m)
                .HasColumnType("money");
            entity.Property(e => e.Benefit).HasColumnType("money");
            entity.Property(e => e.BranchTelId).HasColumnName("BranchTelID");
            entity.Property(e => e.Comment).HasMaxLength(300);
            entity.Property(e => e.CurRateDef)
                .HasDefaultValue(1m)
                .HasColumnType("money");
            entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");
            entity.Property(e => e.CustomerName).HasMaxLength(300);
            entity.Property(e => e.DelivaredDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DeliverName).HasMaxLength(100);
            entity.Property(e => e.Field1).HasMaxLength(200);
            entity.Property(e => e.Field2).HasMaxLength(200);
            entity.Property(e => e.Field3).HasMaxLength(200);
            entity.Property(e => e.Field4).HasMaxLength(200);
            entity.Property(e => e.FkAccountSysCode).HasColumnName("FK_AccountSysCode");
            entity.Property(e => e.FkDocsysCode).HasColumnName("FK_DocsysCode");
            entity.Property(e => e.FkProjectId).HasColumnName("Fk_ProjectID");
            entity.Property(e => e.FkReturnResonId).HasColumnName("FK_ReturnResonID");
            entity.Property(e => e.FkServerTypeId).HasColumnName("FK_ServerTypeID");
            entity.Property(e => e.FkYearId)
                .HasDefaultValue((byte)1)
                .HasColumnName("Fk_YearId");
            entity.Property(e => e.FollowDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InvoiceDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InvoiceMiladiDate).HasColumnType("datetime");
            entity.Property(e => e.IsUpdate).HasDefaultValue(true);
            entity.Property(e => e.Mobile).HasMaxLength(100);
            entity.Property(e => e.PaymentDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PostFollowCode).HasMaxLength(200);
            entity.Property(e => e.RecivedDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ShopId).HasColumnName("ShopID");
            entity.Property(e => e.ShopToken).HasMaxLength(300);
            entity.Property(e => e.Signatur).HasColumnType("image");
            entity.Property(e => e.StatusId).HasColumnName("StatusID");
            entity.Property(e => e.StatusPromp).HasMaxLength(500);
            entity.Property(e => e.SysDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.SysShamsiDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("([dbo].[funsundate](NULL))")
                .IsFixedLength();
            entity.Property(e => e.Type).HasComment("for descibe type of invoice : 1 sale  , 2 buy  , 3 return sale , 4 return buy");
            entity.Property(e => e.UpdateSysDate).HasColumnType("datetime");
            entity.Property(e => e.UserNo).HasDefaultValueSql("([dbo].[FunUserId]())");
            entity.Property(e => e.VisitorAmount).HasColumnType("money");
            entity.Property(e => e.ZipCode).HasMaxLength(100);

            entity.HasOne(d => d.FkAccountSysCodeNavigation).WithMany(p => p.InvoiceTblFkAccountSysCodeNavigations)
                .HasForeignKey(d => d.FkAccountSysCode)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_InvoiceTbl_Account");

            entity.HasOne(d => d.FkDocsysCodeNavigation).WithMany(p => p.InvoiceTbls)
                .HasForeignKey(d => d.FkDocsysCode)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_InvoiceTbl_DocDetailTbl");

            entity.HasOne(d => d.FkProject).WithMany(p => p.InvoiceTbls)
                .HasForeignKey(d => d.FkProjectId)
                .HasConstraintName("FK__InvoiceTb__Fk_Pr__210D9095");

            entity.HasOne(d => d.FkReturnReson).WithMany(p => p.InvoiceTbls)
                .HasForeignKey(d => d.FkReturnResonId)
                .HasConstraintName("FK__InvoiceTb__FK_Re__3A235722");

            entity.HasOne(d => d.FkServerType).WithMany(p => p.InvoiceTbls)
                .HasForeignKey(d => d.FkServerTypeId)
                .HasConstraintName("FK__InvoiceTb__FK_Se__14F1D273");

            entity.HasOne(d => d.FkYear).WithMany(p => p.InvoiceTbls)
                .HasForeignKey(d => d.FkYearId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__InvoiceTb__Fk_Ye__0940F3FC");

            entity.HasOne(d => d.Status).WithMany(p => p.InvoiceTbls)
                .HasForeignKey(d => d.StatusId)
                .HasConstraintName("FK__InvoiceTb__Statu__392F32E9");

            entity.HasOne(d => d.TypeNavigation).WithMany(p => p.InvoiceTbls)
                .HasForeignKey(d => d.Type)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InvoiceTbl_InvoiceTypeInfo");

            entity.HasOne(d => d.UserNoNavigation).WithMany(p => p.InvoiceTbls)
                .HasForeignKey(d => d.UserNo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InvoiceTbl_Users");

            entity.HasOne(d => d.VisitorSyscodeNavigation).WithMany(p => p.InvoiceTblVisitorSyscodeNavigations)
                .HasForeignKey(d => d.VisitorSyscode)
                .HasConstraintName("FK_InvoiceTbl_visitoracc");
        });

        modelBuilder.Entity<LanguageTbl>(entity =>
        {
            entity.HasKey(e => e.Symbol);

            entity.ToTable("LanguageTBL");

            entity.Property(e => e.Symbol).HasMaxLength(50);
            entity.Property(e => e.Language).HasMaxLength(50);
        });

        modelBuilder.Entity<Log>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Logs__3214EC07C7674E15");

            entity.ToTable(tb => tb.HasTrigger("DeletePreviousRecord"));

            entity.Property(e => e.ActionName).HasMaxLength(200);
            entity.Property(e => e.ClassName).HasMaxLength(100);
            entity.Property(e => e.ContorollerName).HasMaxLength(200);
            entity.Property(e => e.ExceptionMessage).HasColumnType("ntext");
            entity.Property(e => e.ExceptionSource).HasColumnType("ntext");
            entity.Property(e => e.InputModel).HasColumnType("ntext");
            entity.Property(e => e.LogDate).HasColumnType("datetime");
            entity.Property(e => e.MethodName).HasMaxLength(100);
            entity.Property(e => e.OutputModel).HasColumnType("ntext");
            entity.Property(e => e.RequestIp).HasMaxLength(20);
            entity.Property(e => e.ResultMessage).HasMaxLength(300);
            entity.Property(e => e.UserName).HasMaxLength(200);
        });

        modelBuilder.Entity<MoreBarCodeTbl>(entity =>
        {
            entity.HasKey(e => e.SysCode).HasName("PK__MoreBarCodeTBL__381A47C8");

            entity.ToTable("MoreBarCodeTBL");

            entity.Property(e => e.BarCode).HasMaxLength(100);
            entity.Property(e => e.FkGoodSysCode).HasColumnName("FK_GoodSysCode");
        });

        modelBuilder.Entity<OldDataBaseTbl>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__OldDataB__3214EC27AEB1B6EB");

            entity.ToTable("OldDataBaseTbl");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Dbname)
                .HasMaxLength(50)
                .HasColumnName("DBName");
            entity.Property(e => e.Title).HasMaxLength(50);
        });

        modelBuilder.Entity<OstanTbl>(entity =>
        {
            entity.HasKey(e => e.OstanCode).HasName("PK__OstanTbl__4F32B74A");

            entity.ToTable("OstanTbl");

            entity.Property(e => e.OstanCode).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<PartnersTbl>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Partners__3214EC27253141F3");

            entity.ToTable("PartnersTBL");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");

            entity.HasOne(d => d.AccountSysCodeNavigation).WithMany(p => p.PartnersTbls)
                .HasForeignKey(d => d.AccountSysCode)
                .HasConstraintName("FK__PartnersT__Accou__5C2E5663");
        });

        modelBuilder.Entity<PersonActivityTbl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Person_ActivityTBL");

            entity.Property(e => e.FkAccountSysCode).HasColumnName("FK_AccountSysCode");
            entity.Property(e => e.FkPersonActivity).HasColumnName("FK_PersonActivity");
            entity.Property(e => e.Isactive).HasColumnName("ISActive");

            entity.HasOne(d => d.FkAccountSysCodeNavigation).WithMany()
                .HasForeignKey(d => d.FkAccountSysCode)
                .HasConstraintName("FK__Person_Ac__FK_Ac__5887175A");

            entity.HasOne(d => d.FkPersonActivityNavigation).WithMany()
                .HasForeignKey(d => d.FkPersonActivity)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Person_Ac__FK_Pe__597B3B93");
        });

        modelBuilder.Entity<PersonActivityTbl1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PersonActivityTB__55AAAAAF");

            entity.ToTable("PersonActivityTBL");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Activity).HasMaxLength(100);
        });

        modelBuilder.Entity<PersonCommercialTbl>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PersonCommercial__65E11278");

            entity.ToTable("PersonCommercialTBL");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.HexaColor).HasMaxLength(15);
            entity.Property(e => e.Title).HasMaxLength(200);
        });

        modelBuilder.Entity<PersonCostMountlyTbl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Person_CostMountlyTBL");

            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.FkAccountSysCode).HasColumnName("FK_AccountSysCode");
            entity.Property(e => e.FkPersonCostMountLy).HasColumnName("FK_PersonCostMountLy");
            entity.Property(e => e.Isactive).HasColumnName("ISActive");
            entity.Property(e => e.Qty).HasColumnName("QTY");

            entity.HasOne(d => d.FkAccountSysCodeNavigation).WithMany()
                .HasForeignKey(d => d.FkAccountSysCode)
                .HasConstraintName("FK__Person_Co__FK_Ac__033C6B35");

            entity.HasOne(d => d.FkPersonCostMountLyNavigation).WithMany()
                .HasForeignKey(d => d.FkPersonCostMountLy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Person_Co__FK_Pe__04308F6E");
        });

        modelBuilder.Entity<PersonCostMountlyTbl1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PersonCostMountl__015422C3");

            entity.ToTable("PersonCostMountlyTBL");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Title).HasMaxLength(100);
        });

        modelBuilder.Entity<PersonCreditDetailTbl>(entity =>
        {
            entity.HasKey(e => e.SysCode).HasName("PK__PersonCreditDeta__679450C0");

            entity.ToTable("PersonCreditDetailTBL");

            entity.Property(e => e.Comment).HasMaxLength(1000);
            entity.Property(e => e.FkAccountSysCode).HasColumnName("Fk_AccountSysCode");
            entity.Property(e => e.Price).HasColumnType("money");
            entity.Property(e => e.ShamsiSysDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("([dbo].[funsundate](getdate()))")
                .IsFixedLength();
            entity.Property(e => e.SndPrice).HasColumnType("money");
            entity.Property(e => e.SysDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.FkAccountSysCodeNavigation).WithMany(p => p.PersonCreditDetailTbls)
                .HasForeignKey(d => d.FkAccountSysCode)
                .HasConstraintName("FK__PersonCre__Fk_Ac__688874F9");

            entity.HasOne(d => d.User).WithMany(p => p.PersonCreditDetailTbls)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__PersonCre__UserI__697C9932");
        });

        modelBuilder.Entity<PersonCreditTbl>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PersonCreditTBL__62108194");

            entity.ToTable("PersonCreditTBL");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Comment).HasMaxLength(1000);
            entity.Property(e => e.FkAccountsysCode).HasColumnName("FK_AccountsysCode");
            entity.Property(e => e.Title).HasMaxLength(200);

            entity.HasOne(d => d.FkAccountsysCodeNavigation).WithMany(p => p.PersonCreditTbls)
                .HasForeignKey(d => d.FkAccountsysCode)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__PersonCre__FK_Ac__6304A5CD");
        });

        modelBuilder.Entity<PersonCustomerKindTbl>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PersonCustomerKi__67C95AEA");

            entity.ToTable("PersonCustomerKindTBL");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Title).HasMaxLength(200);
        });

        modelBuilder.Entity<PersonForPrint>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PersonForPrint");
        });

        modelBuilder.Entity<PersonGroup1Tbl>(entity =>
        {
            entity.HasKey(e => e.GroupId);

            entity.ToTable("PersonGroup1Tbl");

            entity.Property(e => e.GroupName).HasMaxLength(100);
        });

        modelBuilder.Entity<PersonGroup2Tbl>(entity =>
        {
            entity.HasKey(e => e.GroupId);

            entity.ToTable("PersonGroup2Tbl");

            entity.Property(e => e.GroupName).HasMaxLength(100);
        });

        modelBuilder.Entity<PersonKind>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PersonKind__4B622666");

            entity.ToTable("PersonKind");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Kind).HasMaxLength(200);
        });

        modelBuilder.Entity<PersonTbl>(entity =>
        {
            entity.HasKey(e => e.FkAccountSysCode).HasName("PK_PersonTbl_1");

            entity.ToTable("PersonTbl", tb =>
                {
                    tb.HasTrigger("RGONUpdate_eShopPerson");
                    tb.HasTrigger("TRGONPersonsChanged");
                });

            entity.Property(e => e.FkAccountSysCode)
                .ValueGeneratedNever()
                .HasColumnName("FK_AccountSysCode");
            entity.Property(e => e.BirthDayDate)
                .HasMaxLength(10)
                .HasColumnName("birthDayDate");
            entity.Property(e => e.CardId1).HasColumnName("CardID1");
            entity.Property(e => e.CardId2).HasColumnName("CardID2");
            entity.Property(e => e.CreateDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Credit).HasColumnType("money");
            entity.Property(e => e.EShopId)
                .HasMaxLength(200)
                .HasColumnName("eShopId");
            entity.Property(e => e.FkIdkind).HasColumnName("FK_IDKind");
            entity.Property(e => e.FkPersonCommercial).HasColumnName("FK_PersonCommercial");
            entity.Property(e => e.FkPersonCutomerKind).HasColumnName("FK_PersonCutomerKind");
            entity.Property(e => e.FkTaxPersonKindId)
                .HasDefaultValue((byte)1)
                .HasColumnName("Fk_TaxPersonKindId");
            entity.Property(e => e.GroupId1).HasDefaultValue(1);
            entity.Property(e => e.GroupId2).HasDefaultValue(1);
            entity.Property(e => e.IsDistributor).HasDefaultValue(false);
            entity.Property(e => e.IsDriver).HasDefaultValue(false);
            entity.Property(e => e.IsEmployee).HasDefaultValue(false);
            entity.Property(e => e.IsUpdate).HasDefaultValue(true);
            entity.Property(e => e.Resume).HasColumnType("ntext");
            entity.Property(e => e.UpdateDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.VisitorBaseAmmount).HasColumnType("money");
            entity.Property(e => e.VisitorIncreaseAmmount).HasColumnType("money");

            entity.HasOne(d => d.Contact).WithMany(p => p.PersonTbls)
                .HasForeignKey(d => d.ContactId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_PersonTbl_TelBook");

            entity.HasOne(d => d.FkAccountSysCodeNavigation).WithOne(p => p.PersonTbl)
                .HasForeignKey<PersonTbl>(d => d.FkAccountSysCode)
                .HasConstraintName("FK_PersonTbl_CodeMNGDWNTbl");

            entity.HasOne(d => d.FkIdkindNavigation).WithMany(p => p.PersonTbls)
                .HasForeignKey(d => d.FkIdkind)
                .HasConstraintName("FK__PersonTbl__FK_ID__4C564A9F");

            entity.HasOne(d => d.FkPersonCommercialNavigation).WithMany(p => p.PersonTbls)
                .HasForeignKey(d => d.FkPersonCommercial)
                .HasConstraintName("FK__PersonTbl__FK_Pe__6B99EBCE");

            entity.HasOne(d => d.FkPersonCutomerKindNavigation).WithMany(p => p.PersonTbls)
                .HasForeignKey(d => d.FkPersonCutomerKind)
                .HasConstraintName("FK__PersonTbl__FK_Pe__6AA5C795");

            entity.HasOne(d => d.FkTaxPersonKind).WithMany(p => p.PersonTbls)
                .HasForeignKey(d => d.FkTaxPersonKindId)
                .HasConstraintName("FK__PersonTbl__Fk_Ta__68150A5B");

            entity.HasOne(d => d.GroupId1Navigation).WithMany(p => p.PersonTbls)
                .HasForeignKey(d => d.GroupId1)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_PersonTbl_PersonGroup1Tbl");

            entity.HasOne(d => d.GroupId2Navigation).WithMany(p => p.PersonTbls)
                .HasForeignKey(d => d.GroupId2)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_PersonTbl_PersonGroup2Tbl");

            entity.HasOne(d => d.SalePriceNoNavigation).WithMany(p => p.PersonTbls)
                .HasForeignKey(d => d.SalePriceNo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PersonTbl_PriceTypeInfo");
        });

        modelBuilder.Entity<Policy>(entity =>
        {
            entity.HasKey(e => e.Pid);

            entity.Property(e => e.Pid)
                .ValueGeneratedNever()
                .HasColumnName("PID");
            entity.Property(e => e.Plevel).HasColumnName("PLevel");
            entity.Property(e => e.Pname)
                .HasMaxLength(1000)
                .HasColumnName("PName");
        });

        modelBuilder.Entity<PolicysList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("PolicysList");

            entity.Property(e => e.Pid)
                .ValueGeneratedOnAdd()
                .HasColumnName("PID");
            entity.Property(e => e.Plevel).HasColumnName("PLevel");
            entity.Property(e => e.Pname).HasColumnName("PName");
        });

        modelBuilder.Entity<PosTransactionTbl>(entity =>
        {
            entity.HasKey(e => e.SysCode).HasName("PK__PosTransactionTB__44801EAD");

            entity.ToTable("PosTransactionTBL");

            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.CardNumber).HasMaxLength(50);
            entity.Property(e => e.Rrn).HasColumnName("RRN");
            entity.Property(e => e.SysDate).HasColumnType("datetime");
            entity.Property(e => e.SysShamsiDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<PricingDetailTbl>(entity =>
        {
            entity.HasKey(e => e.SysCode).HasName("PK__PricingD__EE72712DAFE5D3C0");

            entity.ToTable("PricingDetailTBL");

            entity.Property(e => e.Comment)
                .HasMaxLength(1000)
                .HasDefaultValue("");
            entity.Property(e => e.DiscountPer).HasDefaultValue(0.0);
            entity.Property(e => e.Fee)
                .HasDefaultValue(0m)
                .HasColumnType("money");
            entity.Property(e => e.FkPricingId).HasColumnName("Fk_PricingID");
            entity.Property(e => e.LastDiscountPer).HasDefaultValue(0.0);
            entity.Property(e => e.RowNo).HasColumnName("RowNO");
            entity.Property(e => e.SalePrice1)
                .HasDefaultValue(0m)
                .HasColumnType("money");
            entity.Property(e => e.SalePrice1Per).HasDefaultValue(0.0);
            entity.Property(e => e.SalePrice2)
                .HasDefaultValue(0m)
                .HasColumnType("money");
            entity.Property(e => e.SalePrice2Per).HasDefaultValue(0.0);
            entity.Property(e => e.SalePrice3)
                .HasDefaultValue(0m)
                .HasColumnType("money");
            entity.Property(e => e.SalePrice3Per).HasDefaultValue(0.0);
            entity.Property(e => e.SalePrice4)
                .HasDefaultValue(0m)
                .HasColumnType("money");
            entity.Property(e => e.SalePrice4Per).HasDefaultValue(0.0);
            entity.Property(e => e.SalePrice5)
                .HasDefaultValue(0m)
                .HasColumnType("money");
            entity.Property(e => e.SalePrice5Per).HasDefaultValue(0.0);

            entity.HasOne(d => d.FkPricing).WithMany(p => p.PricingDetailTbls)
                .HasForeignKey(d => d.FkPricingId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__PricingDe__Fk_Pr__41C3AD93");

            entity.HasOne(d => d.GoodSysCodeNavigation).WithMany(p => p.PricingDetailTbls)
                .HasForeignKey(d => d.GoodSysCode)
                .HasConstraintName("FK__PricingDe__GoodS__42B7D1CC");
        });

        modelBuilder.Entity<PricingTbl>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PricingT__3214EC27E647C3A7");

            entity.ToTable("PricingTBL");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Comment)
                .HasMaxLength(2000)
                .HasDefaultValue("");
            entity.Property(e => e.Field1)
                .HasMaxLength(1000)
                .HasDefaultValue("");
            entity.Property(e => e.Field2)
                .HasMaxLength(1000)
                .HasDefaultValue("");
            entity.Property(e => e.Field3)
                .HasMaxLength(1000)
                .HasDefaultValue("");
            entity.Property(e => e.MiladiDate).HasColumnType("datetime");
            entity.Property(e => e.ShamsiDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.SysMiladiDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.SysShamsiDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("([dbo].[funsundate](getdate()))")
                .IsFixedLength();
            entity.Property(e => e.UserNo).HasDefaultValueSql("([dbo].[FunUserId]())");

            entity.HasOne(d => d.AccountCodeNavigation).WithMany(p => p.PricingTbls)
                .HasForeignKey(d => d.AccountCode)
                .HasConstraintName("FK__PricingTB__Accou__32816A03");

            entity.HasOne(d => d.UserNoNavigation).WithMany(p => p.PricingTbls)
                .HasForeignKey(d => d.UserNo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PricingTB__UserN__30992191");
        });

        modelBuilder.Entity<PrintLayout>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Fkid).HasColumnName("FKID");
            entity.Property(e => e.LayoutName).HasMaxLength(200);
            entity.Property(e => e.Xmldata).HasColumnName("XMLdata");

            entity.HasOne(d => d.Fk).WithMany(p => p.PrintLayouts)
                .HasForeignKey(d => d.Fkid)
                .HasConstraintName("FK_PrintLayouts_GridsInfo");
        });

        modelBuilder.Entity<ProjectTbl>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ProjectT__3214EC27A091F53B");

            entity.ToTable("ProjectTBL");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.Title).HasMaxLength(500);
        });

        modelBuilder.Entity<PromotionTbl>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Promotio__3214EC27C613FFA1");

            entity.ToTable("PromotionTBL");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.FkMainGoodSysCode).HasColumnName("FK_MainGoodSysCode");
            entity.Property(e => e.FkPromotionGoodSysCode).HasColumnName("FK_PromotionGoodSysCode");

            entity.HasOne(d => d.FkMainGoodSysCodeNavigation).WithMany(p => p.PromotionTblFkMainGoodSysCodeNavigations)
                .HasForeignKey(d => d.FkMainGoodSysCode)
                .HasConstraintName("FK__Promotion__FK_Ma__6561EF8B");

            entity.HasOne(d => d.FkPromotionGoodSysCodeNavigation).WithMany(p => p.PromotionTblFkPromotionGoodSysCodeNavigations)
                .HasForeignKey(d => d.FkPromotionGoodSysCode)
                .HasConstraintName("FK__Promotion__FK_Pr__665613C4");
        });

        modelBuilder.Entity<ScaduleCircuitTbl>(entity =>
        {
            entity.HasKey(e => e.SysCode).HasName("PK__ScaduleCircuitTB__12B3B8EF");

            entity.ToTable("ScaduleCircuitTBL");

            entity.Property(e => e.Comment).HasColumnType("ntext");
            entity.Property(e => e.FkScaduleSysCode).HasColumnName("FK_ScaduleSysCode");
            entity.Property(e => e.FollowDate).HasColumnType("datetime");
            entity.Property(e => e.FollowShamsiDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RecevieUserId).HasColumnName("RecevieUserID");
            entity.Property(e => e.SendUserId).HasColumnName("SendUserID");
            entity.Property(e => e.ShamsiSysDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("([dbo].[funsundate](NULL))")
                .IsFixedLength();
            entity.Property(e => e.SysDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.RecevieUser).WithMany(p => p.ScaduleCircuitTblRecevieUsers)
                .HasForeignKey(d => d.RecevieUserId)
                .HasConstraintName("FK__ScaduleCi__Recev__149C0161");

            entity.HasOne(d => d.SendUser).WithMany(p => p.ScaduleCircuitTblSendUsers)
                .HasForeignKey(d => d.SendUserId)
                .HasConstraintName("FK__ScaduleCi__SendU__13A7DD28");
        });

        modelBuilder.Entity<ScaduleTbl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ScaduleTbl");

            entity.Property(e => e.Comment).HasMaxLength(4000);
            entity.Property(e => e.DateS)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.FinishShamsiDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("([dbo].[funsundate](NULL))")
                .IsFixedLength();
            entity.Property(e => e.FinishSysDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FkGoodSysCode).HasColumnName("Fk_GoodSysCode");
            entity.Property(e => e.FkPersonId).HasColumnName("FK_PersonID");
            entity.Property(e => e.ReceiveUserId)
                .HasDefaultValue(1)
                .HasColumnName("ReceiveUserID");
            entity.Property(e => e.ShamsiSysDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("1397/08/20")
                .IsFixedLength();
            entity.Property(e => e.SysCode).ValueGeneratedOnAdd();
            entity.Property(e => e.SysDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.TimeS).HasColumnType("datetime");
            entity.Property(e => e.Title)
                .HasMaxLength(1000)
                .HasDefaultValue("");

            entity.HasOne(d => d.FkGoodSysCodeNavigation).WithMany()
                .HasForeignKey(d => d.FkGoodSysCode)
                .HasConstraintName("FK__ScaduleTb__Fk_Go__027D5126");

            entity.HasOne(d => d.FkPerson).WithMany()
                .HasForeignKey(d => d.FkPersonId)
                .HasConstraintName("FK__ScaduleTb__FK_Pe__01892CED");

            entity.HasOne(d => d.ReceiveUser).WithMany()
                .HasForeignKey(d => d.ReceiveUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ScaduleTb__Recei__0371755F");
        });

        modelBuilder.Entity<SmsLogTbl>(entity =>
        {
            entity.HasKey(e => e.SysCode).HasName("PK__SmsLogTBL__6E414E4F");

            entity.ToTable("SmsLogTBL");

            entity.Property(e => e.BatchKey).HasMaxLength(1000);
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.Mobile).HasMaxLength(20);
            entity.Property(e => e.Msg).HasMaxLength(1000);
            entity.Property(e => e.PanelId)
                .HasMaxLength(500)
                .HasColumnName("PanelID");
            entity.Property(e => e.ShamsiDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<SqlErrMsg>(entity =>
        {
            entity.HasKey(e => e.Msgnum).HasName("PK__SqlErrMsg__2A8B4280");

            entity.ToTable("SqlErrMsg");

            entity.Property(e => e.Msgnum)
                .ValueGeneratedNever()
                .HasColumnName("msgnum");
            entity.Property(e => e.Msgtext)
                .HasMaxLength(1000)
                .HasColumnName("msgtext");
            entity.Property(e => e.MsgtextEn)
                .HasMaxLength(1000)
                .HasColumnName("msgtext_EN");
            entity.Property(e => e.Replace)
                .HasMaxLength(100)
                .HasColumnName("replace");
            entity.Property(e => e.Severity).HasColumnName("severity");
        });

        modelBuilder.Entity<StockDeletedTbl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StockDeletedTbl");

            entity.Property(e => e.BarCode).HasMaxLength(100);
            entity.Property(e => e.BuyLastFee).HasColumnType("money");
            entity.Property(e => e.Code).HasMaxLength(100);
            entity.Property(e => e.Comment).HasMaxLength(300);
            entity.Property(e => e.Field1).HasMaxLength(1000);
            entity.Property(e => e.Field2).HasMaxLength(1000);
            entity.Property(e => e.Field3).HasMaxLength(1000);
            entity.Property(e => e.FstUnit).HasMaxLength(100);
            entity.Property(e => e.GroupId1).HasColumnName("GroupID1");
            entity.Property(e => e.GroupId2).HasColumnName("GroupID2");
            entity.Property(e => e.ImageName).HasMaxLength(1000);
            entity.Property(e => e.MaxQty).HasColumnName("MaxQTY");
            entity.Property(e => e.RtlTolft).HasColumnName("rtlTOlft");
            entity.Property(e => e.SalePrice1).HasColumnType("money");
            entity.Property(e => e.SalePrice2).HasColumnType("money");
            entity.Property(e => e.SalePrice3).HasColumnType("money");
            entity.Property(e => e.SalePrice4).HasColumnType("money");
            entity.Property(e => e.SalePrice5).HasColumnType("money");
            entity.Property(e => e.SecUnit).HasMaxLength(100);
            entity.Property(e => e.TechnicalBox).HasColumnType("ntext");
            entity.Property(e => e.Term).HasMaxLength(1000);
            entity.Property(e => e.Title).HasMaxLength(1000);
            entity.Property(e => e.UserPrice).HasColumnType("money");
        });

        modelBuilder.Entity<StockGroup1Tbl>(entity =>
        {
            entity.HasKey(e => e.GroupId);

            entity.ToTable("stockGroup1Tbl", tb =>
                {
                    tb.HasTrigger("TRGONDeleteGoodGroup1");
                    tb.HasTrigger("TRGONUpdateGoodGroup1");
                });

            entity.Property(e => e.GroupName).HasMaxLength(100);
        });

        modelBuilder.Entity<StockGroup2Tbl>(entity =>
        {
            entity.HasKey(e => e.GroupId);

            entity.ToTable("stockGroup2Tbl", tb =>
                {
                    tb.HasTrigger("TRGONDeleteGoodGroup2");
                    tb.HasTrigger("TRGONUpdateGoodGroup2");
                });

            entity.Property(e => e.GroupName).HasMaxLength(100);
        });

        modelBuilder.Entity<StockGroup3Tbl>(entity =>
        {
            entity.HasKey(e => e.GroupId).HasName("PK__stockGro__149AF36AE81717EA");

            entity.ToTable("stockGroup3Tbl", tb =>
                {
                    tb.HasTrigger("TRGONDeleteGoodGroup3");
                    tb.HasTrigger("TRGONUpdateGoodGroup3");
                });

            entity.Property(e => e.GroupName).HasMaxLength(100);
        });

        modelBuilder.Entity<StockTbl>(entity =>
        {
            entity.HasKey(e => e.GoodSyscode);

            entity.ToTable("StockTbl", tb =>
                {
                    tb.HasTrigger("RGONDeleteGood_AutoSync");
                    tb.HasTrigger("RGONUpdateGood_AutoSync");
                    tb.HasTrigger("TRGONEditGoods");
                    tb.HasTrigger("TRGONEditGoods_BarcodeManager");
                    tb.HasTrigger("TRGONGoodsChanged");
                    tb.HasTrigger("TRGOnDeleteGoods");
                });

            entity.Property(e => e.BarCode).HasMaxLength(100);
            entity.Property(e => e.BuyLastFee).HasColumnType("money");
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.Code).HasMaxLength(100);
            entity.Property(e => e.Comment).HasMaxLength(300);
            entity.Property(e => e.CreateDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Field1).HasMaxLength(1000);
            entity.Property(e => e.Field2).HasMaxLength(1000);
            entity.Property(e => e.Field3).HasMaxLength(1000);
            entity.Property(e => e.Field4).HasMaxLength(200);
            entity.Property(e => e.Field5).HasMaxLength(200);
            entity.Property(e => e.FkTaxUnitId).HasColumnName("Fk_TaxUnitId");
            entity.Property(e => e.FstUnit).HasMaxLength(100);
            entity.Property(e => e.GroupId1)
                .HasDefaultValue(1)
                .HasColumnName("GroupID1");
            entity.Property(e => e.GroupId2)
                .HasDefaultValue(1)
                .HasColumnName("GroupID2");
            entity.Property(e => e.GroupId3).HasColumnName("GroupID3");
            entity.Property(e => e.HasPromotion).HasDefaultValue(false);
            entity.Property(e => e.ImageName).HasMaxLength(1000);
            entity.Property(e => e.IsUpdate).HasDefaultValue(true);
            entity.Property(e => e.LastFeeNoCost).HasColumnType("money");
            entity.Property(e => e.Located).HasMaxLength(200);
            entity.Property(e => e.MaxQty).HasColumnName("MaxQTY");
            entity.Property(e => e.RtlTolft).HasColumnName("rtlTOlft");
            entity.Property(e => e.SalePrice1).HasColumnType("money");
            entity.Property(e => e.SalePrice2).HasColumnType("money");
            entity.Property(e => e.SalePrice3).HasColumnType("money");
            entity.Property(e => e.SalePrice4).HasColumnType("money");
            entity.Property(e => e.SalePrice5).HasColumnType("money");
            entity.Property(e => e.SecUnit).HasMaxLength(100);
            entity.Property(e => e.SendToServer).HasDefaultValue(true);
            entity.Property(e => e.TechnicalBox).HasColumnType("ntext");
            entity.Property(e => e.Term).HasMaxLength(1000);
            entity.Property(e => e.Title).HasMaxLength(1000);
            entity.Property(e => e.UpdateDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.UserPrice).HasColumnType("money");

            entity.HasOne(d => d.Category).WithMany(p => p.StockTbls)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK__StockTbl__Catego__0C278248");

            entity.HasOne(d => d.FkTaxUnit).WithMany(p => p.StockTbls)
                .HasForeignKey(d => d.FkTaxUnitId)
                .HasConstraintName("FK__StockTbl__Fk_Tax__6AF17706");

            entity.HasOne(d => d.GroupId1Navigation).WithMany(p => p.StockTbls)
                .HasForeignKey(d => d.GroupId1)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_StockTbl_stockGroup1Tbl");

            entity.HasOne(d => d.GroupId2Navigation).WithMany(p => p.StockTbls)
                .HasForeignKey(d => d.GroupId2)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_StockTbl_stockGroup2Tbl");

            entity.HasOne(d => d.GroupId3Navigation).WithMany(p => p.StockTbls)
                .HasForeignKey(d => d.GroupId3)
                .HasConstraintName("FK__StockTbl__GroupI__0B335E0F");

            entity.HasOne(d => d.Seller).WithMany(p => p.StockTbls)
                .HasForeignKey(d => d.SellerId)
                .HasConstraintName("FK__StockTbl__Seller__4A2FA1B9");

            entity.HasOne(d => d.TypeNavigation).WithMany(p => p.StockTbls)
                .HasForeignKey(d => d.Type)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockTbl_type");
        });

        modelBuilder.Entity<StpForDistributionPrint>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StpForDistributionPrint");

            entity.Property(e => e.StpName).HasMaxLength(100);
            entity.Property(e => e.Syscode).ValueGeneratedOnAdd();
            entity.Property(e => e.TableName).HasMaxLength(100);
        });

        modelBuilder.Entity<StpForDocumentPrint>(entity =>
        {
            entity.HasKey(e => e.Syscode);

            entity.ToTable("StpForDocumentPrint");

            entity.Property(e => e.StpName).HasMaxLength(100);
            entity.Property(e => e.TableName).HasMaxLength(100);
        });

        modelBuilder.Entity<StpForInventoryPrint>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StpForInventoryPrint");

            entity.Property(e => e.StpName).HasMaxLength(100);
            entity.Property(e => e.Syscode).ValueGeneratedOnAdd();
            entity.Property(e => e.TableName).HasMaxLength(100);
        });

        modelBuilder.Entity<StpForInvoicePrint>(entity =>
        {
            entity.HasKey(e => e.Syscode);

            entity.ToTable("StpForInvoicePrint");

            entity.Property(e => e.StpName).HasMaxLength(100);
            entity.Property(e => e.TableName).HasMaxLength(100);
        });

        modelBuilder.Entity<StpForPricingPrint>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StpForPricingPrint");

            entity.Property(e => e.StpName).HasMaxLength(100);
            entity.Property(e => e.Syscode).ValueGeneratedOnAdd();
            entity.Property(e => e.TableName).HasMaxLength(100);
        });

        modelBuilder.Entity<StpForTransferWareHousePrint>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StpForTransferWareHousePrint");

            entity.Property(e => e.StpName).HasMaxLength(100);
            entity.Property(e => e.Syscode).ValueGeneratedOnAdd();
            entity.Property(e => e.TableName).HasMaxLength(100);
        });

        modelBuilder.Entity<StpForWarehouseCounting>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StpForWarehouseCounting");

            entity.Property(e => e.StpName).HasMaxLength(100);
            entity.Property(e => e.Syscode).ValueGeneratedOnAdd();
            entity.Property(e => e.TableName).HasMaxLength(100);
        });

        modelBuilder.Entity<SysObjVerTbl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Sys_ObjVerTbl");

            entity.Property(e => e.Des).HasMaxLength(1000);
            entity.Property(e => e.Obj)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Ver).HasMaxLength(50);
        });

        modelBuilder.Entity<TaxErrorType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TaxError__3214EC076B5760FA");

            entity.ToTable("TaxErrorType");

            entity.Property(e => e.ErrorTitle).HasMaxLength(50);
        });

        modelBuilder.Entity<TaxInvoice>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TaxInvoi__3214EC077622F597");

            entity.ToTable(tb => tb.HasTrigger("TRGOnUpdate_TaxInvoice"));

            entity.Property(e => e.CashAmount).HasColumnType("money");
            entity.Property(e => e.CreateDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FkTaxInvoiceIssueId).HasColumnName("Fk_TaxInvoiceIssueId");
            entity.Property(e => e.FkTaxInvoicePatternId).HasColumnName("Fk_TaxInvoicePatternId");
            entity.Property(e => e.FkTaxInvoiceSettlementId).HasColumnName("Fk_TaxInvoiceSettlementId");
            entity.Property(e => e.FkTaxInvoiceStatus).HasColumnName("Fk_TaxInvoiceStatus");
            entity.Property(e => e.FkTaxInvoiceTypeId).HasColumnName("Fk_TaxInvoiceTypeId");
            entity.Property(e => e.FkTaxSettingId).HasColumnName("Fk_TaxSettingId");
            entity.Property(e => e.FkUserId).HasColumnName("Fk_UserId");
            entity.Property(e => e.InNo).HasMaxLength(10);
            entity.Property(e => e.InvoiceUid).HasMaxLength(128);
            entity.Property(e => e.IrTaxId).HasMaxLength(22);
            entity.Property(e => e.PersonAmount).HasColumnType("money");
            entity.Property(e => e.RefrenceId).HasMaxLength(128);
            entity.Property(e => e.TaxId).HasMaxLength(22);
            entity.Property(e => e.UpdateDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.FkTaxInvoiceIssue).WithMany(p => p.TaxInvoices)
                .HasForeignKey(d => d.FkTaxInvoiceIssueId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TaxInvoic__Fk_Ta__5CA357AF");

            entity.HasOne(d => d.FkTaxInvoicePattern).WithMany(p => p.TaxInvoices)
                .HasForeignKey(d => d.FkTaxInvoicePatternId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TaxInvoic__Fk_Ta__5BAF3376");

            entity.HasOne(d => d.FkTaxInvoiceSettlement).WithMany(p => p.TaxInvoices)
                .HasForeignKey(d => d.FkTaxInvoiceSettlementId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TaxInvoic__Fk_Ta__5D977BE8");

            entity.HasOne(d => d.FkTaxInvoiceStatusNavigation).WithMany(p => p.TaxInvoices)
                .HasForeignKey(d => d.FkTaxInvoiceStatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TaxInvoic__Fk_Ta__61680CCC");

            entity.HasOne(d => d.FkTaxInvoiceType).WithMany(p => p.TaxInvoices)
                .HasForeignKey(d => d.FkTaxInvoiceTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TaxInvoic__Fk_Ta__5ABB0F3D");

            entity.HasOne(d => d.FkTaxSetting).WithMany(p => p.TaxInvoices)
                .HasForeignKey(d => d.FkTaxSettingId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TaxInvoic__Fk_Ta__6073E893");

            entity.HasOne(d => d.FkUser).WithMany(p => p.TaxInvoices)
                .HasForeignKey(d => d.FkUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TaxInvoic__Fk_Us__625C3105");
        });

        modelBuilder.Entity<TaxInvoiceIssue>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TaxInvoi__3214EC076E3167FF");

            entity.ToTable("TaxInvoiceIssue");

            entity.Property(e => e.IssueTitle).HasMaxLength(50);
        });

        modelBuilder.Entity<TaxInvoicePattern>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TaxInvoi__3214EC072D19CF5A");

            entity.ToTable("TaxInvoicePattern");

            entity.Property(e => e.PatternTitle).HasMaxLength(50);
        });

        modelBuilder.Entity<TaxInvoiceSettlement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TaxInvoi__3214EC072D5F1530");

            entity.ToTable("TaxInvoiceSettlement");

            entity.Property(e => e.SettlementTitle).HasMaxLength(50);
        });

        modelBuilder.Entity<TaxInvoiceStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TaxInvoi__3214EC0731BF903A");

            entity.ToTable("TaxInvoiceStatus");

            entity.Property(e => e.StatusTitle).HasMaxLength(50);
        });

        modelBuilder.Entity<TaxInvoiceType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TaxInvoi__3214EC07126F5071");

            entity.ToTable("TaxInvoiceType");

            entity.Property(e => e.TypeTitle).HasMaxLength(50);
        });

        modelBuilder.Entity<TaxInvoicesError>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TaxInvoi__3214EC072F18B0E3");

            entity.ToTable("TaxInvoices_Errors");

            entity.Property(e => e.Code).HasMaxLength(22);
            entity.Property(e => e.ErrorType).HasMaxLength(22);
            entity.Property(e => e.FkTaxErrorTypeId).HasColumnName("Fk_TaxErrorTypeId");
            entity.Property(e => e.FkTaxInvoiceId).HasColumnName("Fk_TaxInvoiceId");
            entity.Property(e => e.Message).HasMaxLength(1000);

            entity.HasOne(d => d.FkTaxErrorType).WithMany(p => p.TaxInvoicesErrors)
                .HasForeignKey(d => d.FkTaxErrorTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TaxInvoic__Fk_Ta__02C90097");

            entity.HasOne(d => d.FkTaxInvoice).WithMany(p => p.TaxInvoicesErrors)
                .HasForeignKey(d => d.FkTaxInvoiceId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__TaxInvoic__Fk_Ta__01D4DC5E");
        });

        modelBuilder.Entity<TaxInvoicesLog>(entity =>
        {
            entity.HasKey(e => e.SysCode).HasName("PK__TaxInvoi__EE72712D501B8B22");

            entity.ToTable("TaxInvoices_Log");

            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.FkTaxInvoiceIssueId).HasColumnName("Fk_TaxInvoiceIssueId");
            entity.Property(e => e.FkTaxInvoicePatternId).HasColumnName("Fk_TaxInvoicePatternId");
            entity.Property(e => e.FkTaxInvoiceSettlementId).HasColumnName("Fk_TaxInvoiceSettlementId");
            entity.Property(e => e.FkTaxInvoiceStatus).HasColumnName("Fk_TaxInvoiceStatus");
            entity.Property(e => e.FkTaxInvoiceTypeId).HasColumnName("Fk_TaxInvoiceTypeId");
            entity.Property(e => e.FkTaxSettingId).HasColumnName("Fk_TaxSettingId");
            entity.Property(e => e.FkUserId).HasColumnName("Fk_UserId");
            entity.Property(e => e.InNo).HasMaxLength(10);
            entity.Property(e => e.InvoiceUid).HasMaxLength(128);
            entity.Property(e => e.IrTaxId).HasMaxLength(22);
            entity.Property(e => e.RefrenceId).HasMaxLength(128);
            entity.Property(e => e.TaxId).HasMaxLength(22);
            entity.Property(e => e.UpdateDateTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<TaxPersonKind>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TaxPerso__3214EC07863F79EB");

            entity.ToTable("TaxPersonKind");

            entity.Property(e => e.PersonKindTitle).HasMaxLength(50);
        });

        modelBuilder.Entity<TaxSetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TaxSetti__3214EC07A250EE6A");

            entity.ToTable("TaxSetting");

            entity.HasIndex(e => e.MeliCode, "UQ__TaxSetti__59B24E73A71D4C7C").IsUnique();

            entity.Property(e => e.BaseUrl).HasMaxLength(100);
            entity.Property(e => e.CetificateCode)
                .HasMaxLength(4000)
                .HasColumnName("Cetificate_Code");
            entity.Property(e => e.EconomicCode).HasMaxLength(20);
            entity.Property(e => e.MeliCode).HasMaxLength(20);
            entity.Property(e => e.MemoryId)
                .HasMaxLength(20)
                .HasColumnName("Memory_Id");
            entity.Property(e => e.PrivateKey)
                .HasMaxLength(3000)
                .HasColumnName("Private_Key");
            entity.Property(e => e.PublickKey)
                .HasMaxLength(3000)
                .HasColumnName("Publick_Key");
            entity.Property(e => e.TitleFilaName)
                .HasMaxLength(150)
                .HasColumnName("Title_FilaName");
            entity.Property(e => e.ZipCode).HasMaxLength(20);
        });

        modelBuilder.Entity<TaxUnit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TaxUnit__3214EC07716B7865");

            entity.ToTable("TaxUnit");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Unit).HasMaxLength(50);
        });

        modelBuilder.Entity<TelBook>(entity =>
        {
            entity.ToTable("TelBook");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Comment).HasColumnType("ntext");
            entity.Property(e => e.Company).HasMaxLength(50);
            entity.Property(e => e.FkIdcity).HasColumnName("FK_IDCity");
            entity.Property(e => e.FkIdostan).HasColumnName("FK_IDOstan");
            entity.Property(e => e.FkZone).HasColumnName("FK_Zone");
            entity.Property(e => e.Latitude).HasColumnType("decimal(18, 14)");
            entity.Property(e => e.Longitude).HasColumnType("decimal(18, 14)");
            entity.Property(e => e.OwnerUserId).HasColumnName("OwnerUserID");
            entity.Property(e => e.TelegramId)
                .HasMaxLength(200)
                .HasColumnName("TelegramID");
            entity.Property(e => e.TelegramMobileNo).HasMaxLength(50);

            entity.HasOne(d => d.FkIdcityNavigation).WithMany(p => p.TelBooks)
                .HasForeignKey(d => d.FkIdcity)
                .HasConstraintName("FK__TelBook__FK_IDCi__5303482E");

            entity.HasOne(d => d.FkIdostanNavigation).WithMany(p => p.TelBooks)
                .HasForeignKey(d => d.FkIdostan)
                .HasConstraintName("FK__TelBook__FK_IDOs__53F76C67");
        });

        modelBuilder.Entity<TelNumber>(entity =>
        {
            entity.HasKey(e => e.SysCode);

            entity.Property(e => e.TelBookId).HasColumnName("TelBookID");
            entity.Property(e => e.TelNo).HasMaxLength(50);
            entity.Property(e => e.Title).HasMaxLength(50);

            entity.HasOne(d => d.TelBook).WithMany(p => p.TelNumbers)
                .HasForeignKey(d => d.TelBookId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_TelNumbers_TelBook");
        });

        modelBuilder.Entity<TelType>(entity =>
        {
            entity.HasKey(e => e.Fk);

            entity.Property(e => e.Fk)
                .ValueGeneratedNever()
                .HasColumnName("FK");
            entity.Property(e => e.TelTypes).HasMaxLength(50);
        });

        modelBuilder.Entity<TransferWareHoseDetailTbl>(entity =>
        {
            entity.HasKey(e => e.SysCode).HasName("PK__TransferWareHose__2D9CB955");

            entity.ToTable("TransferWareHoseDetailTbl");

            entity.Property(e => e.Comment).HasMaxLength(300);
            entity.Property(e => e.DateExpire)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.FkTransferSysCode).HasColumnName("FK_TransferSysCode");
            entity.Property(e => e.SerialNo).HasMaxLength(100);
            entity.Property(e => e.Unit).HasMaxLength(100);

            entity.HasOne(d => d.FkTransferSysCodeNavigation).WithMany(p => p.TransferWareHoseDetailTbls)
                .HasForeignKey(d => d.FkTransferSysCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TransferW__FK_Tr__2F8501C7");

            entity.HasOne(d => d.GoodSysCodeNavigation).WithMany(p => p.TransferWareHoseDetailTbls)
                .HasForeignKey(d => d.GoodSysCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TransferW__GoodS__2E90DD8E");
        });

        modelBuilder.Entity<TransferWareHoseTbl>(entity =>
        {
            entity.HasKey(e => e.TransferSerialNo).HasName("PK__TransferWareHose__2BB470E3");

            entity.ToTable("TransferWareHoseTbl");

            entity.Property(e => e.Comment).HasMaxLength(300);
            entity.Property(e => e.FkYearId)
                .HasDefaultValue((byte)1)
                .HasColumnName("Fk_YearId");
            entity.Property(e => e.Ismovaghat).HasColumnName("ISMovaghat");
            entity.Property(e => e.SysDate).HasColumnType("datetime");
            entity.Property(e => e.SysShamsiDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TransferDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.FkYear).WithMany(p => p.TransferWareHoseTbls)
                .HasForeignKey(d => d.FkYearId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TransferW__Fk_Ye__0D1184E0");

            entity.HasOne(d => d.UserNoNavigation).WithMany(p => p.TransferWareHoseTbls)
                .HasForeignKey(d => d.UserNo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TransferW__UserN__78F3E6EC");
        });

        modelBuilder.Entity<TypeOfSettlementTbl>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TypeOfSettlement__61516785");

            entity.ToTable("TypeOfSettlementTBL");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Settlement).HasMaxLength(100);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Uid);

            entity.Property(e => e.Uid).HasColumnName("UID");
            entity.Property(e => e.Gid).HasColumnName("GID");
            entity.Property(e => e.IsUpdatePersonTblDocList)
                .HasDefaultValue(true)
                .HasColumnName("IsUpdatePersonTbl_DocList");
            entity.Property(e => e.IsUpdatePersonTblInvoiceList)
                .HasDefaultValue(true)
                .HasColumnName("IsUpdatePersonTbl_InvoiceList");
            entity.Property(e => e.IsUpdateStockTbl).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.PassWord).HasMaxLength(4000);
            entity.Property(e => e.Uname)
                .HasMaxLength(1000)
                .HasColumnName("UName");

            entity.HasOne(d => d.GidNavigation).WithMany(p => p.Users)
                .HasForeignKey(d => d.Gid)
                .HasConstraintName("FK_Users_Groups");
        });

        modelBuilder.Entity<UserDefaultGridLayoutTbl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("UserDefaultGridLayoutTbl");
        });

        modelBuilder.Entity<UserDefaultPrintLayoutTbl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("UserDefaultPrintLayoutTbl");
        });

        modelBuilder.Entity<VideoViewLogTbl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("VideoViewLogTBL");

            entity.Property(e => e.FkUid).HasColumnName("FK_UID");
            entity.Property(e => e.FkVideoId).HasColumnName("FK_VideoID");
            entity.Property(e => e.ViewDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Visit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Visits__3214EC2726BD159B");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.FkAccountSysCode).HasColumnName("Fk_AccountSysCode");
            entity.Property(e => e.FkInvoiceSerialNo).HasColumnName("Fk_InvoiceSerialNo");
            entity.Property(e => e.FkVisitorSysCode).HasColumnName("Fk_VisitorSysCode");
            entity.Property(e => e.MiladiDate).HasColumnType("datetime");
            entity.Property(e => e.ShamsiDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.VisitsComment)
                .HasMaxLength(500)
                .HasColumnName("Visits_Comment");
            entity.Property(e => e.VisitsLat)
                .HasMaxLength(50)
                .HasColumnName("Visits_Lat");
            entity.Property(e => e.VisitsLong)
                .HasMaxLength(50)
                .HasColumnName("Visits_Long");
            entity.Property(e => e.VisitsStatus).HasColumnName("Visits_Status");

            entity.HasOne(d => d.Category).WithMany(p => p.Visits)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK__Visits__Category__2B161DBC");

            entity.HasOne(d => d.FkAccountSysCodeNavigation).WithMany(p => p.VisitFkAccountSysCodeNavigations)
                .HasForeignKey(d => d.FkAccountSysCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Visits__Fk_Accou__2839B111");

            entity.HasOne(d => d.FkInvoiceSerialNoNavigation).WithMany(p => p.Visits)
                .HasForeignKey(d => d.FkInvoiceSerialNo)
                .HasConstraintName("FK__Visits__Fk_Invoi__2A21F983");

            entity.HasOne(d => d.FkVisitorSysCodeNavigation).WithMany(p => p.VisitFkVisitorSysCodeNavigations)
                .HasForeignKey(d => d.FkVisitorSysCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Visits__Fk_Visit__292DD54A");
        });

        modelBuilder.Entity<VisitScaduleTbl>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__VisitScaduleTBL__711DBAFA");

            entity.ToTable("VisitScaduleTBL");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.FkVisitorId).HasColumnName("FK_VisitorID");
            entity.Property(e => e.FkZoneId).HasColumnName("FK_ZoneID");
            entity.Property(e => e.ShamsiDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Title).HasMaxLength(500);

            entity.HasOne(d => d.FkVisitor).WithMany(p => p.VisitScaduleTbls)
                .HasForeignKey(d => d.FkVisitorId)
                .HasConstraintName("FK__VisitScad__FK_Vi__7211DF33");

            entity.HasOne(d => d.FkZone).WithMany(p => p.VisitScaduleTbls)
                .HasForeignKey(d => d.FkZoneId)
                .HasConstraintName("FK__VisitScad__FK_Zo__7306036C");
        });

        modelBuilder.Entity<VisitsCategory>(entity =>
        {
            entity.HasKey(e => e.CategoryId).HasName("PK__VisitsCa__19093A0B01962469");

            entity.ToTable("VisitsCategory");

            entity.Property(e => e.CategoryId).ValueGeneratedOnAdd();
            entity.Property(e => e.Title).HasMaxLength(200);

            entity.HasOne(d => d.VisitTypeNavigation).WithMany(p => p.VisitsCategories)
                .HasForeignKey(d => d.VisitType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__VisitsCat__Visit__255D4466");
        });

        modelBuilder.Entity<VisitsType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__VisitsTy__3214EC27F3B49697");

            entity.ToTable("VisitsType");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Title).HasMaxLength(200);
        });

        modelBuilder.Entity<VwAccountCheckInUnPassSum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_Account_CheckInUnPass_Sum");

            entity.Property(e => e.Cur1Amount).HasColumnType("money");
            entity.Property(e => e.Cur2Amount).HasColumnType("money");
            entity.Property(e => e.Cur3Amount).HasColumnType("money");
            entity.Property(e => e.Remain).HasColumnType("money");
        });

        modelBuilder.Entity<VwAccountGhestInUnPassSum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_Account_GhestInUnPass_Sum");

            entity.Property(e => e.Cur1Amount).HasColumnType("money");
            entity.Property(e => e.Cur2Amount).HasColumnType("money");
            entity.Property(e => e.Cur3Amount).HasColumnType("money");
            entity.Property(e => e.Remain).HasColumnType("money");
        });

        modelBuilder.Entity<VwAccountRemain>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_Account_Remain");

            entity.Property(e => e.Cur1Amount).HasColumnType("money");
            entity.Property(e => e.Cur2Amount).HasColumnType("money");
            entity.Property(e => e.Cur3Amount).HasColumnType("money");
            entity.Property(e => e.LastDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.LastMiladiDate).HasColumnType("datetime");
            entity.Property(e => e.Remain).HasColumnType("money");
        });

        modelBuilder.Entity<VwAllBarcodeOfStockList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_AllBarcodeOfStockList");

            entity.Property(e => e.BarCode).HasMaxLength(100);
        });

        modelBuilder.Entity<VwAndroidMehr>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_AndroidMehr");

            entity.Property(e => e.BirthDayDate)
                .HasMaxLength(10)
                .HasColumnName("birthDayDate");
            entity.Property(e => e.CardId1).HasColumnName("CardID1");
            entity.Property(e => e.CardId2).HasColumnName("CardID2");
            entity.Property(e => e.CheckRemain).HasColumnType("money");
            entity.Property(e => e.CreditLimit).HasColumnType("money");
            entity.Property(e => e.FkAccountSysCode).HasColumnName("FK_AccountSysCode");
            entity.Property(e => e.FkIdkind).HasColumnName("FK_IDKind");
            entity.Property(e => e.FkPersonCommercial).HasColumnName("FK_PersonCommercial");
            entity.Property(e => e.Remain).HasColumnType("money");
            entity.Property(e => e.TelNo).HasMaxLength(50);
            entity.Property(e => e.TelbookAddress).HasColumnName("Telbook_Address");
            entity.Property(e => e.TelbookComment)
                .HasMaxLength(50)
                .HasColumnName("Telbook_Comment");
            entity.Property(e => e.VisitorBaseAmmount).HasColumnType("money");
            entity.Property(e => e.VisitorIncreaseAmmount).HasColumnType("money");
        });

        modelBuilder.Entity<VwCompleteInventory>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_CompleteInventory");

            entity.Property(e => e.ColorName).HasMaxLength(1000);
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.DateExpire)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DetailField1).HasMaxLength(1000);
            entity.Property(e => e.DetailField2).HasMaxLength(1000);
            entity.Property(e => e.Field1).HasMaxLength(1000);
            entity.Property(e => e.Field2).HasMaxLength(1000);
            entity.Property(e => e.Field3).HasMaxLength(1000);
            entity.Property(e => e.Field4).HasMaxLength(1000);
            entity.Property(e => e.Field5).HasMaxLength(1000);
            entity.Property(e => e.FkDistributorSysCode).HasColumnName("Fk_DistributorSysCode");
            entity.Property(e => e.FkDriversSysCode).HasColumnName("Fk_DriversSysCode");
            entity.Property(e => e.FkInventorySysCode).HasColumnName("FK_InventorySysCode");
            entity.Property(e => e.FkInvoiceSerial).HasColumnName("Fk_InvoiceSerial");
            entity.Property(e => e.FkTransferSerial).HasColumnName("Fk_TransferSerial");
            entity.Property(e => e.GoodsComment).HasMaxLength(300);
            entity.Property(e => e.SerialNo).HasMaxLength(100);
            entity.Property(e => e.ShamsiDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ShamsiSysDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.SizeName).HasMaxLength(1000);
            entity.Property(e => e.SysDate).HasColumnType("datetime");
            entity.Property(e => e.TypeTitle).HasMaxLength(100);
            entity.Property(e => e.Uname)
                .HasMaxLength(1000)
                .HasColumnName("UName");
            entity.Property(e => e.Unit).HasMaxLength(100);
            entity.Property(e => e.WareHouseName).HasMaxLength(1000);
        });

        modelBuilder.Entity<VwCompleteInvoice>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_CompleteInvoice");

            entity.Property(e => e.ArchiveName).HasMaxLength(100);
            entity.Property(e => e.Comment).HasMaxLength(300);
            entity.Property(e => e.CustomerName).HasMaxLength(300);
            entity.Property(e => e.DelivaredDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DetailComment).HasMaxLength(300);
            entity.Property(e => e.Fee).HasColumnType("money");
            entity.Property(e => e.FkAccountSysCode).HasColumnName("FK_AccountSysCode");
            entity.Property(e => e.FkDocsysCode).HasColumnName("FK_DocsysCode");
            entity.Property(e => e.FkInvoiceSysCode).HasColumnName("FK_InvoiceSysCode");
            entity.Property(e => e.FkProjectId).HasColumnName("Fk_ProjectID");
            entity.Property(e => e.FkYearId).HasColumnName("Fk_YearId");
            entity.Property(e => e.InvoiceDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PaymentDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RecivedDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.SerialNo).HasMaxLength(100);
            entity.Property(e => e.SysDate).HasColumnType("datetime");
            entity.Property(e => e.Term).HasMaxLength(1000);
            entity.Property(e => e.Unit).HasMaxLength(100);
            entity.Property(e => e.UserPrice).HasColumnType("money");
            entity.Property(e => e.VisitorAmount).HasColumnType("money");
        });

        modelBuilder.Entity<VwCompleteRemainAnbarTransfer>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_CompleteRemain_Anbar_Transfer");

            entity.Property(e => e.DateExpire)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.SerialNo).HasMaxLength(100);
        });

        modelBuilder.Entity<VwCompleteRemainAnbarTransferByTitle>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_CompleteRemain_Anbar_Transfer_ByTitle");

            entity.Property(e => e.ColorName).HasMaxLength(1000);
            entity.Property(e => e.DateExpire)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.SerialNo).HasMaxLength(100);
            entity.Property(e => e.SizeName).HasMaxLength(1000);
            entity.Property(e => e.WareHouseName).HasMaxLength(1000);
        });

        modelBuilder.Entity<VwCompleteVisit>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_CompleteVisits");

            entity.Property(e => e.CategoryTitle).HasMaxLength(200);
            entity.Property(e => e.Comment).HasMaxLength(500);
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Lat).HasMaxLength(50);
            entity.Property(e => e.Long).HasMaxLength(50);
            entity.Property(e => e.MiladiDate).HasColumnType("datetime");
            entity.Property(e => e.SatusTitle).HasMaxLength(200);
            entity.Property(e => e.ShamsiDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.StatusId).HasColumnName("StatusID");
            entity.Property(e => e.TotalAmount).HasColumnType("money");
        });

        modelBuilder.Entity<VwContactIdContactSumary>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_ContactId_ContactSumary");

            entity.Property(e => e.EghtesadCode).HasMaxLength(50);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("email");
            entity.Property(e => e.Family).HasMaxLength(50);
            entity.Property(e => e.FatherName).HasMaxLength(50);
            entity.Property(e => e.Fax)
                .HasMaxLength(50)
                .HasColumnName("fax");
            entity.Property(e => e.FkIdcity).HasColumnName("FK_IDCity");
            entity.Property(e => e.FkIdostan).HasColumnName("FK_IDOstan");
            entity.Property(e => e.FkZone).HasColumnName("FK_Zone");
            entity.Property(e => e.HesabNo).HasMaxLength(50);
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.MeliCode).HasMaxLength(50);
            entity.Property(e => e.Mobile).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.SabtNo).HasMaxLength(50);
            entity.Property(e => e.ShenasehMeli).HasMaxLength(50);
            entity.Property(e => e.Tel).HasMaxLength(50);
            entity.Property(e => e.ZipCode)
                .HasMaxLength(50)
                .HasColumnName("ZipCOde");
        });

        modelBuilder.Entity<VwGoodCardex>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_GoodCardex");

            entity.Property(e => e.ColorName).HasMaxLength(1000);
            entity.Property(e => e.FkDocsysCode).HasColumnName("FK_DocsysCode");
            entity.Property(e => e.FkProjectId).HasColumnName("Fk_ProjectID");
            entity.Property(e => e.FkYearId).HasColumnName("Fk_YearId");
            entity.Property(e => e.InvoiceDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.SerialNo).HasMaxLength(100);
            entity.Property(e => e.SizeName).HasMaxLength(1000);
            entity.Property(e => e.Title).HasMaxLength(1000);
            entity.Property(e => e.Type).HasMaxLength(200);
            entity.Property(e => e.WareHouseName).HasMaxLength(1000);
        });

        modelBuilder.Entity<VwGoodOrderIn>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_GoodOrderIn");
        });

        modelBuilder.Entity<VwGoodOrderOut>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_GoodOrderOut");
        });

        modelBuilder.Entity<VwInventoryGoodDetailRemain>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_InventoryGoodDetailRemain");

            entity.Property(e => e.DateExpire)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.SerialNo).HasMaxLength(100);
        });

        modelBuilder.Entity<VwInventoryGoodDetailRemainByTitle>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_InventoryGoodDetailRemain_ByTitle");

            entity.Property(e => e.ColorName).HasMaxLength(1000);
            entity.Property(e => e.DateExpire)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.SerialNo).HasMaxLength(100);
            entity.Property(e => e.SizeName).HasMaxLength(1000);
            entity.Property(e => e.WareHouseName).HasMaxLength(1000);
        });

        modelBuilder.Entity<VwInventoryGoodSimpleRemain>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_InventoryGoodSimpleRemain");
        });

        modelBuilder.Entity<VwInvoiceAndInventoryRemain>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_InvoiceAndInventoryRemain");

            entity.Property(e => e.DateExpire)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.SerialNo).HasMaxLength(100);
        });

        modelBuilder.Entity<VwInvoiceByInventory>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_InvoiceByInventory");

            entity.Property(e => e.Comment).HasMaxLength(300);
            entity.Property(e => e.DelivaredDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.FkAccountSysCode).HasColumnName("FK_AccountSysCode");
            entity.Property(e => e.FkDocsysCode).HasColumnName("FK_DocsysCode");
            entity.Property(e => e.InventoryDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InvoiceDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PaymentDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RecivedDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<VwInvoiceCostAmount>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_invoice_Cost_Amount");

            entity.Property(e => e.CostAmount).HasColumnType("money");
            entity.Property(e => e.FkInvoiceSysCode).HasColumnName("FK_InvoiceSysCode");
            entity.Property(e => e.FstUnitQty).HasColumnName("FstUnitQTY");
            entity.Property(e => e.GoodVisitorAmount).HasColumnType("money");
            entity.Property(e => e.InvoiceAmount).HasColumnType("money");
            entity.Property(e => e.InvoiceAmountAvarez).HasColumnType("money");
            entity.Property(e => e.InvoiceAmountMaliat).HasColumnType("money");
            entity.Property(e => e.SndUnitQty).HasColumnName("SndUnitQTY");
            entity.Property(e => e.TotalAmount).HasColumnType("money");
            entity.Property(e => e.TotalAmountWithMaliat).HasColumnType("money");
        });

        modelBuilder.Entity<VwInvoiceDetailCostPersonDocDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_InvoiceDetail_Cost_PersonDocDetail");

            entity.Property(e => e.Comment).HasMaxLength(300);
            entity.Property(e => e.InvoiceDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Title).HasMaxLength(1000);
            entity.Property(e => e.Unit)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwInvoiceListNotPaymentAndNoPaymentComplete>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_InvoiceList_NotPayment_AndNoPaymentComplete");

            entity.Property(e => e.AmountPayment).HasColumnType("money");
            entity.Property(e => e.ArchiveName).HasMaxLength(100);
            entity.Property(e => e.Comment).HasMaxLength(300);
            entity.Property(e => e.DelivaredDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DeliveredMiladiDate).HasColumnType("datetime");
            entity.Property(e => e.FkAccountSysCode).HasColumnName("FK_AccountSysCode");
            entity.Property(e => e.FkDocsysCode).HasColumnName("FK_DocsysCode");
            entity.Property(e => e.FkProjectId).HasColumnName("Fk_ProjectID");
            entity.Property(e => e.FkYearId).HasColumnName("Fk_YearId");
            entity.Property(e => e.InvoiceAmountAvarez).HasColumnType("money");
            entity.Property(e => e.InvoiceAmountAvarezMaliat).HasColumnType("money");
            entity.Property(e => e.InvoiceAmountMaliat).HasColumnType("money");
            entity.Property(e => e.InvoiceDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InvoiceMiladiDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PaymentMiladiDate).HasColumnType("datetime");
            entity.Property(e => e.RecievedMiladiDate).HasColumnType("datetime");
            entity.Property(e => e.RecivedDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Settlement).HasMaxLength(100);
            entity.Property(e => e.SysDate).HasColumnType("datetime");
            entity.Property(e => e.TotalAmount).HasColumnType("money");
            entity.Property(e => e.TotalAmountWithMaliat).HasColumnType("money");
            entity.Property(e => e.Type).HasMaxLength(200);
            entity.Property(e => e.Uname)
                .HasMaxLength(1000)
                .HasColumnName("UName");
        });

        modelBuilder.Entity<VwInvoiceListPayment>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_InvoiceList_Payment");

            entity.Property(e => e.AmountPayWithOutMaliat).HasColumnType("decimal(38, 6)");
            entity.Property(e => e.ArchiveName).HasMaxLength(100);
            entity.Property(e => e.Comment).HasMaxLength(300);
            entity.Property(e => e.DelivaredDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DeliveredMiladiDate).HasColumnType("datetime");
            entity.Property(e => e.DocDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Fee).HasColumnType("money");
            entity.Property(e => e.FkAccountSysCode).HasColumnName("FK_AccountSysCode");
            entity.Property(e => e.FkDocDetailSysCode).HasColumnName("FK_DocDetailSysCode");
            entity.Property(e => e.FkDocsysCode).HasColumnName("FK_DocsysCode");
            entity.Property(e => e.FkInvoiceSerial).HasColumnName("FK_InvoiceSerial");
            entity.Property(e => e.FkProjectId).HasColumnName("Fk_ProjectID");
            entity.Property(e => e.FkYearId).HasColumnName("Fk_YearId");
            entity.Property(e => e.InvoiceAmountAvarez).HasColumnType("money");
            entity.Property(e => e.InvoiceAmountAvarezMaliat).HasColumnType("money");
            entity.Property(e => e.InvoiceAmountMaliat).HasColumnType("money");
            entity.Property(e => e.InvoiceDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InvoiceMiladiDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PaymentMiladiDate).HasColumnType("datetime");
            entity.Property(e => e.RecievedMiladiDate).HasColumnType("datetime");
            entity.Property(e => e.RecivedDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Settlement).HasMaxLength(100);
            entity.Property(e => e.SysDate).HasColumnType("datetime");
            entity.Property(e => e.TotalAmount).HasColumnType("money");
            entity.Property(e => e.TotalAmountWithMaliat).HasColumnType("money");
            entity.Property(e => e.Type).HasMaxLength(200);
            entity.Property(e => e.Uname)
                .HasMaxLength(1000)
                .HasColumnName("UName");
        });

        modelBuilder.Entity<VwInvoiceSumPayment>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_InvoiceSumPayment");

            entity.Property(e => e.Fee).HasColumnType("money");
            entity.Property(e => e.FkInvoiceSerial).HasColumnName("FK_InvoiceSerial");
        });

        modelBuilder.Entity<VwInvoiceTasviehComplete>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_InvoiceTasviehComplete");

            entity.Property(e => e.AmmountIn)
                .HasColumnType("money")
                .HasColumnName("AmmountIN");
            entity.Property(e => e.AmmountOut)
                .HasColumnType("money")
                .HasColumnName("AmmountOUT");
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.FkAccountSyscode).HasColumnName("Fk_AccountSyscode");
        });

        modelBuilder.Entity<VwLastInvoiceOfPerson>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_LastInvoiceOfPerson");

            entity.Property(e => e.FkAccountSysCode).HasColumnName("FK_AccountSysCode");
            entity.Property(e => e.LastDay).HasColumnName("lastDay");
            entity.Property(e => e.LastInvoiceDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.LastInvoiceMiladiDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<VwLeadAccount>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_LeadAccounts");

            entity.Property(e => e.Balance).HasColumnType("money");
            entity.Property(e => e.Code)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.FkAccoutnSysCode).HasColumnName("Fk_AccoutnSysCode");
            entity.Property(e => e.FkAccoutnSysCode0).HasColumnName("Fk_AccoutnSysCode0");
            entity.Property(e => e.HasMngdwn).HasColumnName("Has_MNGDWN");
            entity.Property(e => e.SecurLevelTitle).HasMaxLength(1000);
            entity.Property(e => e.Title).HasMaxLength(250);
            entity.Property(e => e.TypeTitle).HasMaxLength(50);
        });

        modelBuilder.Entity<VwLeadAccountsTreeList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_LeadAccountsTreeList");

            entity.Property(e => e.Balance).HasColumnType("money");
            entity.Property(e => e.Code)
                .HasMaxLength(120)
                .IsUnicode(false);
            entity.Property(e => e.FkAccoutnSysCode).HasColumnName("Fk_AccoutnSysCode");
            entity.Property(e => e.FkAccoutnSysCode0).HasColumnName("Fk_AccoutnSysCode0");
            entity.Property(e => e.HasMngdwn).HasColumnName("Has_MNGDWN");
            entity.Property(e => e.Title).HasMaxLength(373);
        });

        modelBuilder.Entity<VwLeadAccountsWithParent>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_LeadAccountsWithParent");

            entity.Property(e => e.Code)
                .HasMaxLength(120)
                .IsUnicode(false);
            entity.Property(e => e.Code0)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Code1)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Code2)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.Code3)
                .HasMaxLength(120)
                .IsUnicode(false);
            entity.Property(e => e.Level0Id).HasColumnName("Level0ID");
            entity.Property(e => e.Level0Title).HasMaxLength(250);
            entity.Property(e => e.Level1Id).HasColumnName("Level1ID");
            entity.Property(e => e.Level1Title).HasMaxLength(250);
            entity.Property(e => e.Level2Id).HasColumnName("Level2ID");
            entity.Property(e => e.Level2Title).HasMaxLength(250);
            entity.Property(e => e.Level3Id).HasColumnName("level3ID");
            entity.Property(e => e.Level3Title).HasMaxLength(250);
        });

        modelBuilder.Entity<VwLinkToAccountTitle>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_LinkTo_Account&Title");

            entity.Property(e => e.FkAccountSysCode0).HasColumnName("FK_AccountSysCode0");
        });

        modelBuilder.Entity<VwMaliatMokarar>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_MaliatMokarar");

            entity.Property(e => e.EghtesadCode).HasMaxLength(50);
            entity.Property(e => e.FkIdcity).HasColumnName("FK_IDCity");
            entity.Property(e => e.FkIdostan).HasColumnName("FK_IDOstan");
            entity.Property(e => e.InvoiceDate)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Maliat).HasColumnName("maliat");
            entity.Property(e => e.MeliCode).HasMaxLength(50);
            entity.Property(e => e.ShenasehMeli).HasMaxLength(50);
            entity.Property(e => e.Tel).HasMaxLength(50);
            entity.Property(e => e.Title).HasMaxLength(1000);
            entity.Property(e => e.ZipCode)
                .HasMaxLength(50)
                .HasColumnName("ZipCOde");
        });

        modelBuilder.Entity<VwPersonList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_PersonList");

            entity.Property(e => e.BirthDayDate)
                .HasMaxLength(10)
                .HasColumnName("birthDayDate");
            entity.Property(e => e.CardId1).HasColumnName("CardID1");
            entity.Property(e => e.CardId2).HasColumnName("CardID2");
            entity.Property(e => e.FkAccountSysCode).HasColumnName("FK_AccountSysCode");
            entity.Property(e => e.FkIdkind).HasColumnName("FK_IDKind");
            entity.Property(e => e.VisitorBaseAmmount).HasColumnType("money");
            entity.Property(e => e.VisitorIncreaseAmmount).HasColumnType("money");
        });

        modelBuilder.Entity<VwPersonRemainCheckRemain>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_Person_Remain_CheckRemain");

            entity.Property(e => e.CheckRemain).HasColumnType("money");
            entity.Property(e => e.Remain).HasColumnType("money");
        });

        modelBuilder.Entity<VwPersonStateCityZone>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_Person_State_City_Zone");

            entity.Property(e => e.City).HasMaxLength(200);
            entity.Property(e => e.FkIdcity).HasColumnName("FK_IDCity");
            entity.Property(e => e.FkIdostan).HasColumnName("FK_IDOstan");
            entity.Property(e => e.FkZone).HasColumnName("FK_Zone");
            entity.Property(e => e.State).HasMaxLength(200);
            entity.Property(e => e.Zone).HasMaxLength(1000);
        });

        modelBuilder.Entity<VwPricingDetailComplete>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_PricingDetailComplete");

            entity.Property(e => e.Comment).HasMaxLength(2000);
            entity.Property(e => e.CommentRow).HasMaxLength(1000);
            entity.Property(e => e.Fee).HasColumnType("money");
            entity.Property(e => e.Field1).HasMaxLength(1000);
            entity.Property(e => e.Field2).HasMaxLength(1000);
            entity.Property(e => e.Field3).HasMaxLength(1000);
            entity.Property(e => e.FkPricingId).HasColumnName("Fk_PricingID");
            entity.Property(e => e.GoodTitle).HasMaxLength(1000);
            entity.Property(e => e.MiladiDate).HasColumnType("datetime");
            entity.Property(e => e.SalePrice1).HasColumnType("money");
            entity.Property(e => e.SalePrice2).HasColumnType("money");
            entity.Property(e => e.SalePrice3).HasColumnType("money");
            entity.Property(e => e.SalePrice4).HasColumnType("money");
            entity.Property(e => e.SalePrice5).HasColumnType("money");
            entity.Property(e => e.ShamsiDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.SysMiladiDate).HasColumnType("datetime");
            entity.Property(e => e.SysShamsiDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Uname)
                .HasMaxLength(1000)
                .HasColumnName("UName");
        });

        modelBuilder.Entity<VwRemainGoodTolidi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_RemainGoodTolidi");

            entity.Property(e => e.Qty).HasColumnName("qty");
        });

        modelBuilder.Entity<VwSysGoodRemainDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_Sys_GoodRemainDetail");

            entity.Property(e => e.Qty).HasColumnName("QTY");
            entity.Property(e => e.SerialNo).HasMaxLength(100);
        });

        modelBuilder.Entity<VwSysGoodRemainSimple>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_Sys_GoodRemainSimple");

            entity.Property(e => e.Qty).HasColumnName("QTY");
        });

        modelBuilder.Entity<VwTaxErrorComplete>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_TaxError_Complete");

            entity.Property(e => e.Code).HasMaxLength(22);
            entity.Property(e => e.ErrorTitle).HasMaxLength(50);
            entity.Property(e => e.ErrorType).HasMaxLength(22);
            entity.Property(e => e.FkTaxErrorTypeId).HasColumnName("Fk_TaxErrorTypeId");
            entity.Property(e => e.FkTaxInvoiceId).HasColumnName("Fk_TaxInvoiceId");
            entity.Property(e => e.Message).HasMaxLength(1000);
        });

        modelBuilder.Entity<VwTaxInvoiceAmount>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_TaxInvoice_Amount");

            entity.Property(e => e.AmountAfterDisTadis).HasColumnName("AmountAfterDis_Tadis");
            entity.Property(e => e.AmountBeforeDisTprdis).HasColumnName("AmountBeforeDis_Tprdis");
            entity.Property(e => e.DiscountAmountTdis).HasColumnName("DiscountAmount_Tdis");
            entity.Property(e => e.FkInvoiceSysCode).HasColumnName("FK_InvoiceSysCode");
            entity.Property(e => e.MaliatAvarezAmountTvam).HasColumnName("MaliatAvarezAmount_Tvam");
            entity.Property(e => e.TotalAmountTbill).HasColumnName("TotalAmount_Tbill");
        });

        modelBuilder.Entity<VwTaxInvoiceBody>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_TaxInvoiceBody");

            entity.Property(e => e.AmountAfterDisAdis).HasColumnName("AmountAfterDis_Adis");
            entity.Property(e => e.AmountBeforeDisPrdis).HasColumnName("AmountBeforeDis_Prdis");
            entity.Property(e => e.DiscountAmountDis).HasColumnName("DiscountAmount_Dis");
            entity.Property(e => e.Fee).HasColumnType("money");
            entity.Property(e => e.FkInvoiceSysCode).HasColumnName("FK_InvoiceSysCode");
            entity.Property(e => e.MaliatAvarezAmountVam).HasColumnName("MaliatAvarezAmount_Vam");
            entity.Property(e => e.MaliatAvarezPerVra).HasColumnName("MaliatAvarezPer_Vra");
            entity.Property(e => e.QuantityAm).HasColumnName("Quantity_Am");
            entity.Property(e => e.TaxIdSstid).HasColumnName("TaxId_Sstid");
            entity.Property(e => e.TaxUnit).HasMaxLength(50);
            entity.Property(e => e.TaxUnitIdMu).HasColumnName("TaxUnitId_Mu");
            entity.Property(e => e.TitleSstt)
                .HasMaxLength(1000)
                .HasColumnName("Title_Sstt");
            entity.Property(e => e.TotalAmountTsstam).HasColumnName("TotalAmount_Tsstam");
        });

        modelBuilder.Entity<VwTaxInvoiceComplete>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_TaxInvoice_Complete");

            entity.Property(e => e.CashAmount).HasColumnType("money");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.FkTaxInvoiceIssueId).HasColumnName("Fk_TaxInvoiceIssueId");
            entity.Property(e => e.FkTaxInvoicePatternId).HasColumnName("Fk_TaxInvoicePatternId");
            entity.Property(e => e.FkTaxInvoiceSettlementId).HasColumnName("Fk_TaxInvoiceSettlementId");
            entity.Property(e => e.FkTaxInvoiceStatus).HasColumnName("Fk_TaxInvoiceStatus");
            entity.Property(e => e.FkTaxInvoiceTypeId).HasColumnName("Fk_TaxInvoiceTypeId");
            entity.Property(e => e.FkTaxSettingId).HasColumnName("Fk_TaxSettingId");
            entity.Property(e => e.FkUserId).HasColumnName("Fk_UserId");
            entity.Property(e => e.InNo).HasMaxLength(10);
            entity.Property(e => e.InvoiceUid).HasMaxLength(128);
            entity.Property(e => e.IrTaxId).HasMaxLength(22);
            entity.Property(e => e.IssueTitle).HasMaxLength(50);
            entity.Property(e => e.MemoryId)
                .HasMaxLength(20)
                .HasColumnName("Memory_Id");
            entity.Property(e => e.PatternTitle).HasMaxLength(50);
            entity.Property(e => e.PersonAmount).HasColumnType("money");
            entity.Property(e => e.RefrenceId).HasMaxLength(128);
            entity.Property(e => e.SellerEconomicCode)
                .HasMaxLength(20)
                .HasColumnName("Seller_EconomicCode");
            entity.Property(e => e.SellerMeliCode)
                .HasMaxLength(20)
                .HasColumnName("Seller_MeliCode");
            entity.Property(e => e.SellerZipCode)
                .HasMaxLength(20)
                .HasColumnName("Seller_ZipCode");
            entity.Property(e => e.SettlementTitle).HasMaxLength(50);
            entity.Property(e => e.StatusTitle).HasMaxLength(50);
            entity.Property(e => e.TaxId).HasMaxLength(22);
            entity.Property(e => e.TaxUname)
                .HasMaxLength(1000)
                .HasColumnName("TaxUName");
            entity.Property(e => e.TitleFilaName)
                .HasMaxLength(150)
                .HasColumnName("Title_FilaName");
            entity.Property(e => e.TypeTitle).HasMaxLength(50);
            entity.Property(e => e.UpdateDateTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<VwTaxInvoiceCompleteLastStatus>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_TaxInvoice_Complete_LastStatus");

            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.FkTaxInvoiceIssueId).HasColumnName("Fk_TaxInvoiceIssueId");
            entity.Property(e => e.FkTaxInvoicePatternId).HasColumnName("Fk_TaxInvoicePatternId");
            entity.Property(e => e.FkTaxInvoiceSettlementId).HasColumnName("Fk_TaxInvoiceSettlementId");
            entity.Property(e => e.FkTaxInvoiceStatus).HasColumnName("Fk_TaxInvoiceStatus");
            entity.Property(e => e.FkTaxInvoiceTypeId).HasColumnName("Fk_TaxInvoiceTypeId");
            entity.Property(e => e.FkTaxSettingId).HasColumnName("Fk_TaxSettingId");
            entity.Property(e => e.InNo).HasMaxLength(10);
            entity.Property(e => e.InvoiceUid).HasMaxLength(128);
            entity.Property(e => e.IrTaxId).HasMaxLength(22);
            entity.Property(e => e.MemoryId)
                .HasMaxLength(20)
                .HasColumnName("Memory_Id");
            entity.Property(e => e.PatternTitle).HasMaxLength(50);
            entity.Property(e => e.RefrenceId).HasMaxLength(128);
            entity.Property(e => e.SellerEconomicCode)
                .HasMaxLength(20)
                .HasColumnName("Seller_EconomicCode");
            entity.Property(e => e.SellerMeliCode)
                .HasMaxLength(20)
                .HasColumnName("Seller_MeliCode");
            entity.Property(e => e.SellerZipCode)
                .HasMaxLength(20)
                .HasColumnName("Seller_ZipCode");
            entity.Property(e => e.SettlementTitle).HasMaxLength(50);
            entity.Property(e => e.StatusTitle).HasMaxLength(50);
            entity.Property(e => e.TaxId).HasMaxLength(22);
            entity.Property(e => e.TaxUname)
                .HasMaxLength(1000)
                .HasColumnName("TaxUName");
            entity.Property(e => e.TitleFilaName)
                .HasMaxLength(150)
                .HasColumnName("Title_FilaName");
            entity.Property(e => e.TypeTitle).HasMaxLength(50);
            entity.Property(e => e.UpdateDateTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<VwTaxInvoiceLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_TaxInvoice_Log");

            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.FkTaxInvoicePatternId).HasColumnName("Fk_TaxInvoicePatternId");
            entity.Property(e => e.FkTaxInvoiceSettlementId).HasColumnName("Fk_TaxInvoiceSettlementId");
            entity.Property(e => e.FkTaxInvoiceStatus).HasColumnName("Fk_TaxInvoiceStatus");
            entity.Property(e => e.FkTaxInvoiceTypeId).HasColumnName("Fk_TaxInvoiceTypeId");
            entity.Property(e => e.FkUserId).HasColumnName("Fk_UserId");
            entity.Property(e => e.InNo).HasMaxLength(10);
            entity.Property(e => e.InvoiceUid).HasMaxLength(128);
            entity.Property(e => e.IrTaxId).HasMaxLength(22);
            entity.Property(e => e.IssueTitle).HasMaxLength(50);
            entity.Property(e => e.MemoryId)
                .HasMaxLength(20)
                .HasColumnName("Memory_Id");
            entity.Property(e => e.PatternTitle).HasMaxLength(50);
            entity.Property(e => e.RefrenceId).HasMaxLength(128);
            entity.Property(e => e.SettlementTitle).HasMaxLength(50);
            entity.Property(e => e.StatusTitle).HasMaxLength(50);
            entity.Property(e => e.TaxId).HasMaxLength(22);
            entity.Property(e => e.TitleFilaName)
                .HasMaxLength(150)
                .HasColumnName("Title_FilaName");
            entity.Property(e => e.TypeTitle).HasMaxLength(50);
            entity.Property(e => e.Uname)
                .HasMaxLength(1000)
                .HasColumnName("UName");
            entity.Property(e => e.UpdateDateTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<VwTaxPersonComplete>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_TaxPerson_Complete");

            entity.Property(e => e.City).HasMaxLength(200);
            entity.Property(e => e.EghtesadCode).HasMaxLength(50);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("email");
            entity.Property(e => e.Fax)
                .HasMaxLength(50)
                .HasColumnName("fax");
            entity.Property(e => e.FkTaxPersonKindId).HasColumnName("Fk_TaxPersonKindId");
            entity.Property(e => e.HesabNo).HasMaxLength(50);
            entity.Property(e => e.MeliCode).HasMaxLength(50);
            entity.Property(e => e.Mobile).HasMaxLength(50);
            entity.Property(e => e.PersonKindTitle).HasMaxLength(50);
            entity.Property(e => e.SabtNo).HasMaxLength(50);
            entity.Property(e => e.ShenasehMeli).HasMaxLength(50);
            entity.Property(e => e.State).HasMaxLength(200);
            entity.Property(e => e.Tel).HasMaxLength(50);
            entity.Property(e => e.ZipCode)
                .HasMaxLength(50)
                .HasColumnName("ZipCOde");
        });

        modelBuilder.Entity<VwTransferAndInventoryRemain>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_TransferAndInventoryRemain");

            entity.Property(e => e.DateExpire)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.SerialNo).HasMaxLength(100);
            entity.Property(e => e.Sign).HasColumnName("sign");
        });

        modelBuilder.Entity<VwVisitorDriverMovaze>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_Visitor_Driver_Movaze");

            entity.Property(e => e.تلفنبازاریاب2)
                .HasMaxLength(50)
                .HasColumnName("تلفن بازاریاب 2");
            entity.Property(e => e.تلفنراننده)
                .HasMaxLength(50)
                .HasColumnName("تلفن راننده");
            entity.Property(e => e.تلفنموزع)
                .HasMaxLength(50)
                .HasColumnName("تلفن موزع");
            entity.Property(e => e.موبایلبازاریاب2)
                .HasMaxLength(50)
                .HasColumnName("موبایل بازاریاب 2");
            entity.Property(e => e.موبایلراننده)
                .HasMaxLength(50)
                .HasColumnName("موبایل راننده");
            entity.Property(e => e.موبایلموزع)
                .HasMaxLength(50)
                .HasColumnName("موبایل موزع");
            entity.Property(e => e.نامراننده).HasColumnName("نام راننده");
            entity.Property(e => e.نامموزع).HasColumnName("نام موزع");
            entity.Property(e => e.نحوهتسویه)
                .HasMaxLength(100)
                .HasColumnName("نحوه تسویه");
        });

        modelBuilder.Entity<VwWareHouseTransferComplete>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_WareHouseTransferComplete");

            entity.Property(e => e.AccountTitle)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.BarCode).HasMaxLength(100);
            entity.Property(e => e.Code).HasMaxLength(100);
            entity.Property(e => e.Color).HasMaxLength(1000);
            entity.Property(e => e.Comment).HasMaxLength(300);
            entity.Property(e => e.CultureName)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.CurFee)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.CurName)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.DateExpire)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DelivaredDate)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.FkAccountSysCode).HasColumnName("FK_AccountSysCode");
            entity.Property(e => e.FkDocsysCode).HasColumnName("FK_DocsysCode");
            entity.Property(e => e.FkYearId).HasColumnName("Fk_YearId");
            entity.Property(e => e.FollowDate)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.GoodTitle).HasMaxLength(1000);
            entity.Property(e => e.GroupName1)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.GroupName2)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceComment).HasMaxLength(300);
            entity.Property(e => e.InvoiceDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InvoiceType).HasMaxLength(17);
            entity.Property(e => e.PersonGroup1)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("personGroup1");
            entity.Property(e => e.PersonGroup2)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("personGroup2");
            entity.Property(e => e.RecivedDate)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.SerialNo).HasMaxLength(100);
            entity.Property(e => e.Size).HasMaxLength(1000);
            entity.Property(e => e.TempInvoice)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Term).HasMaxLength(1000);
            entity.Property(e => e.Uname)
                .HasMaxLength(1000)
                .HasColumnName("UName");
            entity.Property(e => e.Unit).HasMaxLength(100);
            entity.Property(e => e.Visitor)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.VisitorRowName)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.WareHouse).HasMaxLength(1000);
            entity.Property(e => e.WareHouseId).HasColumnName("WareHouseID");
        });

        modelBuilder.Entity<VwWarehouseCounting>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_WarehouseCounting");

            entity.Property(e => e.Comment).HasMaxLength(500);
            entity.Property(e => e.EditMiladiDate).HasColumnType("datetime");
            entity.Property(e => e.EditShamsiDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.EditUname)
                .HasMaxLength(1000)
                .HasColumnName("EditUName");
            entity.Property(e => e.FkDocSysCodeIn).HasColumnName("Fk_DocSysCodeIn");
            entity.Property(e => e.FkDocSysCodeOut).HasColumnName("Fk_DocSysCodeOut");
            entity.Property(e => e.MiladiDate).HasColumnType("datetime");
            entity.Property(e => e.RegMiladiDate).HasColumnType("datetime");
            entity.Property(e => e.RegShamsiDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RegUname)
                .HasMaxLength(1000)
                .HasColumnName("RegUName");
            entity.Property(e => e.ShamsiDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<VwWarehouseCountingDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_WarehouseCountingDetail");

            entity.Property(e => e.ColorName).HasMaxLength(1000);
            entity.Property(e => e.Comment).HasMaxLength(500);
            entity.Property(e => e.DateExpire)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Fee).HasColumnType("money");
            entity.Property(e => e.FkDocSysCodeIn).HasColumnName("Fk_DocSysCodeIn");
            entity.Property(e => e.FkDocSysCodeOut).HasColumnName("Fk_DocSysCodeOut");
            entity.Property(e => e.FkProjectId).HasColumnName("Fk_ProjectId");
            entity.Property(e => e.FkYearId).HasColumnName("Fk_YearId");
            entity.Property(e => e.GoodTitle).HasMaxLength(1000);
            entity.Property(e => e.MiladiDate).HasColumnType("datetime");
            entity.Property(e => e.RegShamsiDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.SerialNo).HasMaxLength(100);
            entity.Property(e => e.ShamsiDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.SizeName).HasMaxLength(1000);
            entity.Property(e => e.Unit).HasMaxLength(100);
            entity.Property(e => e.WareHouseName).HasMaxLength(1000);
        });

        modelBuilder.Entity<VwcompleteCode>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VWCompleteCode");

            entity.Property(e => e.CreditLimit).HasColumnType("money");
        });

        modelBuilder.Entity<VwcompleteGood>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VWCompleteGood");

            entity.Property(e => e.BarCode).HasMaxLength(100);
            entity.Property(e => e.BuyLastFee).HasColumnType("money");
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.CategoryTitle).HasMaxLength(200);
            entity.Property(e => e.Code).HasMaxLength(100);
            entity.Property(e => e.Comment).HasMaxLength(300);
            entity.Property(e => e.Field1).HasMaxLength(1000);
            entity.Property(e => e.Field2).HasMaxLength(1000);
            entity.Property(e => e.Field3).HasMaxLength(1000);
            entity.Property(e => e.Field4).HasMaxLength(200);
            entity.Property(e => e.Field5).HasMaxLength(200);
            entity.Property(e => e.FstUnit).HasMaxLength(100);
            entity.Property(e => e.GroupId3).HasColumnName("GroupID3");
            entity.Property(e => e.GroupName1).HasMaxLength(100);
            entity.Property(e => e.GroupName2).HasMaxLength(100);
            entity.Property(e => e.GroupName3).HasMaxLength(100);
            entity.Property(e => e.ImageName).HasMaxLength(1000);
            entity.Property(e => e.LastFeeNoCost).HasColumnType("money");
            entity.Property(e => e.Located).HasMaxLength(200);
            entity.Property(e => e.MaxQty).HasColumnName("MaxQTY");
            entity.Property(e => e.RtlTolft).HasColumnName("rtlTOlft");
            entity.Property(e => e.SalePrice1).HasColumnType("money");
            entity.Property(e => e.SalePrice2).HasColumnType("money");
            entity.Property(e => e.SalePrice3).HasColumnType("money");
            entity.Property(e => e.SalePrice4).HasColumnType("money");
            entity.Property(e => e.SalePrice5).HasColumnType("money");
            entity.Property(e => e.SecUnit).HasMaxLength(100);
            entity.Property(e => e.TechnicalBox).HasColumnType("ntext");
            entity.Property(e => e.Term).HasMaxLength(1000);
            entity.Property(e => e.Title).HasMaxLength(1000);
            entity.Property(e => e.Type).HasMaxLength(1000);
            entity.Property(e => e.UserPrice).HasColumnType("money");
        });

        modelBuilder.Entity<VwdocumentDetailDocHeader>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VWDocumentDetail_DocHeader");

            entity.Property(e => e.AmmountIn)
                .HasColumnType("money")
                .HasColumnName("AmmountIN");
            entity.Property(e => e.AmmountOut)
                .HasColumnType("money")
                .HasColumnName("AmmountOUT");
            entity.Property(e => e.ArchiveName).HasMaxLength(1000);
            entity.Property(e => e.Code)
                .HasMaxLength(120)
                .IsUnicode(false);
            entity.Property(e => e.Comment).HasMaxLength(1000);
            entity.Property(e => e.Cur1Amount).HasColumnType("money");
            entity.Property(e => e.Cur2Amount).HasColumnType("money");
            entity.Property(e => e.Cur3Amount).HasColumnType("money");
            entity.Property(e => e.DocDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DocMiladiDate).HasColumnType("datetime");
            entity.Property(e => e.FkAccountId).HasColumnName("Fk_AccountId");
            entity.Property(e => e.FkAccountSyscode).HasColumnName("Fk_AccountSyscode");
            entity.Property(e => e.FkDocSysCode).HasColumnName("Fk_docSysCode");
            entity.Property(e => e.FkProjectId).HasColumnName("Fk_ProjectID");
            entity.Property(e => e.FkTypeId).HasColumnName("Fk_TypeID");
            entity.Property(e => e.FkVisitorSysCode).HasColumnName("FK_VisitorSysCode");
            entity.Property(e => e.FkYearId).HasColumnName("Fk_YearId");
            entity.Property(e => e.Level0Id).HasColumnName("Level0ID");
            entity.Property(e => e.Level0Title).HasMaxLength(250);
            entity.Property(e => e.Level1Id).HasColumnName("Level1ID");
            entity.Property(e => e.Level1Title).HasMaxLength(250);
            entity.Property(e => e.Level2Id).HasColumnName("Level2ID");
            entity.Property(e => e.Level2Title).HasMaxLength(250);
            entity.Property(e => e.Level3Id).HasColumnName("level3ID");
            entity.Property(e => e.Level3Title).HasMaxLength(250);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.ProjectName).HasMaxLength(500);
            entity.Property(e => e.SndFkAccountSyscode).HasColumnName("SndFk_AccountSyscode");
            entity.Property(e => e.StrCode).HasMaxLength(13);
            entity.Property(e => e.SysDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<VwdocumentDetailDocHeaderNotTemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VWDocumentDetail_DocHeader_NotTemp");

            entity.Property(e => e.AmmountIn)
                .HasColumnType("money")
                .HasColumnName("AmmountIN");
            entity.Property(e => e.AmmountOut)
                .HasColumnType("money")
                .HasColumnName("AmmountOUT");
            entity.Property(e => e.ArchiveName).HasMaxLength(1000);
            entity.Property(e => e.Code)
                .HasMaxLength(120)
                .IsUnicode(false);
            entity.Property(e => e.Code0)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Code1)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Code2)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.Code3)
                .HasMaxLength(120)
                .IsUnicode(false);
            entity.Property(e => e.Comment).HasMaxLength(1000);
            entity.Property(e => e.Cur1Amount).HasColumnType("money");
            entity.Property(e => e.Cur2Amount).HasColumnType("money");
            entity.Property(e => e.Cur3Amount).HasColumnType("money");
            entity.Property(e => e.DocDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DocMiladiDate).HasColumnType("datetime");
            entity.Property(e => e.FkAccountId).HasColumnName("Fk_AccountId");
            entity.Property(e => e.FkAccountSyscode).HasColumnName("Fk_AccountSyscode");
            entity.Property(e => e.FkDocSysCode).HasColumnName("Fk_docSysCode");
            entity.Property(e => e.FkProjectId).HasColumnName("Fk_ProjectID");
            entity.Property(e => e.FkTypeId).HasColumnName("Fk_TypeID");
            entity.Property(e => e.FkVisitorSysCode).HasColumnName("FK_VisitorSysCode");
            entity.Property(e => e.FkYearId).HasColumnName("Fk_YearId");
            entity.Property(e => e.Level0Id).HasColumnName("Level0ID");
            entity.Property(e => e.Level0Title).HasMaxLength(250);
            entity.Property(e => e.Level1Id).HasColumnName("Level1ID");
            entity.Property(e => e.Level1Title).HasMaxLength(250);
            entity.Property(e => e.Level2Id).HasColumnName("Level2ID");
            entity.Property(e => e.Level2Title).HasMaxLength(250);
            entity.Property(e => e.Level3Id).HasColumnName("level3ID");
            entity.Property(e => e.Level3Title).HasMaxLength(250);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.ProjectName).HasMaxLength(500);
            entity.Property(e => e.SndFkAccountSyscode).HasColumnName("SndFk_AccountSyscode");
            entity.Property(e => e.StrCode).HasMaxLength(13);
            entity.Property(e => e.SysDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<VwgoodAvrageFee>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VWGoodAvrageFee");

            entity.Property(e => e.AvgFee).HasColumnType("money");
        });

        modelBuilder.Entity<VwgoodDetailRemain>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VWGoodDetailRemain");

            entity.Property(e => e.DateExpire)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.SerialNo).HasMaxLength(100);
        });

        modelBuilder.Entity<VwgoodDetailRemainForPropertyInvoice>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VWGoodDetailRemainForPropertyInvoice");

            entity.Property(e => e.DateExpire)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.SerialNo).HasMaxLength(100);
        });

        modelBuilder.Entity<VwgoodReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VWGoodReport");

            entity.Property(e => e.BarCode).HasMaxLength(100);
            entity.Property(e => e.BaseRate).HasColumnType("money");
            entity.Property(e => e.Code).HasMaxLength(100);
            entity.Property(e => e.Color).HasMaxLength(1000);
            entity.Property(e => e.Comment).HasMaxLength(300);
            entity.Property(e => e.Cost).HasColumnType("money");
            entity.Property(e => e.CultureName).HasMaxLength(50);
            entity.Property(e => e.CurFee).HasColumnType("money");
            entity.Property(e => e.CurName).HasMaxLength(50);
            entity.Property(e => e.CurRateDef).HasColumnType("money");
            entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");
            entity.Property(e => e.CustomerName).HasMaxLength(300);
            entity.Property(e => e.DelivaredDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DiscountFee).HasColumnType("money");
            entity.Property(e => e.Fee).HasColumnType("money");
            entity.Property(e => e.FkAccountSysCode).HasColumnName("FK_AccountSysCode");
            entity.Property(e => e.FkDocsysCode).HasColumnName("FK_DocsysCode");
            entity.Property(e => e.FkProjectId).HasColumnName("Fk_ProjectID");
            entity.Property(e => e.FkYearId).HasColumnName("Fk_YearId");
            entity.Property(e => e.FollowDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.GoodTitle).HasMaxLength(1000);
            entity.Property(e => e.GroupName1).HasMaxLength(100);
            entity.Property(e => e.GroupName2).HasMaxLength(100);
            entity.Property(e => e.GroupName3).HasMaxLength(100);
            entity.Property(e => e.InvoiceComment).HasMaxLength(300);
            entity.Property(e => e.InvoiceDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InvoiceType).HasMaxLength(200);
            entity.Property(e => e.PersonGroup1)
                .HasMaxLength(100)
                .HasColumnName("personGroup1");
            entity.Property(e => e.PersonGroup2)
                .HasMaxLength(100)
                .HasColumnName("personGroup2");
            entity.Property(e => e.RecivedDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.SerialNo).HasMaxLength(100);
            entity.Property(e => e.Size).HasMaxLength(1000);
            entity.Property(e => e.TempInvoice).HasMaxLength(10);
            entity.Property(e => e.Term).HasMaxLength(1000);
            entity.Property(e => e.Uname)
                .HasMaxLength(1000)
                .HasColumnName("UName");
            entity.Property(e => e.Unit).HasMaxLength(100);
            entity.Property(e => e.VisitorFee).HasColumnType("money");
            entity.Property(e => e.WareHouse).HasMaxLength(1000);
        });

        modelBuilder.Entity<VwgoodSimpleLastCurrencySummary>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VWGoodSimpleLastCurrencySummary");

            entity.Property(e => e.BaseRate).HasColumnType("money");
            entity.Property(e => e.CurFee).HasColumnType("money");
            entity.Property(e => e.CurName).HasMaxLength(50);
            entity.Property(e => e.CurRateDef).HasColumnType("money");
            entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");
            entity.Property(e => e.InvoiceDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<VwgoodSimpleLastSummary>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VWGoodSimpleLastSummary");

            entity.Property(e => e.LastDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.LastSeller).HasMaxLength(300);
        });

        modelBuilder.Entity<VwgoodSimpleRemain>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VWGoodSimpleRemain");
        });

        modelBuilder.Entity<VwinvoiceDetailComplete>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VWInvoiceDetailComplete");

            entity.Property(e => e.BenefitCost).HasColumnType("money");
            entity.Property(e => e.Comment).HasMaxLength(300);
            entity.Property(e => e.CommentRow).HasMaxLength(300);
            entity.Property(e => e.Cost).HasColumnType("money");
            entity.Property(e => e.CustomerName).HasMaxLength(300);
            entity.Property(e => e.DateExpire)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DelivaredDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DiscountFee).HasColumnType("money");
            entity.Property(e => e.Field3).HasMaxLength(200);
            entity.Property(e => e.Field4).HasMaxLength(200);
            entity.Property(e => e.FkAccountSysCode).HasColumnName("FK_AccountSysCode");
            entity.Property(e => e.FkDocsysCode).HasColumnName("FK_DocsysCode");
            entity.Property(e => e.FkProjectId).HasColumnName("Fk_ProjectID");
            entity.Property(e => e.FkYearId).HasColumnName("Fk_YearId");
            entity.Property(e => e.GrossFee).HasColumnType("money");
            entity.Property(e => e.GroupId1).HasColumnName("GroupID1");
            entity.Property(e => e.GroupId2).HasColumnName("GroupID2");
            entity.Property(e => e.GroupId3).HasColumnName("GroupID3");
            entity.Property(e => e.InvoiceDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InvoiceMiladiDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RecivedDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.SerialNo).HasMaxLength(100);
            entity.Property(e => e.SysDate).HasColumnType("datetime");
            entity.Property(e => e.SysShamsiDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Term).HasMaxLength(1000);
            entity.Property(e => e.Title).HasMaxLength(1000);
            entity.Property(e => e.Unit).HasMaxLength(100);
            entity.Property(e => e.VisitorFee).HasColumnType("money");
        });

        modelBuilder.Entity<VwinvoiceDetailCompleteForAndroid>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VWInvoiceDetailCompleteForAndroid");

            entity.Property(e => e.ColorName).HasMaxLength(1000);
            entity.Property(e => e.FkAccountSysCode).HasColumnName("FK_AccountSysCode");
            entity.Property(e => e.FkDocsysCode).HasColumnName("FK_DocsysCode");
            entity.Property(e => e.GoodName).HasMaxLength(1000);
            entity.Property(e => e.InvoiceComment).HasMaxLength(300);
            entity.Property(e => e.InvoiceDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InvoiceType).HasMaxLength(200);
            entity.Property(e => e.SizeName).HasMaxLength(1000);
            entity.Property(e => e.Unit).HasMaxLength(100);
            entity.Property(e => e.WareHouseName).HasMaxLength(1000);
        });

        modelBuilder.Entity<WareHouseTbl>(entity =>
        {
            entity.HasKey(e => e.SysCode);

            entity.ToTable("WareHouseTbl");

            entity.Property(e => e.WareHouseName).HasMaxLength(1000);
        });

        modelBuilder.Entity<WarehouseCounting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Warehous__3214EC070EF0EFA7");

            entity.ToTable("WarehouseCounting");

            entity.Property(e => e.Comment).HasMaxLength(500);
            entity.Property(e => e.EditMiladiDate).HasColumnType("datetime");
            entity.Property(e => e.EditShamsiDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.FkDocSysCodeIn).HasColumnName("Fk_DocSysCodeIn");
            entity.Property(e => e.FkDocSysCodeOut).HasColumnName("Fk_DocSysCodeOut");
            entity.Property(e => e.FkProjectId).HasColumnName("Fk_ProjectId");
            entity.Property(e => e.FkYearId)
                .HasDefaultValue((byte)1)
                .HasColumnName("Fk_YearId");
            entity.Property(e => e.MiladiDate).HasColumnType("datetime");
            entity.Property(e => e.RegMiladiDate).HasColumnType("datetime");
            entity.Property(e => e.RegShamsiDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ShamsiDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.FkProject).WithMany(p => p.WarehouseCountings)
                .HasForeignKey(d => d.FkProjectId)
                .HasConstraintName("FK__Warehouse__Fk_Pr__19775BC5");

            entity.HasOne(d => d.FkYear).WithMany(p => p.WarehouseCountings)
                .HasForeignKey(d => d.FkYearId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Warehouse__Fk_Ye__0EF9CD52");
        });

        modelBuilder.Entity<WarehouseCountingDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Warehous__3214EC07F46EED7D");

            entity.ToTable("WarehouseCountingDetail");

            entity.Property(e => e.Comment).HasMaxLength(300);
            entity.Property(e => e.DateExpire)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Fee).HasColumnType("money");
            entity.Property(e => e.FkWarehouseCountingId).HasColumnName("Fk_WarehouseCountingId");
            entity.Property(e => e.SerialNo).HasMaxLength(100);
            entity.Property(e => e.Unit).HasMaxLength(100);

            entity.HasOne(d => d.ColorNavigation).WithMany(p => p.WarehouseCountingDetails)
                .HasForeignKey(d => d.Color)
                .HasConstraintName("FK__Warehouse__Color__3B226853");

            entity.HasOne(d => d.FkWarehouseCounting).WithMany(p => p.WarehouseCountingDetails)
                .HasForeignKey(d => d.FkWarehouseCountingId)
                .HasConstraintName("FK__Warehouse__Fk_Wa__3751D76F");

            entity.HasOne(d => d.GoodSysCodeNavigation).WithMany(p => p.WarehouseCountingDetails)
                .HasForeignKey(d => d.GoodSysCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Warehouse__GoodS__3845FBA8");

            entity.HasOne(d => d.SizeNavigation).WithMany(p => p.WarehouseCountingDetails)
                .HasForeignKey(d => d.Size)
                .HasConstraintName("FK__WarehouseC__Size__3A2E441A");

            entity.HasOne(d => d.WarehouseNavigation).WithMany(p => p.WarehouseCountingDetails)
                .HasForeignKey(d => d.Warehouse)
                .HasConstraintName("FK__Warehouse__Wareh__393A1FE1");
        });

        modelBuilder.Entity<ZoneTbl>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ZoneTBL__75586032");

            entity.ToTable("ZoneTBL");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Zone).HasMaxLength(1000);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
