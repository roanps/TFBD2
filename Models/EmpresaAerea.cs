using System;
using System.Collections.Generic;

namespace scafold1.Models;

public class EmpresaAerea
{
    public int IdEmpresa { get; set; }

    public string Nome { get; set; } = null!;

    public string Telefone { get; set; } = null!;

    public string Cnpj { get; set; } = null!;

    public virtual ICollection<Aeronave> Aeronaves { get; set; } = new List<Aeronave>();
}
