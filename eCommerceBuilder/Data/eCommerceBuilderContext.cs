using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using eCommerceBuilder.Models;

namespace eCommerceBuilder.Data
{
    public class eCommerceBuilderContext : DbContext
    {
        public eCommerceBuilderContext (DbContextOptions<eCommerceBuilderContext> options)
            : base(options)
        {
        }

        public DbSet<eCommerceBuilder.Models.StoreRequestQue> StoreRequestQue { get; set; } = default!;

        public DbSet<eCommerceBuilder.Models.WebsiteType>? WebsiteType { get; set; }
    }
}
