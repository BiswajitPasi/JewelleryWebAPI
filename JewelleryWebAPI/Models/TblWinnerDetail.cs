using System;
using System.Collections.Generic;

namespace JewelleryWebAPI.Models;

public partial class TblWinnerDetail
{
    public int Srno { get; set; }

    public string? PrizeIssueId { get; set; }

    public string? WinnerId { get; set; }

    public string? CouponCode { get; set; }

    public string? Qrcode { get; set; }

    public decimal? PrizeAmount { get; set; }

    public string? Status { get; set; }
}
