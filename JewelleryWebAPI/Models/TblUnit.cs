﻿using System;
using System.Collections.Generic;

namespace JewelleryWebAPI.Models;

public partial class TblUnit
{
    public decimal UnitId { get; set; }

    public string? UnitName { get; set; }

    public string? Narration { get; set; }

    public int? NoOfDecimalplaces { get; set; }

    public string? FormalName { get; set; }

    public string? Extra1 { get; set; }

    public string? Extra2 { get; set; }

    public DateTime? ExtraDate { get; set; }
}
