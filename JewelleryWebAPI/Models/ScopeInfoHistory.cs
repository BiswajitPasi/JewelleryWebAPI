using System;
using System.Collections.Generic;

namespace JewelleryWebAPI.Models;

public partial class ScopeInfoHistory
{
    public Guid SyncScopeId { get; set; }

    public string SyncScopeName { get; set; } = null!;

    public long? ScopeLastSyncTimestamp { get; set; }

    public long? ScopeLastSyncDuration { get; set; }

    public DateTime? ScopeLastSync { get; set; }
}
