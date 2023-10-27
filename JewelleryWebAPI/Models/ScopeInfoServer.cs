using System;
using System.Collections.Generic;

namespace JewelleryWebAPI.Models;

public partial class ScopeInfoServer
{
    public string SyncScopeName { get; set; } = null!;

    public string? SyncScopeSchema { get; set; }

    public string? SyncScopeSetup { get; set; }

    public string? SyncScopeVersion { get; set; }

    public long? SyncScopeLastCleanTimestamp { get; set; }
}
