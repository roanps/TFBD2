using System;
using System.Collections.Generic;

namespace scafold1.Models;

public class Aeroporto
{
    public int IdAeroporto { get; set; }

    public string? Nome { get; set; }

    public string? Cidade { get; set; }

    public string? Estado { get; set; }


    public virtual ICollection<Escala> Escalas { get; set; } = new List<Escala>();

    public virtual ICollection<Voo> VooIdAeroportoDestinoNavigations { get; set; } = new List<Voo>();

    public virtual ICollection<Voo> VooIdAeroportoOrigemNavigations { get; set; } = new List<Voo>();
}
