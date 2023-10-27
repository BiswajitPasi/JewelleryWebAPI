﻿using System;
using System.Collections.Generic;

namespace JewelleryWebAPI.Models;

public partial class TblJournalDetail
{
    public decimal JournalDetailsId { get; set; }

    public decimal? JournalMasterId { get; set; }

    public decimal? LedgerId { get; set; }

    public decimal? Credit { get; set; }

    public decimal? Debit { get; set; }

    public decimal? ExchangeRateId { get; set; }

    public string? ChequeNo { get; set; }

    public DateTime? ChequeDate { get; set; }

    public DateTime? ExtraDate { get; set; }

    public string? Extra1 { get; set; }

    public string? Extra2 { get; set; }
}
