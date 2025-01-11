using System;
using System.Collections.Generic;
using GetScffoldFromDb.Models;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Data;

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
            entity.Property(e => e.Balance).HasDefaultValue(0m);

            entity.HasOne(d => d.FkAccoutnSysCodeNavigation).WithMany(p => p.Accounts).HasConstraintName("FK__Accounts__Fk_Acc__3FFC2C09");

            entity.HasOne(d => d.FkAccoutnSysCode0Navigation).WithMany(p => p.Accounts).HasConstraintName("FK__Accounts__Fk_Acc__40F05042");

            entity.HasOne(d => d.ParentAccountRefNavigation).WithMany(p => p.InverseParentAccountRefNavigation).HasConstraintName("FK_Account_ParentAccountRef");

            entity.HasOne(d => d.SecurLevelNavigation).WithMany(p => p.Accounts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Accounts__SecurL__41E4747B");
        });

        modelBuilder.Entity<AccountType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AccountT__3214EC27ACD74B8F");
        });

        modelBuilder.Entity<AutoSync>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AutoSync__3214EC07DC1D427D");

            entity.ToTable("AutoSync", tb => tb.HasTrigger("RGONDeleteAutoSync"));

            entity.Property(e => e.ModifiedDate).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<AutoSyncLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AutoSync__3214EC0774919555");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.LogDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.ModifiedDate).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<BackUpLogTbl>(entity =>
        {
            entity.Property(e => e.ShamsiDate).IsFixedLength();
        });

        modelBuilder.Entity<BankDetailTbl>(entity =>
        {
            entity.ToTable("BankDetailTbl", tb => tb.HasTrigger("TRGOnDeleteBankDetail"));

            entity.Property(e => e.FkDocDetailsyscode).ValueGeneratedNever();

            entity.HasOne(d => d.FkDocDetailsyscodeNavigation).WithOne(p => p.BankDetailTbl).HasConstraintName("FK_BankDetailTbl_DocDetailTbl");
        });

        modelBuilder.Entity<BanksTbl>(entity =>
        {
            entity.Property(e => e.FkAccountSyscode).ValueGeneratedNever();

            entity.HasOne(d => d.FkAccountSyscodeNavigation).WithOne(p => p.BanksTbl).HasConstraintName("FK_BanksTbl_CodeMNGDWNTbl");
        });

        modelBuilder.Entity<BarcodeTbl>(entity =>
        {
            entity.HasOne(d => d.GoodCodeNavigation).WithMany(p => p.BarcodeTbls)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BarcodeTbl_StockTbl");
        });

        modelBuilder.Entity<BranchTbl>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BranchTBL__5D4BCC77");

            entity.HasOne(d => d.FkAccountSysCodeNavigation).WithMany(p => p.BranchTbls)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__BranchTBL__FK_Ac__5F3414E9");

            entity.HasOne(d => d.FkTelBook).WithMany(p => p.BranchTbls).HasConstraintName("FK__BranchTBL__FK_Te__5E3FF0B0");
        });

        modelBuilder.Entity<CarTbl>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CarTBL__3214EC2760F15D69");

            entity.Property(e => e.LoadLapacity).HasDefaultValue(0f);
        });

        modelBuilder.Entity<ChangeBankDetailTbl>(entity =>
        {
            entity.Property(e => e.OnChangeSysDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.OnChangeSysShamsiDate)
                .HasDefaultValueSql("([dbo].[funsundate](NULL))")
                .IsFixedLength();
            entity.Property(e => e.OnChangeUserId).HasDefaultValueSql("([dbo].[funuserid]())");
        });

        modelBuilder.Entity<ChangeCheckInTbl>(entity =>
        {
            entity.HasKey(e => e.RowNo).HasName("PK__ChangeCh__FFEE5BA250274E3C");

            entity.Property(e => e.BeHesabDate).IsFixedLength();
            entity.Property(e => e.CheckDate).IsFixedLength();
            entity.Property(e => e.OnChangeSysDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.OnChangeSysShamsiDate)
                .HasDefaultValueSql("([dbo].[funsundate](NULL))")
                .IsFixedLength();
            entity.Property(e => e.OnChangeUserId).HasDefaultValueSql("([dbo].[funuserid]())");
            entity.Property(e => e.PassDate).IsFixedLength();
            entity.Property(e => e.RejectDate).IsFixedLength();
        });

        modelBuilder.Entity<ChangeCheckOuttbl>(entity =>
        {
            entity.Property(e => e.CheckDate).IsFixedLength();
            entity.Property(e => e.OnChangeSysDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.OnChangeSysShamsiDate)
                .HasDefaultValueSql("([dbo].[funsundate](NULL))")
                .IsFixedLength();
            entity.Property(e => e.OnChangeUserId).HasDefaultValueSql("([dbo].[funuserid]())");
        });

        modelBuilder.Entity<ChangeDocDetailTbl>(entity =>
        {
            entity.Property(e => e.IsDeleteOnServer).HasDefaultValue(false);
            entity.Property(e => e.OnChangeSysDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.OnChangeSysShamsiDate)
                .HasDefaultValueSql("([dbo].[funsundate](NULL))")
                .IsFixedLength();
            entity.Property(e => e.OnChangeUserId).HasDefaultValueSql("([dbo].[funuserid]())");
        });

        modelBuilder.Entity<ChangeDocTbl>(entity =>
        {
            entity.Property(e => e.DocDate).IsFixedLength();
            entity.Property(e => e.OnChangeSysDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.OnChangeSysShamsiDate)
                .HasDefaultValueSql("([dbo].[funsundate](NULL))")
                .IsFixedLength();
            entity.Property(e => e.OnChangeUserId).HasDefaultValueSql("([dbo].[funuserid]())");
        });

        modelBuilder.Entity<ChangeGhestInTbl>(entity =>
        {
            entity.Property(e => e.Date).IsFixedLength();
            entity.Property(e => e.OnChangeSysDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.OnChangeSysShamsiDate)
                .HasDefaultValueSql("([dbo].[funsundate](NULL))")
                .IsFixedLength();
            entity.Property(e => e.OnChangeUserId).HasDefaultValueSql("([dbo].[funuserid]())");
        });

        modelBuilder.Entity<ChangeInventoryDetailTbl>(entity =>
        {
            entity.Property(e => e.DateExpire).IsFixedLength();
        });

        modelBuilder.Entity<ChangeInventoryTbl>(entity =>
        {
            entity.Property(e => e.OnChangeSysShamsiDate).IsFixedLength();
            entity.Property(e => e.ShamsiDate).IsFixedLength();
            entity.Property(e => e.ShamsiSysDate).IsFixedLength();
        });

        modelBuilder.Entity<ChangeInvoiceCostDetailTbl>(entity =>
        {
            entity.Property(e => e.OnChangeSysDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.OnChangeSysShamsiDate)
                .HasDefaultValueSql("([dbo].[funsundate](NULL))")
                .IsFixedLength();
            entity.Property(e => e.OnChangeUserId).HasDefaultValueSql("([dbo].[funuserid]())");
        });

        modelBuilder.Entity<ChangeInvoiceTbl>(entity =>
        {
            entity.Property(e => e.DelivaredDate).IsFixedLength();
            entity.Property(e => e.InvoiceDate).IsFixedLength();
            entity.Property(e => e.IsDeleteOnServer).HasDefaultValue(true);
            entity.Property(e => e.OnChangeSysDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.OnChangeSysShamsiDate)
                .HasDefaultValueSql("([dbo].[funsundate](NULL))")
                .IsFixedLength();
            entity.Property(e => e.OnChangeUserId).HasDefaultValueSql("([dbo].[funuserid]())");
            entity.Property(e => e.PaymentDate).IsFixedLength();
            entity.Property(e => e.RecivedDate).IsFixedLength();
        });

        modelBuilder.Entity<ChangeinvoiceDetailTbl>(entity =>
        {
            entity.Property(e => e.DateExpire).IsFixedLength();
            entity.Property(e => e.OnChangeSysDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.OnChangeSysShamsiDate)
                .HasDefaultValueSql("([dbo].[funsundate](NULL))")
                .IsFixedLength();
            entity.Property(e => e.OnChangeUserId).HasDefaultValueSql("([dbo].[funuserid]())");
        });

        modelBuilder.Entity<ChartLayoutTbl>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ChartLay__3214EC2716E45895");
        });

        modelBuilder.Entity<CheckInCreditStatusTbl>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CheckInC__3214EC2728A929D3");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<CheckInStatusTbl>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CheckInS__3214EC273A5D3D2F");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<CheckInTbl>(entity =>
        {
            entity.ToTable("CheckInTBL", tb =>
                {
                    tb.HasTrigger("TRGOnDeleteCheckIn");
                    tb.HasTrigger("TRGOnInsertCheckIn");
                    tb.HasTrigger("TRGOnUpdateCheckIn");
                });

            entity.Property(e => e.FkDocSysCode).ValueGeneratedNever();
            entity.Property(e => e.BeHesabDate).IsFixedLength();
            entity.Property(e => e.CheckDate).IsFixedLength();
            entity.Property(e => e.IsReject).HasDefaultValue(false);
            entity.Property(e => e.PassDate).IsFixedLength();
            entity.Property(e => e.RejectDate).IsFixedLength();

            entity.HasOne(d => d.BankAccountCodeNavigation).WithMany(p => p.CheckInTbls).HasConstraintName("FK_CheckInTBL_BanksTbl");

            entity.HasOne(d => d.BehesabDocCodeNavigation).WithMany(p => p.CheckInTbls).HasConstraintName("FK__CheckInTB__Behes__54C23EC5");

            entity.HasOne(d => d.BelongtoNavigation).WithMany(p => p.CheckInTbls)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_CheckInTBL_Belongto");

            entity.HasOne(d => d.FkDocSysCodeNavigation).WithOne(p => p.CheckInTbl).HasConstraintName("FK_CheckInTBL_DocDetailTbl");

            entity.HasOne(d => d.FkSayadiInquiryStatusNavigation).WithMany(p => p.CheckInTbls).HasConstraintName("FK__CheckInTB__FK_Sa__749A117A");
        });

        modelBuilder.Entity<CheckInsForPrintTbl>(entity =>
        {
            entity.Property(e => e.CheckDate).IsFixedLength();
        });

        modelBuilder.Entity<CheckOuttbl>(entity =>
        {
            entity.ToTable("CheckOUTTBL", tb => tb.HasTrigger("TRGOnDeleteCheckOUT"));

            entity.Property(e => e.FkDocSysCode).ValueGeneratedNever();
            entity.Property(e => e.CheckDate).IsFixedLength();

            entity.HasOne(d => d.BelongtoNavigation).WithMany(p => p.CheckOuttbls)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_CheckOUTTBL_Belongto");

            entity.HasOne(d => d.FkBankAccountNavigation).WithMany(p => p.CheckOuttbls)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CheckOUTTBL_Bank");

            entity.HasOne(d => d.FkDocSysCodeNavigation).WithOne(p => p.CheckOuttbl).HasConstraintName("FK_CheckOUTTBL_detail");
        });

        modelBuilder.Entity<CityTbl>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PK__CityTbl__511AFFBC");

            entity.Property(e => e.Code).ValueGeneratedNever();

            entity.HasOne(d => d.FkOstanNavigation).WithMany(p => p.CityTbls).HasConstraintName("FK__CityTbl__FK_Osta__520F23F5");
        });

        modelBuilder.Entity<CodeMngdwntbl>(entity =>
        {
            entity.ToTable("CodeMNGDWNTbl", tb => tb.HasTrigger("TRGOnDeleteCodeMNGDWNTbl"));

            entity.Property(e => e.IsUpdate).HasDefaultValue(true);

            entity.HasOne(d => d.FkAccountSysCode0Navigation).WithMany(p => p.CodeMngdwntbls)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CodeMNGDWNTbl_CodeMNGUPTbl");

            entity.HasOne(d => d.SecurLevelNavigation).WithMany(p => p.CodeMngdwntbls)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CodeMNGDWNTbl_securlevel");
        });

        modelBuilder.Entity<CodeMnguptbl>(entity =>
        {
            entity.Property(e => e.AccountSysCode0).ValueGeneratedNever();

            entity.HasOne(d => d.KindNavigation).WithMany(p => p.CodeMnguptbls)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CodeMNGUPTbl_AccountType");
        });

        modelBuilder.Entity<ConsumedGoodsTbl>(entity =>
        {
            entity.HasKey(e => e.SysCode).HasName("PK__ConsumedGoodsTBL__26EFBBC6");

            entity.HasOne(d => d.FkConsumedGoodsNavigation).WithMany(p => p.ConsumedGoodsTbls).HasConstraintName("FK__ConsumedG__FK_Co__27E3DFFF");
        });

        modelBuilder.Entity<ContactImagesTbl>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ContactI__3214EC27E7B2E5C9");

            entity.HasOne(d => d.FkTelBook).WithMany(p => p.ContactImagesTbls)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ContactIm__FK_Te__6FF48C97");
        });

        modelBuilder.Entity<CostTbl>(entity =>
        {
            entity.Property(e => e.FkAccountSyscode).ValueGeneratedNever();
            entity.Property(e => e.GroupId1).HasDefaultValue(1);
            entity.Property(e => e.GroupId2).HasDefaultValue(1);

            entity.HasOne(d => d.FkAccountSyscodeNavigation).WithOne(p => p.CostTbl).HasConstraintName("FK_CostTbl_CodeMNGDWNTbl");

            entity.HasOne(d => d.GroupId1Navigation).WithMany(p => p.CostTbls)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_CostTbl_CostGroup1Tbl");

            entity.HasOne(d => d.GroupId2Navigation).WithMany(p => p.CostTbls)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_CostTbl_CostGroup2Tbl");
        });

        modelBuilder.Entity<CurrencyTbl>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Currency__3214EC277740A8A4");

            entity.Property(e => e.ShamsiUpdateDate).IsFixedLength();
        });

        modelBuilder.Entity<DashbordLayoutTbl>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.UseCurrentDatabase).HasDefaultValue(true);
        });

        modelBuilder.Entity<DataBaseSettingTbl>(entity =>
        {
            entity.HasKey(e => e.Syscode).HasName("PK_DataBaseSetting");
        });

        modelBuilder.Entity<DataLog>(entity =>
        {
            entity.Property(e => e.SysDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.SysShamsiDate)
                .HasDefaultValueSql("([dbo].[funsundate](NULL))")
                .IsFixedLength();
            entity.Property(e => e.UserId).HasDefaultValueSql("([dbo].[funuserid]())");

            entity.HasOne(d => d.ActionNavigation).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DataLog_InfoType");
        });

        modelBuilder.Entity<DefaultPrintInfoLay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DefaultP__3214EC07E01E139F");

            entity.HasOne(d => d.FkPrintLayout).WithMany(p => p.DefaultPrintInfoLays).HasConstraintName("FK__DefaultPr__Fk_Pr__206E7217");

            entity.HasOne(d => d.PrintInfo).WithMany(p => p.DefaultPrintInfoLays).HasConstraintName("FK__DefaultPr__Print__2256BA89");

            entity.HasOne(d => d.User).WithMany(p => p.DefaultPrintInfoLays).HasConstraintName("FK__DefaultPr__UserI__21629650");
        });

        modelBuilder.Entity<DisCountCardTbl>(entity =>
        {
            entity.HasKey(e => e.SerialNo).HasName("PK__DisCountCardTBL__23DE44F1");

            entity.Property(e => e.ExpDateShamsi).IsFixedLength();
        });

        modelBuilder.Entity<DiscountCardTransactionTbl>(entity =>
        {
            entity.HasKey(e => e.SysCode).HasName("PK__DiscountCardTran__26BAB19C");

            entity.Property(e => e.SysShamsiDate).IsFixedLength();
        });

        modelBuilder.Entity<DiscountModelsTbl>(entity =>
        {
            entity.HasKey(e => e.SysCode).HasName("PK__DiscountModelsTB__4C214075");
        });

        modelBuilder.Entity<DistributionDetailTbl>(entity =>
        {
            entity.HasKey(e => e.SysCode).HasName("PK__Distribu__EE72712D152ADE2B");

            entity.Property(e => e.Comment).HasDefaultValue("");
            entity.Property(e => e.Field1).HasDefaultValue("");
            entity.Property(e => e.Field2).HasDefaultValue("");
            entity.Property(e => e.Field3).HasDefaultValue("");

            entity.HasOne(d => d.FkDistributionSerialNavigation).WithMany(p => p.DistributionDetailTbls).HasConstraintName("FK__Distribut__FK_Di__11FF8BD8");

            entity.HasOne(d => d.FkInvoiceSerialNavigation).WithMany(p => p.DistributionDetailTbls).HasConstraintName("FK__Distribut__FK_In__110B679F");
        });

        modelBuilder.Entity<DistributionTbl>(entity =>
        {
            entity.HasKey(e => e.DistributionSerial).HasName("PK__Distribu__F8C3E3A57BF82040");

            entity.Property(e => e.Comment).HasDefaultValue("");
            entity.Property(e => e.DistributionDate).IsFixedLength();
            entity.Property(e => e.Field1).HasDefaultValue("");
            entity.Property(e => e.Field2).HasDefaultValue("");
            entity.Property(e => e.Field3).HasDefaultValue("");
            entity.Property(e => e.SysMiladiDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.SysShamsiDate)
                .HasDefaultValueSql("([dbo].[Funsundate](getdate()))")
                .IsFixedLength();

            entity.HasOne(d => d.FkCar).WithMany(p => p.DistributionTbls).HasConstraintName("FK__Distribut__FK_Ca__068DD92C");

            entity.HasOne(d => d.FkDistributorSysCodeNavigation).WithMany(p => p.DistributionTblFkDistributorSysCodeNavigations).HasConstraintName("FK__Distribut__FK_Di__7EECB764");

            entity.HasOne(d => d.FkDriverSysCodeNavigation).WithMany(p => p.DistributionTblFkDriverSysCodeNavigations).HasConstraintName("FK__Distribut__FK_Dr__7DF8932B");

            entity.HasOne(d => d.UserNoNavigation).WithMany(p => p.DistributionTbls)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Distribut__UserN__03B16C81");
        });

        modelBuilder.Entity<DocDetailTbl>(entity =>
        {
            entity.ToTable("DocDetailTbl", tb =>
                {
                    tb.HasTrigger("TRGOnDeleteDocDetail");
                    tb.HasTrigger("TRGOnUpdateDocDetail");
                });

            entity.Property(e => e.FkAccountId).HasDefaultValue(173);
            entity.Property(e => e.IsUpdate).HasDefaultValue(true);

            entity.HasOne(d => d.FkAccount).WithMany(p => p.DocDetailTbls)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DocDetail__Fk_Ac__096B112E");

            entity.HasOne(d => d.FkAccountSyscodeNavigation).WithMany(p => p.DocDetailTbls)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DocDetailTbl_CodeMNGDWNTbl");

            entity.HasOne(d => d.FkDocSysCodeNavigation).WithMany(p => p.DocDetailTbls).HasConstraintName("FK_DocDetailTbl_DocTbl");
        });

        modelBuilder.Entity<DocLinkSndTbl>(entity =>
        {
            entity.HasKey(e => e.FkFstDocDetail).HasName("PK__DocLinkS__450EFCF1873D3D75");

            entity.Property(e => e.FkFstDocDetail).ValueGeneratedNever();

            entity.HasOne(d => d.FkFstDocDetailNavigation).WithOne(p => p.DocLinkSndTblFkFstDocDetailNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DocLinkSn__FK_Fs__0CE69C57");

            entity.HasOne(d => d.FkMainDocDetailNavigation).WithMany(p => p.DocLinkSndTblFkMainDocDetailNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DocLinkSn__FK_Ma__0ECEE4C9");

            entity.HasOne(d => d.FkSndDocDetailNavigation).WithMany(p => p.DocLinkSndTblFkSndDocDetailNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DocLinkSn__FK_Sn__0DDAC090");
        });

        modelBuilder.Entity<DocLinkTbl>(entity =>
        {
            entity.ToTable("DocLinkTBL", tb => tb.HasTrigger("TRGOnUpdateDocLink"));

            entity.Property(e => e.FkFstDocDetail).ValueGeneratedNever();

            entity.HasOne(d => d.FkFstDocDetailNavigation).WithOne(p => p.DocLinkTblFkFstDocDetailNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DocLinkTBL_DocDetailTbl");

            entity.HasOne(d => d.FkSndDocDetailNavigation).WithMany(p => p.DocLinkTblFkSndDocDetailNavigations).HasConstraintName("FK_DocLinkTBL_DocDetailTbl1");
        });

        modelBuilder.Entity<DocTbl>(entity =>
        {
            entity.ToTable("DocTbl", tb => tb.HasTrigger("TRGOnDeleteDoc"));

            entity.Property(e => e.DocDate).IsFixedLength();
            entity.Property(e => e.FkTypeId).HasDefaultValue((byte)2);
            entity.Property(e => e.FkYearId).HasDefaultValue((byte)1);
            entity.Property(e => e.Lock).HasDefaultValue(false);
            entity.Property(e => e.SysDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.SysShamsiDate)
                .HasDefaultValueSql("([dbo].[funsundate](NULL))")
                .IsFixedLength();
            entity.Property(e => e.UserIdno).HasDefaultValueSql("([dbo].[FunUserId]())");

            entity.HasOne(d => d.FkProject).WithMany(p => p.DocTbls).HasConstraintName("FK__DocTbl__Fk_Proje__0FE30493");

            entity.HasOne(d => d.FkType).WithMany(p => p.DocTbls)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DocTbl__Fk_TypeI__10D728CC");

            entity.HasOne(d => d.FkYear).WithMany(p => p.DocTbls)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DocTbl__Fk_YearI__0758AB8A");

            entity.HasOne(d => d.UserIdnoNavigation).WithMany(p => p.DocTbls).HasConstraintName("FK_DocTbl_Users");
        });

        modelBuilder.Entity<DocTypeTbl>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DocTypeT__3214EC270CEEC06C");
        });

        modelBuilder.Entity<FinancialYear>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Financia__3214EC07F35BAF60");

            entity.Property(e => e.EndDateShamsi).IsFixedLength();
            entity.Property(e => e.StartDateShamsi).IsFixedLength();
        });

        modelBuilder.Entity<FormLayoutTbl>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__FormLayoutTBL__2E5BD364");

            entity.Property(e => e.LanguageId).HasDefaultValue((byte)1);
        });

        modelBuilder.Entity<GhestInTbl>(entity =>
        {
            entity.ToTable("GhestInTBL", tb => tb.HasTrigger("TRGOnDeleteGhestInTBL"));

            entity.Property(e => e.FkDocSysCode).ValueGeneratedNever();
            entity.Property(e => e.Date).IsFixedLength();
            entity.Property(e => e.SysCode).ValueGeneratedOnAdd();

            entity.HasOne(d => d.BelongtoNavigation).WithMany(p => p.GhestInTbls)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_GhestInTBL_Belongto");

            entity.HasOne(d => d.FkDocSysCodeNavigation).WithOne(p => p.GhestInTbl).HasConstraintName("FK_GhestInTBL_DocDetailTbl");
        });

        modelBuilder.Entity<GoodColorTbl>(entity =>
        {
            entity.HasOne(d => d.GoodSysCodeNavigation).WithMany(p => p.GoodColorTbls).HasConstraintName("FK_GoodColorTbl_Stock");
        });

        modelBuilder.Entity<GoodSizeTbl>(entity =>
        {
            entity.HasOne(d => d.GoodSysCodeNavigation).WithMany(p => p.GoodSizeTbls).HasConstraintName("FK_GoodSizeTbl_stock");
        });

        modelBuilder.Entity<GoodVisitorTbl>(entity =>
        {
            entity.HasKey(e => e.SysCode).HasName("PK__GoodVisitorTBL__0682EC34");

            entity.HasOne(d => d.AccountSysCodeNavigation).WithMany(p => p.GoodVisitorTbls)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__GoodVisit__Accou__0777106D");

            entity.HasOne(d => d.GoodSysCodeNavigation).WithMany(p => p.GoodVisitorTbls)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__GoodVisit__GoodS__086B34A6");
        });

        modelBuilder.Entity<GoodWarehouseTbl>(entity =>
        {
            entity.HasKey(e => e.SysCode).HasName("PK__GoodWarehouseTBL__60E75331");

            entity.HasOne(d => d.GoodSysCodeNavigation).WithMany(p => p.GoodWarehouseTbls)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__GoodWareh__GoodS__62CF9BA3");

            entity.HasOne(d => d.WareHouseSysCodeNavigation).WithMany(p => p.GoodWarehouseTbls)
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

            entity.Property(e => e.CatImageUrl).HasDefaultValue("");
        });

        modelBuilder.Entity<GoodsGalleriesTbl>(entity =>
        {
            entity.Property(e => e.SysCode).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<GoodsGroup1PersonAccountTbl>(entity =>
        {
            entity.HasKey(e => e.Syscode).HasName("PK__GoodsGroup1Perso__3BEAD8AC");

            entity.HasOne(d => d.AccountSysCodeNavigation).WithMany(p => p.GoodsGroup1PersonAccountTbls)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__GoodsGrou__Accou__3CDEFCE5");
        });

        modelBuilder.Entity<GoodsGroup2PersonAccountTbl>(entity =>
        {
            entity.HasKey(e => e.Syscode).HasName("PK__GoodsGroup2Perso__3EC74557");

            entity.HasOne(d => d.AccountSysCodeNavigation).WithMany(p => p.GoodsGroup2PersonAccountTbls)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__GoodsGrou__Accou__3FBB6990");
        });

        modelBuilder.Entity<GoodsImagesTbl>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__GoodsImagesTBL__00CA12DE");

            entity.ToTable("GoodsImagesTBL", tb => tb.HasTrigger("RGONUpdateGoodImage"));

            entity.HasOne(d => d.FkGoodSysCodeNavigation).WithMany(p => p.GoodsImagesTbls)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__GoodsImag__FK_Go__01BE3717");
        });

        modelBuilder.Entity<GoodsQuotaTbl>(entity =>
        {
            entity.HasKey(e => e.SysCode).HasName("PK__GoodsQuo__EE72712DB410CD61");

            entity.Property(e => e.EndDateShamsi).IsFixedLength();
            entity.Property(e => e.SartDateShamsi).IsFixedLength();

            entity.HasOne(d => d.FkAccountSysCodeNavigation).WithMany(p => p.GoodsQuotaTbls)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__GoodsQuot__FK_Ac__2E11BAA1");

            entity.HasOne(d => d.FkGoodSysCodeNavigation).WithMany(p => p.GoodsQuotaTbls)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__GoodsQuot__FK_Go__2C29722F");

            entity.HasOne(d => d.FkWareHouse).WithMany(p => p.GoodsQuotaTbls).HasConstraintName("FK__GoodsQuot__FK_Wa__2D1D9668");
        });

        modelBuilder.Entity<GpstrackingTbl>(entity =>
        {
            entity.Property(e => e.Dt).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.ShamsiDate).IsFixedLength();
            entity.Property(e => e.TrackingId).ValueGeneratedOnAdd();

            entity.HasOne(d => d.FkAccountSysCodeNavigation).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__GPSTracki__Fk_Ac__48DABF76");
        });

        modelBuilder.Entity<GridLayOutFilterTbl>(entity =>
        {
            entity.HasOne(d => d.FkFilter).WithMany(p => p.GridLayOutFilterTbls)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_GridLayOutFilterTbl_GridFilterTitleTbl");
        });

        modelBuilder.Entity<GridLayout>(entity =>
        {
            entity.HasOne(d => d.Fk).WithMany(p => p.GridLayouts).HasConstraintName("FK_GridLayouts_GridsInfo");
        });

        modelBuilder.Entity<GridsInfo>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<GroupPolicy>(entity =>
        {
            entity.HasOne(d => d.GidNavigation).WithMany(p => p.GroupPolicies).HasConstraintName("FK_GroupPolicys_Groups");
        });

        modelBuilder.Entity<InfoAccountKind>(entity =>
        {
            entity.Property(e => e.KindCode).ValueGeneratedNever();
        });

        modelBuilder.Entity<InfoConvCurToStringTbl>(entity =>
        {
            entity.Property(e => e.Value).ValueGeneratedNever();
        });

        modelBuilder.Entity<InfoDataLogAction>(entity =>
        {
            entity.Property(e => e.Value).ValueGeneratedNever();
        });

        modelBuilder.Entity<InfoGoodTypeTbl>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PK_GoodTypeTbl");

            entity.Property(e => e.Code).ValueGeneratedNever();
        });

        modelBuilder.Entity<InfoInvoiceType>(entity =>
        {
            entity.Property(e => e.Value).ValueGeneratedNever();
            entity.Property(e => e.Syscode).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<InfoPersonPriceNoTbl>(entity =>
        {
            entity.Property(e => e.Value).ValueGeneratedNever();
        });

        modelBuilder.Entity<InfoSecurityLevelTbl>(entity =>
        {
            entity.Property(e => e.Value).ValueGeneratedNever();
        });

        modelBuilder.Entity<InventoryDetailTbl>(entity =>
        {
            entity.HasKey(e => e.SysCode).HasName("PK__InventoryDetailT__3D9E16F4");

            entity.ToTable("InventoryDetailTbl", tb => tb.HasTrigger("TRGOnDeleteInventoryDetailTbl"));

            entity.Property(e => e.DateExpire).IsFixedLength();

            entity.HasOne(d => d.ColorNavigation).WithMany(p => p.InventoryDetailTbls).HasConstraintName("FK__Inventory__Color__407A839F");

            entity.HasOne(d => d.FkInventorySysCodeNavigation).WithMany(p => p.InventoryDetailTbls).HasConstraintName("FK__Inventory__FK_In__4262CC11");

            entity.HasOne(d => d.GoodSysCodeNavigation).WithMany(p => p.InventoryDetailTbls)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Inventory__GoodS__3E923B2D");

            entity.HasOne(d => d.SizeNavigation).WithMany(p => p.InventoryDetailTbls).HasConstraintName("FK__InventoryD__Size__3F865F66");

            entity.HasOne(d => d.WareHouseNavigation).WithMany(p => p.InventoryDetailTbls).HasConstraintName("FK__Inventory__WareH__416EA7D8");
        });

        modelBuilder.Entity<InventoryTbl>(entity =>
        {
            entity.HasKey(e => e.InventorySerial).HasName("PK__InventoryTBL__3508D0F3");

            entity.ToTable("InventoryTBL", tb =>
                {
                    tb.HasTrigger("TRGOnDeleteInventory");
                    tb.HasTrigger("TRGOnUpdateInventory");
                });

            entity.Property(e => e.FkYearId).HasDefaultValue((byte)1);
            entity.Property(e => e.ShamsiDate).IsFixedLength();
            entity.Property(e => e.ShamsiSysDate).IsFixedLength();
            entity.Property(e => e.UserNo).HasDefaultValueSql("([dbo].[FunUserId]())");

            entity.HasOne(d => d.FkAccountSysCodeNavigation).WithMany(p => p.InventoryTbls).HasConstraintName("FK__Inventory__FK_Ac__0ADD8CFD");

            entity.HasOne(d => d.FkDistributorSysCodeNavigation).WithMany(p => p.InventoryTblFkDistributorSysCodeNavigations).HasConstraintName("FK__Inventory__Fk_Di__3BB5CE82");

            entity.HasOne(d => d.FkDriversSysCodeNavigation).WithMany(p => p.InventoryTblFkDriversSysCodeNavigations).HasConstraintName("FK__Inventory__Fk_Dr__3AC1AA49");

            entity.HasOne(d => d.FkInvoiceSerialNavigation).WithMany(p => p.InventoryTbls).HasConstraintName("FK__Inventory__Fk_In__38D961D7");

            entity.HasOne(d => d.FkTransferSerialNavigation).WithMany(p => p.InventoryTbls).HasConstraintName("FK__Inventory__Fk_Tr__39CD8610");

            entity.HasOne(d => d.FkYear).WithMany(p => p.InventoryTbls)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Inventory__Fk_Ye__0B293C6E");

            entity.HasOne(d => d.UserNoNavigation).WithMany(p => p.InventoryTbls)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Inventory__UserN__35FCF52C");
        });

        modelBuilder.Entity<InventoryTypeTbl>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__InventoryTypeTBL__33208881");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<InvoiceCostDetailTbl>(entity =>
        {
            entity.ToTable("InvoiceCostDetailTbl", tb => tb.HasTrigger("TRGOnDeleteInvoiceCostDetailTbl"));

            entity.HasOne(d => d.FkFactorSerialNoNavigation).WithMany(p => p.InvoiceCostDetailTbls).HasConstraintName("FK_InvoiceCostDetailTbl_InvoiceTbl");

            entity.HasOne(d => d.FkInvoiceCostSysCodeNavigation).WithMany(p => p.InvoiceCostDetailTbls)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InvoiceCostDetailTbl_InvoiceCostTbl");
        });

        modelBuilder.Entity<InvoiceDetailTbl>(entity =>
        {
            entity.ToTable("invoiceDetailTbl", tb =>
                {
                    tb.HasTrigger("RGONDeleteGoodInvoice_AutoSync");
                    tb.HasTrigger("RGONUpdateGoodInvoice_AutoSync");
                    tb.HasTrigger("TRGOnDeleteinvoiceDetailTbl");
                });

            entity.Property(e => e.DateExpire).IsFixedLength();
            entity.Property(e => e.WeighCarwithBar).HasDefaultValue(0.0);
            entity.Property(e => e.WeightCar).HasDefaultValue(0.0);

            entity.HasOne(d => d.ColorNavigation).WithMany(p => p.InvoiceDetailTbls).HasConstraintName("FK_invoiceDetailTbl_Color");

            entity.HasOne(d => d.FkInvoiceSysCodeNavigation).WithMany(p => p.InvoiceDetailTbls).HasConstraintName("FK_invoiceDetailTbl_InvoiceTbl");

            entity.HasOne(d => d.GoodSysCodeNavigation).WithMany(p => p.InvoiceDetailTblGoodSysCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_invoiceDetailTbl_StockTbl");

            entity.HasOne(d => d.PromotionGoodSysCodeNavigation).WithMany(p => p.InvoiceDetailTblPromotionGoodSysCodeNavigations).HasConstraintName("FK__invoiceDe__Promo__1CB22475");

            entity.HasOne(d => d.SizeNavigation).WithMany(p => p.InvoiceDetailTbls).HasConstraintName("FK_invoiceDetailTbl_size");

            entity.HasOne(d => d.WareHouseNavigation).WithMany(p => p.InvoiceDetailTbls).HasConstraintName("FK_invoiceDetailTbl_warehouse");
        });

        modelBuilder.Entity<InvoiceInfoPrint>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__InvoiceI__3214EC070B677F57");
        });

        modelBuilder.Entity<InvoicePaymentTbl>(entity =>
        {
            entity.HasKey(e => e.SysCode).HasName("PK__InvoicePaymentTb__1995C0A8");

            entity.HasOne(d => d.FkDocDetailSysCodeNavigation).WithMany(p => p.InvoicePaymentTbls)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__DocDetailSysCode_InvoicePayment");

            entity.HasOne(d => d.FkInvoiceSerialNavigation).WithMany(p => p.InvoicePaymentTbls).HasConstraintName("FK__InvoicePa__FK_In__1A89E4E1");
        });

        modelBuilder.Entity<InvoiceReturnResonTbl>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__InvoiceR__3214EC27DDF4A6EF");
        });

        modelBuilder.Entity<InvoiceServerType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__InvoiceS__3214EC27D65A3061");
        });

        modelBuilder.Entity<InvoiceStatusTbl>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__InvoiceS__3214EC275E2FBE54");
        });

        modelBuilder.Entity<InvoiceTbl>(entity =>
        {
            entity.ToTable("InvoiceTbl", tb =>
                {
                    tb.HasTrigger("TRGInvoiceUpdateSignField");
                    tb.HasTrigger("TRGOnDeleteInvoice");
                    tb.HasTrigger("TRGOnUpdateInvoice");
                });

            entity.HasIndex(e => new { e.FkAccountSysCode, e.FkDocsysCode, e.InvoiceNo }, "NonClusteredIndex-20241012-114640").HasFillFactor(90);

            entity.Property(e => e.BaseRate).HasDefaultValue(1m);
            entity.Property(e => e.CurRateDef).HasDefaultValue(1m);
            entity.Property(e => e.DelivaredDate).IsFixedLength();
            entity.Property(e => e.FkYearId).HasDefaultValue((byte)1);
            entity.Property(e => e.FollowDate).IsFixedLength();
            entity.Property(e => e.InvoiceDate).IsFixedLength();
            entity.Property(e => e.IsUpdate).HasDefaultValue(true);
            entity.Property(e => e.PaymentDate).IsFixedLength();
            entity.Property(e => e.RecivedDate).IsFixedLength();
            entity.Property(e => e.SysDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.SysShamsiDate)
                .HasDefaultValueSql("([dbo].[funsundate](NULL))")
                .IsFixedLength();
            entity.Property(e => e.Type).HasComment("for descibe type of invoice : 1 sale  , 2 buy  , 3 return sale , 4 return buy");
            entity.Property(e => e.UserNo).HasDefaultValueSql("([dbo].[FunUserId]())");

            entity.HasOne(d => d.FkAccountSysCodeNavigation).WithMany(p => p.InvoiceTblFkAccountSysCodeNavigations)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_InvoiceTbl_Account");

            entity.HasOne(d => d.FkDocsysCodeNavigation).WithMany(p => p.InvoiceTbls)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_InvoiceTbl_DocDetailTbl");

            entity.HasOne(d => d.FkProject).WithMany(p => p.InvoiceTbls).HasConstraintName("FK__InvoiceTb__Fk_Pr__210D9095");

            entity.HasOne(d => d.FkReturnReson).WithMany(p => p.InvoiceTbls).HasConstraintName("FK__InvoiceTb__FK_Re__3A235722");

            entity.HasOne(d => d.FkServerType).WithMany(p => p.InvoiceTbls).HasConstraintName("FK__InvoiceTb__FK_Se__14F1D273");

            entity.HasOne(d => d.FkYear).WithMany(p => p.InvoiceTbls)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__InvoiceTb__Fk_Ye__0940F3FC");

            entity.HasOne(d => d.Status).WithMany(p => p.InvoiceTbls).HasConstraintName("FK__InvoiceTb__Statu__392F32E9");

            entity.HasOne(d => d.TypeNavigation).WithMany(p => p.InvoiceTbls)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InvoiceTbl_InvoiceTypeInfo");

            entity.HasOne(d => d.UserNoNavigation).WithMany(p => p.InvoiceTbls)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InvoiceTbl_Users");

            entity.HasOne(d => d.VisitorSyscodeNavigation).WithMany(p => p.InvoiceTblVisitorSyscodeNavigations).HasConstraintName("FK_InvoiceTbl_visitoracc");
        });

        modelBuilder.Entity<Log>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Logs__3214EC07C7674E15");

            entity.ToTable(tb => tb.HasTrigger("DeletePreviousRecord"));
        });

        modelBuilder.Entity<MoreBarCodeTbl>(entity =>
        {
            entity.HasKey(e => e.SysCode).HasName("PK__MoreBarCodeTBL__381A47C8");
        });

        modelBuilder.Entity<OldDataBaseTbl>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__OldDataB__3214EC27AEB1B6EB");
        });

        modelBuilder.Entity<OstanTbl>(entity =>
        {
            entity.HasKey(e => e.OstanCode).HasName("PK__OstanTbl__4F32B74A");

            entity.Property(e => e.OstanCode).ValueGeneratedNever();
        });

        modelBuilder.Entity<PartnersTbl>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Partners__3214EC27253141F3");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.HasOne(d => d.AccountSysCodeNavigation).WithMany(p => p.PartnersTbls).HasConstraintName("FK__PartnersT__Accou__5C2E5663");
        });

        modelBuilder.Entity<PersonActivityTbl>(entity =>
        {
            entity.HasOne(d => d.FkAccountSysCodeNavigation).WithMany().HasConstraintName("FK__Person_Ac__FK_Ac__5887175A");

            entity.HasOne(d => d.FkPersonActivityNavigation).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Person_Ac__FK_Pe__597B3B93");
        });

        modelBuilder.Entity<PersonActivityTbl1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PersonActivityTB__55AAAAAF");
        });

        modelBuilder.Entity<PersonCommercialTbl>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PersonCommercial__65E11278");
        });

        modelBuilder.Entity<PersonCostMountlyTbl>(entity =>
        {
            entity.HasOne(d => d.FkAccountSysCodeNavigation).WithMany().HasConstraintName("FK__Person_Co__FK_Ac__033C6B35");

            entity.HasOne(d => d.FkPersonCostMountLyNavigation).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Person_Co__FK_Pe__04308F6E");
        });

        modelBuilder.Entity<PersonCostMountlyTbl1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PersonCostMountl__015422C3");
        });

        modelBuilder.Entity<PersonCreditDetailTbl>(entity =>
        {
            entity.HasKey(e => e.SysCode).HasName("PK__PersonCreditDeta__679450C0");

            entity.Property(e => e.ShamsiSysDate)
                .HasDefaultValueSql("([dbo].[funsundate](getdate()))")
                .IsFixedLength();
            entity.Property(e => e.SysDate).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.FkAccountSysCodeNavigation).WithMany(p => p.PersonCreditDetailTbls).HasConstraintName("FK__PersonCre__Fk_Ac__688874F9");

            entity.HasOne(d => d.User).WithMany(p => p.PersonCreditDetailTbls).HasConstraintName("FK__PersonCre__UserI__697C9932");
        });

        modelBuilder.Entity<PersonCreditTbl>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PersonCreditTBL__62108194");

            entity.HasOne(d => d.FkAccountsysCodeNavigation).WithMany(p => p.PersonCreditTbls)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__PersonCre__FK_Ac__6304A5CD");
        });

        modelBuilder.Entity<PersonCustomerKindTbl>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PersonCustomerKi__67C95AEA");
        });

        modelBuilder.Entity<PersonKind>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PersonKind__4B622666");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<PersonTbl>(entity =>
        {
            entity.HasKey(e => e.FkAccountSysCode).HasName("PK_PersonTbl_1");

            entity.ToTable("PersonTbl", tb =>
                {
                    tb.HasTrigger("RGONUpdate_eShopPerson");
                    tb.HasTrigger("TRGONPersonsChanged");
                });

            entity.Property(e => e.FkAccountSysCode).ValueGeneratedNever();
            entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FkTaxPersonKindId).HasDefaultValue((byte)1);
            entity.Property(e => e.GroupId1).HasDefaultValue(1);
            entity.Property(e => e.GroupId2).HasDefaultValue(1);
            entity.Property(e => e.IsDistributor).HasDefaultValue(false);
            entity.Property(e => e.IsDriver).HasDefaultValue(false);
            entity.Property(e => e.IsEmployee).HasDefaultValue(false);
            entity.Property(e => e.IsUpdate).HasDefaultValue(true);
            entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Contact).WithMany(p => p.PersonTbls)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_PersonTbl_TelBook");

            entity.HasOne(d => d.FkAccountSysCodeNavigation).WithOne(p => p.PersonTbl).HasConstraintName("FK_PersonTbl_CodeMNGDWNTbl");

            entity.HasOne(d => d.FkIdkindNavigation).WithMany(p => p.PersonTbls).HasConstraintName("FK__PersonTbl__FK_ID__4C564A9F");

            entity.HasOne(d => d.FkPersonCommercialNavigation).WithMany(p => p.PersonTbls).HasConstraintName("FK__PersonTbl__FK_Pe__6B99EBCE");

            entity.HasOne(d => d.FkPersonCutomerKindNavigation).WithMany(p => p.PersonTbls).HasConstraintName("FK__PersonTbl__FK_Pe__6AA5C795");

            entity.HasOne(d => d.FkTaxPersonKind).WithMany(p => p.PersonTbls).HasConstraintName("FK__PersonTbl__Fk_Ta__68150A5B");

            entity.HasOne(d => d.GroupId1Navigation).WithMany(p => p.PersonTbls)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_PersonTbl_PersonGroup1Tbl");

            entity.HasOne(d => d.GroupId2Navigation).WithMany(p => p.PersonTbls)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_PersonTbl_PersonGroup2Tbl");

            entity.HasOne(d => d.SalePriceNoNavigation).WithMany(p => p.PersonTbls)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PersonTbl_PriceTypeInfo");
        });

        modelBuilder.Entity<Policy>(entity =>
        {
            entity.Property(e => e.Pid).ValueGeneratedNever();
        });

        modelBuilder.Entity<PolicysList>(entity =>
        {
            entity.ToView("PolicysList");

            entity.Property(e => e.Pid).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PosTransactionTbl>(entity =>
        {
            entity.HasKey(e => e.SysCode).HasName("PK__PosTransactionTB__44801EAD");

            entity.Property(e => e.SysShamsiDate).IsFixedLength();
        });

        modelBuilder.Entity<PricingDetailTbl>(entity =>
        {
            entity.HasKey(e => e.SysCode).HasName("PK__PricingD__EE72712DAFE5D3C0");

            entity.Property(e => e.Comment).HasDefaultValue("");
            entity.Property(e => e.DiscountPer).HasDefaultValue(0.0);
            entity.Property(e => e.Fee).HasDefaultValue(0m);
            entity.Property(e => e.LastDiscountPer).HasDefaultValue(0.0);
            entity.Property(e => e.SalePrice1).HasDefaultValue(0m);
            entity.Property(e => e.SalePrice1Per).HasDefaultValue(0.0);
            entity.Property(e => e.SalePrice2).HasDefaultValue(0m);
            entity.Property(e => e.SalePrice2Per).HasDefaultValue(0.0);
            entity.Property(e => e.SalePrice3).HasDefaultValue(0m);
            entity.Property(e => e.SalePrice3Per).HasDefaultValue(0.0);
            entity.Property(e => e.SalePrice4).HasDefaultValue(0m);
            entity.Property(e => e.SalePrice4Per).HasDefaultValue(0.0);
            entity.Property(e => e.SalePrice5).HasDefaultValue(0m);
            entity.Property(e => e.SalePrice5Per).HasDefaultValue(0.0);

            entity.HasOne(d => d.FkPricing).WithMany(p => p.PricingDetailTbls)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__PricingDe__Fk_Pr__41C3AD93");

            entity.HasOne(d => d.GoodSysCodeNavigation).WithMany(p => p.PricingDetailTbls).HasConstraintName("FK__PricingDe__GoodS__42B7D1CC");
        });

        modelBuilder.Entity<PricingTbl>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PricingT__3214EC27E647C3A7");

            entity.Property(e => e.Comment).HasDefaultValue("");
            entity.Property(e => e.Field1).HasDefaultValue("");
            entity.Property(e => e.Field2).HasDefaultValue("");
            entity.Property(e => e.Field3).HasDefaultValue("");
            entity.Property(e => e.ShamsiDate).IsFixedLength();
            entity.Property(e => e.SysMiladiDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.SysShamsiDate)
                .HasDefaultValueSql("([dbo].[funsundate](getdate()))")
                .IsFixedLength();
            entity.Property(e => e.UserNo).HasDefaultValueSql("([dbo].[FunUserId]())");

            entity.HasOne(d => d.AccountCodeNavigation).WithMany(p => p.PricingTbls).HasConstraintName("FK__PricingTB__Accou__32816A03");

            entity.HasOne(d => d.UserNoNavigation).WithMany(p => p.PricingTbls)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PricingTB__UserN__30992191");
        });

        modelBuilder.Entity<PrintLayout>(entity =>
        {
            entity.HasOne(d => d.Fk).WithMany(p => p.PrintLayouts).HasConstraintName("FK_PrintLayouts_GridsInfo");
        });

        modelBuilder.Entity<ProjectTbl>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ProjectT__3214EC27A091F53B");

            entity.Property(e => e.Active).HasDefaultValue(true);
        });

        modelBuilder.Entity<PromotionTbl>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Promotio__3214EC27C613FFA1");

            entity.HasOne(d => d.FkMainGoodSysCodeNavigation).WithMany(p => p.PromotionTblFkMainGoodSysCodeNavigations).HasConstraintName("FK__Promotion__FK_Ma__6561EF8B");

            entity.HasOne(d => d.FkPromotionGoodSysCodeNavigation).WithMany(p => p.PromotionTblFkPromotionGoodSysCodeNavigations).HasConstraintName("FK__Promotion__FK_Pr__665613C4");
        });

        modelBuilder.Entity<ScaduleCircuitTbl>(entity =>
        {
            entity.HasKey(e => e.SysCode).HasName("PK__ScaduleCircuitTB__12B3B8EF");

            entity.Property(e => e.FollowShamsiDate).IsFixedLength();
            entity.Property(e => e.ShamsiSysDate)
                .HasDefaultValueSql("([dbo].[funsundate](NULL))")
                .IsFixedLength();
            entity.Property(e => e.SysDate).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.RecevieUser).WithMany(p => p.ScaduleCircuitTblRecevieUsers).HasConstraintName("FK__ScaduleCi__Recev__149C0161");

            entity.HasOne(d => d.SendUser).WithMany(p => p.ScaduleCircuitTblSendUsers).HasConstraintName("FK__ScaduleCi__SendU__13A7DD28");
        });

        modelBuilder.Entity<ScaduleTbl>(entity =>
        {
            entity.Property(e => e.DateS).IsFixedLength();
            entity.Property(e => e.FinishShamsiDate)
                .HasDefaultValueSql("([dbo].[funsundate](NULL))")
                .IsFixedLength();
            entity.Property(e => e.FinishSysDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.ReceiveUserId).HasDefaultValue(1);
            entity.Property(e => e.ShamsiSysDate)
                .HasDefaultValue("1397/08/20")
                .IsFixedLength();
            entity.Property(e => e.SysCode).ValueGeneratedOnAdd();
            entity.Property(e => e.SysDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Title).HasDefaultValue("");

            entity.HasOne(d => d.FkGoodSysCodeNavigation).WithMany().HasConstraintName("FK__ScaduleTb__Fk_Go__027D5126");

            entity.HasOne(d => d.FkPerson).WithMany().HasConstraintName("FK__ScaduleTb__FK_Pe__01892CED");

            entity.HasOne(d => d.ReceiveUser).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ScaduleTb__Recei__0371755F");
        });

        modelBuilder.Entity<SmsLogTbl>(entity =>
        {
            entity.HasKey(e => e.SysCode).HasName("PK__SmsLogTBL__6E414E4F");

            entity.Property(e => e.ShamsiDate).IsFixedLength();
        });

        modelBuilder.Entity<SqlErrMsg>(entity =>
        {
            entity.HasKey(e => e.Msgnum).HasName("PK__SqlErrMsg__2A8B4280");

            entity.Property(e => e.Msgnum).ValueGeneratedNever();
        });

        modelBuilder.Entity<StockGroup1Tbl>(entity =>
        {
            entity.ToTable("stockGroup1Tbl", tb =>
                {
                    tb.HasTrigger("TRGONDeleteGoodGroup1");
                    tb.HasTrigger("TRGONUpdateGoodGroup1");
                });
        });

        modelBuilder.Entity<StockGroup2Tbl>(entity =>
        {
            entity.ToTable("stockGroup2Tbl", tb =>
                {
                    tb.HasTrigger("TRGONDeleteGoodGroup2");
                    tb.HasTrigger("TRGONUpdateGoodGroup2");
                });
        });

        modelBuilder.Entity<StockGroup3Tbl>(entity =>
        {
            entity.HasKey(e => e.GroupId).HasName("PK__stockGro__149AF36AE81717EA");

            entity.ToTable("stockGroup3Tbl", tb =>
                {
                    tb.HasTrigger("TRGONDeleteGoodGroup3");
                    tb.HasTrigger("TRGONUpdateGoodGroup3");
                });
        });

        modelBuilder.Entity<StockTbl>(entity =>
        {
            entity.ToTable("StockTbl", tb =>
                {
                    tb.HasTrigger("RGONDeleteGood_AutoSync");
                    tb.HasTrigger("RGONUpdateGood_AutoSync");
                    tb.HasTrigger("TRGONEditGoods");
                    tb.HasTrigger("TRGONEditGoods_BarcodeManager");
                    tb.HasTrigger("TRGONGoodsChanged");
                    tb.HasTrigger("TRGOnDeleteGoods");
                });

            entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.GroupId1).HasDefaultValue(1);
            entity.Property(e => e.GroupId2).HasDefaultValue(1);
            entity.Property(e => e.HasPromotion).HasDefaultValue(false);
            entity.Property(e => e.IsUpdate).HasDefaultValue(true);
            entity.Property(e => e.SendToServer).HasDefaultValue(true);
            entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Category).WithMany(p => p.StockTbls).HasConstraintName("FK__StockTbl__Catego__0C278248");

            entity.HasOne(d => d.FkTaxUnit).WithMany(p => p.StockTbls).HasConstraintName("FK__StockTbl__Fk_Tax__6AF17706");

            entity.HasOne(d => d.GroupId1Navigation).WithMany(p => p.StockTbls)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_StockTbl_stockGroup1Tbl");

            entity.HasOne(d => d.GroupId2Navigation).WithMany(p => p.StockTbls)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_StockTbl_stockGroup2Tbl");

            entity.HasOne(d => d.GroupId3Navigation).WithMany(p => p.StockTbls).HasConstraintName("FK__StockTbl__GroupI__0B335E0F");

            entity.HasOne(d => d.Seller).WithMany(p => p.StockTbls).HasConstraintName("FK__StockTbl__Seller__4A2FA1B9");

            entity.HasOne(d => d.TypeNavigation).WithMany(p => p.StockTbls)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockTbl_type");
        });

        modelBuilder.Entity<StpForDistributionPrint>(entity =>
        {
            entity.Property(e => e.Syscode).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<StpForInventoryPrint>(entity =>
        {
            entity.Property(e => e.Syscode).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<StpForPricingPrint>(entity =>
        {
            entity.Property(e => e.Syscode).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<StpForTransferWareHousePrint>(entity =>
        {
            entity.Property(e => e.Syscode).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<StpForWarehouseCounting>(entity =>
        {
            entity.Property(e => e.Syscode).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TaxErrorType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TaxError__3214EC076B5760FA");
        });

        modelBuilder.Entity<TaxInvoice>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TaxInvoi__3214EC077622F597");

            entity.ToTable(tb => tb.HasTrigger("TRGOnUpdate_TaxInvoice"));

            entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.FkTaxInvoiceIssue).WithMany(p => p.TaxInvoices)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TaxInvoic__Fk_Ta__5CA357AF");

            entity.HasOne(d => d.FkTaxInvoicePattern).WithMany(p => p.TaxInvoices)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TaxInvoic__Fk_Ta__5BAF3376");

            entity.HasOne(d => d.FkTaxInvoiceSettlement).WithMany(p => p.TaxInvoices)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TaxInvoic__Fk_Ta__5D977BE8");

            entity.HasOne(d => d.FkTaxInvoiceStatusNavigation).WithMany(p => p.TaxInvoices)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TaxInvoic__Fk_Ta__61680CCC");

            entity.HasOne(d => d.FkTaxInvoiceType).WithMany(p => p.TaxInvoices)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TaxInvoic__Fk_Ta__5ABB0F3D");

            entity.HasOne(d => d.FkTaxSetting).WithMany(p => p.TaxInvoices)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TaxInvoic__Fk_Ta__6073E893");

            entity.HasOne(d => d.FkUser).WithMany(p => p.TaxInvoices)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TaxInvoic__Fk_Us__625C3105");
        });

        modelBuilder.Entity<TaxInvoiceIssue>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TaxInvoi__3214EC076E3167FF");
        });

        modelBuilder.Entity<TaxInvoicePattern>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TaxInvoi__3214EC072D19CF5A");
        });

        modelBuilder.Entity<TaxInvoiceSettlement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TaxInvoi__3214EC072D5F1530");
        });

        modelBuilder.Entity<TaxInvoiceStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TaxInvoi__3214EC0731BF903A");
        });

        modelBuilder.Entity<TaxInvoiceType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TaxInvoi__3214EC07126F5071");
        });

        modelBuilder.Entity<TaxInvoicesError>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TaxInvoi__3214EC072F18B0E3");

            entity.HasOne(d => d.FkTaxErrorType).WithMany(p => p.TaxInvoicesErrors)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TaxInvoic__Fk_Ta__02C90097");

            entity.HasOne(d => d.FkTaxInvoice).WithMany(p => p.TaxInvoicesErrors)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__TaxInvoic__Fk_Ta__01D4DC5E");
        });

        modelBuilder.Entity<TaxInvoicesLog>(entity =>
        {
            entity.HasKey(e => e.SysCode).HasName("PK__TaxInvoi__EE72712D501B8B22");
        });

        modelBuilder.Entity<TaxPersonKind>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TaxPerso__3214EC07863F79EB");
        });

        modelBuilder.Entity<TaxSetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TaxSetti__3214EC07A250EE6A");
        });

        modelBuilder.Entity<TaxUnit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TaxUnit__3214EC07716B7865");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<TelBook>(entity =>
        {
            entity.HasOne(d => d.FkIdcityNavigation).WithMany(p => p.TelBooks).HasConstraintName("FK__TelBook__FK_IDCi__5303482E");

            entity.HasOne(d => d.FkIdostanNavigation).WithMany(p => p.TelBooks).HasConstraintName("FK__TelBook__FK_IDOs__53F76C67");
        });

        modelBuilder.Entity<TelNumber>(entity =>
        {
            entity.HasOne(d => d.TelBook).WithMany(p => p.TelNumbers)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_TelNumbers_TelBook");
        });

        modelBuilder.Entity<TelType>(entity =>
        {
            entity.Property(e => e.Fk).ValueGeneratedNever();
        });

        modelBuilder.Entity<TransferWareHoseDetailTbl>(entity =>
        {
            entity.HasKey(e => e.SysCode).HasName("PK__TransferWareHose__2D9CB955");

            entity.Property(e => e.DateExpire).IsFixedLength();

            entity.HasOne(d => d.FkTransferSysCodeNavigation).WithMany(p => p.TransferWareHoseDetailTbls)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TransferW__FK_Tr__2F8501C7");

            entity.HasOne(d => d.GoodSysCodeNavigation).WithMany(p => p.TransferWareHoseDetailTbls)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TransferW__GoodS__2E90DD8E");
        });

        modelBuilder.Entity<TransferWareHoseTbl>(entity =>
        {
            entity.HasKey(e => e.TransferSerialNo).HasName("PK__TransferWareHose__2BB470E3");

            entity.Property(e => e.FkYearId).HasDefaultValue((byte)1);
            entity.Property(e => e.SysShamsiDate).IsFixedLength();
            entity.Property(e => e.TransferDate).IsFixedLength();

            entity.HasOne(d => d.FkYear).WithMany(p => p.TransferWareHoseTbls)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TransferW__Fk_Ye__0D1184E0");

            entity.HasOne(d => d.UserNoNavigation).WithMany(p => p.TransferWareHoseTbls)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TransferW__UserN__78F3E6EC");
        });

        modelBuilder.Entity<TypeOfSettlementTbl>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TypeOfSettlement__61516785");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.Property(e => e.IsUpdatePersonTblDocList).HasDefaultValue(true);
            entity.Property(e => e.IsUpdatePersonTblInvoiceList).HasDefaultValue(true);
            entity.Property(e => e.IsUpdateStockTbl).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.GidNavigation).WithMany(p => p.Users).HasConstraintName("FK_Users_Groups");
        });

        modelBuilder.Entity<Visit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Visits__3214EC2726BD159B");

            entity.Property(e => e.ShamsiDate).IsFixedLength();

            entity.HasOne(d => d.Category).WithMany(p => p.Visits).HasConstraintName("FK__Visits__Category__2B161DBC");

            entity.HasOne(d => d.FkAccountSysCodeNavigation).WithMany(p => p.VisitFkAccountSysCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Visits__Fk_Accou__2839B111");

            entity.HasOne(d => d.FkInvoiceSerialNoNavigation).WithMany(p => p.Visits).HasConstraintName("FK__Visits__Fk_Invoi__2A21F983");

            entity.HasOne(d => d.FkVisitorSysCodeNavigation).WithMany(p => p.VisitFkVisitorSysCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Visits__Fk_Visit__292DD54A");
        });

        modelBuilder.Entity<VisitScaduleTbl>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__VisitScaduleTBL__711DBAFA");

            entity.Property(e => e.ShamsiDate).IsFixedLength();

            entity.HasOne(d => d.FkVisitor).WithMany(p => p.VisitScaduleTbls).HasConstraintName("FK__VisitScad__FK_Vi__7211DF33");

            entity.HasOne(d => d.FkZone).WithMany(p => p.VisitScaduleTbls).HasConstraintName("FK__VisitScad__FK_Zo__7306036C");
        });

        modelBuilder.Entity<VisitsCategory>(entity =>
        {
            entity.HasKey(e => e.CategoryId).HasName("PK__VisitsCa__19093A0B01962469");

            entity.Property(e => e.CategoryId).ValueGeneratedOnAdd();

            entity.HasOne(d => d.VisitTypeNavigation).WithMany(p => p.VisitsCategories)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__VisitsCat__Visit__255D4466");
        });

        modelBuilder.Entity<VisitsType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__VisitsTy__3214EC27F3B49697");
        });

        modelBuilder.Entity<VwAccountCheckInUnPassSum>(entity =>
        {
            entity.ToView("VW_Account_CheckInUnPass_Sum");
        });

        modelBuilder.Entity<VwAccountGhestInUnPassSum>(entity =>
        {
            entity.ToView("VW_Account_GhestInUnPass_Sum");
        });

        modelBuilder.Entity<VwAccountRemain>(entity =>
        {
            entity.ToView("VW_Account_Remain");

            entity.Property(e => e.LastDate).IsFixedLength();
        });

        modelBuilder.Entity<VwAllBarcodeOfStockList>(entity =>
        {
            entity.ToView("VW_AllBarcodeOfStockList");
        });

        modelBuilder.Entity<VwAndroidMehr>(entity =>
        {
            entity.ToView("VW_AndroidMehr");
        });

        modelBuilder.Entity<VwCompleteInventory>(entity =>
        {
            entity.ToView("VW_CompleteInventory");

            entity.Property(e => e.DateExpire).IsFixedLength();
            entity.Property(e => e.ShamsiDate).IsFixedLength();
            entity.Property(e => e.ShamsiSysDate).IsFixedLength();
        });

        modelBuilder.Entity<VwCompleteInvoice>(entity =>
        {
            entity.ToView("VW_CompleteInvoice");

            entity.Property(e => e.DelivaredDate).IsFixedLength();
            entity.Property(e => e.InvoiceDate).IsFixedLength();
            entity.Property(e => e.PaymentDate).IsFixedLength();
            entity.Property(e => e.RecivedDate).IsFixedLength();
        });

        modelBuilder.Entity<VwCompleteRemainAnbarTransfer>(entity =>
        {
            entity.ToView("VW_CompleteRemain_Anbar_Transfer");

            entity.Property(e => e.DateExpire).IsFixedLength();
        });

        modelBuilder.Entity<VwCompleteRemainAnbarTransferByTitle>(entity =>
        {
            entity.ToView("VW_CompleteRemain_Anbar_Transfer_ByTitle");

            entity.Property(e => e.DateExpire).IsFixedLength();
        });

        modelBuilder.Entity<VwCompleteVisit>(entity =>
        {
            entity.ToView("VW_CompleteVisits");

            entity.Property(e => e.ShamsiDate).IsFixedLength();
        });

        modelBuilder.Entity<VwContactIdContactSumary>(entity =>
        {
            entity.ToView("VW_ContactId_ContactSumary");
        });

        modelBuilder.Entity<VwGoodCardex>(entity =>
        {
            entity.ToView("VW_GoodCardex");

            entity.Property(e => e.InvoiceDate).IsFixedLength();
        });

        modelBuilder.Entity<VwGoodOrderIn>(entity =>
        {
            entity.ToView("VW_GoodOrderIn");
        });

        modelBuilder.Entity<VwGoodOrderOut>(entity =>
        {
            entity.ToView("VW_GoodOrderOut");
        });

        modelBuilder.Entity<VwInventoryGoodDetailRemain>(entity =>
        {
            entity.ToView("VW_InventoryGoodDetailRemain");

            entity.Property(e => e.DateExpire).IsFixedLength();
        });

        modelBuilder.Entity<VwInventoryGoodDetailRemainByTitle>(entity =>
        {
            entity.ToView("VW_InventoryGoodDetailRemain_ByTitle");

            entity.Property(e => e.DateExpire).IsFixedLength();
        });

        modelBuilder.Entity<VwInventoryGoodSimpleRemain>(entity =>
        {
            entity.ToView("VW_InventoryGoodSimpleRemain");
        });

        modelBuilder.Entity<VwInvoiceAndInventoryRemain>(entity =>
        {
            entity.ToView("VW_InvoiceAndInventoryRemain");

            entity.Property(e => e.DateExpire).IsFixedLength();
        });

        modelBuilder.Entity<VwInvoiceByInventory>(entity =>
        {
            entity.ToView("VW_InvoiceByInventory");

            entity.Property(e => e.DelivaredDate).IsFixedLength();
            entity.Property(e => e.InventoryDate).IsFixedLength();
            entity.Property(e => e.InvoiceDate).IsFixedLength();
            entity.Property(e => e.PaymentDate).IsFixedLength();
            entity.Property(e => e.RecivedDate).IsFixedLength();
        });

        modelBuilder.Entity<VwInvoiceCostAmount>(entity =>
        {
            entity.ToView("VW_invoice_Cost_Amount");
        });

        modelBuilder.Entity<VwInvoiceDetailCostPersonDocDetail>(entity =>
        {
            entity.ToView("VW_InvoiceDetail_Cost_PersonDocDetail");

            entity.Property(e => e.InvoiceDate).IsFixedLength();
        });

        modelBuilder.Entity<VwInvoiceListNotPaymentAndNoPaymentComplete>(entity =>
        {
            entity.ToView("VW_InvoiceList_NotPayment_AndNoPaymentComplete");

            entity.Property(e => e.DelivaredDate).IsFixedLength();
            entity.Property(e => e.InvoiceDate).IsFixedLength();
            entity.Property(e => e.PaymentDate).IsFixedLength();
            entity.Property(e => e.RecivedDate).IsFixedLength();
        });

        modelBuilder.Entity<VwInvoiceListPayment>(entity =>
        {
            entity.ToView("VW_InvoiceList_Payment");

            entity.Property(e => e.DelivaredDate).IsFixedLength();
            entity.Property(e => e.DocDate).IsFixedLength();
            entity.Property(e => e.InvoiceDate).IsFixedLength();
            entity.Property(e => e.PaymentDate).IsFixedLength();
            entity.Property(e => e.RecivedDate).IsFixedLength();
        });

        modelBuilder.Entity<VwInvoiceSumPayment>(entity =>
        {
            entity.ToView("VW_InvoiceSumPayment");
        });

        modelBuilder.Entity<VwInvoiceTasviehComplete>(entity =>
        {
            entity.ToView("VW_InvoiceTasviehComplete");
        });

        modelBuilder.Entity<VwLastInvoiceOfPerson>(entity =>
        {
            entity.ToView("VW_LastInvoiceOfPerson");

            entity.Property(e => e.LastInvoiceDate).IsFixedLength();
        });

        modelBuilder.Entity<VwLeadAccount>(entity =>
        {
            entity.ToView("VW_LeadAccounts");
        });

        modelBuilder.Entity<VwLeadAccountsTreeList>(entity =>
        {
            entity.ToView("VW_LeadAccountsTreeList");
        });

        modelBuilder.Entity<VwLeadAccountsWithParent>(entity =>
        {
            entity.ToView("VW_LeadAccountsWithParent");
        });

        modelBuilder.Entity<VwLinkToAccountTitle>(entity =>
        {
            entity.ToView("VW_LinkTo_Account&Title");
        });

        modelBuilder.Entity<VwMaliatMokarar>(entity =>
        {
            entity.ToView("VW_MaliatMokarar");

            entity.Property(e => e.InvoiceDate).IsFixedLength();
        });

        modelBuilder.Entity<VwPersonList>(entity =>
        {
            entity.ToView("VW_PersonList");
        });

        modelBuilder.Entity<VwPersonRemainCheckRemain>(entity =>
        {
            entity.ToView("VW_Person_Remain_CheckRemain");
        });

        modelBuilder.Entity<VwPersonStateCityZone>(entity =>
        {
            entity.ToView("VW_Person_State_City_Zone");
        });

        modelBuilder.Entity<VwPricingDetailComplete>(entity =>
        {
            entity.ToView("VW_PricingDetailComplete");

            entity.Property(e => e.ShamsiDate).IsFixedLength();
            entity.Property(e => e.SysShamsiDate).IsFixedLength();
        });

        modelBuilder.Entity<VwRemainGoodTolidi>(entity =>
        {
            entity.ToView("VW_RemainGoodTolidi");
        });

        modelBuilder.Entity<VwSysGoodRemainDetail>(entity =>
        {
            entity.ToView("VW_Sys_GoodRemainDetail");
        });

        modelBuilder.Entity<VwSysGoodRemainSimple>(entity =>
        {
            entity.ToView("VW_Sys_GoodRemainSimple");
        });

        modelBuilder.Entity<VwTaxErrorComplete>(entity =>
        {
            entity.ToView("VW_TaxError_Complete");
        });

        modelBuilder.Entity<VwTaxInvoiceAmount>(entity =>
        {
            entity.ToView("VW_TaxInvoice_Amount");
        });

        modelBuilder.Entity<VwTaxInvoiceBody>(entity =>
        {
            entity.ToView("VW_TaxInvoiceBody");
        });

        modelBuilder.Entity<VwTaxInvoiceComplete>(entity =>
        {
            entity.ToView("VW_TaxInvoice_Complete");
        });

        modelBuilder.Entity<VwTaxInvoiceCompleteLastStatus>(entity =>
        {
            entity.ToView("VW_TaxInvoice_Complete_LastStatus");
        });

        modelBuilder.Entity<VwTaxInvoiceLog>(entity =>
        {
            entity.ToView("VW_TaxInvoice_Log");
        });

        modelBuilder.Entity<VwTaxPersonComplete>(entity =>
        {
            entity.ToView("VW_TaxPerson_Complete");
        });

        modelBuilder.Entity<VwTransferAndInventoryRemain>(entity =>
        {
            entity.ToView("VW_TransferAndInventoryRemain");

            entity.Property(e => e.DateExpire).IsFixedLength();
        });

        modelBuilder.Entity<VwVisitorDriverMovaze>(entity =>
        {
            entity.ToView("VW_Visitor_Driver_Movaze");
        });

        modelBuilder.Entity<VwWareHouseTransferComplete>(entity =>
        {
            entity.ToView("VW_WareHouseTransferComplete");

            entity.Property(e => e.DateExpire).IsFixedLength();
            entity.Property(e => e.InvoiceDate).IsFixedLength();
        });

        modelBuilder.Entity<VwWarehouseCounting>(entity =>
        {
            entity.ToView("VW_WarehouseCounting");

            entity.Property(e => e.EditShamsiDate).IsFixedLength();
            entity.Property(e => e.RegShamsiDate).IsFixedLength();
            entity.Property(e => e.ShamsiDate).IsFixedLength();
        });

        modelBuilder.Entity<VwWarehouseCountingDetail>(entity =>
        {
            entity.ToView("VW_WarehouseCountingDetail");

            entity.Property(e => e.DateExpire).IsFixedLength();
            entity.Property(e => e.RegShamsiDate).IsFixedLength();
            entity.Property(e => e.ShamsiDate).IsFixedLength();
        });

        modelBuilder.Entity<VwcompleteCode>(entity =>
        {
            entity.ToView("VWCompleteCode");
        });

        modelBuilder.Entity<VwcompleteGood>(entity =>
        {
            entity.ToView("VWCompleteGood");
        });

        modelBuilder.Entity<VwdocumentDetailDocHeader>(entity =>
        {
            entity.ToView("VWDocumentDetail_DocHeader");

            entity.Property(e => e.DocDate).IsFixedLength();
        });

        modelBuilder.Entity<VwdocumentDetailDocHeaderNotTemp>(entity =>
        {
            entity.ToView("VWDocumentDetail_DocHeader_NotTemp");

            entity.Property(e => e.DocDate).IsFixedLength();
        });

        modelBuilder.Entity<VwgoodAvrageFee>(entity =>
        {
            entity.ToView("VWGoodAvrageFee");
        });

        modelBuilder.Entity<VwgoodDetailRemain>(entity =>
        {
            entity.ToView("VWGoodDetailRemain");

            entity.Property(e => e.DateExpire).IsFixedLength();
        });

        modelBuilder.Entity<VwgoodDetailRemainForPropertyInvoice>(entity =>
        {
            entity.ToView("VWGoodDetailRemainForPropertyInvoice");

            entity.Property(e => e.DateExpire).IsFixedLength();
        });

        modelBuilder.Entity<VwgoodReport>(entity =>
        {
            entity.ToView("VWGoodReport");

            entity.Property(e => e.DelivaredDate).IsFixedLength();
            entity.Property(e => e.FollowDate).IsFixedLength();
            entity.Property(e => e.InvoiceDate).IsFixedLength();
            entity.Property(e => e.RecivedDate).IsFixedLength();
        });

        modelBuilder.Entity<VwgoodSimpleLastCurrencySummary>(entity =>
        {
            entity.ToView("VWGoodSimpleLastCurrencySummary");

            entity.Property(e => e.InvoiceDate).IsFixedLength();
        });

        modelBuilder.Entity<VwgoodSimpleLastSummary>(entity =>
        {
            entity.ToView("VWGoodSimpleLastSummary");

            entity.Property(e => e.LastDate).IsFixedLength();
        });

        modelBuilder.Entity<VwgoodSimpleRemain>(entity =>
        {
            entity.ToView("VWGoodSimpleRemain");
        });

        modelBuilder.Entity<VwinvoiceDetailComplete>(entity =>
        {
            entity.ToView("VWInvoiceDetailComplete");

            entity.Property(e => e.DateExpire).IsFixedLength();
            entity.Property(e => e.DelivaredDate).IsFixedLength();
            entity.Property(e => e.InvoiceDate).IsFixedLength();
            entity.Property(e => e.PaymentDate).IsFixedLength();
            entity.Property(e => e.RecivedDate).IsFixedLength();
            entity.Property(e => e.SysShamsiDate).IsFixedLength();
        });

        modelBuilder.Entity<VwinvoiceDetailCompleteForAndroid>(entity =>
        {
            entity.ToView("VWInvoiceDetailCompleteForAndroid");

            entity.Property(e => e.InvoiceDate).IsFixedLength();
        });

        modelBuilder.Entity<WarehouseCounting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Warehous__3214EC070EF0EFA7");

            entity.Property(e => e.EditShamsiDate).IsFixedLength();
            entity.Property(e => e.FkYearId).HasDefaultValue((byte)1);
            entity.Property(e => e.RegShamsiDate).IsFixedLength();
            entity.Property(e => e.ShamsiDate).IsFixedLength();

            entity.HasOne(d => d.FkProject).WithMany(p => p.WarehouseCountings).HasConstraintName("FK__Warehouse__Fk_Pr__19775BC5");

            entity.HasOne(d => d.FkYear).WithMany(p => p.WarehouseCountings)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Warehouse__Fk_Ye__0EF9CD52");
        });

        modelBuilder.Entity<WarehouseCountingDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Warehous__3214EC07F46EED7D");

            entity.Property(e => e.DateExpire).IsFixedLength();

            entity.HasOne(d => d.ColorNavigation).WithMany(p => p.WarehouseCountingDetails).HasConstraintName("FK__Warehouse__Color__3B226853");

            entity.HasOne(d => d.FkWarehouseCounting).WithMany(p => p.WarehouseCountingDetails).HasConstraintName("FK__Warehouse__Fk_Wa__3751D76F");

            entity.HasOne(d => d.GoodSysCodeNavigation).WithMany(p => p.WarehouseCountingDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Warehouse__GoodS__3845FBA8");

            entity.HasOne(d => d.SizeNavigation).WithMany(p => p.WarehouseCountingDetails).HasConstraintName("FK__WarehouseC__Size__3A2E441A");

            entity.HasOne(d => d.WarehouseNavigation).WithMany(p => p.WarehouseCountingDetails).HasConstraintName("FK__Warehouse__Wareh__393A1FE1");
        });

        modelBuilder.Entity<ZoneTbl>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ZoneTBL__75586032");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
