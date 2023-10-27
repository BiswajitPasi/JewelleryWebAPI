using System;
using System.Collections.Generic;

namespace JewelleryWebAPI.Models;

public partial class TblDeliveryDetail
{
    public long Srno { get; set; }

    public string? DispatchId { get; set; }

    public DateTime DispatchDateTime { get; set; }

    public decimal? SalesOrderId { get; set; }

    public decimal? SalesMasterId { get; set; }

    public string? SalesInvoiceNo { get; set; }

    public string? SalesOrderNo { get; set; }

    public decimal? EmployeeId { get; set; }

    public string? EmployeeName { get; set; }

    public string? VeichcleNo { get; set; }

    public decimal? TotalAmount { get; set; }

    public bool? Status { get; set; }

    public bool? PaymentCollect { get; set; }

    public DateTime? PaymentCollectDate { get; set; }
}
