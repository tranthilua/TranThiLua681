using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TranThiLua681.Models;

    public class AplicationContext : DbContext
    {
        public AplicationContext (DbContextOptions<AplicationContext> options)
            : base(options)
        {
        }

        public DbSet<TranThiLua681.Models.TTL681> TTL681 { get; set; }

        public DbSet<TranThiLua681.Models.PersonTTL681> PersonTTL681 { get; set; }
    }
