using System;
using System.Collections.Generic;

namespace JewelleryWebAPI.Models;

public partial class TblProductTracking
{
    public decimal ProductId { get; set; }

    public Guid? UpdateScopeId { get; set; }

    public byte[]? Timestamp { get; set; }

    public long? TimestampBigint { get; set; }

    public bool SyncRowIsTombstone { get; set; }

    public DateTime? LastChangeDatetime { get; set; }
}
