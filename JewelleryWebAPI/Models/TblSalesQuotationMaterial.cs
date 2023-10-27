using System;
using System.Collections.Generic;

namespace JewelleryWebAPI.Models;

public partial class TblSalesQuotationMaterial
{
    public int Srno { get; set; }

    public decimal QuotationId { get; set; }

    public string? Type { get; set; }

    public string? Description { get; set; }
}
