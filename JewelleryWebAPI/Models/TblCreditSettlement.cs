using System;
using System.Collections.Generic;

namespace JewelleryWebAPI.Models;

public partial class TblCreditSettlement
{
    public int Srno { get; set; }

    public string? ReceiptVoucherId { get; set; }

    public decimal? LedgerId { get; set; }

    public string? CustomerName { get; set; }

    public DateTime? Date { get; set; }

    public decimal? TotalAmount { get; set; }

    public decimal? TotalPreviousPaid { get; set; }

    public decimal? TotalBalance { get; set; }

    public decimal? NowPaidCash { get; set; }

    public decimal? NowPaidCard { get; set; }

    public decimal? BalanceDue { get; set; }

    public string? Paymode { get; set; }

    public string? CardNo { get; set; }

    public string? Status { get; set; }

    public decimal? UserId { get; set; }
}
