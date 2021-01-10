using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Uzduotis.Services
{
    public class PersonContext : DbContext
    {
        public virtual DbSet<Person> Person { get; set; }

        public PersonContext(DbContextOptions<PersonContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>(entity =>
            {
                entity.HasKey(e => e.ID);

                entity.Property(e => e.Vardas).HasColumnName("Vardas");

                entity.Property(e => e.Pavarde).HasColumnName("Pavarde");

                entity.Property(e => e.Telefonas).HasColumnName("Telefonas");

                entity.Property(e => e.ElPastas).HasColumnName("ElPastas");

            });
        }
    }
}
