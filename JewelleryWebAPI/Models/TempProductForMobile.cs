using System;
using System.Collections.Generic;

namespace JewelleryWebAPI.Models;

public partial class TempProductForMobile
{
    public decimal TransactionId { get; set; }

    public decimal? ProductId { get; set; }

    public string? Probarcode { get; set; }

    public string? ProductName { get; set; }

    public decimal? Qty { get; set; }

    public decimal? Rate { get; set; }

    public decimal? UnitId { get; set; }

    public string? UnitName { get; set; }

    public decimal? UnitConversionId { get; set; }

    public decimal? Discount { get; set; }

    public decimal? TaxId { get; set; }

    public decimal? BatchId { get; set; }

    public decimal? GodownId { get; set; }

    public decimal? RackId { get; set; }

    public decimal? TaxAmount { get; set; }

    public decimal? GrossAmount { get; set; }

    public decimal? NetAmount { get; set; }

    public decimal? Amount { get; set; }

    public decimal? PurchaseOrderDetailsId { get; set; }

    public decimal? PurchaseOrderMasterId { get; set; }

    public decimal? FinancialYearId { get; set; }
}
