using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ManagmentRR.Models;

namespace ManagmentRR.Models
{
    public class ManagmentRRContext : DbContext
    {
        public ManagmentRRContext (DbContextOptions<ManagmentRRContext> options)
            : base(options)
        {
        }

        public DbSet<Tape> Tape { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<ManagmentRR.Models.TrocaTape> TrocaTape { get; set; }
    }
}
