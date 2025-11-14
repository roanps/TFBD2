using System.ClientModel;
using Microsoft.EntityFrameworkCore;
using scafold1.Models;
namespace scafold1.Data
{
    public class Scafold1Context : DbContext
    {
        public Scafold1Context (DbContextOptions<Scafold1Context> options)
            : base(options)
        {
        }

        public DbSet<Aeronave> Aeronaves { get; set; }
        public DbSet<Aeroporto> Aeroportos { get; set; }
        public DbSet<EmpresaAerea> EmpresaAereas { get; set; }
        public DbSet<Escala> Escalas { get; set; }
        public DbSet<Passageiro> Passageiros { get; set; }
        public DbSet<Passagem> Passagens { get; set; }
        public DbSet<Poltrona> Poltronas { get; set; }
        public DbSet<Voo> Voos { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {       
                modelBuilder.Entity<Aeronave>().ToTable("Aeronave");
                modelBuilder.Entity<Aeroporto>().ToTable("Aeroporto");
                modelBuilder.Entity<EmpresaAerea>().ToTable("EmpresaAerea");
                modelBuilder.Entity<Escala>().ToTable("Escala");
                modelBuilder.Entity<Passageiro>().ToTable("Passageiro");
                modelBuilder.Entity<Passagem>().ToTable("Passagem");
                modelBuilder.Entity<Poltrona>().ToTable("Poltrona");
                modelBuilder.Entity<Voo>().ToTable("Voo");
        }
    }
}
