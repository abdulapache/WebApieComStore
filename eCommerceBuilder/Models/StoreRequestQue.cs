using System;
using System.Collections.Generic;
using eCommerceBuilder.Data;

namespace eCommerceBuilder.Models;

public partial class StoreRequestQue
{
    public int Id { get; set; }

    public string? Business { get; set; }

    public string? StoreTitle { get; set; }

    public string? Name { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }
}
