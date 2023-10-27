using System;
using System.Collections.Generic;

namespace JewelleryWebAPI.Models;

public partial class TblTicketReceive
{
    public int Srno { get; set; }

    public int RecCode { get; set; }

    public DateTime? RecDate { get; set; }

    public int? EmployeeId { get; set; }

    public string? Remarks { get; set; }

    public decimal? TotalAmount { get; set; }

    public bool? Approve { get; set; }

    public bool? Status { get; set; }
}
