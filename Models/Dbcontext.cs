using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;

namespace PfaFinal.Models
{
    public class Dbcontext : IdentityDbContext<IdentityUser>
    {
        public Dbcontext(DbContextOptions<Dbcontext> options)
           : base(options)
        {
        }

        public virtual DbSet<Professeur> Professeurs { get; set; } = null!;
        public virtual DbSet<Reservation> Reservations { get; set; } = null!;
        public virtual DbSet<Salle> Salles { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}