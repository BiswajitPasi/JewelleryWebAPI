﻿using System;
using System.Collections.Generic;

namespace JewelleryWebAPI.Models;

public partial class TblSalesOrderBillTax
{
    public decimal SalesBillTaxId { get; set; }

    public decimal? SalesMasterId { get; set; }

    public decimal? TaxId { get; set; }

    public decimal? TaxAmount { get; set; }

    public DateTime? ExtraDate { get; set; }

    public string? Extra1 { get; set; }

    public string? Extra2 { get; set; }
}
