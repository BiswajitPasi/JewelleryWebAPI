using System;
using System.Collections.Generic;

namespace JewelleryWebAPI.Models;

public partial class TblProductGroup
{
    public decimal GroupId { get; set; }

    public string? GroupName { get; set; }

    public decimal? GroupUnder { get; set; }

    public string? Narration { get; set; }

    public string? Extra1 { get; set; }

    public string? Extra2 { get; set; }

    public DateTime? ExtraDate { get; set; }
}
