using System;
using System.Collections.Generic;

namespace JewelleryWebAPI.Models;

public partial class SchemaInfo
{
    public int SchemaMajorVersion { get; set; }

    public int SchemaMinorVersion { get; set; }

    public string SchemaExtendedInfo { get; set; } = null!;
}
