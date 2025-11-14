using System;
using System.Collections.Generic;

namespace scafold1.Models;

public partial class Voo
{
    public int IdVoo { get; set; }

    public int IdAeronave { get; set; }

    public int IdAeroportoOrigem { get; set; }

    public DateTime Partida { get; set; }

    public int IdAeroportoDestino { get; set; }

    public DateTime Chegada { get; set; }

    public virtual Aeronave IdAeronaveNavigation { get; set; } = null!;

    public virtual Aeroporto IdAeroportoDestinoNavigation { get; set; } = null!;

    public virtual Aeroporto IdAeroportoOrigemNavigation { get; set; } = null!;

    public virtual ICollection<Passagem> Passagems { get; set; } = new List<Passagem>();

    public virtual ICollection<Poltrona> Poltronas { get; set; } = new List<Poltrona>();

    public virtual ICollection<Escala> IdEscalas { get; set; } = new List<Escala>();
}
