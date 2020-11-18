using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCWithEF.Models;

namespace MVCWithEF.Data
{
    public class MVCWithEFContext : DbContext
    {
        public MVCWithEFContext (DbContextOptions<MVCWithEFContext> options)
            : base(options)
        {
        }

        public DbSet<MVCWithEF.Models.Artikel> Artikel { get; set; }
    }
}
