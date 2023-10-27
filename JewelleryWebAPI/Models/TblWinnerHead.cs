using System;
using System.Collections.Generic;

namespace JewelleryWebAPI.Models;

public partial class TblWinnerHead
{
    public int Srno { get; set; }

    public string PrizeIssueId { get; set; } = null!;

    public DateTime? PrizeIssuedate { get; set; }

    public string? IssuedFromBooklet { get; set; }

    public int? IssuedSalesmanId { get; set; }

    public string? IssuedSalesman { get; set; }

    public string? IssuedSalesmanCode { get; set; }

    public DateTime? IssuedBookletDt { get; set; }

    public string? WinnerId { get; set; }

    public string? WinnerCprno { get; set; }

    public string? WinnerName { get; set; }

    public string? WinnerAddress { get; set; }

    public string? WinnerMobNo { get; set; }

    public string? WinnerEmailId { get; set; }

    public byte[]? WinnerPicture { get; set; }

    public decimal? TotalPrizeAmt { get; set; }

    public string? Narration { get; set; }

    public string? Status { get; set; }
}
