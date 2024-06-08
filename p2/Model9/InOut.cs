using System;
using System.Collections.Generic;

namespace p2.Model9;

public partial class InOut
{
    public int EntryId { get; set; }

    public int VehicleId { get; set; }

    public DateTime EntryDateTime { get; set; }

    public DateTime? ExitDateTime { get; set; }

    public virtual Vehicle Vehicle { get; set; } = null!;
}
