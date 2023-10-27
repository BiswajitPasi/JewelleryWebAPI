using System;
using System.Collections.Generic;

namespace JewelleryWebAPI.Models;

public partial class TblField
{
    public int FieldId { get; set; }

    public int? FormId { get; set; }

    public string? FieldName { get; set; }
}
