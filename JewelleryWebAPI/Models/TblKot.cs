using System;
using System.Collections.Generic;

namespace JewelleryWebAPI.Models;

public partial class TblKot
{
    public int Srno { get; set; }

    public int? SalesOrderId { get; set; }

    public string? SalesOrderNo { get; set; }

    public int? CustomerId { get; set; }

    public string? Customername { get; set; }

    public string? OrderType { get; set; }

    public int? TableId { get; set; }

    public string? TableNo { get; set; }

    public string? DeliverAddress { get; set; }

    public string? Kotno { get; set; }

    public DateTime? KotDate { get; set; }

    public TimeSpan? KotTime { get; set; }

    public decimal? ProductId { get; set; }

    public string? ProductName { get; set; }

    public decimal? Quantity { get; set; }

    public bool? Completed { get; set; }

    public bool? Status { get; set; }

    public DateTime? ExtraDate { get; set; }

    public string? Extra1 { get; set; }

    public string? Extra2 { get; set; }

    public decimal? NowQty { get; set; }

    public string? Extra3 { get; set; }
}
