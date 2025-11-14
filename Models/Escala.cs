using System;
using System.Collections.Generic;

namespace scafold1.Models;

public partial class Escala
{
    public int IdEscala { get; set; }

    public int IdAeroportoEscala { get; set; }

    public DateTime ChegadaEscala { get; set; }

    public DateTime SaidaEscala { get; set; }

    public virtual Aeroporto IdAeroportoEscalaNavigation { get; set; } = null!;

    public virtual ICollection<Voo> IdVoos { get; set; } = new List<Voo>();
}
