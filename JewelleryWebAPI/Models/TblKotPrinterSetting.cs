using System;
using System.Collections.Generic;

namespace JewelleryWebAPI.Models;

public partial class TblKotPrinterSetting
{
    public int Srno { get; set; }

    public string? PrintFor { get; set; }

    public string? PrinterName { get; set; }

    public string? PortNo { get; set; }

    public string? Driver { get; set; }

    public string? DeviceId { get; set; }

    public bool? Shared { get; set; }

    public string? Status { get; set; }

    public string? PrinterType { get; set; }
}
