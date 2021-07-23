using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using KompasBySajra.Models;

namespace KompasBySajra.Data
{
    public class DataContext : DbContext
    {
        public DataContext (DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<KompasBySajra.Models.Pas> Pas { get; set; }

        public DbSet<KompasBySajra.Models.Korisnik> Korisnik { get; set; }

        public DbSet<KompasBySajra.Models.ZahtjevZaUdomljavanje> ZahtjevZaUdomljavanje { get; set; }
    }
}
