using System;
using System.Collections.Generic;

namespace JewelleryWebAPI.Models;

public partial class TblAccountLedgerContactPerson
{
    public long Srno { get; set; }

    public int? LedgerId { get; set; }

    public string? ContactPerson { get; set; }

    public string? Designation { get; set; }

    public string? MobileNo { get; set; }

    public string? Email { get; set; }
}
