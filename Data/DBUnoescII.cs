using Microsoft.EntityFrameworkCore;
using scafold1.Models;

namespace scafold1.Data;

public partial class DBUnoescII : DbContext
{
    public DBUnoescII()
    {
    }

    public DBUnoescII(DbContextOptions<DBUnoescII> options)
        : base(options)
    {
    }

    public virtual DbSet<Aeronave> Aeronaves { get; set; }

    public virtual DbSet<Aeroporto> Aeroportos { get; set; }

    public virtual DbSet<EmpresaAerea> EmpresaAereas { get; set; }

    public virtual DbSet<Escala> Escalas { get; set; }

    public virtual DbSet<Passageiro> Passageiros { get; set; }

    public virtual DbSet<Passagem> Passagems { get; set; }

    public virtual DbSet<Poltrona> Poltronas { get; set; }

    public virtual DbSet<Voo> Voos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=DBUnoescII;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Aeronave>(entity =>
        {
            entity.HasKey(e => e.IdAeronave).HasName("PK__AERONAVE__8D0DAF56FBC3E480");

            entity.ToTable("AERONAVE");

            entity.Property(e => e.IdAeronave).HasColumnName("ID_AERONAVE");
            entity.Property(e => e.CapacidadeMaximaCombustivel).HasColumnName("CAPACIDADE_MAXIMA_COMBUSTIVEL");
            entity.Property(e => e.CapacidadeMaximaVoo).HasColumnName("CAPACIDADE_MAXIMA_VOO");
            entity.Property(e => e.DataFabricacao).HasColumnName("DATA_FABRICACAO");
            entity.Property(e => e.IdEmpresa).HasColumnName("ID_EMPRESA");
            entity.Property(e => e.ModeloAeronave)
                .HasMaxLength(255)
                .HasColumnName("MODELO_AERONAVE");
            entity.Property(e => e.NumeroMaximoTripulantes).HasColumnName("NUMERO_MAXIMO_TRIPULANTES");
            entity.Property(e => e.NumeroPoltronas).HasColumnName("NUMERO_POLTRONAS");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.Aeronaves)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__AERONAVE__ID_EMP__2A4B4B5E");
        });

        modelBuilder.Entity<Aeroporto>(entity =>
        {
            entity.HasKey(e => e.IdAeroporto).HasName("PK__AEROPORT__21947E40BAFFDD43");

            entity.ToTable("AEROPORTO");


            entity.Property(e => e.IdAeroporto).HasColumnName("ID_AEROPORTO");
            entity.Property(e => e.Cidade)
                .HasMaxLength(255)
                .HasColumnName("CIDADE");
            entity.Property(e => e.Estado)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ESTADO");
            entity.Property(e => e.Nome)
                .HasMaxLength(255)
                .HasColumnName("NOME");
        });

        modelBuilder.Entity<EmpresaAerea>(entity =>
        {
            entity.HasKey(e => e.IdEmpresa).HasName("PK__EMPRESA___E30DF09CBDD6C204");

            entity.ToTable("EMPRESA_AEREA");

            entity.HasIndex(e => e.Cnpj, "UQ__EMPRESA___AA57D6B4A8E2983A").IsUnique();

            entity.Property(e => e.IdEmpresa).HasColumnName("ID_EMPRESA");
            entity.Property(e => e.Cnpj)
                .HasMaxLength(14)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CNPJ");
            entity.Property(e => e.Nome)
                .HasMaxLength(255)
                .HasColumnName("NOME");
            entity.Property(e => e.Telefone)
                .HasMaxLength(15)
                .HasColumnName("TELEFONE");
        });

        modelBuilder.Entity<Escala>(entity =>
        {
            entity.HasKey(e => e.IdEscala).HasName("PK__ESCALA__C83F08465E5603AA");

            entity.ToTable("ESCALA");

            entity.Property(e => e.IdEscala).HasColumnName("ID_ESCALA");
            entity.Property(e => e.ChegadaEscala)
                .HasColumnType("datetime")
                .HasColumnName("CHEGADA_ESCALA");
            entity.Property(e => e.IdAeroportoEscala).HasColumnName("ID_AEROPORTO_ESCALA");
            entity.Property(e => e.SaidaEscala)
                .HasColumnType("datetime")
                .HasColumnName("SAIDA_ESCALA");

            entity.HasOne(d => d.IdAeroportoEscalaNavigation).WithMany(p => p.Escalas)
                .HasForeignKey(d => d.IdAeroportoEscala)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ESCALA__ID_AEROP__31EC6D26");
        });

        modelBuilder.Entity<Passageiro>(entity =>
        {
            entity.HasKey(e => e.IdPassageiro).HasName("PK__PASSAGEI__8F5D4CD8E2557BF1");

            entity.ToTable("PASSAGEIRO");

            entity.HasIndex(e => e.Cpf, "UQ__PASSAGEI__C1F8973189EC37B4").IsUnique();

            entity.Property(e => e.IdPassageiro).HasColumnName("ID_PASSAGEIRO");
            entity.Property(e => e.Cpf)
                .HasMaxLength(11)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CPF");
            entity.Property(e => e.DataNascimento).HasColumnName("DATA_NASCIMENTO");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("EMAIL");
            entity.Property(e => e.EstadoCivil)
                .HasMaxLength(255)
                .HasColumnName("ESTADO_CIVIL");
            entity.Property(e => e.Nacionalidade)
                .HasMaxLength(255)
                .HasColumnName("NACIONALIDADE");
            entity.Property(e => e.Nome)
                .HasMaxLength(255)
                .HasColumnName("NOME");
            entity.Property(e => e.Preferencial)
                .HasDefaultValue(false)
                .HasColumnName("PREFERENCIAL");
            entity.Property(e => e.Sexo)
                .HasMaxLength(10)
                .HasColumnName("SEXO");
            entity.Property(e => e.Telefone)
                .HasMaxLength(15)
                .HasColumnName("TELEFONE");
        });

        modelBuilder.Entity<Passagem>(entity =>
        {
            entity.HasKey(e => new { e.IdPassageiro, e.IdVoo }).HasName("PK__PASSAGEM__CD2EF41E657EBB1C");

            entity.ToTable("PASSAGEM");

            entity.Property(e => e.IdPassageiro).HasColumnName("ID_PASSAGEIRO");
            entity.Property(e => e.IdVoo).HasColumnName("ID_VOO");
            entity.Property(e => e.CheckinRealizado)
                .HasDefaultValue(false)
                .HasColumnName("CHECKIN_REALIZADO");
            entity.Property(e => e.NumeroPoltrona)
                .HasMaxLength(5)
                .HasColumnName("NUMERO_POLTRONA");

            entity.HasOne(d => d.IdPassageiroNavigation).WithMany(p => p.Passagens)
                .HasForeignKey(d => d.IdPassageiro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PASSAGEM__ID_PAS__45F365D3");

            entity.HasOne(d => d.IdVooNavigation).WithMany(p => p.Passagems)
                .HasForeignKey(d => d.IdVoo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PASSAGEM__ID_VOO__46E78A0C");

            entity.HasOne(d => d.Poltrona).WithMany(p => p.Passagems)
                .HasForeignKey(d => new { d.IdVoo, d.NumeroPoltrona })
                .HasConstraintName("FK__PASSAGEM__47DBAE45");
        });

        modelBuilder.Entity<Poltrona>(entity =>
        {
            entity.HasKey(e => new { e.IdVoo, e.NumeroPoltrona }).HasName("PK__POLTRONA__B781BB2307C7CD1A");

            entity.ToTable("POLTRONA");

            entity.Property(e => e.IdVoo).HasColumnName("ID_VOO");
            entity.Property(e => e.NumeroPoltrona)
                .HasMaxLength(5)
                .HasColumnName("NUMERO_POLTRONA");
            entity.Property(e => e.Lado)
                .HasMaxLength(10)
                .HasColumnName("LADO");
            entity.Property(e => e.Ocupada)
                .HasDefaultValue(false)
                .HasColumnName("OCUPADA");
            entity.Property(e => e.TipoPoltrona)
                .HasMaxLength(10)
                .HasColumnName("TIPO_POLTRONA");

            entity.HasOne(d => d.IdVooNavigation).WithMany(p => p.Poltronas)
                .HasForeignKey(d => d.IdVoo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__POLTRONA__ID_VOO__4222D4EF");
        });

        modelBuilder.Entity<Voo>(entity =>
        {
            entity.HasKey(e => e.IdVoo).HasName("PK__VOO__273B8C65E0A8DDF4");

            entity.ToTable("VOO");

            entity.Property(e => e.IdVoo).HasColumnName("ID_VOO");
            entity.Property(e => e.Chegada)
                .HasColumnType("datetime")
                .HasColumnName("CHEGADA");
            entity.Property(e => e.IdAeronave).HasColumnName("ID_AERONAVE");
            entity.Property(e => e.IdAeroportoDestino).HasColumnName("ID_AEROPORTO_DESTINO");
            entity.Property(e => e.IdAeroportoOrigem).HasColumnName("ID_AEROPORTO_ORIGEM");
            entity.Property(e => e.Partida)
                .HasColumnType("datetime")
                .HasColumnName("PARTIDA");

            entity.HasOne(d => d.IdAeronaveNavigation).WithMany(p => p.Voos)
                .HasForeignKey(d => d.IdAeronave)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__VOO__ID_AERONAVE__2D27B809");

            entity.HasOne(d => d.IdAeroportoDestinoNavigation).WithMany(p => p.VooIdAeroportoDestinoNavigations)
                .HasForeignKey(d => d.IdAeroportoDestino)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__VOO__ID_AEROPORT__2F10007B");

            entity.HasOne(d => d.IdAeroportoOrigemNavigation).WithMany(p => p.VooIdAeroportoOrigemNavigations)
                .HasForeignKey(d => d.IdAeroportoOrigem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__VOO__ID_AEROPORT__2E1BDC42");

            entity.HasMany(d => d.IdEscalas).WithMany(p => p.IdVoos)
                .UsingEntity<Dictionary<string, object>>(
                    "VooEscala",
                    r => r.HasOne<Escala>().WithMany()
                        .HasForeignKey("IdEscala")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__VOO_ESCAL__ID_ES__35BCFE0A"),
                    l => l.HasOne<Voo>().WithMany()
                        .HasForeignKey("IdVoo")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__VOO_ESCAL__ID_VO__34C8D9D1"),
                    j =>
                    {
                        j.HasKey("IdVoo", "IdEscala").HasName("PK__VOO_ESCA__5BB87CE10FEE0B0B");
                        j.ToTable("VOO_ESCALA");
                        j.IndexerProperty<int>("IdVoo").HasColumnName("ID_VOO");
                        j.IndexerProperty<int>("IdEscala").HasColumnName("ID_ESCALA");
                    });
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
