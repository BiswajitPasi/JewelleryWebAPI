﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace JewelleryWebAPI.Models;

public partial class TblSalesOrderDetails
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public decimal SalesOrderDetailsId { get; set; }

    public decimal? SalesOrderMasterId { get; set; }

    public decimal? ProductId { get; set; }

    public decimal? Qty { get; set; }

    public decimal? Rate { get; set; }

    public decimal? UnitId { get; set; }

    public decimal? UnitConversionId { get; set; }

    public decimal? Amount { get; set; }

    public decimal? QuotationDetailsId { get; set; }

    public decimal? BatchId { get; set; }

    public int? SlNo { get; set; }

    public DateTime? ExtraDate { get; set; }

    public string? Extra1 { get; set; }

    public string? Extra2 { get; set; }

	[NotMapped]
	public virtual string? productName { get; set; }
}
