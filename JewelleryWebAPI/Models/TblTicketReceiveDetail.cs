using System;
using System.Collections.Generic;

namespace JewelleryWebAPI.Models;

public partial class TblTicketReceiveDetail
{
    public int Srno { get; set; }

    public int? ResCode { get; set; }

    public DateTime? ReceiveDate { get; set; }

    public double? CashAmt { get; set; }

    public double? FreeTicket { get; set; }

    public double Qtybd1 { get; set; }

    public double? Qtybd5 { get; set; }

    public double? Qtybd10 { get; set; }

    public double? Qtybd50 { get; set; }

    public double? Qtybd100 { get; set; }

    public decimal? ToalAmount { get; set; }

    public int? EmployeeId { get; set; }

    public double? Qtybd2 { get; set; }

    public double? Qtybd20 { get; set; }
}
