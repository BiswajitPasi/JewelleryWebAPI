using System;
using System.Collections.Generic;

namespace JewelleryWebAPI.Models;

public partial class TblShift
{
    public int ShiftId { get; set; }

    public string? ShiftName { get; set; }

    public TimeSpan? StartTime { get; set; }

    public TimeSpan? EndTime { get; set; }

    public string? TotalHours { get; set; }

    public string? Naration { get; set; }

    public string? Status { get; set; }
}
