using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RealEstate.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RealEstate.Data
{
    public class RealEstateContext : IdentityDbContext<AppUser>
    {
        public DbSet<Agent> Agents { get; set; }
        public DbSet<Seller> Sellers { get; set; }

        public RealEstateContext(DbContextOptions options) : base(options)
        {

        }
    }
}
