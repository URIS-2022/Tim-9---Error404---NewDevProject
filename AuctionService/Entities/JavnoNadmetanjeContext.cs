using System;
using Microsoft.EntityFrameworkCore;

namespace AuctionService.Entities
{
	public class JavnoNadmetanjeContext : DbContext
	{
		public JavnoNadmetanjeContext(DbContextOptions<JavnoNadmetanjeContext> options) : base(options)
		{
		}

        public DbSet<JavnoNadmetanje> javnoaNadmetanja { get; set; }
		public DbSet<TipJavnogNadmetanja> tipoviNadmetanja { get; set; }
		public DbSet<StatusNadmetanja> statusiNadmetanja { get; set; }
		public DbSet<Kupac> kupci { get; set; }
		public DbSet<Licitacija> licitacije { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<TipJavnogNadmetanja>()
				.HasData(new
				{
					TipJavnogNadmetanjaID = Guid.Parse("4246a611-7b2f-429d-a9ba-0e539c81b82f"),
					nazivTipa = "Javna licitacija"
				});

            modelBuilder.Entity<TipJavnogNadmetanja>()
            .HasData(new
            {
                TipJavnogNadmetanjaID = Guid.Parse("99b6d6ec-4358-4898-936b-31b31d236324"),
                nazivTipa = "Otvaranje zatvorenih ponuda"
            });

            modelBuilder.Entity<StatusNadmetanja>()
                .HasData(new
                {
                    statusNadmetanjaID = Guid.Parse("4246a611-7b2f-429d-a9ba-0e539c81b82f"),
                    naziv = "Prvi krug"
                });

            modelBuilder.Entity<StatusNadmetanja>()
                .HasData(new
                {
                    statusNadmetanjaID = Guid.Parse("4246a611-7b2f-429d-a9ba-0e539c81b82f"),
                    naziv = "Drugi krug sa starim uslovima"
                });

            modelBuilder.Entity<StatusNadmetanja>()
                .HasData(new
                {
                    statusNadmetanjaID = Guid.Parse("4246a611-7b2f-429d-a9ba-0e539c81b82f"),
                    naziv = "Drugi krug sa novim uslovima"
                });
            
        }
	}
}

