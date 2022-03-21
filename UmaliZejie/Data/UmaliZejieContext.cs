#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UmaliZejie.Models;

namespace UmaliZejie.Data
{
    public class UmaliZejieContext : DbContext
    {
        public UmaliZejieContext (DbContextOptions<UmaliZejieContext> options)
            : base(options)
        {
        }

        public DbSet<UmaliZejie.Models.Shops> Shops { get; set; }
    }
}
