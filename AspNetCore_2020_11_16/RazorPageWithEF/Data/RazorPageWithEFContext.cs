using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPageWithEF.Models;

namespace RazorPageWithEF.Data
{
    public class RazorPageWithEFContext : DbContext
    {
        public RazorPageWithEFContext (DbContextOptions<RazorPageWithEFContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPageWithEF.Models.FootballClub> FootballClub { get; set; }
    }
}
