using System;
using System.Collections.Generic;

namespace scafold1.Models;

public partial class Passageiro
{
    public int IdPassageiro { get; set; }

    public string Nome { get; set; } = null!;

    public DateOnly DataNascimento { get; set; }

    public string Sexo { get; set; } = null!;

    public string Cpf { get; set; } = null!;

    public string EstadoCivil { get; set; } = null!;

    public string Nacionalidade { get; set; } = null!;

    public bool? Preferencial { get; set; }

    public string? Email { get; set; }

    public string? Telefone { get; set; }

    public virtual ICollection<Passagem> Passagens { get; set; } = new List<Passagem>();
}
