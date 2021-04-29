using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using AquaticsStoreAssignment.Models;

namespace AquaticsStoreAssignment.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<AquaticsStoreAssignment.Models.Fish> Fish { get; set; }
        public DbSet<AquaticsStoreAssignment.Models.Tank> Tank { get; set; }
    }
}
