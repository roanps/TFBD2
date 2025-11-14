using System;
using System.Collections.Generic;

namespace scafold1.Models;

public partial class Poltrona
{
    public int IdVoo { get; set; }

    public string NumeroPoltrona { get; set; } = null!;

    public string? TipoPoltrona { get; set; }

    public string? Lado { get; set; }

    public bool? Ocupada { get; set; }

    public virtual Voo IdVooNavigation { get; set; } = null!;

    public virtual ICollection<Passagem> Passagems { get; set; } = new List<Passagem>();
}
