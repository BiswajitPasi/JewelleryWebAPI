﻿using System;
using System.Collections.Generic;

namespace JewelleryWebAPI.Models;

public partial class TblSalesQuotationMaster
{
    public decimal QuotationMasterId { get; set; }

    public string? VoucherNo { get; set; }

    public string? InvoiceNo { get; set; }

    public decimal? VoucherTypeId { get; set; }

    public decimal? SuffixPrefixId { get; set; }

    public DateTime? Date { get; set; }

    public decimal? PricinglevelId { get; set; }

    public decimal? LedgerId { get; set; }

    public decimal? EmployeeId { get; set; }

    public bool? Approved { get; set; }

    public decimal? SubTotal { get; set; }

    public decimal? Discount { get; set; }

    public decimal? TaxAmount { get; set; }

    public decimal? TotalAmount { get; set; }

    public string? Narration { get; set; }

    public decimal? FinancialYearId { get; set; }

    public DateTime? ExtraDate { get; set; }

    public string? Extra1 { get; set; }

    public string? Extra2 { get; set; }

    public decimal? ExchangeRateId { get; set; }

    public decimal? UserId { get; set; }

    public string? ProjectId { get; set; }

    public string? Note { get; set; }

    public string? AttenMobile { get; set; }
}
