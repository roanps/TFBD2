using System;
using System.Collections.Generic;

namespace scafold1.Models;

public class Passagem
{
    public int IdPassagem { get; set; }

    public int IdPassageiro { get; set; }

    public int IdVoo { get; set; }

    public string? NumeroPoltrona { get; set; }

    public bool? CheckinRealizado { get; set; }

    public virtual Passageiro IdPassageiroNavigation { get; set; } = null!;

    public virtual Voo IdVooNavigation { get; set; } = null!;

    public virtual Poltrona? Poltrona { get; set; }
}
