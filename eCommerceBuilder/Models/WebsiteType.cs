using System;
using System.Collections.Generic;

namespace eCommerceBuilder.Models;

public partial class WebsiteType
{
    public int Id { get; set; }

    public string StoreType { get; set; } = null!;
}
