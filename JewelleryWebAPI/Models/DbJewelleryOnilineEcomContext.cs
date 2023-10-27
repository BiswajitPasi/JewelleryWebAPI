using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace JewelleryWebAPI.Models;

public partial class DbJewelleryOnilineEcomContext : DbContext
{
    public DbJewelleryOnilineEcomContext()
    {
    }

    public DbJewelleryOnilineEcomContext(DbContextOptions<DbJewelleryOnilineEcomContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CashInOutFlow1> CashInOutFlow1s { get; set; }

    public virtual DbSet<SchemaInfo> SchemaInfos { get; set; }

    public virtual DbSet<ScopeConfig> ScopeConfigs { get; set; }

    public virtual DbSet<ScopeInfo> ScopeInfos { get; set; }

    public virtual DbSet<ScopeInfoHistory> ScopeInfoHistories { get; set; }

    public virtual DbSet<ScopeInfoServer> ScopeInfoServers { get; set; }

    public virtual DbSet<TblAccountGroup> TblAccountGroups { get; set; }

    public virtual DbSet<TblAccountGroupToCopy> TblAccountGroupToCopies { get; set; }

    public virtual DbSet<TblAccountLedger> TblAccountLedgers { get; set; }

    public virtual DbSet<TblAccountLedgerContactPerson> TblAccountLedgerContactPeople { get; set; }

    public virtual DbSet<TblAccountLedgerToCopy> TblAccountLedgerToCopies { get; set; }

    public virtual DbSet<TblAccountLedgerTracking> TblAccountLedgerTrackings { get; set; }

    public virtual DbSet<TblAdditionalCost> TblAdditionalCosts { get; set; }

    public virtual DbSet<TblAdvancePayment> TblAdvancePayments { get; set; }

    public virtual DbSet<TblArea> TblAreas { get; set; }

    public virtual DbSet<TblBankReconciliation> TblBankReconciliations { get; set; }

    public virtual DbSet<TblBarcodeSetting> TblBarcodeSettings { get; set; }

    public virtual DbSet<TblBatch> TblBatches { get; set; }

    public virtual DbSet<TblBom> TblBoms { get; set; }

    public virtual DbSet<TblBonusDeduction> TblBonusDeductions { get; set; }

    public virtual DbSet<TblBrand> TblBrands { get; set; }

    public virtual DbSet<TblBudgetDetail> TblBudgetDetails { get; set; }

    public virtual DbSet<TblBudgetMaster> TblBudgetMasters { get; set; }

    public virtual DbSet<TblCompany> TblCompanies { get; set; }

    public virtual DbSet<TblCompanyPath> TblCompanyPaths { get; set; }

    public virtual DbSet<TblContraDetail> TblContraDetails { get; set; }

    public virtual DbSet<TblContraMaster> TblContraMasters { get; set; }

    public virtual DbSet<TblCounter> TblCounters { get; set; }

    public virtual DbSet<TblCreditNoteDetail> TblCreditNoteDetails { get; set; }

    public virtual DbSet<TblCreditNoteMaster> TblCreditNoteMasters { get; set; }

    public virtual DbSet<TblCreditSettlement> TblCreditSettlements { get; set; }

    public virtual DbSet<TblCurrency> TblCurrencies { get; set; }

    public virtual DbSet<TblCurrencyToCopy> TblCurrencyToCopies { get; set; }

    public virtual DbSet<TblDailyAttendanceDetail> TblDailyAttendanceDetails { get; set; }

    public virtual DbSet<TblDailyAttendanceMaster> TblDailyAttendanceMasters { get; set; }

    public virtual DbSet<TblDailySalaryVoucherDetail> TblDailySalaryVoucherDetails { get; set; }

    public virtual DbSet<TblDailySalaryVoucherMaster> TblDailySalaryVoucherMasters { get; set; }

    public virtual DbSet<TblDebitNoteDetail> TblDebitNoteDetails { get; set; }

    public virtual DbSet<TblDebitNoteMaster> TblDebitNoteMasters { get; set; }

    public virtual DbSet<TblDeliveryDetail> TblDeliveryDetails { get; set; }

    public virtual DbSet<TblDeliveryNoteDetail> TblDeliveryNoteDetails { get; set; }

    public virtual DbSet<TblDeliveryNoteMaster> TblDeliveryNoteMasters { get; set; }

    public virtual DbSet<TblDesignation> TblDesignations { get; set; }

    public virtual DbSet<TblDetail> TblDetails { get; set; }

    public virtual DbSet<TblDetailsCopy> TblDetailsCopies { get; set; }

    public virtual DbSet<TblDiscount> TblDiscounts { get; set; }

    public virtual DbSet<TblDocumentManage> TblDocumentManages { get; set; }

    public virtual DbSet<TblEmployee> TblEmployees { get; set; }

    public virtual DbSet<TblExchangeRate> TblExchangeRates { get; set; }

    public virtual DbSet<TblExtraOption> TblExtraOptions { get; set; }

    public virtual DbSet<TblField> TblFields { get; set; }

    public virtual DbSet<TblFieldsCopy> TblFieldsCopies { get; set; }

    public virtual DbSet<TblFinancialYear> TblFinancialYears { get; set; }

    public virtual DbSet<TblForm> TblForms { get; set; }

    public virtual DbSet<TblFormCopy> TblFormCopies { get; set; }

    public virtual DbSet<TblGodown> TblGodowns { get; set; }

    public virtual DbSet<TblHoliday> TblHolidays { get; set; }

    public virtual DbSet<TblJournalDetail> TblJournalDetails { get; set; }

    public virtual DbSet<TblJournalMaster> TblJournalMasters { get; set; }

    public virtual DbSet<TblKot> TblKots { get; set; }

    public virtual DbSet<TblKotPrinterSetting> TblKotPrinterSettings { get; set; }

    public virtual DbSet<TblLedgerPosting> TblLedgerPostings { get; set; }

    public virtual DbSet<TblMaster> TblMasters { get; set; }

    public virtual DbSet<TblMasterCopy> TblMasterCopies { get; set; }

    public virtual DbSet<TblMaterialIssueDetail> TblMaterialIssueDetails { get; set; }

    public virtual DbSet<TblMaterialIsuue> TblMaterialIsuues { get; set; }

    public virtual DbSet<TblMaterialIsuueMaster> TblMaterialIsuueMasters { get; set; }

    public virtual DbSet<TblMaterialReceiptDetail> TblMaterialReceiptDetails { get; set; }

    public virtual DbSet<TblMaterialReceiptMaster> TblMaterialReceiptMasters { get; set; }

    public virtual DbSet<TblMobileReport> TblMobileReports { get; set; }

    public virtual DbSet<TblMobileReportSale> TblMobileReportSales { get; set; }

    public virtual DbSet<TblModelNo> TblModelNos { get; set; }

    public virtual DbSet<TblMonthlySalary> TblMonthlySalaries { get; set; }

    public virtual DbSet<TblMonthlySalaryDetail> TblMonthlySalaryDetails { get; set; }

    public virtual DbSet<TblPackageDetail> TblPackageDetails { get; set; }

    public virtual DbSet<TblPackageHead> TblPackageHeads { get; set; }

    public virtual DbSet<TblPartyBalance> TblPartyBalances { get; set; }

    public virtual DbSet<TblPayHead> TblPayHeads { get; set; }

    public virtual DbSet<TblPaymentDetail> TblPaymentDetails { get; set; }

    public virtual DbSet<TblPaymentMaster> TblPaymentMasters { get; set; }

    public virtual DbSet<TblPdcclearanceMaster> TblPdcclearanceMasters { get; set; }

    public virtual DbSet<TblPdcpayableMaster> TblPdcpayableMasters { get; set; }

    public virtual DbSet<TblPdcreceivableMaster> TblPdcreceivableMasters { get; set; }

    public virtual DbSet<TblPhysicalStockDetail> TblPhysicalStockDetails { get; set; }

    public virtual DbSet<TblPhysicalStockMaster> TblPhysicalStockMasters { get; set; }

    public virtual DbSet<TblPriceList> TblPriceLists { get; set; }

    public virtual DbSet<TblPricingLevel> TblPricingLevels { get; set; }

    public virtual DbSet<TblPrivilege> TblPrivileges { get; set; }

    public virtual DbSet<TblPrizeList> TblPrizeLists { get; set; }

    public virtual DbSet<TblProduct> TblProducts { get; set; }

    public virtual DbSet<TblProductGroup> TblProductGroups { get; set; }

    public virtual DbSet<TblProductTemp> TblProductTemps { get; set; }

    public virtual DbSet<TblProductTracking> TblProductTrackings { get; set; }

    public virtual DbSet<TblProfitRange> TblProfitRanges { get; set; }

    public virtual DbSet<TblProject> TblProjects { get; set; }

    public virtual DbSet<TblProjectCostD> TblProjectCostDs { get; set; }

    public virtual DbSet<TblProjectCostH> TblProjectCostHs { get; set; }

    public virtual DbSet<TblPurchaseBillTax> TblPurchaseBillTaxes { get; set; }

    public virtual DbSet<TblPurchaseDetail> TblPurchaseDetails { get; set; }

    public virtual DbSet<TblPurchaseFromCustomer> TblPurchaseFromCustomers { get; set; }

    public virtual DbSet<TblPurchaseMaster> TblPurchaseMasters { get; set; }

    public virtual DbSet<TblPurchaseOrderDetail> TblPurchaseOrderDetails { get; set; }

    public virtual DbSet<TblPurchaseOrderMaster> TblPurchaseOrderMasters { get; set; }

    public virtual DbSet<TblPurchaseReturnBilltax> TblPurchaseReturnBilltaxes { get; set; }

    public virtual DbSet<TblPurchaseReturnDetail> TblPurchaseReturnDetails { get; set; }

    public virtual DbSet<TblPurchaseReturnMaster> TblPurchaseReturnMasters { get; set; }

    public virtual DbSet<TblPurchasefromCustomerDetailsP> TblPurchasefromCustomerDetailsPs { get; set; }

    public virtual DbSet<TblPurchasefromCustomerDetailsP1> TblPurchasefromCustomerDetailsPs1 { get; set; }

    public virtual DbSet<TblQuickLaunchItem> TblQuickLaunchItems { get; set; }

    public virtual DbSet<TblQuickLaunchItemsToCopy> TblQuickLaunchItemsToCopies { get; set; }

    public virtual DbSet<TblRack> TblRacks { get; set; }

    public virtual DbSet<TblReceiptDetail> TblReceiptDetails { get; set; }

    public virtual DbSet<TblReceiptMaster> TblReceiptMasters { get; set; }

    public virtual DbSet<TblRejectionInDetail> TblRejectionInDetails { get; set; }

    public virtual DbSet<TblRejectionInMaster> TblRejectionInMasters { get; set; }

    public virtual DbSet<TblRejectionOutDetail> TblRejectionOutDetails { get; set; }

    public virtual DbSet<TblRejectionOutMaster> TblRejectionOutMasters { get; set; }

    public virtual DbSet<TblReminder> TblReminders { get; set; }

    public virtual DbSet<TblReservedTable> TblReservedTables { get; set; }

    public virtual DbSet<TblRole> TblRoles { get; set; }

    public virtual DbSet<TblRoute> TblRoutes { get; set; }

    public virtual DbSet<TblSalaryPackage> TblSalaryPackages { get; set; }

    public virtual DbSet<TblSalaryPackageDetail> TblSalaryPackageDetails { get; set; }

    public virtual DbSet<TblSalaryVoucherDetail> TblSalaryVoucherDetails { get; set; }

    public virtual DbSet<TblSalaryVoucherMaster> TblSalaryVoucherMasters { get; set; }

    public virtual DbSet<TblSalesBillDiscount> TblSalesBillDiscounts { get; set; }

    public virtual DbSet<TblSalesBillTax> TblSalesBillTaxes { get; set; }

    public virtual DbSet<TblSalesDetail> TblSalesDetails { get; set; }

    public virtual DbSet<TblSalesMaster> TblSalesMasters { get; set; }

    public virtual DbSet<TblSalesMasterExtraCharge> TblSalesMasterExtraCharges { get; set; }

    public virtual DbSet<TblSalesOrderBillTax> TblSalesOrderBillTaxes { get; set; }

    public virtual DbSet<TblSalesOrderDetails> TblSalesOrderDetails { get; set; }

    public virtual DbSet<TblSalesOrderMaster> TblSalesOrderMasters { get; set; }

    public virtual DbSet<TblSalesQuotationDetail> TblSalesQuotationDetails { get; set; }

    public virtual DbSet<TblSalesQuotationDetailsManual> TblSalesQuotationDetailsManuals { get; set; }

    public virtual DbSet<TblSalesQuotationManual> TblSalesQuotationManuals { get; set; }

    public virtual DbSet<TblSalesQuotationMaster> TblSalesQuotationMasters { get; set; }

    public virtual DbSet<TblSalesQuotationMaterial> TblSalesQuotationMaterials { get; set; }

    public virtual DbSet<TblSalesReturnBillTax> TblSalesReturnBillTaxes { get; set; }

    public virtual DbSet<TblSalesReturnDetail> TblSalesReturnDetails { get; set; }

    public virtual DbSet<TblSalesReturnMaster> TblSalesReturnMasters { get; set; }

    public virtual DbSet<TblService> TblServices { get; set; }

    public virtual DbSet<TblServiceCategory> TblServiceCategories { get; set; }

    public virtual DbSet<TblServiceDetail> TblServiceDetails { get; set; }

    public virtual DbSet<TblServiceMaster> TblServiceMasters { get; set; }

    public virtual DbSet<TblSetExtraOption> TblSetExtraOptions { get; set; }

    public virtual DbSet<TblSetting> TblSettings { get; set; }

    public virtual DbSet<TblSettingsToCopy> TblSettingsToCopies { get; set; }

    public virtual DbSet<TblShift> TblShifts { get; set; }

    public virtual DbSet<TblSize> TblSizes { get; set; }

    public virtual DbSet<TblStandardRate> TblStandardRates { get; set; }

    public virtual DbSet<TblStockJournalDetail> TblStockJournalDetails { get; set; }

    public virtual DbSet<TblStockJournalMaster> TblStockJournalMasters { get; set; }

    public virtual DbSet<TblStockPosting> TblStockPostings { get; set; }

    public virtual DbSet<TblStockTemp> TblStockTemps { get; set; }

    public virtual DbSet<TblSuffixPrefix> TblSuffixPrefixes { get; set; }

    public virtual DbSet<TblTable> TblTables { get; set; }

    public virtual DbSet<TblTableType> TblTableTypes { get; set; }

    public virtual DbSet<TblTax> TblTaxes { get; set; }

    public virtual DbSet<TblTaxDetail> TblTaxDetails { get; set; }

    public virtual DbSet<TblTempSalesBillTax> TblTempSalesBillTaxes { get; set; }

    public virtual DbSet<TblTempSalesBilldiscount> TblTempSalesBilldiscounts { get; set; }

    public virtual DbSet<TblTempSalesDetail> TblTempSalesDetails { get; set; }

    public virtual DbSet<TblTempSalesMaster> TblTempSalesMasters { get; set; }

    public virtual DbSet<TblTicketReceive> TblTicketReceives { get; set; }

    public virtual DbSet<TblTicketReceiveDetail> TblTicketReceiveDetails { get; set; }

    public virtual DbSet<TblUnit> TblUnits { get; set; }

    public virtual DbSet<TblUnitConvertion> TblUnitConvertions { get; set; }

    public virtual DbSet<TblUser> TblUsers { get; set; }

    public virtual DbSet<TblVoucherType> TblVoucherTypes { get; set; }

    public virtual DbSet<TblVoucherTypeTax> TblVoucherTypeTaxes { get; set; }

    public virtual DbSet<TblVoucherTypeToCopy> TblVoucherTypeToCopies { get; set; }

    public virtual DbSet<TblWinnerDetail> TblWinnerDetails { get; set; }

    public virtual DbSet<TblWinnerHead> TblWinnerHeads { get; set; }

    public virtual DbSet<Temp> Temps { get; set; }

    public virtual DbSet<Temp1> Temp1s { get; set; }

    public virtual DbSet<Temp81> Temp81s { get; set; }

    public virtual DbSet<TempProductForMobile> TempProductForMobiles { get; set; }

    public virtual DbSet<View1> View1s { get; set; }

    public virtual DbSet<ViewCashBank> ViewCashBanks { get; set; }

    public virtual DbSet<VwMaxRate> VwMaxRates { get; set; }

    public virtual DbSet<VwMinRate> VwMinRates { get; set; }

    public virtual DbSet<VwStockQuery> VwStockQueries { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=BISU;Initial Catalog=_Db_Jewellery_OnilineEcom;Integrated Security=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CashInOutFlow1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CashInOutFlow1");

            entity.Property(e => e.AccountGroupId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("accountGroupId");
        });

        modelBuilder.Entity<SchemaInfo>(entity =>
        {
            entity.HasKey(e => new { e.SchemaMajorVersion, e.SchemaMinorVersion });

            entity.ToTable("schema_info");

            entity.Property(e => e.SchemaMajorVersion).HasColumnName("schema_major_version");
            entity.Property(e => e.SchemaMinorVersion).HasColumnName("schema_minor_version");
            entity.Property(e => e.SchemaExtendedInfo)
                .HasMaxLength(100)
                .HasColumnName("schema_extended_info");
        });

        modelBuilder.Entity<ScopeConfig>(entity =>
        {
            entity.HasKey(e => e.ConfigId);

            entity.ToTable("scope_config");

            entity.Property(e => e.ConfigId)
                .ValueGeneratedNever()
                .HasColumnName("config_id");
            entity.Property(e => e.ConfigData)
                .HasColumnType("xml")
                .HasColumnName("config_data");
            entity.Property(e => e.ScopeStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("scope_status");
        });

        modelBuilder.Entity<ScopeInfo>(entity =>
        {
            entity.HasKey(e => e.SyncScopeName);

            entity.ToTable("scope_info");

            entity.Property(e => e.SyncScopeName)
                .HasMaxLength(100)
                .HasColumnName("sync_scope_name");
            entity.Property(e => e.ScopeConfigId).HasColumnName("scope_config_id");
            entity.Property(e => e.ScopeId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("scope_id");
            entity.Property(e => e.ScopeLocalId)
                .ValueGeneratedOnAdd()
                .HasColumnName("scope_local_id");
            entity.Property(e => e.ScopeRestoreCount).HasColumnName("scope_restore_count");
            entity.Property(e => e.ScopeSyncKnowledge).HasColumnName("scope_sync_knowledge");
            entity.Property(e => e.ScopeTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("scope_timestamp");
            entity.Property(e => e.ScopeTombstoneCleanupKnowledge).HasColumnName("scope_tombstone_cleanup_knowledge");
            entity.Property(e => e.ScopeUserComment).HasColumnName("scope_user_comment");
        });

        modelBuilder.Entity<ScopeInfoHistory>(entity =>
        {
            entity.HasKey(e => e.SyncScopeId);

            entity.ToTable("scope_info_history");

            entity.Property(e => e.SyncScopeId)
                .ValueGeneratedNever()
                .HasColumnName("sync_scope_id");
            entity.Property(e => e.ScopeLastSync)
                .HasColumnType("datetime")
                .HasColumnName("scope_last_sync");
            entity.Property(e => e.ScopeLastSyncDuration).HasColumnName("scope_last_sync_duration");
            entity.Property(e => e.ScopeLastSyncTimestamp).HasColumnName("scope_last_sync_timestamp");
            entity.Property(e => e.SyncScopeName)
                .HasMaxLength(100)
                .HasColumnName("sync_scope_name");
        });

        modelBuilder.Entity<ScopeInfoServer>(entity =>
        {
            entity.HasKey(e => e.SyncScopeName);

            entity.ToTable("scope_info_server");

            entity.Property(e => e.SyncScopeName)
                .HasMaxLength(100)
                .HasColumnName("sync_scope_name");
            entity.Property(e => e.SyncScopeLastCleanTimestamp).HasColumnName("sync_scope_last_clean_timestamp");
            entity.Property(e => e.SyncScopeSchema).HasColumnName("sync_scope_schema");
            entity.Property(e => e.SyncScopeSetup).HasColumnName("sync_scope_setup");
            entity.Property(e => e.SyncScopeVersion)
                .HasMaxLength(10)
                .HasColumnName("sync_scope_version");
        });

        modelBuilder.Entity<TblAccountGroup>(entity =>
        {
            entity.HasKey(e => e.AccountGroupId).HasName("PK__tbl_Acco__74C422AE625A9A57");

            entity.ToTable("tbl_AccountGroup");

            entity.Property(e => e.AccountGroupId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("accountGroupId");
            entity.Property(e => e.AccountGroupName)
                .IsUnicode(false)
                .HasColumnName("accountGroupName");
            entity.Property(e => e.AffectGrossProfit)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("affectGrossProfit");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.GroupUnder)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("groupUnder");
            entity.Property(e => e.IsDefault).HasColumnName("isDefault");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.Nature)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nature");
        });

        modelBuilder.Entity<TblAccountGroupToCopy>(entity =>
        {
            entity.HasKey(e => e.AccountGroupId);

            entity.ToTable("tbl_AccountGroupToCopy");

            entity.HasIndex(e => e.GroupUnder, "IX_tbl_AccountGroupToCopy");

            entity.HasIndex(e => e.Nature, "IX_tbl_AccountGroupToCopy_1");

            entity.HasIndex(e => new { e.AccountGroupId, e.GroupUnder, e.IsDefault, e.Nature }, "IX_tbl_AccountGroupToCopy_2");

            entity.Property(e => e.AccountGroupId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("accountGroupId");
            entity.Property(e => e.AccountGroupName)
                .IsUnicode(false)
                .HasColumnName("accountGroupName");
            entity.Property(e => e.AffectGrossProfit).HasColumnName("affectGrossProfit");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.GroupUnder)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("groupUnder");
            entity.Property(e => e.IsDefault).HasColumnName("isDefault");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.Nature)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nature");
        });

        modelBuilder.Entity<TblAccountLedger>(entity =>
        {
            entity.HasKey(e => e.LedgerId).HasName("PK_tbl_AccountLedger_1");

            entity.ToTable("tbl_AccountLedger");

            entity.Property(e => e.LedgerId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerId");
            entity.Property(e => e.AccountGroupId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("accountGroupId");
            entity.Property(e => e.Address).HasColumnName("address");
            entity.Property(e => e.AreaId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("areaId");
            entity.Property(e => e.BankAccountNumber)
                .IsUnicode(false)
                .HasColumnName("bankAccountNumber");
            entity.Property(e => e.BillByBill).HasColumnName("billByBill");
            entity.Property(e => e.BranchCode)
                .IsUnicode(false)
                .HasColumnName("branchCode");
            entity.Property(e => e.BranchName)
                .IsUnicode(false)
                .HasColumnName("branchName");
            entity.Property(e => e.CrOrDr)
                .IsUnicode(false)
                .HasColumnName("crOrDr");
            entity.Property(e => e.CreditLimit)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("creditLimit");
            entity.Property(e => e.CreditPeriod).HasColumnName("creditPeriod");
            entity.Property(e => e.Cst)
                .IsUnicode(false)
                .HasColumnName("cst");
            entity.Property(e => e.Email)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.IsDefault).HasColumnName("isDefault");
            entity.Property(e => e.LedgerName).HasColumnName("ledgerName");
            entity.Property(e => e.MailingName)
                .IsUnicode(false)
                .HasColumnName("mailingName");
            entity.Property(e => e.Mobile).HasColumnName("mobile");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.OpeningBalance)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("openingBalance");
            entity.Property(e => e.Pan)
                .IsUnicode(false)
                .HasColumnName("pan");
            entity.Property(e => e.Phone)
                .IsUnicode(false)
                .HasColumnName("phone");
            entity.Property(e => e.PicPhoto)
                .HasColumnType("image")
                .HasColumnName("picPhoto");
            entity.Property(e => e.PicSign)
                .HasColumnType("image")
                .HasColumnName("picSign");
            entity.Property(e => e.PricinglevelId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("pricinglevelId");
            entity.Property(e => e.RouteId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("routeId");
            entity.Property(e => e.Tin)
                .IsUnicode(false)
                .HasColumnName("tin");
        });

        modelBuilder.Entity<TblAccountLedgerContactPerson>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_AccountLedger_ContactPerson");

            entity.Property(e => e.Designation).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.LedgerId).HasColumnName("ledgerId");
            entity.Property(e => e.MobileNo).HasMaxLength(50);
            entity.Property(e => e.Srno).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TblAccountLedgerToCopy>(entity =>
        {
            entity.HasKey(e => e.LedgerId);

            entity.ToTable("tbl_AccountLedgerToCopy");

            entity.HasIndex(e => e.AccountGroupId, "IX_tbl_AccountLedgerToCopy");

            entity.HasIndex(e => e.PricinglevelId, "IX_tbl_AccountLedgerToCopy_1");

            entity.HasIndex(e => e.RouteId, "IX_tbl_AccountLedgerToCopy_2");

            entity.HasIndex(e => e.AreaId, "IX_tbl_AccountLedgerToCopy_3");

            entity.HasIndex(e => new { e.LedgerId, e.AccountGroupId }, "IX_tbl_AccountLedgerToCopy_4");

            entity.HasIndex(e => new { e.AccountGroupId, e.BillByBill }, "IX_tbl_AccountLedgerToCopy_5");

            entity.HasIndex(e => new { e.AreaId, e.RouteId }, "IX_tbl_AccountLedgerToCopy_6");

            entity.HasIndex(e => new { e.AccountGroupId, e.AreaId, e.LedgerId, e.RouteId, e.BillByBill, e.PricinglevelId }, "IX_tbl_AccountLedgerToCopy_7");

            entity.Property(e => e.LedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerId");
            entity.Property(e => e.AccountGroupId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("accountGroupId");
            entity.Property(e => e.Address)
                .IsUnicode(false)
                .HasColumnName("address");
            entity.Property(e => e.AreaId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("areaId");
            entity.Property(e => e.BankAccountNumber)
                .IsUnicode(false)
                .HasColumnName("bankAccountNumber");
            entity.Property(e => e.BillByBill).HasColumnName("billByBill");
            entity.Property(e => e.BranchCode)
                .IsUnicode(false)
                .HasColumnName("branchCode");
            entity.Property(e => e.BranchName)
                .IsUnicode(false)
                .HasColumnName("branchName");
            entity.Property(e => e.CrOrDr)
                .IsUnicode(false)
                .HasColumnName("crOrDr");
            entity.Property(e => e.CreditLimit)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("creditLimit");
            entity.Property(e => e.CreditPeriod).HasColumnName("creditPeriod");
            entity.Property(e => e.Cst)
                .IsUnicode(false)
                .HasColumnName("cst");
            entity.Property(e => e.Email)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.IsDefault).HasColumnName("isDefault");
            entity.Property(e => e.LedgerName)
                .IsUnicode(false)
                .HasColumnName("ledgerName");
            entity.Property(e => e.MailingName)
                .IsUnicode(false)
                .HasColumnName("mailingName");
            entity.Property(e => e.Mobile)
                .IsUnicode(false)
                .HasColumnName("mobile");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.OpeningBalance)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("openingBalance");
            entity.Property(e => e.Pan)
                .IsUnicode(false)
                .HasColumnName("pan");
            entity.Property(e => e.Phone)
                .IsUnicode(false)
                .HasColumnName("phone");
            entity.Property(e => e.PricinglevelId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("pricinglevelId");
            entity.Property(e => e.RouteId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("routeId");
            entity.Property(e => e.State)
                .IsUnicode(false)
                .HasColumnName("state");
            entity.Property(e => e.Tin)
                .IsUnicode(false)
                .HasColumnName("tin");
        });

        modelBuilder.Entity<TblAccountLedgerTracking>(entity =>
        {
            entity.HasKey(e => e.LedgerId);

            entity.ToTable("tbl_AccountLedger_tracking");

            entity.HasIndex(e => new { e.TimestampBigint, e.UpdateScopeId, e.SyncRowIsTombstone, e.LedgerId }, "tbl_AccountLedger_tracking_timestamp_index");

            entity.Property(e => e.LedgerId)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("ledgerId");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.Timestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("timestamp");
            entity.Property(e => e.TimestampBigint)
                .HasComputedColumnSql("(CONVERT([bigint],[timestamp]))", true)
                .HasColumnName("timestamp_bigint");
            entity.Property(e => e.UpdateScopeId).HasColumnName("update_scope_id");
        });

        modelBuilder.Entity<TblAdditionalCost>(entity =>
        {
            entity.HasKey(e => e.AdditionalCostId).HasName("PK__tbl_Addi__D89F761D24092D7A");

            entity.ToTable("tbl_AdditionalCost");

            entity.HasIndex(e => e.VoucherTypeId, "IX_tbl_AdditionalCost");

            entity.HasIndex(e => e.LedgerId, "IX_tbl_AdditionalCost_1");

            entity.HasIndex(e => new { e.VoucherTypeId, e.LedgerId }, "IX_tbl_AdditionalCost_2");

            entity.Property(e => e.AdditionalCostId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("additionalCostId");
            entity.Property(e => e.Credit)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("credit");
            entity.Property(e => e.Debit)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("debit");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.LedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerId");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
        });

        modelBuilder.Entity<TblAdvancePayment>(entity =>
        {
            entity.HasKey(e => e.AdvancePaymentId).HasName("PK__tbl_Adva__1A7BF2355AB9788F");

            entity.ToTable("tbl_AdvancePayment");

            entity.HasIndex(e => e.EmployeeId, "IX_tbl_AdvancePayment");

            entity.HasIndex(e => e.LedgerId, "IX_tbl_AdvancePayment_1");

            entity.HasIndex(e => e.FinancialYearId, "IX_tbl_AdvancePayment_2");

            entity.HasIndex(e => e.SuffixPrefixId, "IX_tbl_AdvancePayment_3");

            entity.HasIndex(e => e.VoucherTypeId, "IX_tbl_AdvancePayment_4");

            entity.HasIndex(e => new { e.EmployeeId, e.LedgerId, e.Date, e.VoucherTypeId }, "IX_tbl_AdvancePayment_5");

            entity.HasIndex(e => new { e.AdvancePaymentId, e.VoucherTypeId }, "IX_tbl_AdvancePayment_6");

            entity.Property(e => e.AdvancePaymentId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("advancePaymentId");
            entity.Property(e => e.Amount)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("amount");
            entity.Property(e => e.ChequeDate)
                .HasColumnType("datetime")
                .HasColumnName("chequeDate");
            entity.Property(e => e.Chequenumber)
                .IsUnicode(false)
                .HasColumnName("chequenumber");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.EmployeeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("employeeId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FinancialYearId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("financialYearId");
            entity.Property(e => e.InvoiceNo)
                .IsUnicode(false)
                .HasColumnName("invoiceNo");
            entity.Property(e => e.LedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerId");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.SalaryMonth)
                .HasColumnType("datetime")
                .HasColumnName("salaryMonth");
            entity.Property(e => e.SuffixPrefixId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("suffixPrefixId");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
        });

        modelBuilder.Entity<TblArea>(entity =>
        {
            entity.HasKey(e => e.AreaId);

            entity.ToTable("tbl_Area");

            entity.Property(e => e.AreaId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("areaId");
            entity.Property(e => e.AreaName)
                .IsUnicode(false)
                .HasColumnName("areaName");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
        });

        modelBuilder.Entity<TblBankReconciliation>(entity =>
        {
            entity.HasKey(e => e.ReconcileId).HasName("PK__tbl_Bank__66CCE65D34413142");

            entity.ToTable("tbl_BankReconciliation");

            entity.HasIndex(e => e.LedgerPostingId, "IX_tbl_BankReconciliation");

            entity.HasIndex(e => e.StatementDate, "IX_tbl_BankReconciliation_1");

            entity.Property(e => e.ReconcileId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("reconcileId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.LedgerPostingId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerPostingId");
            entity.Property(e => e.StatementDate)
                .HasColumnType("datetime")
                .HasColumnName("statementDate");
        });

        modelBuilder.Entity<TblBarcodeSetting>(entity =>
        {
            entity.HasKey(e => e.BarcodeSettingsId).HasName("PK__tbl_Barc__1F1D76191C5DEA11");

            entity.ToTable("tbl_BarcodeSettings");

            entity.HasIndex(e => e.ShowProductCode, "IX_tbl_BarcodeSettings");

            entity.Property(e => e.BarcodeSettingsId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("barcodeSettingsId");
            entity.Property(e => e.CompanyName)
                .IsUnicode(false)
                .HasColumnName("companyName");
            entity.Property(e => e.Eight)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("eight");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.Five)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("five");
            entity.Property(e => e.Four)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("four");
            entity.Property(e => e.Nine)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nine");
            entity.Property(e => e.One)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("one");
            entity.Property(e => e.Point)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("point");
            entity.Property(e => e.Seven)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("seven");
            entity.Property(e => e.ShowCompanyName).HasColumnName("showCompanyName");
            entity.Property(e => e.ShowMrp).HasColumnName("showMRP");
            entity.Property(e => e.ShowProductCode).HasColumnName("showProductCode");
            entity.Property(e => e.ShowPurchaseRate).HasColumnName("showPurchaseRate");
            entity.Property(e => e.Six)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("six");
            entity.Property(e => e.Three)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("three");
            entity.Property(e => e.Two)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("two");
            entity.Property(e => e.Zero)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("zero");
        });

        modelBuilder.Entity<TblBatch>(entity =>
        {
            entity.HasKey(e => e.BatchId).HasName("PK__tbl_Batc__78CCD773147C05D0");

            entity.ToTable("tbl_Batch");

            entity.Property(e => e.BatchId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("batchId");
            entity.Property(e => e.Barcode)
                .IsUnicode(false)
                .HasColumnName("barcode");
            entity.Property(e => e.BatchNo)
                .IsUnicode(false)
                .HasColumnName("batchNo");
            entity.Property(e => e.ExpiryDate)
                .HasColumnType("datetime")
                .HasColumnName("expiryDate");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.ManufacturingDate)
                .HasColumnType("datetime")
                .HasColumnName("manufacturingDate");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.PartNo)
                .IsUnicode(false)
                .HasColumnName("partNo");
            entity.Property(e => e.ProductId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("productId");
        });

        modelBuilder.Entity<TblBom>(entity =>
        {
            entity.HasKey(e => e.BomId).HasName("PK__tbl_Bom__B6B08848184C96B4");

            entity.ToTable("tbl_Bom");

            entity.HasIndex(e => e.ProductId, "IX_tbl_Bom");

            entity.HasIndex(e => e.RowmaterialId, "IX_tbl_Bom_1");

            entity.HasIndex(e => e.UnitId, "IX_tbl_Bom_2");

            entity.HasIndex(e => new { e.RowmaterialId, e.ProductId }, "IX_tbl_Bom_3");

            entity.Property(e => e.BomId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("bomId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.ProductId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("productId");
            entity.Property(e => e.Quantity)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("quantity");
            entity.Property(e => e.RowmaterialId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("rowmaterialId");
            entity.Property(e => e.UnitId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitId");
        });

        modelBuilder.Entity<TblBonusDeduction>(entity =>
        {
            entity.HasKey(e => e.BonusDeductionId);

            entity.ToTable("tbl_BonusDeduction");

            entity.HasIndex(e => e.EmployeeId, "IX_tbl_BonusDeduction");

            entity.HasIndex(e => new { e.EmployeeId, e.Month }, "IX_tbl_BonusDeduction_1");

            entity.HasIndex(e => new { e.Date, e.Month }, "IX_tbl_BonusDeduction_2");

            entity.HasIndex(e => e.Month, "IX_tbl_BonusDeduction_3");

            entity.Property(e => e.BonusDeductionId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("bonusDeductionId");
            entity.Property(e => e.BonusAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("bonusAmount");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.DeductionAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("deductionAmount");
            entity.Property(e => e.EmployeeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("employeeId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.Month)
                .HasColumnType("datetime")
                .HasColumnName("month");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
        });

        modelBuilder.Entity<TblBrand>(entity =>
        {
            entity.HasKey(e => e.BrandId).HasName("PK__tbl_Bran__06B7729946136164");

            entity.ToTable("tbl_Brand");

            entity.Property(e => e.BrandId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("brandId");
            entity.Property(e => e.BrandName).HasColumnName("brandName");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.Manufacturer).HasColumnName("manufacturer");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
        });

        modelBuilder.Entity<TblBudgetDetail>(entity =>
        {
            entity.HasKey(e => e.BudgetDetailsId).HasName("PK__tbl_Budg__C2BA2365004BBB48");

            entity.ToTable("tbl_BudgetDetails");

            entity.HasIndex(e => e.BudgetMasterId, "IX_tbl_BudgetDetails");

            entity.Property(e => e.BudgetDetailsId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("budgetDetailsId");
            entity.Property(e => e.BudgetMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("budgetMasterId");
            entity.Property(e => e.Credit)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("credit");
            entity.Property(e => e.Debit)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("debit");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.Particular)
                .IsUnicode(false)
                .HasColumnName("particular");
        });

        modelBuilder.Entity<TblBudgetMaster>(entity =>
        {
            entity.HasKey(e => e.BudgetMasterId).HasName("PK__tbl_Budg__060415BC7C7B2A64");

            entity.ToTable("tbl_BudgetMaster");

            entity.HasIndex(e => new { e.FromDate, e.ToDate }, "IX_tbl_BudgetMaster");

            entity.Property(e => e.BudgetMasterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("budgetMasterId");
            entity.Property(e => e.BudgetName)
                .IsUnicode(false)
                .HasColumnName("budgetName");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FromDate)
                .HasColumnType("datetime")
                .HasColumnName("fromDate");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.ToDate)
                .HasColumnType("datetime")
                .HasColumnName("toDate");
            entity.Property(e => e.TotalCr)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("totalCr");
            entity.Property(e => e.TotalDr)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("totalDr");
            entity.Property(e => e.Type)
                .IsUnicode(false)
                .HasColumnName("type");
        });

        modelBuilder.Entity<TblCompany>(entity =>
        {
            entity.HasKey(e => e.CompanyId).HasName("PK__tbl_Comp__AD5459903E723F9C");

            entity.ToTable("tbl_Company");

            entity.HasIndex(e => e.CurrencyId, "IX_tbl_Company");

            entity.Property(e => e.CompanyId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("companyId");
            entity.Property(e => e.Address)
                .IsUnicode(false)
                .HasColumnName("address");
            entity.Property(e => e.BooksBeginingFrom)
                .HasColumnType("datetime")
                .HasColumnName("booksBeginingFrom");
            entity.Property(e => e.CompanyName)
                .IsUnicode(false)
                .HasColumnName("companyName");
            entity.Property(e => e.Country)
                .IsUnicode(false)
                .HasColumnName("country");
            entity.Property(e => e.Cst)
                .IsUnicode(false)
                .HasColumnName("cst");
            entity.Property(e => e.CurrencyId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("currencyId");
            entity.Property(e => e.CurrentDate)
                .HasColumnType("datetime")
                .HasColumnName("currentDate");
            entity.Property(e => e.EmailId)
                .IsUnicode(false)
                .HasColumnName("emailId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FinancialYearFrom)
                .HasColumnType("datetime")
                .HasColumnName("financialYearFrom");
            entity.Property(e => e.Logo)
                .HasColumnType("image")
                .HasColumnName("logo");
            entity.Property(e => e.MailingName)
                .IsUnicode(false)
                .HasColumnName("mailingName");
            entity.Property(e => e.Mobile)
                .IsUnicode(false)
                .HasColumnName("mobile");
            entity.Property(e => e.Pan)
                .IsUnicode(false)
                .HasColumnName("pan");
            entity.Property(e => e.Phone)
                .IsUnicode(false)
                .HasColumnName("phone");
            entity.Property(e => e.Pin)
                .IsUnicode(false)
                .HasColumnName("pin");
            entity.Property(e => e.State)
                .IsUnicode(false)
                .HasColumnName("state");
            entity.Property(e => e.Tin)
                .IsUnicode(false)
                .HasColumnName("tin");
            entity.Property(e => e.Web)
                .IsUnicode(false)
                .HasColumnName("web");
        });

        modelBuilder.Entity<TblCompanyPath>(entity =>
        {
            entity.HasKey(e => e.CompanyId).HasName("PK__tbl_Comp__AD5459903B36AB95");

            entity.ToTable("tbl_CompanyPath");

            entity.HasIndex(e => e.IsDefault, "IX_tbl_CompanyPath");

            entity.Property(e => e.CompanyId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("companyId");
            entity.Property(e => e.CompanyName)
                .IsUnicode(false)
                .HasColumnName("companyName");
            entity.Property(e => e.CompanyPath)
                .IsUnicode(false)
                .HasColumnName("companyPath");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.IsDefault).HasColumnName("isDefault");
        });

        modelBuilder.Entity<TblContraDetail>(entity =>
        {
            entity.HasKey(e => e.ContraDetailsId).HasName("PK__tbl_Cont__4D096E75632F8E56");

            entity.ToTable("tbl_ContraDetails");

            entity.HasIndex(e => e.ContraMasterId, "IX_tbl_ContraDetails");

            entity.HasIndex(e => e.LedgerId, "IX_tbl_ContraDetails_1");

            entity.HasIndex(e => e.ExchangeRateId, "IX_tbl_ContraDetails_2");

            entity.HasIndex(e => new { e.ContraMasterId, e.LedgerId }, "IX_tbl_ContraDetails_3");

            entity.Property(e => e.ContraDetailsId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("contraDetailsId");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("amount");
            entity.Property(e => e.ChequeDate)
                .HasColumnType("datetime")
                .HasColumnName("chequeDate");
            entity.Property(e => e.ChequeNo)
                .IsUnicode(false)
                .HasColumnName("chequeNo");
            entity.Property(e => e.ContraMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("contraMasterId");
            entity.Property(e => e.ExchangeRateId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("exchangeRateId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.LedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerId");
        });

        modelBuilder.Entity<TblContraMaster>(entity =>
        {
            entity.HasKey(e => e.ContraMasterId).HasName("PK__tbl_Cont__0B964F325F5EFD72");

            entity.ToTable("tbl_ContraMaster");

            entity.HasIndex(e => e.SuffixPrefixId, "IX_tbl_ContraMaster");

            entity.HasIndex(e => e.SuffixPrefixId, "IX_tbl_ContraMaster_1");

            entity.HasIndex(e => e.UserId, "IX_tbl_ContraMaster_2");

            entity.HasIndex(e => e.VoucherTypeId, "IX_tbl_ContraMaster_3");

            entity.HasIndex(e => new { e.VoucherTypeId, e.LedgerId }, "IX_tbl_ContraMaster_4");

            entity.Property(e => e.ContraMasterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("contraMasterId");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FinancialYearId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("financialYearId");
            entity.Property(e => e.InvoiceNo)
                .IsUnicode(false)
                .HasColumnName("invoiceNo");
            entity.Property(e => e.LedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerId");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.SuffixPrefixId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("suffixPrefixId");
            entity.Property(e => e.TotalAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("totalAmount");
            entity.Property(e => e.Type)
                .IsUnicode(false)
                .HasColumnName("type");
            entity.Property(e => e.UserId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("userId");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
        });

        modelBuilder.Entity<TblCounter>(entity =>
        {
            entity.HasKey(e => e.CounterId).HasName("PK__tbl_Coun__08A9D0236497E884");

            entity.ToTable("tbl_Counter");

            entity.Property(e => e.CounterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("counterId");
            entity.Property(e => e.CounterName)
                .IsUnicode(false)
                .HasColumnName("counterName");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
        });

        modelBuilder.Entity<TblCreditNoteDetail>(entity =>
        {
            entity.HasKey(e => e.CreditNoteDetailsId).HasName("PK__tbl_Cred__3A8A913E10F65906");

            entity.ToTable("tbl_CreditNoteDetails");

            entity.HasIndex(e => e.CreditNoteMasterId, "IX_tbl_CreditNoteDetails");

            entity.HasIndex(e => e.ExchangeRateId, "IX_tbl_CreditNoteDetails_1");

            entity.HasIndex(e => e.ExchangeRateId, "IX_tbl_CreditNoteDetails_2");

            entity.HasIndex(e => e.LedgerId, "IX_tbl_CreditNoteDetails_3");

            entity.HasIndex(e => new { e.CreditNoteMasterId, e.LedgerId }, "IX_tbl_CreditNoteDetails_4");

            entity.Property(e => e.CreditNoteDetailsId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("creditNoteDetailsId");
            entity.Property(e => e.ChequeDate)
                .HasColumnType("datetime")
                .HasColumnName("chequeDate");
            entity.Property(e => e.ChequeNo)
                .IsUnicode(false)
                .HasColumnName("chequeNo");
            entity.Property(e => e.Credit)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("credit");
            entity.Property(e => e.CreditNoteMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("creditNoteMasterId");
            entity.Property(e => e.Debit)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("debit");
            entity.Property(e => e.ExchangeRateId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("exchangeRateId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.LedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerId");
        });

        modelBuilder.Entity<TblCreditNoteMaster>(entity =>
        {
            entity.HasKey(e => e.CreditNoteMasterId).HasName("PK__tbl_Cred__DDC597880D25C822");

            entity.ToTable("tbl_CreditNoteMaster");

            entity.HasIndex(e => e.FinancialYearId, "IX_tbl_CreditNoteMaster");

            entity.HasIndex(e => e.SuffixPrefixId, "IX_tbl_CreditNoteMaster_1");

            entity.HasIndex(e => e.UserId, "IX_tbl_CreditNoteMaster_2");

            entity.HasIndex(e => e.VoucherTypeId, "IX_tbl_CreditNoteMaster_3");

            entity.Property(e => e.CreditNoteMasterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("creditNoteMasterId");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FinancialYearId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("financialYearId");
            entity.Property(e => e.InvoiceNo)
                .IsUnicode(false)
                .HasColumnName("invoiceNo");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.SuffixPrefixId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("suffixPrefixId");
            entity.Property(e => e.TotalAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("totalAmount");
            entity.Property(e => e.UserId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("userId");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
        });

        modelBuilder.Entity<TblCreditSettlement>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_CreditSettlement");

            entity.Property(e => e.BalanceDue).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.CardNo).HasMaxLength(50);
            entity.Property(e => e.CustomerName).HasMaxLength(50);
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.LedgerId).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.NowPaidCard)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("NowPaid_Card");
            entity.Property(e => e.NowPaidCash)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("NowPaid_Cash");
            entity.Property(e => e.Paymode).HasMaxLength(50);
            entity.Property(e => e.ReceiptVoucherId).HasMaxLength(50);
            entity.Property(e => e.Srno).ValueGeneratedOnAdd();
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.TotalBalance).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.TotalPreviousPaid).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.UserId).HasColumnType("decimal(18, 0)");
        });

        modelBuilder.Entity<TblCurrency>(entity =>
        {
            entity.HasKey(e => e.CurrencyId).HasName("PK__tbl_Curr__DAF0B20A592635D8");

            entity.ToTable("tbl_Currency");

            entity.HasIndex(e => e.IsDefault, "IsDefault");

            entity.Property(e => e.CurrencyId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("currencyId");
            entity.Property(e => e.CurrencyName)
                .IsUnicode(false)
                .HasColumnName("currencyName");
            entity.Property(e => e.CurrencySymbol)
                .IsUnicode(false)
                .HasColumnName("currencySymbol");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.IsDefault).HasColumnName("isDefault");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.NoOfDecimalPlaces).HasColumnName("noOfDecimalPlaces");
            entity.Property(e => e.SubunitName)
                .IsUnicode(false)
                .HasColumnName("subunitName");
        });

        modelBuilder.Entity<TblCurrencyToCopy>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_CurrencyToCopy");

            entity.Property(e => e.CurrencyId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("currencyId");
            entity.Property(e => e.CurrencyName)
                .IsUnicode(false)
                .HasColumnName("currencyName");
            entity.Property(e => e.CurrencySymbol)
                .IsUnicode(false)
                .HasColumnName("currencySymbol");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.IsDefault).HasColumnName("isDefault");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.NoOfDecimalPlaces).HasColumnName("noOfDecimalPlaces");
            entity.Property(e => e.SubunitName)
                .IsUnicode(false)
                .HasColumnName("subunitName");
        });

        modelBuilder.Entity<TblDailyAttendanceDetail>(entity =>
        {
            entity.HasKey(e => e.DailyAttendanceDetailsId).HasName("PK__tbl_Dail__990F6D9656E8E7AB");

            entity.ToTable("tbl_DailyAttendanceDetails");

            entity.HasIndex(e => e.DailyAttendanceMasterId, "dailyAttendanceMasterId");

            entity.HasIndex(e => e.EmployeeId, "employeeId");

            entity.HasIndex(e => new { e.DailyAttendanceMasterId, e.EmployeeId }, "grp1");

            entity.Property(e => e.DailyAttendanceDetailsId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("dailyAttendanceDetailsId");
            entity.Property(e => e.DailyAttendanceMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("dailyAttendanceMasterId");
            entity.Property(e => e.EmployeeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("employeeId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.Status)
                .IsUnicode(false)
                .HasColumnName("status");
        });

        modelBuilder.Entity<TblDailyAttendanceMaster>(entity =>
        {
            entity.HasKey(e => e.DailyAttendanceMasterId).HasName("PK__tbl_Dail__6FC4FA94531856C7");

            entity.ToTable("tbl_DailyAttendanceMaster");

            entity.HasIndex(e => e.Date, "IX_tbl_DailyAttendanceMaster");

            entity.Property(e => e.DailyAttendanceMasterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("dailyAttendanceMasterId");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
        });

        modelBuilder.Entity<TblDailySalaryVoucherDetail>(entity =>
        {
            entity.HasKey(e => e.DailySalaryVoucherDetailsId).HasName("PK__tbl_Dail__031176C94F47C5E3");

            entity.ToTable("tbl_DailySalaryVoucherDetails");

            entity.HasIndex(e => e.DailySalaryVoucherMasterId, "IX_tbl_DailySalaryVoucherDetails");

            entity.HasIndex(e => e.EmployeeId, "IX_tbl_DailySalaryVoucherDetails_1");

            entity.HasIndex(e => new { e.DailySalaryVoucherMasterId, e.EmployeeId }, "IX_tbl_DailySalaryVoucherDetails_2");

            entity.Property(e => e.DailySalaryVoucherDetailsId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("dailySalaryVoucherDetailsId");
            entity.Property(e => e.DailySalaryVoucherMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("dailySalaryVoucherMasterId");
            entity.Property(e => e.EmployeeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("employeeId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.Status)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.Wage)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("wage");
        });

        modelBuilder.Entity<TblDailySalaryVoucherMaster>(entity =>
        {
            entity.HasKey(e => e.DailySalaryVoucherMasterId);

            entity.ToTable("tbl_DailySalaryVoucherMaster");

            entity.HasIndex(e => e.FinancialYearId, "financialYearId");

            entity.HasIndex(e => new { e.LedgerId, e.VoucherTypeId }, "grp1");

            entity.HasIndex(e => e.LedgerId, "ledgerId");

            entity.HasIndex(e => e.SuffixPrefixId, "suffixPrefixId");

            entity.HasIndex(e => e.VoucherTypeId, "voucherTypeId");

            entity.Property(e => e.DailySalaryVoucherMasterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("dailySalaryVoucherMasterId");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FinancialYearId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("financialYearId");
            entity.Property(e => e.InvoiceNo)
                .IsUnicode(false)
                .HasColumnName("invoiceNo");
            entity.Property(e => e.LedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerId");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.SalaryDate)
                .HasColumnType("datetime")
                .HasColumnName("salaryDate");
            entity.Property(e => e.SuffixPrefixId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("suffixPrefixId");
            entity.Property(e => e.TotalAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("totalAmount");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
        });

        modelBuilder.Entity<TblDebitNoteDetail>(entity =>
        {
            entity.HasKey(e => e.DebitNoteDetailsId).HasName("PK__tbl_Debi__42220582469E3CA0");

            entity.ToTable("tbl_DebitNoteDetails");

            entity.HasIndex(e => e.DebitNoteMasterId, "IX_tbl_DebitNoteDetails");

            entity.HasIndex(e => e.LedgerId, "IX_tbl_DebitNoteDetails_1");

            entity.HasIndex(e => e.ExchangeRateId, "IX_tbl_DebitNoteDetails_2");

            entity.HasIndex(e => new { e.DebitNoteMasterId, e.LedgerId }, "IX_tbl_DebitNoteDetails_3");

            entity.Property(e => e.DebitNoteDetailsId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("debitNoteDetailsId");
            entity.Property(e => e.ChequeDate)
                .HasColumnType("datetime")
                .HasColumnName("chequeDate");
            entity.Property(e => e.ChequeNo)
                .IsUnicode(false)
                .HasColumnName("chequeNo");
            entity.Property(e => e.Credit)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("credit");
            entity.Property(e => e.Debit)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("debit");
            entity.Property(e => e.DebitNoteMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("debitNoteMasterId");
            entity.Property(e => e.ExchangeRateId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("exchangeRateId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.LedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerId");
        });

        modelBuilder.Entity<TblDebitNoteMaster>(entity =>
        {
            entity.HasKey(e => e.DebitNoteMasterId).HasName("PK__tbl_Debi__1229ABA914C6E9EA");

            entity.ToTable("tbl_DebitNoteMaster");

            entity.HasIndex(e => e.FinancialYearId, "IX_tbl_DebitNoteMaster");

            entity.HasIndex(e => e.SuffixPrefixId, "IX_tbl_DebitNoteMaster_1");

            entity.HasIndex(e => e.UserId, "IX_tbl_DebitNoteMaster_2");

            entity.HasIndex(e => e.VoucherTypeId, "IX_tbl_DebitNoteMaster_3");

            entity.Property(e => e.DebitNoteMasterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("debitNoteMasterId");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FinancialYearId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("financialYearId");
            entity.Property(e => e.InvoiceNo)
                .IsUnicode(false)
                .HasColumnName("invoiceNo");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.SuffixPrefixId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("suffixPrefixId");
            entity.Property(e => e.TotalAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("totalAmount");
            entity.Property(e => e.UserId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("userId");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
        });

        modelBuilder.Entity<TblDeliveryDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_DeliveryDetails");

            entity.Property(e => e.DispatchDateTime).HasColumnType("datetime");
            entity.Property(e => e.DispatchId).HasMaxLength(50);
            entity.Property(e => e.EmployeeId).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.EmployeeName).HasMaxLength(50);
            entity.Property(e => e.PaymentCollect).HasDefaultValueSql("((0))");
            entity.Property(e => e.PaymentCollectDate).HasColumnType("datetime");
            entity.Property(e => e.SalesInvoiceNo).HasMaxLength(50);
            entity.Property(e => e.SalesMasterId).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.SalesOrderId).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.SalesOrderNo).HasMaxLength(50);
            entity.Property(e => e.Srno).ValueGeneratedOnAdd();
            entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.VeichcleNo).HasMaxLength(50);
        });

        modelBuilder.Entity<TblDeliveryNoteDetail>(entity =>
        {
            entity.HasKey(e => e.DeliveryNoteDetailsId).HasName("PK__tbl_Deli__A9A4649E51CFF82A");

            entity.ToTable("tbl_DeliveryNoteDetails");

            entity.HasIndex(e => e.DeliveryNoteMasterId, "IX_tbl_DeliveryNoteDetails");

            entity.HasIndex(e => e.OrderDetails1Id, "IX_tbl_DeliveryNoteDetails_1");

            entity.HasIndex(e => e.ProductId, "IX_tbl_DeliveryNoteDetails_2");

            entity.HasIndex(e => e.UnitId, "IX_tbl_DeliveryNoteDetails_3");

            entity.HasIndex(e => e.UnitConversionId, "IX_tbl_DeliveryNoteDetails_4");

            entity.HasIndex(e => e.QuotationDetails1Id, "IX_tbl_DeliveryNoteDetails_5");

            entity.HasIndex(e => e.BatchId, "IX_tbl_DeliveryNoteDetails_6");

            entity.HasIndex(e => e.GodownId, "IX_tbl_DeliveryNoteDetails_7");

            entity.HasIndex(e => e.RackId, "IX_tbl_DeliveryNoteDetails_8");

            entity.Property(e => e.DeliveryNoteDetailsId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("deliveryNoteDetailsId");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("amount");
            entity.Property(e => e.BatchId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("batchId");
            entity.Property(e => e.DeliveryNoteMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("deliveryNoteMasterId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.GodownId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("godownId");
            entity.Property(e => e.OrderDetails1Id)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("orderDetails1Id");
            entity.Property(e => e.ProductId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("productId");
            entity.Property(e => e.Qty)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("qty");
            entity.Property(e => e.QuotationDetails1Id)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("quotationDetails1Id");
            entity.Property(e => e.RackId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("rackId");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("rate");
            entity.Property(e => e.SlNo).HasColumnName("slNo");
            entity.Property(e => e.UnitConversionId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitConversionId");
            entity.Property(e => e.UnitId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitId");
        });

        modelBuilder.Entity<TblDeliveryNoteMaster>(entity =>
        {
            entity.HasKey(e => e.DeliveryNoteMasterId).HasName("PK__tbl_Deli__72FF880F4DFF6746");

            entity.ToTable("tbl_DeliveryNoteMaster");

            entity.HasIndex(e => e.EmployeeId, "IX_tbl_DeliveryNoteMaster");

            entity.HasIndex(e => e.ExchangeRateId, "IX_tbl_DeliveryNoteMaster_1");

            entity.HasIndex(e => e.Date, "IX_tbl_DeliveryNoteMaster_10");

            entity.HasIndex(e => e.DeliveryNoteMasterId, "IX_tbl_DeliveryNoteMaster_11");

            entity.HasIndex(e => e.FinancialYearId, "IX_tbl_DeliveryNoteMaster_2");

            entity.HasIndex(e => e.LedgerId, "IX_tbl_DeliveryNoteMaster_3");

            entity.HasIndex(e => e.OrderMasterId, "IX_tbl_DeliveryNoteMaster_4");

            entity.HasIndex(e => e.PricinglevelId, "IX_tbl_DeliveryNoteMaster_5");

            entity.HasIndex(e => e.QuotationMasterId, "IX_tbl_DeliveryNoteMaster_6");

            entity.HasIndex(e => e.SuffixPrefixId, "IX_tbl_DeliveryNoteMaster_7");

            entity.HasIndex(e => e.UserId, "IX_tbl_DeliveryNoteMaster_8");

            entity.HasIndex(e => e.VoucherTypeId, "IX_tbl_DeliveryNoteMaster_9");

            entity.Property(e => e.DeliveryNoteMasterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("deliveryNoteMasterId");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.EmployeeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("employeeId");
            entity.Property(e => e.ExchangeRateId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("exchangeRateId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FinancialYearId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("financialYearId");
            entity.Property(e => e.InvoiceNo)
                .IsUnicode(false)
                .HasColumnName("invoiceNo");
            entity.Property(e => e.LedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerId");
            entity.Property(e => e.LrNo)
                .IsUnicode(false)
                .HasColumnName("lrNo");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.OrderMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("orderMasterId");
            entity.Property(e => e.PricinglevelId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("pricinglevelId");
            entity.Property(e => e.QuotationMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("quotationMasterId");
            entity.Property(e => e.SuffixPrefixId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("suffixPrefixId");
            entity.Property(e => e.TotalAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("totalAmount");
            entity.Property(e => e.TransportationCompany)
                .IsUnicode(false)
                .HasColumnName("transportationCompany");
            entity.Property(e => e.UserId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("userId");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
        });

        modelBuilder.Entity<TblDesignation>(entity =>
        {
            entity.HasKey(e => e.DesignationId).HasName("PK__tbl_Desi__197CE32A30C33EC3");

            entity.ToTable("tbl_Designation");

            entity.HasIndex(e => e.AdvanceAmount, "IX_tbl_Designation");

            entity.Property(e => e.DesignationId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("designationId");
            entity.Property(e => e.AdvanceAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("advanceAmount");
            entity.Property(e => e.DesignationName)
                .IsUnicode(false)
                .HasColumnName("designationName");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.LeaveDays)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("leaveDays");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
        });

        modelBuilder.Entity<TblDetail>(entity =>
        {
            entity.HasKey(e => e.DetailsId);

            entity.ToTable("tbl_Details");

            entity.HasIndex(e => e.MasterId, "IX_tbl_Details");

            entity.Property(e => e.DetailsId).HasColumnName("detailsId");
            entity.Property(e => e.Align)
                .IsUnicode(false)
                .HasColumnName("align");
            entity.Property(e => e.Columns).HasColumnName("columns");
            entity.Property(e => e.Dbf)
                .IsUnicode(false)
                .HasColumnName("dbf");
            entity.Property(e => e.DorH).IsUnicode(false);
            entity.Property(e => e.ExtraFieldName)
                .IsUnicode(false)
                .HasColumnName("extraFieldName");
            entity.Property(e => e.FieldsForExtra)
                .IsUnicode(false)
                .HasColumnName("fieldsForExtra");
            entity.Property(e => e.FooterRepeatAll)
                .IsUnicode(false)
                .HasColumnName("footerRepeatAll");
            entity.Property(e => e.MasterId).HasColumnName("masterId");
            entity.Property(e => e.Name)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Repeat)
                .IsUnicode(false)
                .HasColumnName("repeat");
            entity.Property(e => e.RepeatAll)
                .IsUnicode(false)
                .HasColumnName("repeatAll");
            entity.Property(e => e.Row).HasColumnName("row");
            entity.Property(e => e.Text)
                .IsUnicode(false)
                .HasColumnName("text");
            entity.Property(e => e.TextWrap)
                .IsUnicode(false)
                .HasColumnName("textWrap");
            entity.Property(e => e.Width).HasColumnName("width");
            entity.Property(e => e.WrapLineCount).HasColumnName("wrapLineCount");
        });

        modelBuilder.Entity<TblDetailsCopy>(entity =>
        {
            entity.HasKey(e => e.DetailsId);

            entity.ToTable("tbl_DetailsCopy");

            entity.HasIndex(e => e.MasterId, "IX_tbl_DetailsCopy");

            entity.Property(e => e.DetailsId).HasColumnName("detailsId");
            entity.Property(e => e.Align)
                .IsUnicode(false)
                .HasColumnName("align");
            entity.Property(e => e.Columns).HasColumnName("columns");
            entity.Property(e => e.Dbf)
                .IsUnicode(false)
                .HasColumnName("dbf");
            entity.Property(e => e.DorH).IsUnicode(false);
            entity.Property(e => e.ExtraFieldName)
                .IsUnicode(false)
                .HasColumnName("extraFieldName");
            entity.Property(e => e.FieldsForExtra)
                .IsUnicode(false)
                .HasColumnName("fieldsForExtra");
            entity.Property(e => e.FooterRepeatAll)
                .IsUnicode(false)
                .HasColumnName("footerRepeatAll");
            entity.Property(e => e.MasterId).HasColumnName("masterId");
            entity.Property(e => e.Name)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Repeat)
                .IsUnicode(false)
                .HasColumnName("repeat");
            entity.Property(e => e.RepeatAll)
                .IsUnicode(false)
                .HasColumnName("repeatAll");
            entity.Property(e => e.Row).HasColumnName("row");
            entity.Property(e => e.Text)
                .IsUnicode(false)
                .HasColumnName("text");
            entity.Property(e => e.TextWrap)
                .IsUnicode(false)
                .HasColumnName("textWrap");
            entity.Property(e => e.Width).HasColumnName("width");
            entity.Property(e => e.WrapLineCount).HasColumnName("wrapLineCount");
        });

        modelBuilder.Entity<TblDiscount>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_Discount");

            entity.Property(e => e.Automatically).HasMaxLength(50);
            entity.Property(e => e.DiscountAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DiscountName).HasMaxLength(50);
            entity.Property(e => e.DiscountOn).HasMaxLength(50);
            entity.Property(e => e.DiscountPercentage).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DiscountType).HasMaxLength(50);
            entity.Property(e => e.EndDate).HasColumnType("date");
            entity.Property(e => e.FixedOrNot)
                .HasMaxLength(50)
                .HasColumnName("Fixed_orNot");
            entity.Property(e => e.MaxAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MinAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OfferOnpayMode).HasMaxLength(50);
            entity.Property(e => e.PromoCode).HasMaxLength(50);
            entity.Property(e => e.SalesQty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Srno).ValueGeneratedOnAdd();
            entity.Property(e => e.StartDate).HasColumnType("date");
            entity.Property(e => e.Status).HasMaxLength(50);
        });

        modelBuilder.Entity<TblDocumentManage>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("tbl_DocumentManage");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.DeleteBy)
                .HasMaxLength(50)
                .HasColumnName("deleteBy");
            entity.Property(e => e.DeleteDt)
                .HasColumnType("datetime")
                .HasColumnName("deleteDt");
            entity.Property(e => e.MobileNo)
                .HasMaxLength(50)
                .HasColumnName("mobileNo");
            entity.Property(e => e.ProductId).HasColumnName("productId");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
            entity.Property(e => e.UploadBy)
                .HasMaxLength(50)
                .HasColumnName("uploadBy");
            entity.Property(e => e.UploadDt)
                .HasColumnType("datetime")
                .HasColumnName("uploadDt");
        });

        modelBuilder.Entity<TblEmployee>(entity =>
        {
            entity.HasKey(e => e.EmployeeId).HasName("PK__tbl_Empl__C134C9C125518C17");

            entity.ToTable("tbl_Employee");

            entity.HasIndex(e => e.DefaultPackageId, "IX_tbl_Employee");

            entity.HasIndex(e => e.DesignationId, "IX_tbl_Employee_1");

            entity.HasIndex(e => new { e.DesignationId, e.DefaultPackageId, e.IsActive, e.EmployeeId }, "IX_tbl_Employee_2");

            entity.Property(e => e.EmployeeId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("employeeId");
            entity.Property(e => e.Address)
                .IsUnicode(false)
                .HasColumnName("address");
            entity.Property(e => e.BankAccountNumber)
                .IsUnicode(false)
                .HasColumnName("bankAccountNumber");
            entity.Property(e => e.BankName)
                .IsUnicode(false)
                .HasColumnName("bankName");
            entity.Property(e => e.BloodGroup)
                .IsUnicode(false)
                .HasColumnName("bloodGroup");
            entity.Property(e => e.BranchCode)
                .IsUnicode(false)
                .HasColumnName("branchCode");
            entity.Property(e => e.BranchName)
                .IsUnicode(false)
                .HasColumnName("branchName");
            entity.Property(e => e.DailyWage)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("dailyWage");
            entity.Property(e => e.DefaultPackageId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("defaultPackageId");
            entity.Property(e => e.DesignationId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("designationId");
            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("dob");
            entity.Property(e => e.Email)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.EmployeeCode)
                .IsUnicode(false)
                .HasColumnName("employeeCode");
            entity.Property(e => e.EmployeeName)
                .IsUnicode(false)
                .HasColumnName("employeeName");
            entity.Property(e => e.EsiNumber)
                .IsUnicode(false)
                .HasColumnName("esiNumber");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.Gender)
                .IsUnicode(false)
                .HasColumnName("gender");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.JoiningDate)
                .HasColumnType("datetime")
                .HasColumnName("joiningDate");
            entity.Property(e => e.LabourCardExpiryDate)
                .HasColumnType("datetime")
                .HasColumnName("labourCardExpiryDate");
            entity.Property(e => e.LabourCardNumber)
                .IsUnicode(false)
                .HasColumnName("labourCardNumber");
            entity.Property(e => e.MaritalStatus)
                .IsUnicode(false)
                .HasColumnName("maritalStatus");
            entity.Property(e => e.MobileNumber)
                .IsUnicode(false)
                .HasColumnName("mobileNumber");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.PanNumber)
                .IsUnicode(false)
                .HasColumnName("panNumber");
            entity.Property(e => e.PassportExpiryDate)
                .HasColumnType("datetime")
                .HasColumnName("passportExpiryDate");
            entity.Property(e => e.PassportNo)
                .IsUnicode(false)
                .HasColumnName("passportNo");
            entity.Property(e => e.PfNumber)
                .IsUnicode(false)
                .HasColumnName("pfNumber");
            entity.Property(e => e.PhoneNumber)
                .IsUnicode(false)
                .HasColumnName("phoneNumber");
            entity.Property(e => e.Qualification)
                .IsUnicode(false)
                .HasColumnName("qualification");
            entity.Property(e => e.SalaryType)
                .IsUnicode(false)
                .HasColumnName("salaryType");
            entity.Property(e => e.TerminationDate)
                .HasColumnType("datetime")
                .HasColumnName("terminationDate");
            entity.Property(e => e.VisaExpiryDate)
                .HasColumnType("datetime")
                .HasColumnName("visaExpiryDate");
            entity.Property(e => e.VisaNumber)
                .IsUnicode(false)
                .HasColumnName("visaNumber");
        });

        modelBuilder.Entity<TblExchangeRate>(entity =>
        {
            entity.HasKey(e => e.ExchangeRateId).HasName("PK__tbl_Exch__DE88B8415CF6C6BC");

            entity.ToTable("tbl_ExchangeRate");

            entity.HasIndex(e => e.CurrencyId, "IX_tbl_ExchangeRate");

            entity.HasIndex(e => new { e.CurrencyId, e.Date }, "IX_tbl_ExchangeRate_1");

            entity.Property(e => e.ExchangeRateId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("exchangeRateId");
            entity.Property(e => e.CurrencyId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("currencyId");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("rate");
        });

        modelBuilder.Entity<TblExtraOption>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_ExtraOption");

            entity.Property(e => e.ExtraOption).HasMaxLength(50);
            entity.Property(e => e.Price).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Srno).ValueGeneratedOnAdd();
            entity.Property(e => e.Status).HasMaxLength(50);
        });

        modelBuilder.Entity<TblField>(entity =>
        {
            entity.HasKey(e => e.FieldId);

            entity.ToTable("tbl_Fields");

            entity.HasIndex(e => e.FormId, "IX_tbl_Fields");

            entity.Property(e => e.FieldId).HasColumnName("fieldId");
            entity.Property(e => e.FieldName)
                .IsUnicode(false)
                .HasColumnName("fieldName");
            entity.Property(e => e.FormId).HasColumnName("formId");
        });

        modelBuilder.Entity<TblFieldsCopy>(entity =>
        {
            entity.HasKey(e => e.FieldId);

            entity.ToTable("tbl_FieldsCopy");

            entity.HasIndex(e => e.FormId, "IX_tbl_FieldsCopy");

            entity.Property(e => e.FieldId).HasColumnName("fieldId");
            entity.Property(e => e.FieldName)
                .IsUnicode(false)
                .HasColumnName("fieldName");
            entity.Property(e => e.FormId).HasColumnName("formId");
        });

        modelBuilder.Entity<TblFinancialYear>(entity =>
        {
            entity.HasKey(e => e.FinancialYearId).HasName("PK__tbl_Fina__FE30A41137661AB1");

            entity.ToTable("tbl_FinancialYear");

            entity.HasIndex(e => new { e.FromDate, e.ToDate }, "IX_tbl_FinancialYear");

            entity.Property(e => e.FinancialYearId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("financialYearId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FromDate)
                .HasColumnType("datetime")
                .HasColumnName("fromDate");
            entity.Property(e => e.ToDate)
                .HasColumnType("datetime")
                .HasColumnName("toDate");
        });

        modelBuilder.Entity<TblForm>(entity =>
        {
            entity.HasKey(e => e.FormId);

            entity.ToTable("tbl_Form");

            entity.Property(e => e.FormId).HasColumnName("formId");
            entity.Property(e => e.FormName)
                .IsUnicode(false)
                .HasColumnName("formName");
        });

        modelBuilder.Entity<TblFormCopy>(entity =>
        {
            entity.HasKey(e => e.FormId);

            entity.ToTable("tbl_FormCopy");

            entity.Property(e => e.FormId).HasColumnName("formId");
            entity.Property(e => e.FormName)
                .IsUnicode(false)
                .HasColumnName("formName");
        });

        modelBuilder.Entity<TblGodown>(entity =>
        {
            entity.HasKey(e => e.GodownId).HasName("PK__tbl_Godo__14F1AFAB51851410");

            entity.ToTable("tbl_Godown");

            entity.Property(e => e.GodownId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("godownId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.GodownName)
                .IsUnicode(false)
                .HasColumnName("godownName");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
        });

        modelBuilder.Entity<TblHoliday>(entity =>
        {
            entity.HasKey(e => e.HolidayId).HasName("PK__tbl_Holi__EB855CEF29221CFB");

            entity.ToTable("tbl_Holiday");

            entity.Property(e => e.HolidayId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("holidayId");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.HolidayName)
                .IsUnicode(false)
                .HasColumnName("holidayName");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
        });

        modelBuilder.Entity<TblJournalDetail>(entity =>
        {
            entity.HasKey(e => e.JournalDetailsId).HasName("PK__tbl_Jour__3C76D92F764262CA");

            entity.ToTable("tbl_JournalDetails");

            entity.HasIndex(e => e.ExchangeRateId, "IX_tbl_JournalDetails");

            entity.HasIndex(e => e.JournalMasterId, "IX_tbl_JournalDetails_1");

            entity.HasIndex(e => e.LedgerId, "IX_tbl_JournalDetails_2");

            entity.HasIndex(e => new { e.LedgerId, e.ExchangeRateId, e.JournalMasterId }, "IX_tbl_JournalDetails_3");

            entity.Property(e => e.JournalDetailsId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("journalDetailsId");
            entity.Property(e => e.ChequeDate)
                .HasColumnType("datetime")
                .HasColumnName("chequeDate");
            entity.Property(e => e.ChequeNo)
                .IsUnicode(false)
                .HasColumnName("chequeNo");
            entity.Property(e => e.Credit)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("credit");
            entity.Property(e => e.Debit)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("debit");
            entity.Property(e => e.ExchangeRateId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("exchangeRateId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.JournalMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("journalMasterId");
            entity.Property(e => e.LedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerId");
        });

        modelBuilder.Entity<TblJournalMaster>(entity =>
        {
            entity.HasKey(e => e.JournalMasterId).HasName("PK__tbl_Jour__90D22FBE7271D1E6");

            entity.ToTable("tbl_JournalMaster");

            entity.HasIndex(e => e.FinancialYearId, "IX_tbl_JournalMaster");

            entity.HasIndex(e => e.SuffixPrefixId, "IX_tbl_JournalMaster_1");

            entity.HasIndex(e => e.UserId, "IX_tbl_JournalMaster_2");

            entity.HasIndex(e => e.VoucherTypeId, "IX_tbl_JournalMaster_3");

            entity.Property(e => e.JournalMasterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("journalMasterId");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FinancialYearId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("financialYearId");
            entity.Property(e => e.InvoiceNo)
                .IsUnicode(false)
                .HasColumnName("invoiceNo");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.SuffixPrefixId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("suffixPrefixId");
            entity.Property(e => e.TotalAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("totalAmount");
            entity.Property(e => e.UserId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("userId");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
        });

        modelBuilder.Entity<TblKot>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_KOT");

            entity.Property(e => e.Customername).HasMaxLength(50);
            entity.Property(e => e.Extra1).HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .HasMaxLength(50)
                .HasColumnName("extra2");
            entity.Property(e => e.Extra3).HasColumnName("extra3");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.KotDate)
                .HasColumnType("date")
                .HasColumnName("kotDate");
            entity.Property(e => e.Kotno)
                .HasMaxLength(50)
                .HasColumnName("KOTNo");
            entity.Property(e => e.NowQty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OrderType).HasMaxLength(50);
            entity.Property(e => e.ProductId)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("productId");
            entity.Property(e => e.ProductName).HasColumnName("productName");
            entity.Property(e => e.Quantity)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("quantity");
            entity.Property(e => e.SalesOrderNo).HasMaxLength(50);
            entity.Property(e => e.Srno).ValueGeneratedOnAdd();
            entity.Property(e => e.TableNo).HasMaxLength(50);
        });

        modelBuilder.Entity<TblKotPrinterSetting>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_KOT_PrinterSetting");

            entity.Property(e => e.DeviceId)
                .HasMaxLength(50)
                .HasColumnName("DeviceID");
            entity.Property(e => e.PortNo).HasMaxLength(50);
            entity.Property(e => e.PrintFor).HasMaxLength(50);
            entity.Property(e => e.PrinterType).HasMaxLength(50);
            entity.Property(e => e.Srno).ValueGeneratedOnAdd();
            entity.Property(e => e.Status).HasMaxLength(50);
        });

        modelBuilder.Entity<TblLedgerPosting>(entity =>
        {
            entity.HasKey(e => e.LedgerPostingId).HasName("PK__tbl_Ledg__730FE2D769FBBC1F");

            entity.ToTable("tbl_LedgerPosting");

            entity.Property(e => e.LedgerPostingId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerPostingId");
            entity.Property(e => e.ChequeDate)
                .HasColumnType("datetime")
                .HasColumnName("chequeDate");
            entity.Property(e => e.ChequeNo)
                .IsUnicode(false)
                .HasColumnName("chequeNo");
            entity.Property(e => e.Credit)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("credit");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Debit)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("debit");
            entity.Property(e => e.DetailsId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("detailsId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.InvoiceNo)
                .IsUnicode(false)
                .HasColumnName("invoiceNo");
            entity.Property(e => e.LedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerId");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
            entity.Property(e => e.YearId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("yearId");
        });

        modelBuilder.Entity<TblMaster>(entity =>
        {
            entity.HasKey(e => e.MasterId);

            entity.ToTable("tbl_Master");

            entity.Property(e => e.MasterId).HasColumnName("masterId");
            entity.Property(e => e.BlankLneForFooter).HasColumnName("blankLneForFooter");
            entity.Property(e => e.Condensed)
                .IsUnicode(false)
                .HasColumnName("condensed");
            entity.Property(e => e.FooterLocation)
                .IsUnicode(false)
                .HasColumnName("footerLocation");
            entity.Property(e => e.FormName).HasColumnName("formName");
            entity.Property(e => e.IsTwoLineForDetails).HasColumnName("isTwoLineForDetails");
            entity.Property(e => e.IsTwoLineForHedder).HasColumnName("isTwoLineForHedder");
            entity.Property(e => e.LineCountAfterPrint).HasColumnName("lineCountAfterPrint");
            entity.Property(e => e.LineCountBetweenTwo).HasColumnName("lineCountBetweenTwo");
            entity.Property(e => e.PageSize1).HasColumnName("pageSize1");
            entity.Property(e => e.PageSizeOther).HasColumnName("pageSizeOther");
            entity.Property(e => e.Pitch)
                .IsUnicode(false)
                .HasColumnName("pitch");
        });

        modelBuilder.Entity<TblMasterCopy>(entity =>
        {
            entity.HasKey(e => e.MasterId);

            entity.ToTable("tbl_MasterCopy");

            entity.Property(e => e.MasterId)
                .ValueGeneratedNever()
                .HasColumnName("masterId");
            entity.Property(e => e.BlankLneForFooter).HasColumnName("blankLneForFooter");
            entity.Property(e => e.Condensed)
                .IsUnicode(false)
                .HasColumnName("condensed");
            entity.Property(e => e.FooterLocation)
                .IsUnicode(false)
                .HasColumnName("footerLocation");
            entity.Property(e => e.FormName).HasColumnName("formName");
            entity.Property(e => e.IsTwoLineForDetails).HasColumnName("isTwoLineForDetails");
            entity.Property(e => e.IsTwoLineForHedder).HasColumnName("isTwoLineForHedder");
            entity.Property(e => e.LineCountAfterPrint).HasColumnName("lineCountAfterPrint");
            entity.Property(e => e.LineCountBetweenTwo).HasColumnName("lineCountBetweenTwo");
            entity.Property(e => e.PageSize1).HasColumnName("pageSize1");
            entity.Property(e => e.PageSizeOther).HasColumnName("pageSizeOther");
            entity.Property(e => e.Pitch)
                .IsUnicode(false)
                .HasColumnName("pitch");
        });

        modelBuilder.Entity<TblMaterialIssueDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_MaterialIssueDetails");

            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amount");
            entity.Property(e => e.BatchId).HasColumnName("batchId");
            entity.Property(e => e.Extra1)
                .HasMaxLength(50)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .HasMaxLength(50)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.GodownId).HasColumnName("godownId");
            entity.Property(e => e.IssueVoucherNo).HasColumnName("Issue_voucher_No");
            entity.Property(e => e.ProductId).HasColumnName("productId");
            entity.Property(e => e.Qty)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("qty");
            entity.Property(e => e.RackId).HasColumnName("rackId");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("rate");
            entity.Property(e => e.Slno).HasColumnName("slno");
            entity.Property(e => e.Srno).ValueGeneratedOnAdd();
            entity.Property(e => e.UnitConversionId).HasColumnName("unitConversionId");
            entity.Property(e => e.UnitId).HasColumnName("unitId");
        });

        modelBuilder.Entity<TblMaterialIsuue>(entity =>
        {
            entity.HasKey(e => e.IssueVoucherNo);

            entity.ToTable("tbl_MaterialIsuue");

            entity.Property(e => e.IssueVoucherNo)
                .ValueGeneratedNever()
                .HasColumnName("Issue_voucher_No");
            entity.Property(e => e.Extra1)
                .HasMaxLength(50)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .HasMaxLength(50)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("date")
                .HasColumnName("extraDate");
            entity.Property(e => e.FinancialYearId).HasColumnName("financialYearId");
            entity.Property(e => e.GodownId).HasColumnName("godownId");
            entity.Property(e => e.IssueDate)
                .HasColumnType("date")
                .HasColumnName("Issue_Date");
            entity.Property(e => e.Srno).ValueGeneratedOnAdd();
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.TotalStockValue).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UserId).HasColumnName("userId");
        });

        modelBuilder.Entity<TblMaterialIsuueMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_MaterialIsuueMaster");

            entity.Property(e => e.Extra1)
                .HasMaxLength(50)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .HasMaxLength(50)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("date")
                .HasColumnName("extraDate");
            entity.Property(e => e.FinancialYearId).HasColumnName("financialYearId");
            entity.Property(e => e.GodownId).HasColumnName("godownId");
            entity.Property(e => e.IssueDate)
                .HasColumnType("date")
                .HasColumnName("Issue_Date");
            entity.Property(e => e.IssueVoucherNo).HasColumnName("Issue_voucher_No");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.TotalStockValue).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UserId).HasColumnName("userId");
        });

        modelBuilder.Entity<TblMaterialReceiptDetail>(entity =>
        {
            entity.HasKey(e => e.MaterialReceiptDetailsId).HasName("PK__tbl_Mate__320D49ED77F5A112");

            entity.ToTable("tbl_MaterialReceiptDetails");

            entity.HasIndex(e => e.BatchId, "IX_tbl_MaterialReceiptDetails");

            entity.HasIndex(e => e.GodownId, "IX_tbl_MaterialReceiptDetails_1");

            entity.HasIndex(e => e.MaterialReceiptMasterId, "IX_tbl_MaterialReceiptDetails_2");

            entity.HasIndex(e => e.OrderDetailsId, "IX_tbl_MaterialReceiptDetails_3");

            entity.HasIndex(e => e.ProductId, "IX_tbl_MaterialReceiptDetails_4");

            entity.HasIndex(e => e.RackId, "IX_tbl_MaterialReceiptDetails_5");

            entity.HasIndex(e => e.UnitConversionId, "IX_tbl_MaterialReceiptDetails_6");

            entity.HasIndex(e => e.UnitId, "IX_tbl_MaterialReceiptDetails_7");

            entity.HasIndex(e => new { e.BatchId, e.ProductId }, "IX_tbl_MaterialReceiptDetails_8");

            entity.HasIndex(e => new { e.ProductId, e.GodownId, e.RackId, e.Qty }, "IX_tbl_MaterialReceiptDetails_9");

            entity.Property(e => e.MaterialReceiptDetailsId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("materialReceiptDetailsId");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("amount");
            entity.Property(e => e.BatchId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("batchId");
            entity.Property(e => e.Exta2)
                .IsUnicode(false)
                .HasColumnName("exta2");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.GodownId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("godownId");
            entity.Property(e => e.MaterialReceiptMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("materialReceiptMasterId");
            entity.Property(e => e.OrderDetailsId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("orderDetailsId");
            entity.Property(e => e.ProductId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("productId");
            entity.Property(e => e.Qty)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("qty");
            entity.Property(e => e.RackId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("rackId");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("rate");
            entity.Property(e => e.Slno).HasColumnName("slno");
            entity.Property(e => e.UnitConversionId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitConversionId");
            entity.Property(e => e.UnitId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitId");
        });

        modelBuilder.Entity<TblMaterialReceiptMaster>(entity =>
        {
            entity.HasKey(e => e.MaterialReceiptMasterId).HasName("PK__tbl_Mate__47E4E4697425102E");

            entity.ToTable("tbl_MaterialReceiptMaster");

            entity.HasIndex(e => e.ExchangeRateId, "IX_tbl_MaterialReceiptMaster");

            entity.HasIndex(e => e.FinancialYearId, "IX_tbl_MaterialReceiptMaster_1");

            entity.HasIndex(e => e.LedgerId, "IX_tbl_MaterialReceiptMaster_2");

            entity.HasIndex(e => e.OrderMasterId, "IX_tbl_MaterialReceiptMaster_3");

            entity.HasIndex(e => e.SuffixPrefixId, "IX_tbl_MaterialReceiptMaster_4");

            entity.HasIndex(e => e.UserId, "IX_tbl_MaterialReceiptMaster_5");

            entity.HasIndex(e => new { e.VoucherTypeId, e.LedgerId, e.Date }, "IX_tbl_MaterialReceiptMaster_6");

            entity.HasIndex(e => e.VoucherTypeId, "IX_tbl_MaterialReceiptMaster_7");

            entity.Property(e => e.MaterialReceiptMasterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("materialReceiptMasterId");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.ExchangeRateId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("exchangeRateId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FinancialYearId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("financialYearId");
            entity.Property(e => e.InvoiceNo)
                .IsUnicode(false)
                .HasColumnName("invoiceNo");
            entity.Property(e => e.LedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerId");
            entity.Property(e => e.LrNo)
                .IsUnicode(false)
                .HasColumnName("lrNo");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.OrderMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("orderMasterId");
            entity.Property(e => e.SuffixPrefixId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("suffixPrefixId");
            entity.Property(e => e.TotalAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("totalAmount");
            entity.Property(e => e.TransportationCompany)
                .IsUnicode(false)
                .HasColumnName("transportationCompany");
            entity.Property(e => e.UserId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("userId");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
        });

        modelBuilder.Entity<TblMobileReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_Mobile_Report");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Discount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("discount");
            entity.Property(e => e.EmployeeId).HasColumnName("employeeId");
            entity.Property(e => e.EmployeeName).HasColumnName("employeeName");
            entity.Property(e => e.Extra1)
                .HasMaxLength(50)
                .HasColumnName("extra1");
            entity.Property(e => e.GrossAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("grossAmount");
            entity.Property(e => e.GroupId).HasColumnName("groupId");
            entity.Property(e => e.InvoiceNo)
                .HasMaxLength(50)
                .HasColumnName("invoiceNo");
            entity.Property(e => e.LedgerId).HasColumnName("ledgerId");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.ProductName).HasColumnName("productName");
            entity.Property(e => e.Qty)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("qty");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("rate");
            entity.Property(e => e.SalesMasterId).HasColumnName("salesMasterId");
            entity.Property(e => e.TaxAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("taxAmount");
            entity.Property(e => e.VoucherNo)
                .HasMaxLength(50)
                .HasColumnName("voucherNo");
        });

        modelBuilder.Entity<TblMobileReportSale>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_Mobile_Report_Sales");

            entity.Property(e => e.BalanceDue).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.BillDiscount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("billDiscount");
            entity.Property(e => e.EmployeeId).HasColumnName("employeeId");
            entity.Property(e => e.Extra1)
                .HasMaxLength(50)
                .HasColumnName("extra1");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.GrandTotal)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("grandTotal");
            entity.Property(e => e.InvoiceNo).HasColumnName("invoiceNo");
            entity.Property(e => e.LedgerId).HasColumnName("ledgerId");
            entity.Property(e => e.OrderNo).HasMaxLength(50);
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.SalesMasterId).HasColumnName("salesMasterId");
            entity.Property(e => e.TaxAmtOnBill).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.TotalAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("totalAmount");
            entity.Property(e => e.VoucherNo).HasColumnName("voucherNo");
        });

        modelBuilder.Entity<TblModelNo>(entity =>
        {
            entity.HasKey(e => e.ModelNoId).HasName("PK__tbl_Mode__8458D8C94DB4832C");

            entity.ToTable("tbl_ModelNo");

            entity.Property(e => e.ModelNoId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modelNoId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.ModelNo)
                .IsUnicode(false)
                .HasColumnName("modelNo");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
        });

        modelBuilder.Entity<TblMonthlySalary>(entity =>
        {
            entity.HasKey(e => e.MonthlySalaryId).HasName("PK__tbl_Mont__DD79B8643C34F16F");

            entity.ToTable("tbl_MonthlySalary");

            entity.Property(e => e.MonthlySalaryId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("monthlySalaryId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.SalaryMonth)
                .HasColumnType("datetime")
                .HasColumnName("salaryMonth");
        });

        modelBuilder.Entity<TblMonthlySalaryDetail>(entity =>
        {
            entity.HasKey(e => e.MonthlySalaryDetailsId).HasName("PK__tbl_Mont__04252B5040058253");

            entity.ToTable("tbl_MonthlySalaryDetails");

            entity.HasIndex(e => e.EmployeeId, "IX_tbl_MonthlySalaryDetails");

            entity.HasIndex(e => e.MonthlySalaryId, "IX_tbl_MonthlySalaryDetails_1");

            entity.HasIndex(e => e.SalaryPackageId, "IX_tbl_MonthlySalaryDetails_2");

            entity.HasIndex(e => new { e.EmployeeId, e.MonthlySalaryId, e.SalaryPackageId }, "IX_tbl_MonthlySalaryDetails_3");

            entity.Property(e => e.MonthlySalaryDetailsId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("monthlySalaryDetailsId");
            entity.Property(e => e.EmployeeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("employeeId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.MonthlySalaryId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("monthlySalaryId");
            entity.Property(e => e.SalaryPackageId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("salaryPackageId");
        });

        modelBuilder.Entity<TblPackageDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_PackageDetails");

            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("amount");
            entity.Property(e => e.PackageId).HasColumnName("packageId");
            entity.Property(e => e.ProductId).HasColumnName("productId");
            entity.Property(e => e.Qty)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("qty");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("rate");
            entity.Property(e => e.SrNo)
                .ValueGeneratedOnAdd()
                .HasColumnName("srNo");
        });

        modelBuilder.Entity<TblPackageHead>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("tbl_PackageHead");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.PackageName).HasColumnName("packageName");
            entity.Property(e => e.TotalAmount)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("totalAmount");
            entity.Property(e => e.TotalQty)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("totalQty");
        });

        modelBuilder.Entity<TblPartyBalance>(entity =>
        {
            entity.HasKey(e => e.PartyBalanceId).HasName("PK__tbl_Part__69824BB71C680BB2");

            entity.ToTable("tbl_PartyBalance");

            entity.Property(e => e.PartyBalanceId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("partyBalanceId");
            entity.Property(e => e.AgainstInvoiceNo)
                .IsUnicode(false)
                .HasColumnName("againstInvoiceNo");
            entity.Property(e => e.AgainstVoucherNo)
                .IsUnicode(false)
                .HasColumnName("againstVoucherNo");
            entity.Property(e => e.AgainstVoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("againstVoucherTypeId");
            entity.Property(e => e.Credit)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("credit");
            entity.Property(e => e.CreditPeriod).HasColumnName("creditPeriod");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Debit)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("debit");
            entity.Property(e => e.ExchangeRateId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("exchangeRateId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FinancialYearId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("financialYearId");
            entity.Property(e => e.InvoiceNo)
                .IsUnicode(false)
                .HasColumnName("invoiceNo");
            entity.Property(e => e.LedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerId");
            entity.Property(e => e.ModelNoId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modelNoId");
            entity.Property(e => e.ReferenceType)
                .IsUnicode(false)
                .HasColumnName("referenceType");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
            entity.Property(e => e.Weight)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("weight");
            entity.Property(e => e.WeightOut)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("weightOut");
        });

        modelBuilder.Entity<TblPayHead>(entity =>
        {
            entity.HasKey(e => e.PayHeadId).HasName("PK__tbl_PayH__1BAC6FBD2CF2ADDF");

            entity.ToTable("tbl_PayHead");

            entity.Property(e => e.PayHeadId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("payHeadId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.PayHeadName)
                .IsUnicode(false)
                .HasColumnName("payHeadName");
            entity.Property(e => e.Type)
                .IsUnicode(false)
                .HasColumnName("type");
        });

        modelBuilder.Entity<TblPaymentDetail>(entity =>
        {
            entity.HasKey(e => e.PaymentDetailsId).HasName("PK__tbl_Paym__2549CB8A6AD0B01E");

            entity.ToTable("tbl_PaymentDetails");

            entity.Property(e => e.PaymentDetailsId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("paymentDetailsId");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("amount");
            entity.Property(e => e.ChequeDate)
                .HasColumnType("datetime")
                .HasColumnName("chequeDate");
            entity.Property(e => e.ChequeNo)
                .IsUnicode(false)
                .HasColumnName("chequeNo");
            entity.Property(e => e.ExchangeRateId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("exchangeRateId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.LedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerId");
            entity.Property(e => e.PaymentMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("paymentMasterId");
        });

        modelBuilder.Entity<TblPaymentMaster>(entity =>
        {
            entity.HasKey(e => e.PaymentMasterId).HasName("PK__tbl_Paym__F6D0847167001F3A");

            entity.ToTable("tbl_PaymentMaster");

            entity.Property(e => e.PaymentMasterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("paymentMasterId");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FinancialYearId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("financialYearId");
            entity.Property(e => e.InvoiceNo)
                .IsUnicode(false)
                .HasColumnName("invoiceNo");
            entity.Property(e => e.LedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerId");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.SuffixPrefixId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("suffixPrefixId");
            entity.Property(e => e.TotalAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("totalAmount");
            entity.Property(e => e.UserId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("userId");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
        });

        modelBuilder.Entity<TblPdcclearanceMaster>(entity =>
        {
            entity.HasKey(e => e.PdcclearanceMasterId).HasName("PK__tbl_PDCC__D88D38E00955373E");

            entity.ToTable("tbl_PDCClearanceMaster");

            entity.HasIndex(e => e.AgainstId, "IX_tbl_PDCClearanceMaster");

            entity.HasIndex(e => e.FinancialYearId, "IX_tbl_PDCClearanceMaster_1");

            entity.HasIndex(e => e.LedgerId, "IX_tbl_PDCClearanceMaster_2");

            entity.HasIndex(e => e.SuffixPrefixId, "IX_tbl_PDCClearanceMaster_3");

            entity.HasIndex(e => e.UserId, "IX_tbl_PDCClearanceMaster_4");

            entity.HasIndex(e => e.VoucherTypeId, "IX_tbl_PDCClearanceMaster_5");

            entity.HasIndex(e => new { e.AgainstId, e.LedgerId, e.VoucherTypeId }, "IX_tbl_PDCClearanceMaster_6");

            entity.Property(e => e.PdcclearanceMasterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("PDCClearanceMasterId");
            entity.Property(e => e.AgainstId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("againstId");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FinancialYearId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("financialYearId");
            entity.Property(e => e.InvoiceNo)
                .IsUnicode(false)
                .HasColumnName("invoiceNo");
            entity.Property(e => e.LedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerId");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.Status)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.SuffixPrefixId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("suffixPrefixId");
            entity.Property(e => e.Type)
                .IsUnicode(false)
                .HasColumnName("type");
            entity.Property(e => e.UserId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("userId");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
        });

        modelBuilder.Entity<TblPdcpayableMaster>(entity =>
        {
            entity.HasKey(e => e.PdcPayableMasterId).HasName("PK__tbl_PDCP__D5E696DE01B41576");

            entity.ToTable("tbl_PDCPayableMaster");

            entity.HasIndex(e => e.BankId, "IX_tbl_PDCPayableMaster");

            entity.HasIndex(e => e.FinancialYearId, "IX_tbl_PDCPayableMaster_1");

            entity.HasIndex(e => e.LedgerId, "IX_tbl_PDCPayableMaster_2");

            entity.HasIndex(e => e.SuffixPrefixId, "IX_tbl_PDCPayableMaster_3");

            entity.HasIndex(e => e.UserId, "IX_tbl_PDCPayableMaster_4");

            entity.HasIndex(e => e.VoucherTypeId, "IX_tbl_PDCPayableMaster_5");

            entity.Property(e => e.PdcPayableMasterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("pdcPayableMasterId");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("amount");
            entity.Property(e => e.BankId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("bankId");
            entity.Property(e => e.ChequeDate)
                .HasColumnType("datetime")
                .HasColumnName("chequeDate");
            entity.Property(e => e.ChequeNo)
                .IsUnicode(false)
                .HasColumnName("chequeNo");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FinancialYearId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("financialYearId");
            entity.Property(e => e.InvoiceNo)
                .IsUnicode(false)
                .HasColumnName("invoiceNo");
            entity.Property(e => e.LedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerId");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.SuffixPrefixId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("suffixPrefixId");
            entity.Property(e => e.UserId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("userId");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
        });

        modelBuilder.Entity<TblPdcreceivableMaster>(entity =>
        {
            entity.HasKey(e => e.PdcReceivableMasterId).HasName("PK__tbl_PDCR__A14C5E250584A65A");

            entity.ToTable("tbl_PDCReceivableMaster");

            entity.HasIndex(e => e.BankId, "IX_tbl_PDCReceivableMaster");

            entity.HasIndex(e => e.FinancialYearId, "IX_tbl_PDCReceivableMaster_1");

            entity.HasIndex(e => e.LedgerId, "IX_tbl_PDCReceivableMaster_2");

            entity.HasIndex(e => e.SuffixPrefixId, "IX_tbl_PDCReceivableMaster_3");

            entity.HasIndex(e => e.UserId, "IX_tbl_PDCReceivableMaster_4");

            entity.HasIndex(e => e.VoucherTypeId, "IX_tbl_PDCReceivableMaster_5");

            entity.Property(e => e.PdcReceivableMasterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("pdcReceivableMasterId");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("amount");
            entity.Property(e => e.BankId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("bankId");
            entity.Property(e => e.ChequeDate)
                .HasColumnType("datetime")
                .HasColumnName("chequeDate");
            entity.Property(e => e.ChequeNo)
                .IsUnicode(false)
                .HasColumnName("chequeNo");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FinancialYearId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("financialYearId");
            entity.Property(e => e.InvoiceNo)
                .IsUnicode(false)
                .HasColumnName("invoiceNo");
            entity.Property(e => e.LedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerId");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.SuffixPrefixId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("suffixPrefixId");
            entity.Property(e => e.UserId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("userId");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
        });

        modelBuilder.Entity<TblPhysicalStockDetail>(entity =>
        {
            entity.HasKey(e => e.PhysicalStockDetailsId).HasName("PK__tbl_Phys__A94165330ED9066A");

            entity.ToTable("tbl_PhysicalStockDetails");

            entity.Property(e => e.PhysicalStockDetailsId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("physicalStockDetailsId");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("amount");
            entity.Property(e => e.BatchId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("batchId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.GodownId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("godownId");
            entity.Property(e => e.PhysicalStockMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("physicalStockMasterId");
            entity.Property(e => e.ProductId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("productId");
            entity.Property(e => e.Qty)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("qty");
            entity.Property(e => e.RackId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("rackId");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("rate");
            entity.Property(e => e.Slno).HasColumnName("slno");
            entity.Property(e => e.UnitConversionId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitConversionId");
            entity.Property(e => e.UnitId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitId");
        });

        modelBuilder.Entity<TblPhysicalStockMaster>(entity =>
        {
            entity.HasKey(e => e.PhysicalStockMasterId).HasName("PK__tbl_Phys__7367DF7A0B087586");

            entity.ToTable("tbl_PhysicalStockMaster");

            entity.Property(e => e.PhysicalStockMasterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("physicalStockMasterId");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FinancialYearId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("financialYearId");
            entity.Property(e => e.InvoiceNo)
                .IsUnicode(false)
                .HasColumnName("invoiceNo");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.SuffixPrefixId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("suffixPrefixId");
            entity.Property(e => e.TotalAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("totalAmount");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
        });

        modelBuilder.Entity<TblPriceList>(entity =>
        {
            entity.HasKey(e => e.PricelistId).HasName("PK__tbl_Pric__81BD4B85278EDA44");

            entity.ToTable("tbl_PriceList");

            entity.HasIndex(e => e.BatchId, "IX_tbl_PriceList");

            entity.HasIndex(e => e.PricinglevelId, "IX_tbl_PriceList_1");

            entity.HasIndex(e => e.ProductId, "IX_tbl_PriceList_2");

            entity.HasIndex(e => e.UnitId, "IX_tbl_PriceList_3");

            entity.HasIndex(e => new { e.BatchId, e.ProductId, e.PricinglevelId }, "IX_tbl_PriceList_4");

            entity.Property(e => e.PricelistId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("pricelistId");
            entity.Property(e => e.BatchId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("batchId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.PricinglevelId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("pricinglevelId");
            entity.Property(e => e.ProductId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("productId");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("rate");
            entity.Property(e => e.UnitId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitId");
        });

        modelBuilder.Entity<TblPricingLevel>(entity =>
        {
            entity.HasKey(e => e.PricinglevelId).HasName("PK__tbl_Pric__84E896EA23BE4960");

            entity.ToTable("tbl_PricingLevel");

            entity.Property(e => e.PricinglevelId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("pricinglevelId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.PricinglevelName)
                .IsUnicode(false)
                .HasColumnName("pricinglevelName");
        });

        modelBuilder.Entity<TblPrivilege>(entity =>
        {
            entity.HasKey(e => e.PrivilegeId);

            entity.ToTable("tbl_Privilege");

            entity.HasIndex(e => e.RoleId, "IX_tbl_Privilege");

            entity.Property(e => e.PrivilegeId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("privilegeId");
            entity.Property(e => e.Action)
                .IsUnicode(false)
                .HasColumnName("action");
            entity.Property(e => e.Exatra1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("exatra1");
            entity.Property(e => e.Extra2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FormName)
                .IsUnicode(false)
                .HasColumnName("formName");
            entity.Property(e => e.RoleId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("roleId");
        });

        modelBuilder.Entity<TblPrizeList>(entity =>
        {
            entity.HasKey(e => e.PriceCode);

            entity.ToTable("tbl_PrizeList");

            entity.Property(e => e.PriceCode).HasMaxLength(50);
            entity.Property(e => e.PriceAmount).HasMaxLength(50);
            entity.Property(e => e.Srno).ValueGeneratedOnAdd();
            entity.Property(e => e.Status).HasMaxLength(50);
        });

        modelBuilder.Entity<TblProduct>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PK__tbl_Prod__2D10D16A1FEDB87C");

            entity.ToTable("tbl_Product");

            entity.Property(e => e.ProductId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("productId");
            entity.Property(e => e.BrandId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("brandId");
            entity.Property(e => e.Depth)
                .HasMaxLength(50)
                .HasColumnName("depth");
            entity.Property(e => e.Extra1).HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.GodownId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("godownId");
            entity.Property(e => e.GoldPrice)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("goldPrice");
            entity.Property(e => e.GoldRateUsd)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("goldRateUSD");
            entity.Property(e => e.GroupId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("groupId");
            entity.Property(e => e.Height)
                .HasMaxLength(50)
                .HasColumnName("height");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.IsBom).HasColumnName("isBom");
            entity.Property(e => e.IsallowBatch).HasColumnName("isallowBatch");
            entity.Property(e => e.Ismultipleunit).HasColumnName("ismultipleunit");
            entity.Property(e => e.Isopeningstock).HasColumnName("isopeningstock");
            entity.Property(e => e.IsshowRemember).HasColumnName("isshowRemember");
            entity.Property(e => e.Length)
                .HasMaxLength(50)
                .HasColumnName("length");
            entity.Property(e => e.LessPrice)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("lessPrice");
            entity.Property(e => e.MaximumStock)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("maximumStock");
            entity.Property(e => e.Mc)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("mc");
            entity.Property(e => e.MinimumStock)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("minimumStock");
            entity.Property(e => e.ModelNoId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modelNoId");
            entity.Property(e => e.Mpc)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("mpc");
            entity.Property(e => e.Mrp)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("mrp");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.PackageId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("packageId");
            entity.Property(e => e.PartNo)
                .IsUnicode(false)
                .HasColumnName("partNo");
            entity.Property(e => e.ProductCode)
                .IsUnicode(false)
                .HasColumnName("productCode");
            entity.Property(e => e.ProductName).HasColumnName("productName");
            entity.Property(e => e.PurchaseRate)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("purchaseRate");
            entity.Property(e => e.RackId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("rackId");
            entity.Property(e => e.ReorderLevel)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("reorderLevel");
            entity.Property(e => e.SalesRate)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("salesRate");
            entity.Property(e => e.SalesRatePer)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("salesRatePer");
            entity.Property(e => e.SizeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("sizeId");
            entity.Property(e => e.SupplierId).HasColumnName("supplierId");
            entity.Property(e => e.TaxId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("taxId");
            entity.Property(e => e.TaxapplicableOn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("taxapplicableOn");
            entity.Property(e => e.TaxonP)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("taxonP");
            entity.Property(e => e.UnitId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitId");
            entity.Property(e => e.Weight)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("weight");
            entity.Property(e => e.WeightLessPer)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("weightLessPer");
            entity.Property(e => e.Width)
                .HasMaxLength(50)
                .HasColumnName("width");
        });

        modelBuilder.Entity<TblProductGroup>(entity =>
        {
            entity.HasKey(e => e.GroupId).HasName("PK__tbl_Prod__88C1034D10AB74EC");

            entity.ToTable("tbl_ProductGroup");

            entity.HasIndex(e => e.GroupUnder, "IX_tbl_ProductGroup");

            entity.Property(e => e.GroupId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("groupId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.GroupName)
                .IsUnicode(false)
                .HasColumnName("groupName");
            entity.Property(e => e.GroupUnder)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("groupUnder");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
        });

        modelBuilder.Entity<TblProductTemp>(entity =>
        {
            entity.HasKey(e => e.ProductId);

            entity.ToTable("tbl_Product_Temp");

            entity.Property(e => e.ProductId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("productId");
            entity.Property(e => e.BrandId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("brandId");
            entity.Property(e => e.Extra1).HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.GodownId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("godownId");
            entity.Property(e => e.GroupId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("groupId");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.IsBom).HasColumnName("isBom");
            entity.Property(e => e.IsallowBatch).HasColumnName("isallowBatch");
            entity.Property(e => e.Ismultipleunit).HasColumnName("ismultipleunit");
            entity.Property(e => e.Isopeningstock).HasColumnName("isopeningstock");
            entity.Property(e => e.IsshowRemember).HasColumnName("isshowRemember");
            entity.Property(e => e.MaximumStock)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("maximumStock");
            entity.Property(e => e.MinimumStock)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("minimumStock");
            entity.Property(e => e.ModelNoId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("modelNoId");
            entity.Property(e => e.Mrp)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("mrp");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.PartNo)
                .IsUnicode(false)
                .HasColumnName("partNo");
            entity.Property(e => e.ProductCode)
                .IsUnicode(false)
                .HasColumnName("productCode");
            entity.Property(e => e.ProductName).HasColumnName("productName");
            entity.Property(e => e.PurchaseRate)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("purchaseRate");
            entity.Property(e => e.RackId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("rackId");
            entity.Property(e => e.ReorderLevel)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("reorderLevel");
            entity.Property(e => e.SalesRate)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("salesRate");
            entity.Property(e => e.SalesRatePer)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("salesRatePer");
            entity.Property(e => e.SizeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("sizeId");
            entity.Property(e => e.TaxId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("taxId");
            entity.Property(e => e.TaxapplicableOn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("taxapplicableOn");
            entity.Property(e => e.UnitId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitId");
        });

        modelBuilder.Entity<TblProductTracking>(entity =>
        {
            entity.HasKey(e => e.ProductId);

            entity.ToTable("tbl_Product_tracking");

            entity.HasIndex(e => new { e.TimestampBigint, e.UpdateScopeId, e.SyncRowIsTombstone, e.ProductId }, "tbl_Product_tracking_timestamp_index");

            entity.Property(e => e.ProductId)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("productId");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.Timestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("timestamp");
            entity.Property(e => e.TimestampBigint)
                .HasComputedColumnSql("(CONVERT([bigint],[timestamp]))", true)
                .HasColumnName("timestamp_bigint");
            entity.Property(e => e.UpdateScopeId).HasColumnName("update_scope_id");
        });

        modelBuilder.Entity<TblProfitRange>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("tbl_ProfitRange");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.DProfit)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("dProfit");
            entity.Property(e => e.FromWeight)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("fromWeight");
            entity.Property(e => e.MaxProfit)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("maxProfit");
            entity.Property(e => e.ProductId)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("productId");
            entity.Property(e => e.ToWeight)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("toWeight");
        });

        modelBuilder.Entity<TblProject>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("tbl_Project");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.CancelReason).HasColumnName("cancelReason");
            entity.Property(e => e.Date)
                .HasColumnType("date")
                .HasColumnName("date");
            entity.Property(e => e.LedgerId)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("ledgerId");
            entity.Property(e => e.ProjectCancel)
                .HasColumnType("date")
                .HasColumnName("projectCancel");
            entity.Property(e => e.ProjectComplete)
                .HasColumnType("date")
                .HasColumnName("projectComplete");
            entity.Property(e => e.ProjectEnd)
                .HasColumnType("date")
                .HasColumnName("projectEnd");
            entity.Property(e => e.ProjectId)
                .HasMaxLength(50)
                .HasColumnName("projectId");
            entity.Property(e => e.ProjectName).HasColumnName("projectName");
            entity.Property(e => e.ProjectStart)
                .HasColumnType("date")
                .HasColumnName("projectStart");
            entity.Property(e => e.ProjectStatus)
                .HasMaxLength(50)
                .HasColumnName("projectStatus");
            entity.Property(e => e.QuotationId)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("quotationId");
            entity.Property(e => e.SuffixPrefixId)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("suffixPrefixId");
            entity.Property(e => e.VoucherNo)
                .HasMaxLength(50)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("voucherTypeId");
        });

        modelBuilder.Entity<TblProjectCostD>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("tbl_projectCostD");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.AccledgerId).HasColumnName("accledgerId");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("amount");
            entity.Property(e => e.ProjectCostId).HasColumnName("projectCostId");
        });

        modelBuilder.Entity<TblProjectCostH>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("tbl_ProjectCostH");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Date)
                .HasColumnType("date")
                .HasColumnName("date");
            entity.Property(e => e.LedgerId).HasColumnName("ledgerId");
            entity.Property(e => e.ProjectId).HasColumnName("projectId");
            entity.Property(e => e.TotalCost)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("totalCost");
            entity.Property(e => e.UserId).HasColumnName("userId");
        });

        modelBuilder.Entity<TblPurchaseBillTax>(entity =>
        {
            entity.HasKey(e => e.PurchaseBillTaxId).HasName("PK__tbl_Purc__1B87331A27D9BE5E");

            entity.ToTable("tbl_PurchaseBillTax");

            entity.Property(e => e.PurchaseBillTaxId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("purchaseBillTaxId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.PurchaseMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("purchaseMasterId");
            entity.Property(e => e.TaxAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("taxAmount");
            entity.Property(e => e.TaxId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("taxId");
        });

        modelBuilder.Entity<TblPurchaseDetail>(entity =>
        {
            entity.HasKey(e => e.PurchaseDetailsId).HasName("PK__tbl_Purc__67AF05292BAA4F42");

            entity.ToTable("tbl_PurchaseDetails");

            entity.Property(e => e.PurchaseDetailsId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("purchaseDetailsId");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("amount");
            entity.Property(e => e.BatchId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("batchId");
            entity.Property(e => e.Discount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("discount");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.GodownId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("godownId");
            entity.Property(e => e.GoldPrice)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("goldPrice");
            entity.Property(e => e.GrossAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("grossAmount");
            entity.Property(e => e.Mc)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("mc");
            entity.Property(e => e.Mpc)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("mpc");
            entity.Property(e => e.NetAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("netAmount");
            entity.Property(e => e.OrderDetailsId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("orderDetailsId");
            entity.Property(e => e.ProductId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("productId");
            entity.Property(e => e.PurchaseMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("purchaseMasterId");
            entity.Property(e => e.Qty)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("qty");
            entity.Property(e => e.RackId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("rackId");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("rate");
            entity.Property(e => e.ReceiptDetailsId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("receiptDetailsId");
            entity.Property(e => e.SlNo).HasColumnName("slNo");
            entity.Property(e => e.TaxAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("taxAmount");
            entity.Property(e => e.TaxId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("taxId");
            entity.Property(e => e.UnitConversionId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitConversionId");
            entity.Property(e => e.UnitId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitId");
            entity.Property(e => e.Weight)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("weight");
        });

        modelBuilder.Entity<TblPurchaseFromCustomer>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("tbl_PurchaseFromCustomer");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.BalanceAmount)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("balanceAmount");
            entity.Property(e => e.CreditPurchase)
                .HasMaxLength(50)
                .HasColumnName("creditPurchase");
            entity.Property(e => e.CreditSale)
                .HasMaxLength(50)
                .HasColumnName("creditSale");
            entity.Property(e => e.Date)
                .HasColumnType("date")
                .HasColumnName("date");
            entity.Property(e => e.Discount)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("discount");
            entity.Property(e => e.Extra1).HasColumnName("extra1");
            entity.Property(e => e.Extra2).HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FinalAmount)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("finalAmount");
            entity.Property(e => e.FinancialYearId)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("financialYearId");
            entity.Property(e => e.GoldPrice)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("goldPrice");
            entity.Property(e => e.InvoiceNo)
                .HasMaxLength(50)
                .HasColumnName("invoiceNo");
            entity.Property(e => e.LedgerId).HasColumnName("ledgerId");
            entity.Property(e => e.Narration).HasColumnName("narration");
            entity.Property(e => e.NetAmount)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("netAmount");
            entity.Property(e => e.OldGoldValue)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("oldGoldValue");
            entity.Property(e => e.PaidAmount)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("paidAmount");
            entity.Property(e => e.Ptype).HasColumnName("PType");
            entity.Property(e => e.PurchaseAccount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.SuffixPrefixId).HasColumnName("suffixPrefixId");
            entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.TotalNewWeight)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("totalNewWeight");
            entity.Property(e => e.TotalOldWeight)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("totalOldWeight");
            entity.Property(e => e.UserId)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("userId");
            entity.Property(e => e.Vat)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("vat");
            entity.Property(e => e.VoucherNo)
                .HasMaxLength(50)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId).HasColumnName("voucherTypeId");
        });

        modelBuilder.Entity<TblPurchaseMaster>(entity =>
        {
            entity.HasKey(e => e.PurchaseMasterId).HasName("PK__tbl_Purc__9D353EFC20389C96");

            entity.ToTable("tbl_PurchaseMaster");

            entity.Property(e => e.PurchaseMasterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("purchaseMasterId");
            entity.Property(e => e.AdditionalCost)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("additionalCost");
            entity.Property(e => e.BillDiscount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("billDiscount");
            entity.Property(e => e.CreditPeriod)
                .IsUnicode(false)
                .HasColumnName("creditPeriod");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.DiffrenceWeight)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("diffrenceWeight");
            entity.Property(e => e.ExchangeRateId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("exchangeRateId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraAmount)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("extraAmount");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.ExtraGoldPriceBd)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("extraGoldPriceBD");
            entity.Property(e => e.ExtraGoldValue)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("extraGoldValue");
            entity.Property(e => e.ExtraVat)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("extraVAT");
            entity.Property(e => e.ExtraVatId)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("extraVatId");
            entity.Property(e => e.FinancialYearId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("financialYearId");
            entity.Property(e => e.GrandTotal)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("grandTotal");
            entity.Property(e => e.InvoiceNo)
                .IsUnicode(false)
                .HasColumnName("invoiceNo");
            entity.Property(e => e.LedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerId");
            entity.Property(e => e.LrNo)
                .IsUnicode(false)
                .HasColumnName("lrNo");
            entity.Property(e => e.MaterialReceiptMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("materialReceiptMasterId");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.PurchaseAccount)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("purchaseAccount");
            entity.Property(e => e.PurchaseOrderMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("purchaseOrderMasterId");
            entity.Property(e => e.SuffixPrefixId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("suffixPrefixId");
            entity.Property(e => e.TotalAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("totalAmount");
            entity.Property(e => e.TotalTax)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("totalTax");
            entity.Property(e => e.TotalWeightIssued)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("totalWeightIssued");
            entity.Property(e => e.TotalWeightReceived)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("totalWeightReceived");
            entity.Property(e => e.TransportationCompany)
                .IsUnicode(false)
                .HasColumnName("transportationCompany");
            entity.Property(e => e.UserId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("userId");
            entity.Property(e => e.VendorInvoiceDate)
                .HasColumnType("datetime")
                .HasColumnName("vendorInvoiceDate");
            entity.Property(e => e.VendorInvoiceNo)
                .IsUnicode(false)
                .HasColumnName("vendorInvoiceNo");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
        });

        modelBuilder.Entity<TblPurchaseOrderDetail>(entity =>
        {
            entity.HasKey(e => e.PurchaseOrderDetailsId).HasName("PK__tbl_Purc__BDE1867C70547F4A");

            entity.ToTable("tbl_PurchaseOrderDetails");

            entity.Property(e => e.PurchaseOrderDetailsId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("purchaseOrderDetailsId");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("amount");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.ProductId)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("productId");
            entity.Property(e => e.PurchaseOrderMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("purchaseOrderMasterId");
            entity.Property(e => e.Qty)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("qty");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("rate");
            entity.Property(e => e.SlNo).HasColumnName("slNo");
            entity.Property(e => e.UnitConversionId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitConversionId");
            entity.Property(e => e.UnitId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitId");
        });

        modelBuilder.Entity<TblPurchaseOrderMaster>(entity =>
        {
            entity.HasKey(e => e.PurchaseOrderMasterId).HasName("PK__tbl_Purc__DAD68F806C83EE66");

            entity.ToTable("tbl_PurchaseOrderMaster");

            entity.Property(e => e.PurchaseOrderMasterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("purchaseOrderMasterId");
            entity.Property(e => e.Cancelled).HasColumnName("cancelled");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.DueDate)
                .HasColumnType("datetime")
                .HasColumnName("dueDate");
            entity.Property(e => e.EmployeeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("employeeId");
            entity.Property(e => e.ExchangeRateId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("exchangeRateId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FinancialYearId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("financialYearId");
            entity.Property(e => e.InvoiceNo)
                .IsUnicode(false)
                .HasColumnName("invoiceNo");
            entity.Property(e => e.LedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerId");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.SuffixPrefixId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("suffixPrefixId");
            entity.Property(e => e.TotalAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("totalAmount");
            entity.Property(e => e.UserId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("userId");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
        });

        modelBuilder.Entity<TblPurchaseReturnBilltax>(entity =>
        {
            entity.HasKey(e => e.PurchaseReturnBillTaxId);

            entity.ToTable("tbl_PurchaseReturnBilltax");

            entity.HasIndex(e => e.TaxId, "IX_tbl_PurchaseReturnBilltax");

            entity.Property(e => e.PurchaseReturnBillTaxId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("purchaseReturnBillTaxId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.PurchaseReturnMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("purchaseReturnMasterId");
            entity.Property(e => e.TaxAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("taxAmount");
            entity.Property(e => e.TaxId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("taxId");
        });

        modelBuilder.Entity<TblPurchaseReturnDetail>(entity =>
        {
            entity.HasKey(e => e.PurchaseReturnDetailsId).HasName("PK__tbl_Purc__BD84172168B35D82");

            entity.ToTable("tbl_PurchaseReturnDetails");

            entity.HasIndex(e => e.BatchId, "IX_tbl_PurchaseReturnDetails");

            entity.HasIndex(e => e.GodownId, "IX_tbl_PurchaseReturnDetails_1");

            entity.HasIndex(e => e.ProductId, "IX_tbl_PurchaseReturnDetails_2");

            entity.HasIndex(e => e.PurchaseDetailsId, "IX_tbl_PurchaseReturnDetails_3");

            entity.HasIndex(e => e.PurchaseReturnMasterId, "IX_tbl_PurchaseReturnDetails_4");

            entity.HasIndex(e => e.RackId, "IX_tbl_PurchaseReturnDetails_5");

            entity.HasIndex(e => e.TaxId, "IX_tbl_PurchaseReturnDetails_6");

            entity.HasIndex(e => e.UnitConversionId, "IX_tbl_PurchaseReturnDetails_7");

            entity.HasIndex(e => e.UnitId, "IX_tbl_PurchaseReturnDetails_8");

            entity.Property(e => e.PurchaseReturnDetailsId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("purchaseReturnDetailsId");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("amount");
            entity.Property(e => e.BatchId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("batchId");
            entity.Property(e => e.Discount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("discount");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.GodownId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("godownId");
            entity.Property(e => e.GrossAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("grossAmount");
            entity.Property(e => e.NetAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("netAmount");
            entity.Property(e => e.ProductId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("productId");
            entity.Property(e => e.PurchaseDetailsId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("purchaseDetailsId");
            entity.Property(e => e.PurchaseReturnMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("purchaseReturnMasterId");
            entity.Property(e => e.Qty)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("qty");
            entity.Property(e => e.RackId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("rackId");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("rate");
            entity.Property(e => e.SlNo).HasColumnName("slNo");
            entity.Property(e => e.TaxAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("taxAmount");
            entity.Property(e => e.TaxId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("taxId");
            entity.Property(e => e.UnitConversionId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitConversionId");
            entity.Property(e => e.UnitId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitId");
        });

        modelBuilder.Entity<TblPurchaseReturnMaster>(entity =>
        {
            entity.HasKey(e => e.PurchaseReturnMasterId).HasName("PK__tbl_Purc__B4D7A61F64E2CC9E");

            entity.ToTable("tbl_PurchaseReturnMaster");

            entity.HasIndex(e => e.ExchangeRateId, "IX_tbl_PurchaseReturnMaster");

            entity.HasIndex(e => e.FinancialYearId, "IX_tbl_PurchaseReturnMaster_1");

            entity.HasIndex(e => e.LedgerId, "IX_tbl_PurchaseReturnMaster_2");

            entity.HasIndex(e => e.PurchaseAccount, "IX_tbl_PurchaseReturnMaster_3");

            entity.HasIndex(e => e.PurchaseMasterId, "IX_tbl_PurchaseReturnMaster_4");

            entity.HasIndex(e => e.SuffixPrefixId, "IX_tbl_PurchaseReturnMaster_5");

            entity.HasIndex(e => e.UserId, "IX_tbl_PurchaseReturnMaster_6");

            entity.HasIndex(e => e.VoucherTypeId, "IX_tbl_PurchaseReturnMaster_7");

            entity.Property(e => e.PurchaseReturnMasterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("purchaseReturnMasterId");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Discount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("discount");
            entity.Property(e => e.ExchangeRateId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("exchangeRateId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FinancialYearId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("financialYearId");
            entity.Property(e => e.GrandTotal)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("grandTotal");
            entity.Property(e => e.InvoiceNo)
                .IsUnicode(false)
                .HasColumnName("invoiceNo");
            entity.Property(e => e.LedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerId");
            entity.Property(e => e.LrNo)
                .IsUnicode(false)
                .HasColumnName("lrNo");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.PurchaseAccount)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("purchaseAccount");
            entity.Property(e => e.PurchaseMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("purchaseMasterId");
            entity.Property(e => e.SuffixPrefixId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("suffixPrefixId");
            entity.Property(e => e.TotalAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("totalAmount");
            entity.Property(e => e.TotalTax)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("totalTax");
            entity.Property(e => e.TransportationCompany)
                .IsUnicode(false)
                .HasColumnName("transportationCompany");
            entity.Property(e => e.UserId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("userId");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
        });

        modelBuilder.Entity<TblPurchasefromCustomerDetailsP>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("PK_tbl_purchasefromCustomerDetails");

            entity.ToTable("tbl_purchasefromCustomerDetailsP");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.ActualWeight)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("actualWeight");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("amount");
            entity.Property(e => e.GoldTypeId).HasColumnName("goldTypeId");
            entity.Property(e => e.ItemDescription).HasColumnName("itemDescription");
            entity.Property(e => e.Less)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("less");
            entity.Property(e => e.LessPrice)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("lessPrice");
            entity.Property(e => e.Price)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("price");
            entity.Property(e => e.ProductId).HasColumnName("productId");
            entity.Property(e => e.Productode)
                .HasMaxLength(50)
                .HasColumnName("productode");
            entity.Property(e => e.PurchaseMasterId).HasColumnName("purchaseMasterId");
            entity.Property(e => e.Qty)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("qty");
            entity.Property(e => e.RawWeight)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("rawWeight");
            entity.Property(e => e.UnitId).HasColumnName("unitId");
        });

        modelBuilder.Entity<TblPurchasefromCustomerDetailsP1>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("PK_tbl_PurchasefromCustomerNew");

            entity.ToTable("tbl_PurchasefromCustomerDetailsPS");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("amount");
            entity.Property(e => e.CostPrice)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("costPrice");
            entity.Property(e => e.Discount)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("discount");
            entity.Property(e => e.Formula)
                .HasMaxLength(50)
                .HasColumnName("formula");
            entity.Property(e => e.ItemDesc).HasColumnName("itemDesc");
            entity.Property(e => e.MakingCharge)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("makingCharge");
            entity.Property(e => e.MpCharge)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("mpCharge");
            entity.Property(e => e.Price)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("price");
            entity.Property(e => e.ProductCode)
                .HasMaxLength(50)
                .HasColumnName("productCode");
            entity.Property(e => e.ProductId).HasColumnName("productId");
            entity.Property(e => e.Profit)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("profit");
            entity.Property(e => e.ProfitGrm)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("profit_grm");
            entity.Property(e => e.PurchaseMasterId).HasColumnName("purchaseMasterId");
            entity.Property(e => e.Qty)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("qty");
            entity.Property(e => e.SalePrice)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("salePrice");
            entity.Property(e => e.Tax)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("tax");
            entity.Property(e => e.TaxId)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("taxId");
            entity.Property(e => e.UnitId).HasColumnName("unitId");
            entity.Property(e => e.Vat)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("vat");
            entity.Property(e => e.Weight)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("weight");
        });

        modelBuilder.Entity<TblQuickLaunchItem>(entity =>
        {
            entity.HasKey(e => e.QuickLaunchItemsId);

            entity.ToTable("tbl_QuickLaunchItems");

            entity.Property(e => e.QuickLaunchItemsId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("quickLaunchItemsId");
            entity.Property(e => e.Extra1).HasColumnName("extra1");
            entity.Property(e => e.Extra2).HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.ItemsName)
                .IsUnicode(false)
                .HasColumnName("itemsName");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<TblQuickLaunchItemsToCopy>(entity =>
        {
            entity.HasKey(e => e.QuickLaunchItemsId);

            entity.ToTable("tbl_QuickLaunchItemsToCopy");

            entity.Property(e => e.QuickLaunchItemsId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("quickLaunchItemsId");
            entity.Property(e => e.Extra1).HasColumnName("extra1");
            entity.Property(e => e.Extra2).HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.ItemsName)
                .IsUnicode(false)
                .HasColumnName("itemsName");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<TblRack>(entity =>
        {
            entity.HasKey(e => e.RackId).HasName("PK__tbl_Rack__B34912495555A4F4");

            entity.ToTable("tbl_Rack");

            entity.HasIndex(e => e.GodownId, "IX_tbl_Rack");

            entity.Property(e => e.RackId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("rackId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.GodownId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("godownId");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.RackName)
                .IsUnicode(false)
                .HasColumnName("rackName");
        });

        modelBuilder.Entity<TblReceiptDetail>(entity =>
        {
            entity.HasKey(e => e.ReceiptDetailsId).HasName("PK__tbl_Rece__C0FF33FB6EA14102");

            entity.ToTable("tbl_ReceiptDetails");

            entity.Property(e => e.ReceiptDetailsId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("receiptDetailsId");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("amount");
            entity.Property(e => e.ChequeDate)
                .HasColumnType("datetime")
                .HasColumnName("chequeDate");
            entity.Property(e => e.ChequeNo)
                .IsUnicode(false)
                .HasColumnName("chequeNo");
            entity.Property(e => e.ExchangeRateId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("exchangeRateId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.LedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerId");
            entity.Property(e => e.ReceiptMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("receiptMasterId");
        });

        modelBuilder.Entity<TblReceiptMaster>(entity =>
        {
            entity.HasKey(e => e.ReceiptMasterId).HasName("PK__tbl_Rece__B974C2984925A390");

            entity.ToTable("tbl_ReceiptMaster");

            entity.Property(e => e.ReceiptMasterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("receiptMasterId");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FinancialYearId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("financialYearId");
            entity.Property(e => e.InvoiceNo)
                .IsUnicode(false)
                .HasColumnName("invoiceNo");
            entity.Property(e => e.LedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerId");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.SuffixPrefixId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("suffixPrefixId");
            entity.Property(e => e.TotalAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("totalAmount");
            entity.Property(e => e.UserId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("userId");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
        });

        modelBuilder.Entity<TblRejectionInDetail>(entity =>
        {
            entity.HasKey(e => e.RejectionInDetailsId).HasName("PK__tbl_Reje__1B0C62F44A2ED662");

            entity.ToTable("tbl_RejectionInDetails");

            entity.HasIndex(e => e.BatchId, "IX_tbl_RejectionInDetails");

            entity.HasIndex(e => e.DeliveryNoteDetailsId, "IX_tbl_RejectionInDetails_1");

            entity.HasIndex(e => e.GodownId, "IX_tbl_RejectionInDetails_2");

            entity.HasIndex(e => e.ProductId, "IX_tbl_RejectionInDetails_3");

            entity.HasIndex(e => e.RackId, "IX_tbl_RejectionInDetails_4");

            entity.HasIndex(e => e.RejectionInMasterId, "IX_tbl_RejectionInDetails_5");

            entity.HasIndex(e => e.UnitConversionId, "IX_tbl_RejectionInDetails_6");

            entity.HasIndex(e => e.UnitId, "IX_tbl_RejectionInDetails_7");

            entity.Property(e => e.RejectionInDetailsId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("rejectionInDetailsId");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("amount");
            entity.Property(e => e.BatchId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("batchId");
            entity.Property(e => e.DeliveryNoteDetailsId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("deliveryNoteDetailsId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.GodownId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("godownId");
            entity.Property(e => e.ProductId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("productId");
            entity.Property(e => e.Qty)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("qty");
            entity.Property(e => e.RackId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("rackId");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("rate");
            entity.Property(e => e.RejectionInMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("rejectionInMasterId");
            entity.Property(e => e.SlNo).HasColumnName("slNo");
            entity.Property(e => e.UnitConversionId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitConversionId");
            entity.Property(e => e.UnitId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitId");
        });

        modelBuilder.Entity<TblRejectionInMaster>(entity =>
        {
            entity.HasKey(e => e.RejectionInMasterId).HasName("PK__tbl_Reje__9C0B04FD465E457E");

            entity.ToTable("tbl_RejectionInMaster");

            entity.HasIndex(e => e.DeliveryNoteMasterId, "IX_tbl_RejectionInMaster");

            entity.HasIndex(e => e.EmployeeId, "IX_tbl_RejectionInMaster_1");

            entity.HasIndex(e => e.ExchangeRateId, "IX_tbl_RejectionInMaster_2");

            entity.HasIndex(e => e.FinancialYearId, "IX_tbl_RejectionInMaster_3");

            entity.HasIndex(e => e.LedgerId, "IX_tbl_RejectionInMaster_4");

            entity.HasIndex(e => e.PricinglevelId, "IX_tbl_RejectionInMaster_5");

            entity.HasIndex(e => e.SuffixPrefixId, "IX_tbl_RejectionInMaster_6");

            entity.HasIndex(e => e.UserId, "IX_tbl_RejectionInMaster_7");

            entity.HasIndex(e => e.VoucherTypeId, "IX_tbl_RejectionInMaster_8");

            entity.Property(e => e.RejectionInMasterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("rejectionInMasterId");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.DeliveryNoteMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("deliveryNoteMasterId");
            entity.Property(e => e.EmployeeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("employeeId");
            entity.Property(e => e.ExchangeRateId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("exchangeRateId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FinancialYearId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("financialYearId");
            entity.Property(e => e.InvoiceNo)
                .IsUnicode(false)
                .HasColumnName("invoiceNo");
            entity.Property(e => e.LedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerId");
            entity.Property(e => e.LrNo)
                .IsUnicode(false)
                .HasColumnName("lrNo");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.PricinglevelId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("pricinglevelId");
            entity.Property(e => e.SuffixPrefixId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("suffixPrefixId");
            entity.Property(e => e.TotalAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("totalAmount");
            entity.Property(e => e.TransportationCompany)
                .IsUnicode(false)
                .HasColumnName("transportationCompany");
            entity.Property(e => e.UserId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("userId");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
        });

        modelBuilder.Entity<TblRejectionOutDetail>(entity =>
        {
            entity.HasKey(e => e.RejectionOutDetailsId).HasName("PK__tbl_Reje__4B87F6607F96C2DA");

            entity.ToTable("tbl_RejectionOutDetails");

            entity.HasIndex(e => e.BatchId, "IX_tbl_RejectionOutDetails");

            entity.HasIndex(e => e.GodownId, "IX_tbl_RejectionOutDetails_1");

            entity.HasIndex(e => e.ProductId, "IX_tbl_RejectionOutDetails_2");

            entity.HasIndex(e => e.RackId, "IX_tbl_RejectionOutDetails_3");

            entity.HasIndex(e => e.RejectionOutMasterId, "IX_tbl_RejectionOutDetails_4");

            entity.HasIndex(e => e.UnitConversionId, "IX_tbl_RejectionOutDetails_5");

            entity.HasIndex(e => e.UnitId, "IX_tbl_RejectionOutDetails_6");

            entity.Property(e => e.RejectionOutDetailsId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("rejectionOutDetailsId");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("amount");
            entity.Property(e => e.BatchId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("batchId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.GodownId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("godownId");
            entity.Property(e => e.MaterialReceiptDetailsId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("materialReceiptDetailsId");
            entity.Property(e => e.ProductId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("productId");
            entity.Property(e => e.Qty)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("qty");
            entity.Property(e => e.RackId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("rackId");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("rate");
            entity.Property(e => e.RejectionOutMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("rejectionOutMasterId");
            entity.Property(e => e.Slno).HasColumnName("slno");
            entity.Property(e => e.UnitConversionId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitConversionId");
            entity.Property(e => e.UnitId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitId");
        });

        modelBuilder.Entity<TblRejectionOutMaster>(entity =>
        {
            entity.HasKey(e => e.RejectionOutMasterId).HasName("PK__tbl_Reje__236B422C7BC631F6");

            entity.ToTable("tbl_RejectionOutMaster");

            entity.HasIndex(e => e.ExchangeRateId, "IX_tbl_RejectionOutMaster");

            entity.HasIndex(e => e.FinancialYearId, "IX_tbl_RejectionOutMaster_1");

            entity.HasIndex(e => e.LedgerId, "IX_tbl_RejectionOutMaster_2");

            entity.HasIndex(e => e.MaterialReceiptMasterId, "IX_tbl_RejectionOutMaster_3");

            entity.HasIndex(e => e.SuffixPrefixId, "IX_tbl_RejectionOutMaster_4");

            entity.HasIndex(e => e.UserId, "IX_tbl_RejectionOutMaster_5");

            entity.HasIndex(e => e.VoucherTypeId, "IX_tbl_RejectionOutMaster_6");

            entity.Property(e => e.RejectionOutMasterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("rejectionOutMasterId");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.ExchangeRateId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("exchangeRateId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FinancialYearId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("financialYearId");
            entity.Property(e => e.InvoiceNo)
                .IsUnicode(false)
                .HasColumnName("invoiceNo");
            entity.Property(e => e.LedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerId");
            entity.Property(e => e.LrNo)
                .IsUnicode(false)
                .HasColumnName("lrNo");
            entity.Property(e => e.MaterialReceiptMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("materialReceiptMasterId");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.SuffixPrefixId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("suffixPrefixId");
            entity.Property(e => e.TotalAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("totalAmount");
            entity.Property(e => e.TransportationCompany)
                .IsUnicode(false)
                .HasColumnName("transportationCompany");
            entity.Property(e => e.UserId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("userId");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
        });

        modelBuilder.Entity<TblReminder>(entity =>
        {
            entity.HasKey(e => e.ReminderId);

            entity.ToTable("tbl_Reminder");

            entity.Property(e => e.ReminderId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("reminderId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FromDate)
                .HasColumnType("datetime")
                .HasColumnName("fromDate");
            entity.Property(e => e.RemindAbout)
                .IsUnicode(false)
                .HasColumnName("remindAbout");
            entity.Property(e => e.ToDate)
                .HasColumnType("datetime")
                .HasColumnName("toDate");
        });

        modelBuilder.Entity<TblReservedTable>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_ReservedTable");

            entity.Property(e => e.OrderId).HasMaxLength(50);
            entity.Property(e => e.Srno).ValueGeneratedOnAdd();
            entity.Property(e => e.TableId).HasColumnName("tableId");
        });

        modelBuilder.Entity<TblRole>(entity =>
        {
            entity.HasKey(e => e.RoleId);

            entity.ToTable("tbl_Role");

            entity.Property(e => e.RoleId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("roleId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.Role)
                .IsUnicode(false)
                .HasColumnName("role");
        });

        modelBuilder.Entity<TblRoute>(entity =>
        {
            entity.HasKey(e => e.RouteId);

            entity.ToTable("tbl_Route");

            entity.HasIndex(e => e.AreaId, "IX_tbl_Route");

            entity.Property(e => e.RouteId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("routeId");
            entity.Property(e => e.AreaId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("areaId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.RouteName)
                .IsUnicode(false)
                .HasColumnName("routeName");
        });

        modelBuilder.Entity<TblSalaryPackage>(entity =>
        {
            entity.HasKey(e => e.SalaryPackageId).HasName("PK__tbl_Sala__B78BCF693493CFA7");

            entity.ToTable("tbl_SalaryPackage");

            entity.Property(e => e.SalaryPackageId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("salaryPackageId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.SalaryPackageName)
                .IsUnicode(false)
                .HasColumnName("salaryPackageName");
            entity.Property(e => e.TotalAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("totalAmount");
        });

        modelBuilder.Entity<TblSalaryPackageDetail>(entity =>
        {
            entity.HasKey(e => e.SalaryPackageDetailsId).HasName("PK__tbl_Sala__993415083864608B");

            entity.ToTable("tbl_SalaryPackageDetails");

            entity.HasIndex(e => e.PayHeadId, "IX_tbl_SalaryPackageDetails");

            entity.HasIndex(e => e.SalaryPackageId, "IX_tbl_SalaryPackageDetails_1");

            entity.HasIndex(e => new { e.PayHeadId, e.SalaryPackageId }, "IX_tbl_SalaryPackageDetails_2");

            entity.Property(e => e.SalaryPackageDetailsId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("salaryPackageDetailsId");
            entity.Property(e => e.Amount)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("amount");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.PayHeadId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("payHeadId");
            entity.Property(e => e.SalaryPackageId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("salaryPackageId");
        });

        modelBuilder.Entity<TblSalaryVoucherDetail>(entity =>
        {
            entity.HasKey(e => e.SalaryVoucherDetailsId).HasName("PK__tbl_Sala__054D02EE47A6A41B");

            entity.ToTable("tbl_SalaryVoucherDetails");

            entity.HasIndex(e => e.EmployeeId, "IX_tbl_SalaryVoucherDetails");

            entity.HasIndex(e => e.SalaryVoucherMasterId, "IX_tbl_SalaryVoucherDetails_1");

            entity.Property(e => e.SalaryVoucherDetailsId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("salaryVoucherDetailsId");
            entity.Property(e => e.Advance)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("advance");
            entity.Property(e => e.Bonus)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("bonus");
            entity.Property(e => e.Deduction)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("deduction");
            entity.Property(e => e.EmployeeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("employeeId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.Lop)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("lop");
            entity.Property(e => e.Salary)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("salary");
            entity.Property(e => e.SalaryVoucherMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("salaryVoucherMasterId");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("status");
        });

        modelBuilder.Entity<TblSalaryVoucherMaster>(entity =>
        {
            entity.HasKey(e => e.SalaryVoucherMasterId).HasName("PK__tbl_Sala__B363606243D61337");

            entity.ToTable("tbl_SalaryVoucherMaster");

            entity.HasIndex(e => e.FinancialYearId, "IX_tbl_SalaryVoucherMaster");

            entity.HasIndex(e => e.LedgerId, "IX_tbl_SalaryVoucherMaster_1");

            entity.HasIndex(e => e.SuffixPrefixId, "IX_tbl_SalaryVoucherMaster_2");

            entity.HasIndex(e => e.VoucherTypeId, "IX_tbl_SalaryVoucherMaster_3");

            entity.Property(e => e.SalaryVoucherMasterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("salaryVoucherMasterId");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FinancialYearId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("financialYearId");
            entity.Property(e => e.InvoiceNo)
                .IsUnicode(false)
                .HasColumnName("invoiceNo");
            entity.Property(e => e.LedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerId");
            entity.Property(e => e.Month)
                .HasColumnType("datetime")
                .HasColumnName("month");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.SuffixPrefixId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("suffixPrefixId");
            entity.Property(e => e.TotalAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("totalAmount");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
        });

        modelBuilder.Entity<TblSalesBillDiscount>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_SalesBillDiscount");

            entity.Property(e => e.DiscountAmount).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.DiscountId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DiscountPercentage).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.SalesBillTaxId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("salesBillTaxId");
            entity.Property(e => e.SalesMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("salesMasterId");
        });

        modelBuilder.Entity<TblSalesBillTax>(entity =>
        {
            entity.HasKey(e => e.SalesBillTaxId).HasName("PK__tbl_Sale__3E4B1B27334B710A");

            entity.ToTable("tbl_SalesBillTax");

            entity.Property(e => e.SalesBillTaxId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("salesBillTaxId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.SalesMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("salesMasterId");
            entity.Property(e => e.TaxAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("taxAmount");
            entity.Property(e => e.TaxId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("taxId");
        });

        modelBuilder.Entity<TblSalesDetail>(entity =>
        {
            entity.HasKey(e => e.SalesDetailsId).HasName("PK__tbl_Sale__541370DA371C01EE");

            entity.ToTable("tbl_SalesDetails");

            entity.Property(e => e.SalesDetailsId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("salesDetailsId");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("amount");
            entity.Property(e => e.BatchId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("batchId");
            entity.Property(e => e.CostPrice)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("costPrice");
            entity.Property(e => e.DeliveryNoteDetailsId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("deliveryNoteDetailsId");
            entity.Property(e => e.Discount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("discount");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.ExtraPrice).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.GodownId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("godownId");
            entity.Property(e => e.GoldPrice)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("goldPrice");
            entity.Property(e => e.GrossAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("grossAmount");
            entity.Property(e => e.MakingCharge)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("makingCharge");
            entity.Property(e => e.MpCharge)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("mpCharge");
            entity.Property(e => e.NetAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("netAmount");
            entity.Property(e => e.OrderDetailsId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("orderDetailsId");
            entity.Property(e => e.ProductId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("productId");
            entity.Property(e => e.Profit)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("profit");
            entity.Property(e => e.ProfitGrm)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("profit_grm");
            entity.Property(e => e.Qty)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("qty");
            entity.Property(e => e.QuotationDetailsId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("quotationDetailsId");
            entity.Property(e => e.RackId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("rackId");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("rate");
            entity.Property(e => e.SalesMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("salesMasterId");
            entity.Property(e => e.SlNo).HasColumnName("slNo");
            entity.Property(e => e.TaxAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("taxAmount");
            entity.Property(e => e.TaxId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("taxId");
            entity.Property(e => e.UnitConversionId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitConversionId");
            entity.Property(e => e.UnitId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitId");
            entity.Property(e => e.Vat)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("vat");
            entity.Property(e => e.Weight)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("weight");
        });

        modelBuilder.Entity<TblSalesMaster>(entity =>
        {
            entity.HasKey(e => e.SalesMasterId).HasName("PK__tbl_Sale__036BDC222F7AE026");

            entity.ToTable("tbl_SalesMaster");

            entity.Property(e => e.SalesMasterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("salesMasterId");
            entity.Property(e => e.AdditionalCost)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("additionalCost");
            entity.Property(e => e.BalanceDue).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Banknm).HasColumnName("banknm");
            entity.Property(e => e.BillDiscount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("billDiscount");
            entity.Property(e => e.Canceled).HasMaxLength(50);
            entity.Property(e => e.CanceledBy).HasColumnName("canceledBy");
            entity.Property(e => e.CanceledDate)
                .HasColumnType("datetime")
                .HasColumnName("canceledDate");
            entity.Property(e => e.CardAmount).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.CardNo).HasMaxLength(50);
            entity.Property(e => e.CashAmount).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Chequedate)
                .HasColumnType("date")
                .HasColumnName("chequedate");
            entity.Property(e => e.ChnageAmount).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.CounterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("counterId");
            entity.Property(e => e.CreditPeriod).HasColumnName("creditPeriod");
            entity.Property(e => e.CustomerName)
                .IsUnicode(false)
                .HasColumnName("customerName");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.DeliveryNoteMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("deliveryNoteMasterId");
            entity.Property(e => e.DeliveryStatus).HasDefaultValueSql("((0))");
            entity.Property(e => e.EmployeeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("employeeId");
            entity.Property(e => e.ExchangeRateId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("exchangeRateId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraCharge)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("extraCharge");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FinancialYearId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("financialYearId");
            entity.Property(e => e.GoldPrice)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("goldPrice");
            entity.Property(e => e.GrandTotal)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("grandTotal");
            entity.Property(e => e.InvoiceNo)
                .IsUnicode(false)
                .HasColumnName("invoiceNo");
            entity.Property(e => e.LedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerId");
            entity.Property(e => e.LrNo)
                .IsUnicode(false)
                .HasColumnName("lrNo");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.OrderMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("orderMasterId");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.Pos).HasColumnName("POS");
            entity.Property(e => e.PricinglevelId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("pricinglevelId");
            entity.Property(e => e.QuotationMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("quotationMasterId");
            entity.Property(e => e.SalesAccount)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("salesAccount");
            entity.Property(e => e.SalesType).HasMaxLength(50);
            entity.Property(e => e.SuffixPrefixId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("suffixPrefixId");
            entity.Property(e => e.TaxAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("taxAmount");
            entity.Property(e => e.TenderedAmount).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.TotalAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("totalAmount");
            entity.Property(e => e.TotalWeight)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("totalWeight");
            entity.Property(e => e.TransportationCompany)
                .IsUnicode(false)
                .HasColumnName("transportationCompany");
            entity.Property(e => e.UserId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("userId");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
        });

        modelBuilder.Entity<TblSalesMasterExtraCharge>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("tbl_SalesMaster_ExtraCharge");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.ExtraAmount)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("extraAmount");
            entity.Property(e => e.ExtraChargeNm)
                .HasMaxLength(50)
                .HasColumnName("extraChargeNm");
            entity.Property(e => e.SalesMasterId)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("salesMasterId");
        });

        modelBuilder.Entity<TblSalesOrderBillTax>(entity =>
        {
            entity.HasKey(e => e.SalesBillTaxId);

            entity.ToTable("tbl_SalesOrderBillTax");

            entity.Property(e => e.SalesBillTaxId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("salesBillTaxId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.SalesMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("salesMasterId");
            entity.Property(e => e.TaxAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("taxAmount");
            entity.Property(e => e.TaxId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("taxId");
        });

        modelBuilder.Entity<TblSalesOrderDetails>(entity =>
        {
            entity.HasKey(e => e.SalesOrderDetailsId).HasName("PK__tbl_Sale__45789749597119F2");

            entity.ToTable("tbl_SalesOrderDetails");

            entity.HasIndex(e => e.BatchId, "IX_tbl_SalesOrderDetails");

            entity.HasIndex(e => e.ProductId, "IX_tbl_SalesOrderDetails_1");

            entity.HasIndex(e => e.QuotationDetailsId, "IX_tbl_SalesOrderDetails_2");

            entity.HasIndex(e => e.SalesOrderMasterId, "IX_tbl_SalesOrderDetails_3");

            entity.HasIndex(e => e.UnitConversionId, "IX_tbl_SalesOrderDetails_4");

            entity.HasIndex(e => e.UnitId, "IX_tbl_SalesOrderDetails_5");

            entity.Property(e => e.SalesOrderDetailsId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("salesOrderDetailsId");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("amount");
            entity.Property(e => e.BatchId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("batchId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.ProductId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("productId");
            entity.Property(e => e.Qty)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("qty");
            entity.Property(e => e.QuotationDetailsId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("quotationDetailsId");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("rate");
            entity.Property(e => e.SalesOrderMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("salesOrderMasterId");
            entity.Property(e => e.SlNo).HasColumnName("slNo");
            entity.Property(e => e.UnitConversionId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitConversionId");
            entity.Property(e => e.UnitId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitId");
        });

        modelBuilder.Entity<TblSalesOrderMaster>(entity =>
        {
            entity.HasKey(e => e.SalesOrderMasterId).HasName("PK__tbl_Sale__9D8A0C5455A0890E");

            entity.ToTable("tbl_SalesOrderMaster");

            entity.HasIndex(e => e.EmployeeId, "IX_tbl_SalesOrderMaster");

            entity.HasIndex(e => e.ExchangeRateId, "IX_tbl_SalesOrderMaster_1");

            entity.HasIndex(e => e.FinancialYearId, "IX_tbl_SalesOrderMaster_2");

            entity.HasIndex(e => e.LedgerId, "IX_tbl_SalesOrderMaster_3");

            entity.HasIndex(e => e.LedgerId, "IX_tbl_SalesOrderMaster_4");

            entity.HasIndex(e => e.PricinglevelId, "IX_tbl_SalesOrderMaster_5");

            entity.HasIndex(e => e.QuotationMasterId, "IX_tbl_SalesOrderMaster_6");

            entity.HasIndex(e => e.SuffixPrefixId, "IX_tbl_SalesOrderMaster_7");

            entity.HasIndex(e => e.UserId, "IX_tbl_SalesOrderMaster_8");

            entity.HasIndex(e => e.VoucherTypeId, "IX_tbl_SalesOrderMaster_9");

            entity.Property(e => e.SalesOrderMasterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("salesOrderMasterId");
            entity.Property(e => e.Cancelled).HasColumnName("cancelled");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.DueDate)
                .HasColumnType("datetime")
                .HasColumnName("dueDate");
            entity.Property(e => e.EmployeeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("employeeId");
            entity.Property(e => e.ExchangeRateId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("exchangeRateId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FinancialYearId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("financialYearId");
            entity.Property(e => e.InvoiceNo)
                .IsUnicode(false)
                .HasColumnName("invoiceNo");
            entity.Property(e => e.LedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerId");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.PricinglevelId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("pricinglevelId");
            entity.Property(e => e.QuotationMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("quotationMasterId");
            entity.Property(e => e.SuffixPrefixId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("suffixPrefixId");
            entity.Property(e => e.TotalAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("totalAmount");
            entity.Property(e => e.UserId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("userId");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
        });

        modelBuilder.Entity<TblSalesQuotationDetail>(entity =>
        {
            entity.HasKey(e => e.QuotationDetailsId).HasName("PK__tbl_Sale__5875C12861123BBA");

            entity.ToTable("tbl_SalesQuotationDetails");

            entity.HasIndex(e => e.BatchId, "IX_tbl_SalesQuotationDetails");

            entity.HasIndex(e => e.ProductId, "IX_tbl_SalesQuotationDetails_1");

            entity.HasIndex(e => e.QuotationMasterId, "IX_tbl_SalesQuotationDetails_2");

            entity.HasIndex(e => e.UnitConversionId, "IX_tbl_SalesQuotationDetails_3");

            entity.HasIndex(e => e.UnitId, "IX_tbl_SalesQuotationDetails_4");

            entity.Property(e => e.QuotationDetailsId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("quotationDetailsId");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("amount");
            entity.Property(e => e.BatchId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("batchId");
            entity.Property(e => e.Dimension)
                .HasMaxLength(50)
                .HasColumnName("dimension");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.Height)
                .HasMaxLength(50)
                .HasColumnName("height");
            entity.Property(e => e.Length)
                .HasMaxLength(50)
                .HasColumnName("length");
            entity.Property(e => e.ProductId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("productId");
            entity.Property(e => e.Qty)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("qty");
            entity.Property(e => e.QuotationMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("quotationMasterId");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("rate");
            entity.Property(e => e.Slno).HasColumnName("slno");
            entity.Property(e => e.UnitConversionId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitConversionId");
            entity.Property(e => e.UnitId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitId");
            entity.Property(e => e.Width)
                .HasMaxLength(50)
                .HasColumnName("width");
        });

        modelBuilder.Entity<TblSalesQuotationDetailsManual>(entity =>
        {
            entity.HasKey(e => e.QuotationDetailsId);

            entity.ToTable("tbl_SalesQuotationDetails_Manual");

            entity.Property(e => e.QuotationDetailsId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("quotationDetailsId");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("amount");
            entity.Property(e => e.BatchId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("batchId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.ProductId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("productId");
            entity.Property(e => e.Qty)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("qty");
            entity.Property(e => e.QuotationMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("quotationMasterId");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("rate");
            entity.Property(e => e.Slno).HasColumnName("slno");
            entity.Property(e => e.UnitConversionId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitConversionId");
            entity.Property(e => e.UnitId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitId");
        });

        modelBuilder.Entity<TblSalesQuotationManual>(entity =>
        {
            entity.HasKey(e => e.QuotationMasterId);

            entity.ToTable("tbl_SalesQuotationManual");

            entity.Property(e => e.QuotationMasterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("quotationMasterId");
            entity.Property(e => e.Approved).HasColumnName("approved");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.EmployeeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("employeeId");
            entity.Property(e => e.ExchangeRateId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("exchangeRateId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FinancialYearId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("financialYearId");
            entity.Property(e => e.InvoiceNo)
                .IsUnicode(false)
                .HasColumnName("invoiceNo");
            entity.Property(e => e.LedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerId");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.PricinglevelId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("pricinglevelId");
            entity.Property(e => e.SuffixPrefixId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("suffixPrefixId");
            entity.Property(e => e.TotalAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("totalAmount");
            entity.Property(e => e.UserId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("userId");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
        });

        modelBuilder.Entity<TblSalesQuotationMaster>(entity =>
        {
            entity.HasKey(e => e.QuotationMasterId).HasName("PK__tbl_Sale__8D6FDEBD5D41AAD6");

            entity.ToTable("tbl_SalesQuotationMaster");

            entity.HasIndex(e => e.EmployeeId, "IX_tbl_SalesQuotationMaster");

            entity.HasIndex(e => e.ExchangeRateId, "IX_tbl_SalesQuotationMaster_1");

            entity.HasIndex(e => e.FinancialYearId, "IX_tbl_SalesQuotationMaster_2");

            entity.HasIndex(e => e.LedgerId, "IX_tbl_SalesQuotationMaster_3");

            entity.HasIndex(e => e.PricinglevelId, "IX_tbl_SalesQuotationMaster_4");

            entity.HasIndex(e => e.SuffixPrefixId, "IX_tbl_SalesQuotationMaster_5");

            entity.HasIndex(e => e.UserId, "IX_tbl_SalesQuotationMaster_6");

            entity.HasIndex(e => e.VoucherTypeId, "IX_tbl_SalesQuotationMaster_7");

            entity.Property(e => e.QuotationMasterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("quotationMasterId");
            entity.Property(e => e.Approved).HasColumnName("approved");
            entity.Property(e => e.AttenMobile)
                .HasMaxLength(50)
                .HasColumnName("attenMobile");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Discount)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("discount");
            entity.Property(e => e.EmployeeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("employeeId");
            entity.Property(e => e.ExchangeRateId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("exchangeRateId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FinancialYearId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("financialYearId");
            entity.Property(e => e.InvoiceNo)
                .IsUnicode(false)
                .HasColumnName("invoiceNo");
            entity.Property(e => e.LedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerId");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.Note).HasColumnName("note");
            entity.Property(e => e.PricinglevelId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("pricinglevelId");
            entity.Property(e => e.ProjectId)
                .HasMaxLength(50)
                .HasColumnName("projectId");
            entity.Property(e => e.SubTotal)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("subTotal");
            entity.Property(e => e.SuffixPrefixId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("suffixPrefixId");
            entity.Property(e => e.TaxAmount)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("taxAmount");
            entity.Property(e => e.TotalAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("totalAmount");
            entity.Property(e => e.UserId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("userId");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
        });

        modelBuilder.Entity<TblSalesQuotationMaterial>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("tbl_SalesQuotationMaterials");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.QuotationId)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("quotationId");
            entity.Property(e => e.Type).HasColumnName("type");
        });

        modelBuilder.Entity<TblSalesReturnBillTax>(entity =>
        {
            entity.HasKey(e => e.SalesReturnBillTaxId).HasName("PK__tbl_Sale__5BD749863EBD23B6");

            entity.ToTable("tbl_SalesReturnBillTax");

            entity.HasIndex(e => e.SalesReturnMasterId, "IX_tbl_SalesReturnBillTax");

            entity.HasIndex(e => e.TaxId, "IX_tbl_SalesReturnBillTax_1");

            entity.Property(e => e.SalesReturnBillTaxId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("salesReturnBillTaxId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.SalesReturnMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("salesReturnMasterId");
            entity.Property(e => e.TaxAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("taxAmount");
            entity.Property(e => e.TaxId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("taxId");
        });

        modelBuilder.Entity<TblSalesReturnDetail>(entity =>
        {
            entity.HasKey(e => e.SalesReturnDetailsId).HasName("PK__tbl_Sale__0C252C0D428DB49A");

            entity.ToTable("tbl_SalesReturnDetails");

            entity.HasIndex(e => e.BatchId, "IX_tbl_SalesReturnDetails");

            entity.HasIndex(e => e.GodownId, "IX_tbl_SalesReturnDetails_1");

            entity.HasIndex(e => e.ProductId, "IX_tbl_SalesReturnDetails_2");

            entity.HasIndex(e => e.RackId, "IX_tbl_SalesReturnDetails_3");

            entity.HasIndex(e => e.SalesDetailsId, "IX_tbl_SalesReturnDetails_4");

            entity.HasIndex(e => e.SalesReturnMasterId, "IX_tbl_SalesReturnDetails_5");

            entity.HasIndex(e => e.TaxId, "IX_tbl_SalesReturnDetails_6");

            entity.HasIndex(e => e.UnitConversionId, "IX_tbl_SalesReturnDetails_7");

            entity.HasIndex(e => e.UnitId, "IX_tbl_SalesReturnDetails_8");

            entity.Property(e => e.SalesReturnDetailsId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("salesReturnDetailsId");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("amount");
            entity.Property(e => e.BatchId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("batchId");
            entity.Property(e => e.Discount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("discount");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.GodownId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("godownId");
            entity.Property(e => e.GrossAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("grossAmount");
            entity.Property(e => e.NetAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("netAmount");
            entity.Property(e => e.ProductId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("productId");
            entity.Property(e => e.Qty)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("qty");
            entity.Property(e => e.RackId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("rackId");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("rate");
            entity.Property(e => e.SalesDetailsId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("salesDetailsId");
            entity.Property(e => e.SalesReturnMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("salesReturnMasterId");
            entity.Property(e => e.SlNo).HasColumnName("slNo");
            entity.Property(e => e.TaxAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("taxAmount");
            entity.Property(e => e.TaxId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("taxId");
            entity.Property(e => e.UnitConversionId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitConversionId");
            entity.Property(e => e.UnitId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitId");
        });

        modelBuilder.Entity<TblSalesReturnMaster>(entity =>
        {
            entity.HasKey(e => e.SalesReturnMasterId).HasName("PK__tbl_Sale__DB499E433AEC92D2");

            entity.ToTable("tbl_SalesReturnMaster");

            entity.HasIndex(e => e.EmployeeId, "IX_tbl_SalesReturnMaster");

            entity.HasIndex(e => e.ExchangeRateId, "IX_tbl_SalesReturnMaster_1");

            entity.HasIndex(e => e.FinancialYearId, "IX_tbl_SalesReturnMaster_2");

            entity.HasIndex(e => e.LedgerId, "IX_tbl_SalesReturnMaster_3");

            entity.HasIndex(e => e.PricinglevelId, "IX_tbl_SalesReturnMaster_4");

            entity.HasIndex(e => e.SalesAccount, "IX_tbl_SalesReturnMaster_5");

            entity.HasIndex(e => e.SalesMasterId, "IX_tbl_SalesReturnMaster_6");

            entity.HasIndex(e => e.SuffixPrefixId, "IX_tbl_SalesReturnMaster_7");

            entity.HasIndex(e => e.UserId, "IX_tbl_SalesReturnMaster_8");

            entity.HasIndex(e => e.VoucherTypeId, "IX_tbl_SalesReturnMaster_9");

            entity.Property(e => e.SalesReturnMasterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("salesReturnMasterId");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Discount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("discount");
            entity.Property(e => e.EmployeeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("employeeId");
            entity.Property(e => e.ExchangeRateId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("exchangeRateId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FinancialYearId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("financialYearId");
            entity.Property(e => e.GrandTotal)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("grandTotal");
            entity.Property(e => e.InvoiceNo)
                .IsUnicode(false)
                .HasColumnName("invoiceNo");
            entity.Property(e => e.LedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerId");
            entity.Property(e => e.LrNo)
                .IsUnicode(false)
                .HasColumnName("lrNo");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.PricinglevelId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("pricinglevelId");
            entity.Property(e => e.SalesAccount)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("salesAccount");
            entity.Property(e => e.SalesMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("salesMasterId");
            entity.Property(e => e.SuffixPrefixId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("suffixPrefixId");
            entity.Property(e => e.TaxAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("taxAmount");
            entity.Property(e => e.TotalAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("totalAmount");
            entity.Property(e => e.TransportationCompany)
                .IsUnicode(false)
                .HasColumnName("transportationCompany");
            entity.Property(e => e.UserId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("userId");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
        });

        modelBuilder.Entity<TblService>(entity =>
        {
            entity.HasKey(e => e.ServiceId).HasName("PK__tbl_Serv__455070DF70099B30");

            entity.ToTable("tbl_Service");

            entity.HasIndex(e => e.ServiceCategoryId, "IX_tbl_Service");

            entity.Property(e => e.ServiceId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("serviceId");
            entity.Property(e => e.Comission)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("comission");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("rate");
            entity.Property(e => e.ServiceCategoryId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("serviceCategoryId");
            entity.Property(e => e.ServiceName).HasColumnName("serviceName");
        });

        modelBuilder.Entity<TblServiceCategory>(entity =>
        {
            entity.HasKey(e => e.ServiceCategoryId).HasName("PK__tbl_Serv__77EC43563AA1AEB8");

            entity.ToTable("tbl_ServiceCategory");

            entity.Property(e => e.ServiceCategoryId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("serviceCategoryId");
            entity.Property(e => e.CategoryName)
                .IsUnicode(false)
                .HasColumnName("categoryName");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
        });

        modelBuilder.Entity<TblServiceDetail>(entity =>
        {
            entity.HasKey(e => e.ServiceDetailsId).HasName("PK__tbl_Serv__E8F292C47DE38492");

            entity.ToTable("tbl_ServiceDetails");

            entity.HasIndex(e => e.ServiceId, "IX_tbl_ServiceDetails");

            entity.HasIndex(e => e.ServiceMasterId, "IX_tbl_ServiceDetails_1");

            entity.Property(e => e.ServiceDetailsId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("serviceDetailsId");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("amount");
            entity.Property(e => e.Comission)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("comission");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.Measure).HasColumnName("measure");
            entity.Property(e => e.Qty)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("qty");
            entity.Property(e => e.RepairCost)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("repairCost");
            entity.Property(e => e.ServiceId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("serviceId");
            entity.Property(e => e.ServiceMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("serviceMasterId");
        });

        modelBuilder.Entity<TblServiceMaster>(entity =>
        {
            entity.HasKey(e => e.ServiceMasterId).HasName("PK__tbl_Serv__BF261C547A12F3AE");

            entity.ToTable("tbl_ServiceMaster");

            entity.HasIndex(e => e.EmployeeId, "IX_tbl_ServiceMaster");

            entity.HasIndex(e => e.ExchangeRateId, "IX_tbl_ServiceMaster_1");

            entity.HasIndex(e => e.FinancialYearId, "IX_tbl_ServiceMaster_2");

            entity.HasIndex(e => e.LedgerId, "IX_tbl_ServiceMaster_3");

            entity.HasIndex(e => e.ServiceAccount, "IX_tbl_ServiceMaster_4");

            entity.HasIndex(e => e.SuffixPrefixId, "IX_tbl_ServiceMaster_5");

            entity.HasIndex(e => e.UserId, "IX_tbl_ServiceMaster_6");

            entity.HasIndex(e => e.VoucherTypeId, "IX_tbl_ServiceMaster_7");

            entity.Property(e => e.ServiceMasterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("serviceMasterId");
            entity.Property(e => e.CreditPeriod).HasColumnName("creditPeriod");
            entity.Property(e => e.Customer)
                .IsUnicode(false)
                .HasColumnName("customer");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.DeliveryDate)
                .HasColumnType("date")
                .HasColumnName("deliveryDate");
            entity.Property(e => e.Discount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("discount");
            entity.Property(e => e.EmployeeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("employeeId");
            entity.Property(e => e.ExchangeRateId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("exchangeRateId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FinancialYearId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("financialYearId");
            entity.Property(e => e.GrandTotal)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("grandTotal");
            entity.Property(e => e.InvoiceNo)
                .IsUnicode(false)
                .HasColumnName("invoiceNo");
            entity.Property(e => e.LedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerId");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.SalesMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("salesMasterId");
            entity.Property(e => e.ServiceAccount)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("serviceAccount");
            entity.Property(e => e.SuffixPrefixId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("suffixPrefixId");
            entity.Property(e => e.TotalAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("totalAmount");
            entity.Property(e => e.UserId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("userId");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
        });

        modelBuilder.Entity<TblSetExtraOption>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_SetExtraOption");

            entity.Property(e => e.ExtraOptionId).HasColumnName("extraOptionId");
            entity.Property(e => e.ProductId).HasColumnName("productId");
            entity.Property(e => e.Srno).ValueGeneratedOnAdd();
            entity.Property(e => e.Status).HasMaxLength(50);
        });

        modelBuilder.Entity<TblSetting>(entity =>
        {
            entity.HasKey(e => e.SettingsId);

            entity.ToTable("tbl_Settings");

            entity.Property(e => e.SettingsId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("settingsId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.SettingsName)
                .IsUnicode(false)
                .HasColumnName("settingsName");
            entity.Property(e => e.Status)
                .IsUnicode(false)
                .HasColumnName("status");
        });

        modelBuilder.Entity<TblSettingsToCopy>(entity =>
        {
            entity.HasKey(e => e.SettingsId);

            entity.ToTable("tbl_SettingsToCopy");

            entity.Property(e => e.SettingsId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("settingsId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.SettingsName)
                .IsUnicode(false)
                .HasColumnName("settingsName");
            entity.Property(e => e.Status)
                .IsUnicode(false)
                .HasColumnName("status");
        });

        modelBuilder.Entity<TblShift>(entity =>
        {
            entity.HasKey(e => e.ShiftId);

            entity.ToTable("tbl_Shift");

            entity.Property(e => e.ShiftName).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.TotalHours).HasMaxLength(50);
        });

        modelBuilder.Entity<TblSize>(entity =>
        {
            entity.HasKey(e => e.SizeId).HasName("PK__tbl_Size__55B1E55749E3F248");

            entity.ToTable("tbl_Size");

            entity.Property(e => e.SizeId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("sizeId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.Size)
                .IsUnicode(false)
                .HasColumnName("size");
        });

        modelBuilder.Entity<TblStandardRate>(entity =>
        {
            entity.HasKey(e => e.StandardRateId).HasName("PK__tbl_Stan__F75A1E8460C757A0");

            entity.ToTable("tbl_StandardRate");

            entity.HasIndex(e => e.BatchId, "IX_tbl_StandardRate");

            entity.HasIndex(e => e.ProductId, "IX_tbl_StandardRate_1");

            entity.HasIndex(e => e.UnitId, "IX_tbl_StandardRate_2");

            entity.Property(e => e.StandardRateId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("standardRateId");
            entity.Property(e => e.ApplicableFrom)
                .HasColumnType("datetime")
                .HasColumnName("applicableFrom");
            entity.Property(e => e.ApplicableTo)
                .HasColumnType("datetime")
                .HasColumnName("applicableTo");
            entity.Property(e => e.BatchId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("batchId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.ProductId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("productId");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("rate");
            entity.Property(e => e.UnitId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitId");
        });

        modelBuilder.Entity<TblStockJournalDetail>(entity =>
        {
            entity.HasKey(e => e.StockJournalDetailsId).HasName("PK__tbl_Stoc__3224B9A70737E4A2");

            entity.ToTable("tbl_StockJournalDetails");

            entity.Property(e => e.StockJournalDetailsId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("stockJournalDetailsId");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("amount");
            entity.Property(e => e.BatchId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("batchId");
            entity.Property(e => e.ConsumptionOrProduction)
                .IsUnicode(false)
                .HasColumnName("consumptionOrProduction");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.GodownId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("godownId");
            entity.Property(e => e.ProductId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("productId");
            entity.Property(e => e.Qty)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("qty");
            entity.Property(e => e.RackId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("rackId");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("rate");
            entity.Property(e => e.Slno).HasColumnName("slno");
            entity.Property(e => e.StockJournalMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("stockJournalMasterId");
            entity.Property(e => e.UnitConversionId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitConversionId");
            entity.Property(e => e.UnitId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitId");
        });

        modelBuilder.Entity<TblStockJournalMaster>(entity =>
        {
            entity.HasKey(e => e.StockJournalMasterId).HasName("PK__tbl_Stoc__8B1D7000036753BE");

            entity.ToTable("tbl_StockJournalMaster");

            entity.Property(e => e.StockJournalMasterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("stockJournalMasterId");
            entity.Property(e => e.AdditionalCost)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("additionalCost");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.ExchangeRateId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("exchangeRateId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FinancialYearId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("financialYearId");
            entity.Property(e => e.InvoiceNo)
                .IsUnicode(false)
                .HasColumnName("invoiceNo");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.SuffixPrefixId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("suffixPrefixId");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
        });

        modelBuilder.Entity<TblStockPosting>(entity =>
        {
            entity.HasKey(e => e.StockPostingId).HasName("PK__tbl_Stoc__CAEC17F7158603F9");

            entity.ToTable("tbl_StockPosting");

            entity.Property(e => e.StockPostingId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("stockPostingId");
            entity.Property(e => e.AgainstInvoiceNo)
                .IsUnicode(false)
                .HasColumnName("againstInvoiceNo");
            entity.Property(e => e.AgainstVoucherNo)
                .IsUnicode(false)
                .HasColumnName("againstVoucherNo");
            entity.Property(e => e.AgainstVoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("againstVoucherTypeId");
            entity.Property(e => e.BatchId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("batchId");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FinancialYearId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("financialYearId");
            entity.Property(e => e.GodTypeId).HasColumnName("godTypeId");
            entity.Property(e => e.GodownId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("godownId");
            entity.Property(e => e.GroupId).HasColumnName("groupId");
            entity.Property(e => e.InvoiceNo)
                .IsUnicode(false)
                .HasColumnName("invoiceNo");
            entity.Property(e => e.InwardQty)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("inwardQty");
            entity.Property(e => e.OutwardQty)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("outwardQty");
            entity.Property(e => e.ProductId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("productId");
            entity.Property(e => e.RackId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("rackId");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("rate");
            entity.Property(e => e.SupplierId).HasColumnName("supplierId");
            entity.Property(e => e.UnitId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitId");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
            entity.Property(e => e.Weight)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("weight");
        });

        modelBuilder.Entity<TblStockTemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_Stock_Temp");

            entity.Property(e => e.GodownId)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("godownId");
            entity.Property(e => e.ProductId)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("productId");
            entity.Property(e => e.Qty)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("qty");
        });

        modelBuilder.Entity<TblSuffixPrefix>(entity =>
        {
            entity.HasKey(e => e.SuffixprefixId).HasName("PK__tbl_Suff__5876721373DA2C14");

            entity.ToTable("tbl_SuffixPrefix");

            entity.HasIndex(e => e.VoucherTypeId, "IX_tbl_SuffixPrefix");

            entity.Property(e => e.SuffixprefixId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("suffixprefixId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FromDate)
                .HasColumnType("datetime")
                .HasColumnName("fromDate");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.PrefillWithZero).HasColumnName("prefillWithZero");
            entity.Property(e => e.Prefix)
                .IsUnicode(false)
                .HasColumnName("prefix");
            entity.Property(e => e.StartIndex)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("startIndex");
            entity.Property(e => e.Suffix)
                .IsUnicode(false)
                .HasColumnName("suffix");
            entity.Property(e => e.ToDate)
                .HasColumnType("datetime")
                .HasColumnName("toDate");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
            entity.Property(e => e.WidthOfNumericalPart).HasColumnName("widthOfNumericalPart");
        });

        modelBuilder.Entity<TblTable>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_Table");

            entity.Property(e => e.Reserved).HasDefaultValueSql("((0))");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.TableId).ValueGeneratedOnAdd();
            entity.Property(e => e.TableNo).HasMaxLength(50);
        });

        modelBuilder.Entity<TblTableType>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_TableType");

            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.TableTypeId).ValueGeneratedOnAdd();
            entity.Property(e => e.TypeName).HasMaxLength(50);
        });

        modelBuilder.Entity<TblTax>(entity =>
        {
            entity.HasKey(e => e.TaxId).HasName("PK__tbl_Tax__24D2883933008CF0");

            entity.ToTable("tbl_Tax");

            entity.HasIndex(e => e.ApplicableOn, "IX_tbl_Tax");

            entity.HasIndex(e => e.TaxId, "IX_tbl_Tax_1");

            entity.Property(e => e.TaxId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("taxId");
            entity.Property(e => e.ApplicableOn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("applicableOn");
            entity.Property(e => e.CalculatingMode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("calculatingMode");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("rate");
            entity.Property(e => e.TaxName)
                .IsUnicode(false)
                .HasColumnName("taxName");
        });

        modelBuilder.Entity<TblTaxDetail>(entity =>
        {
            entity.HasKey(e => e.TaxdetailsId).HasName("PK__tbl_TaxD__B3B4F7A536D11DD4");

            entity.ToTable("tbl_TaxDetails");

            entity.HasIndex(e => new { e.SelectedtaxId, e.TaxId, e.TaxdetailsId }, "grp01");

            entity.HasIndex(e => e.SelectedtaxId, "selectedtaxId");

            entity.HasIndex(e => e.TaxId, "taxId");

            entity.Property(e => e.TaxdetailsId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("taxdetailsId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.SelectedtaxId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("selectedtaxId");
            entity.Property(e => e.TaxId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("taxId");
        });

        modelBuilder.Entity<TblTempSalesBillTax>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_Temp_SalesBillTax");

            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.SalesBillTaxId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("salesBillTaxId");
            entity.Property(e => e.SalesMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("salesMasterId");
            entity.Property(e => e.TaxAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("taxAmount");
            entity.Property(e => e.TaxId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("taxId");
        });

        modelBuilder.Entity<TblTempSalesBilldiscount>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_Temp_SalesBilldiscount");

            entity.Property(e => e.DiscountAmount).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.DiscountId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DiscountPercentage).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.SalesBillTaxId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("salesBillTaxId");
            entity.Property(e => e.SalesMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("salesMasterId");
        });

        modelBuilder.Entity<TblTempSalesDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_Temp_SalesDetails");

            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("amount");
            entity.Property(e => e.BatchId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("batchId");
            entity.Property(e => e.DeliveryNoteDetailsId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("deliveryNoteDetailsId");
            entity.Property(e => e.Discount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("discount");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.Extra3).HasColumnName("extra3");
            entity.Property(e => e.Extra4)
                .HasMaxLength(50)
                .HasColumnName("extra4");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.ExtraPrice).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.GodownId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("godownId");
            entity.Property(e => e.GrossAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("grossAmount");
            entity.Property(e => e.NetAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("netAmount");
            entity.Property(e => e.OrderDetailsId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("orderDetailsId");
            entity.Property(e => e.ProductId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("productId");
            entity.Property(e => e.Qty)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("qty");
            entity.Property(e => e.QuotationDetailsId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("quotationDetailsId");
            entity.Property(e => e.RackId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("rackId");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("rate");
            entity.Property(e => e.SalesDetailsId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("salesDetailsId");
            entity.Property(e => e.SalesMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("salesMasterId");
            entity.Property(e => e.SlNo).HasColumnName("slNo");
            entity.Property(e => e.TaxAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("taxAmount");
            entity.Property(e => e.TaxId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("taxId");
            entity.Property(e => e.UnitConversionId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitConversionId");
            entity.Property(e => e.UnitId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitId");
        });

        modelBuilder.Entity<TblTempSalesMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_Temp_SalesMaster");

            entity.Property(e => e.AdditionalCost)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("additionalCost");
            entity.Property(e => e.BillDiscount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("billDiscount");
            entity.Property(e => e.CounterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("counterId");
            entity.Property(e => e.CreditPeriod).HasColumnName("creditPeriod");
            entity.Property(e => e.CustomerName)
                .IsUnicode(false)
                .HasColumnName("customerName");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.DeliveryNoteMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("deliveryNoteMasterId");
            entity.Property(e => e.DeliveryStatus).HasDefaultValueSql("((0))");
            entity.Property(e => e.EmployeeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("employeeId");
            entity.Property(e => e.ExchangeRateId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("exchangeRateId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FinancialYearId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("financialYearId");
            entity.Property(e => e.GrandTotal)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("grandTotal");
            entity.Property(e => e.InvoiceNo)
                .IsUnicode(false)
                .HasColumnName("invoiceNo");
            entity.Property(e => e.LedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerId");
            entity.Property(e => e.LrNo)
                .IsUnicode(false)
                .HasColumnName("lrNo");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.OrderMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("orderMasterId");
            entity.Property(e => e.Pos).HasColumnName("POS");
            entity.Property(e => e.PricinglevelId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("pricinglevelId");
            entity.Property(e => e.QuotationMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("quotationMasterId");
            entity.Property(e => e.SalesAccount)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("salesAccount");
            entity.Property(e => e.SalesMasterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("salesMasterId");
            entity.Property(e => e.SuffixPrefixId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("suffixPrefixId");
            entity.Property(e => e.TaxAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("taxAmount");
            entity.Property(e => e.TotalAmount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("totalAmount");
            entity.Property(e => e.TransportationCompany)
                .IsUnicode(false)
                .HasColumnName("transportationCompany");
            entity.Property(e => e.UserId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("userId");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
        });

        modelBuilder.Entity<TblTicketReceive>(entity =>
        {
            entity.HasKey(e => e.RecCode);

            entity.ToTable("tbl_TicketReceive");

            entity.Property(e => e.RecCode).ValueGeneratedNever();
            entity.Property(e => e.Approve).HasDefaultValueSql("((0))");
            entity.Property(e => e.RecDate).HasColumnType("datetime");
            entity.Property(e => e.Remarks).HasMaxLength(150);
            entity.Property(e => e.Srno).ValueGeneratedOnAdd();
            entity.Property(e => e.Status).HasDefaultValueSql("((0))");
            entity.Property(e => e.TotalAmount).HasColumnType("money");
        });

        modelBuilder.Entity<TblTicketReceiveDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_TicketReceive_Details");

            entity.Property(e => e.Qtybd1).HasColumnName("QTYBd1");
            entity.Property(e => e.Qtybd10).HasColumnName("QTYBd10");
            entity.Property(e => e.Qtybd100).HasColumnName("QTYBd100");
            entity.Property(e => e.Qtybd2).HasColumnName("QTYBd2");
            entity.Property(e => e.Qtybd20).HasColumnName("QTYBd20");
            entity.Property(e => e.Qtybd5).HasColumnName("QTYBd5");
            entity.Property(e => e.Qtybd50).HasColumnName("QTYBd50");
            entity.Property(e => e.ReceiveDate).HasColumnType("datetime");
            entity.Property(e => e.Srno).ValueGeneratedOnAdd();
            entity.Property(e => e.ToalAmount).HasColumnType("money");
        });

        modelBuilder.Entity<TblUnit>(entity =>
        {
            entity.HasKey(e => e.UnitId).HasName("PK__tbl_Unit__55D792354242D080");

            entity.ToTable("tbl_Unit");

            entity.Property(e => e.UnitId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.FormalName)
                .IsUnicode(false)
                .HasColumnName("formalName");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.NoOfDecimalplaces).HasColumnName("noOfDecimalplaces");
            entity.Property(e => e.UnitName)
                .IsUnicode(false)
                .HasColumnName("unitName");
        });

        modelBuilder.Entity<TblUnitConvertion>(entity =>
        {
            entity.HasKey(e => e.UnitconversionId).HasName("PK__tbl_Unit__07076F271C1D2798");

            entity.ToTable("tbl_UnitConvertion");

            entity.Property(e => e.UnitconversionId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitconversionId");
            entity.Property(e => e.ConversionRate)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("conversionRate");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.ProductId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("productId");
            entity.Property(e => e.Quantities)
                .IsUnicode(false)
                .HasColumnName("quantities");
            entity.Property(e => e.UnitId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitId");
        });

        modelBuilder.Entity<TblUser>(entity =>
        {
            entity.HasKey(e => e.UserId);

            entity.ToTable("tbl_User");

            entity.HasIndex(e => new { e.RoleId, e.UserId }, "grp01");

            entity.HasIndex(e => e.RoleId, "roleId");

            entity.Property(e => e.UserId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("userId");
            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.EmployeeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("employeeId");
            entity.Property(e => e.Extra1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.RoleId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("roleId");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("userName");
        });

        modelBuilder.Entity<TblVoucherType>(entity =>
        {
            entity.HasKey(e => e.VoucherTypeId).HasName("PK__tbl_Vouc__96246DEA68687968");

            entity.ToTable("tbl_VoucherType");

            entity.HasIndex(e => new { e.VoucherTypeId, e.MasterId }, "grp01");

            entity.HasIndex(e => e.MasterId, "masterId");

            entity.Property(e => e.VoucherTypeId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
            entity.Property(e => e.Declaration)
                .IsUnicode(false)
                .HasColumnName("declaration");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.Heading1)
                .IsUnicode(false)
                .HasColumnName("heading1");
            entity.Property(e => e.Heading2)
                .IsUnicode(false)
                .HasColumnName("heading2");
            entity.Property(e => e.Heading3)
                .IsUnicode(false)
                .HasColumnName("heading3");
            entity.Property(e => e.Heading4)
                .IsUnicode(false)
                .HasColumnName("heading4");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.IsDefault).HasColumnName("isDefault");
            entity.Property(e => e.IsTaxApplicable).HasColumnName("isTaxApplicable");
            entity.Property(e => e.MasterId).HasColumnName("masterId");
            entity.Property(e => e.MethodOfVoucherNumbering)
                .IsUnicode(false)
                .HasColumnName("methodOfVoucherNumbering");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.TypeOfVoucher)
                .IsUnicode(false)
                .HasColumnName("typeOfVoucher");
            entity.Property(e => e.VoucherTypeName)
                .IsUnicode(false)
                .HasColumnName("voucherTypeName");
        });

        modelBuilder.Entity<TblVoucherTypeTax>(entity =>
        {
            entity.HasKey(e => e.VoucherTypeTaxId).HasName("PK__tbl_Vouc__BD57380E6C390A4C");

            entity.ToTable("tbl_VoucherTypeTax");

            entity.HasIndex(e => new { e.TaxId, e.VoucherTypeId, e.VoucherTypeTaxId }, "grp1");

            entity.HasIndex(e => new { e.VoucherTypeTaxId, e.TaxId }, "grp2");

            entity.HasIndex(e => e.TaxId, "taxId");

            entity.HasIndex(e => e.VoucherTypeTaxId, "voucherTypeTaxId");

            entity.Property(e => e.VoucherTypeTaxId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeTaxId");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.TaxId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("taxId");
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
        });

        modelBuilder.Entity<TblVoucherTypeToCopy>(entity =>
        {
            entity.HasKey(e => e.VoucherTypeId);

            entity.ToTable("tbl_VoucherTypeToCopy");

            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
            entity.Property(e => e.Declaration)
                .IsUnicode(false)
                .HasColumnName("declaration");
            entity.Property(e => e.Extra1)
                .IsUnicode(false)
                .HasColumnName("extra1");
            entity.Property(e => e.Extra2)
                .IsUnicode(false)
                .HasColumnName("extra2");
            entity.Property(e => e.ExtraDate)
                .HasColumnType("datetime")
                .HasColumnName("extraDate");
            entity.Property(e => e.Heading1)
                .IsUnicode(false)
                .HasColumnName("heading1");
            entity.Property(e => e.Heading2)
                .IsUnicode(false)
                .HasColumnName("heading2");
            entity.Property(e => e.Heading3)
                .IsUnicode(false)
                .HasColumnName("heading3");
            entity.Property(e => e.Heading4)
                .IsUnicode(false)
                .HasColumnName("heading4");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.IsDefault).HasColumnName("isDefault");
            entity.Property(e => e.IsTaxApplicable).HasColumnName("isTaxApplicable");
            entity.Property(e => e.MasterId).HasColumnName("masterId");
            entity.Property(e => e.MethodOfVoucherNumbering)
                .IsUnicode(false)
                .HasColumnName("methodOfVoucherNumbering");
            entity.Property(e => e.Narration)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.TypeOfVoucher)
                .IsUnicode(false)
                .HasColumnName("typeOfVoucher");
            entity.Property(e => e.VoucherTypeName)
                .IsUnicode(false)
                .HasColumnName("voucherTypeName");
        });

        modelBuilder.Entity<TblWinnerDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_WinnerDetails");

            entity.Property(e => e.CouponCode).HasMaxLength(50);
            entity.Property(e => e.PrizeAmount).HasColumnType("money");
            entity.Property(e => e.PrizeIssueId).HasMaxLength(50);
            entity.Property(e => e.Qrcode)
                .HasMaxLength(50)
                .HasColumnName("QRCode");
            entity.Property(e => e.Srno).ValueGeneratedOnAdd();
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.WinnerId).HasMaxLength(50);
        });

        modelBuilder.Entity<TblWinnerHead>(entity =>
        {
            entity.HasKey(e => e.PrizeIssueId);

            entity.ToTable("tbl_WinnerHead");

            entity.Property(e => e.PrizeIssueId).HasMaxLength(50);
            entity.Property(e => e.IssuedBookletDt).HasColumnType("date");
            entity.Property(e => e.IssuedFromBooklet).HasMaxLength(50);
            entity.Property(e => e.IssuedSalesman).HasMaxLength(50);
            entity.Property(e => e.IssuedSalesmanCode).HasMaxLength(50);
            entity.Property(e => e.PrizeIssuedate).HasColumnType("datetime");
            entity.Property(e => e.Srno).ValueGeneratedOnAdd();
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.TotalPrizeAmt).HasColumnType("money");
            entity.Property(e => e.WinnerCprno)
                .HasMaxLength(50)
                .HasColumnName("WinnerCPRNo");
            entity.Property(e => e.WinnerEmailId).HasMaxLength(50);
            entity.Property(e => e.WinnerId).HasMaxLength(50);
            entity.Property(e => e.WinnerMobNo).HasMaxLength(50);
            entity.Property(e => e.WinnerName).HasMaxLength(50);
            entity.Property(e => e.WinnerPicture).HasColumnType("image");
        });

        modelBuilder.Entity<Temp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TEMP");

            entity.Property(e => e.AccountGroupId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("accountGroupId");
            entity.Property(e => e.AccountGroupName)
                .IsUnicode(false)
                .HasColumnName("accountGroupName");
            entity.Property(e => e.GroupUnder)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("groupUnder");
        });

        modelBuilder.Entity<Temp1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TEMP1");

            entity.Property(e => e.AccountGroupId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("accountGroupId");
            entity.Property(e => e.AccountGroupName)
                .IsUnicode(false)
                .HasColumnName("accountGroupName");
            entity.Property(e => e.GroupUnder)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("groupUnder");
        });

        modelBuilder.Entity<Temp81>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TEMP81");

            entity.Property(e => e.AccountGroupId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("accountGroupId");
            entity.Property(e => e.AccountGroupName)
                .IsUnicode(false)
                .HasColumnName("accountGroupName");
            entity.Property(e => e.GroupUnder)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("groupUnder");
        });

        modelBuilder.Entity<TempProductForMobile>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Temp_Product_For_Mobile");

            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amount");
            entity.Property(e => e.BatchId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("batchId");
            entity.Property(e => e.Discount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("discount");
            entity.Property(e => e.FinancialYearId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("financialYearId");
            entity.Property(e => e.GodownId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("godownId");
            entity.Property(e => e.GrossAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("grossAmount");
            entity.Property(e => e.NetAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("netAmount");
            entity.Property(e => e.Probarcode).HasColumnName("probarcode");
            entity.Property(e => e.ProductId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("productId");
            entity.Property(e => e.ProductName)
                .HasMaxLength(50)
                .HasColumnName("productName");
            entity.Property(e => e.PurchaseOrderDetailsId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("purchaseOrderDetailsId");
            entity.Property(e => e.PurchaseOrderMasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("purchaseOrderMasterId");
            entity.Property(e => e.Qty)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("qty");
            entity.Property(e => e.RackId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("rackId");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("rate");
            entity.Property(e => e.TaxAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("taxAmount");
            entity.Property(e => e.TaxId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("taxId");
            entity.Property(e => e.TransactionId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("TransactionID");
            entity.Property(e => e.UnitConversionId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitConversionId");
            entity.Property(e => e.UnitId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("unitId");
            entity.Property(e => e.UnitName)
                .HasMaxLength(50)
                .HasColumnName("unitName");
        });

        modelBuilder.Entity<View1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View1");

            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.Expr1).IsUnicode(false);
            entity.Property(e => e.GroupId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("groupId");
            entity.Property(e => e.InwardQty)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("inwardQty");
            entity.Property(e => e.LedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerId");
            entity.Property(e => e.OutwardQty)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("outwardQty");
            entity.Property(e => e.ProductName).HasColumnName("productName");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("rate");
            entity.Property(e => e.VoucherNo)
                .IsUnicode(false)
                .HasColumnName("voucherNo");
            entity.Property(e => e.VoucherTypeName)
                .IsUnicode(false)
                .HasColumnName("voucherTypeName");
        });

        modelBuilder.Entity<ViewCashBank>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ViewCashBank");

            entity.Property(e => e.AccountGroupId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("accountGroupId");
        });

        modelBuilder.Entity<VwMaxRate>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwMaxRate");

            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Max)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("max");
        });

        modelBuilder.Entity<VwMinRate>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwMinRate");

            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Min)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("min");
        });

        modelBuilder.Entity<VwStockQuery>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwStockQuery");

            entity.Property(e => e.AgainstInvoiceNo)
                .IsUnicode(false)
                .HasColumnName("againstInvoiceNo");
            entity.Property(e => e.AgainstVoucherNo)
                .IsUnicode(false)
                .HasColumnName("againstVoucherNo");
            entity.Property(e => e.AgainstVoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("againstVoucherTypeId");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.GroupId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("groupId");
            entity.Property(e => e.InwardQty)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("inwardQty");
            entity.Property(e => e.LedgerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ledgerId");
            entity.Property(e => e.MasterId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("masterId");
            entity.Property(e => e.OutwardQty)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("outwardQty");
            entity.Property(e => e.ProductCode)
                .IsUnicode(false)
                .HasColumnName("productCode");
            entity.Property(e => e.ProductName).HasColumnName("productName");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("rate");
            entity.Property(e => e.TypeOfVoucher)
                .IsUnicode(false)
                .HasColumnName("typeOfVoucher");
            entity.Property(e => e.VoucherNo).IsUnicode(false);
            entity.Property(e => e.VoucherTypeId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("voucherTypeId");
            entity.Property(e => e.VoucherTypeName)
                .IsUnicode(false)
                .HasColumnName("voucherTypeName");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
