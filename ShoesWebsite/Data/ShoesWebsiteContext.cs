using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ShoesWebsite.Models;

namespace ShoesWebsite.Data
{
    public class ShoesWebsiteContext : DbContext
    {
        public ShoesWebsiteContext (DbContextOptions<ShoesWebsiteContext> options)
            : base(options)
        {
        }

        public DbSet<ShoesWebsite.Models.ShoePage> ShoePage { get; set; } = default!;
    }
}
