using System;
using System.Collections.Generic;

namespace JewelleryWebAPI.Models;

public partial class ScopeConfig
{
    public Guid ConfigId { get; set; }

    public string ConfigData { get; set; } = null!;

    public string? ScopeStatus { get; set; }
}
