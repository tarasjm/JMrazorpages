#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JMrazorpages.Pages.taras;

namespace JMrazorpages.Data
{
    public class JMrazorpagesContext : DbContext
    {
        public JMrazorpagesContext (DbContextOptions<JMrazorpagesContext> options)
            : base(options)
        {
        }

        public DbSet<JMrazorpages.Pages.taras.Class> Class { get; set; }
    }
}
