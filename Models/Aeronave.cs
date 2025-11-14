using System;
using System.Collections.Generic;

namespace scafold1.Models;

public partial class Aeronave
{
    public int IdAeronave { get; set; }

    public int IdEmpresa { get; set; }

    public string ModeloAeronave { get; set; } = null!;

    public DateOnly DataFabricacao { get; set; }

    public int NumeroPoltronas { get; set; }

    public int NumeroMaximoTripulantes { get; set; }

    public int CapacidadeMaximaCombustivel { get; set; }

    public int CapacidadeMaximaVoo { get; set; }

    public virtual EmpresaAerea IdEmpresaNavigation { get; set; } = null!;

    public virtual ICollection<Voo> Voos { get; set; } = new List<Voo>();
}
